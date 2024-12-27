using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace ParaRep
{
    internal class UIFreshener
    {
        /// <summary>
        /// Give ListView controls the new modern appearance of Windows Explorer controls.
        /// </summary>
        /// <param name="handle">A handle to the control.</param>
        public static void FreshenListView(IntPtr handle)
        {
            const uint LVM_FIRST = 0x1000;
            const uint LVM_SETEXTENDEDLISTVIEWSTYLE = LVM_FIRST + 54;
            const uint LVM_GETEXTENDEDLISTVIEWSTYLE = LVM_FIRST + 55;
            const int LVS_EX_DOUBLEBUFFER = 0x00010000;
            const int LVS_EX_FLATSB = 0x00000100;
            const int LVS_EX_BORDERSELECT = 0x00008000;

            int extendedStyle = NativeMethods.SendMessage(handle, LVM_GETEXTENDEDLISTVIEWSTYLE, 0, 0);
            extendedStyle |= LVS_EX_FLATSB;
            extendedStyle |= LVS_EX_BORDERSELECT;
            extendedStyle |= LVS_EX_DOUBLEBUFFER;
            NativeMethods.SendMessage(handle, LVM_SETEXTENDEDLISTVIEWSTYLE, 0, extendedStyle);

            // Give the ListView control the appearance of a Windows Explorer list view
            NativeMethods.SetWindowTheme(handle, NativeMethods.WindowsExplorerTheme, null);
        }

        private static bool IsWindowsVistaOrLater()
        {
            return (Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major >= 6);
        }

        private static bool IsDwmCompositionEnabled()
        {
            int isDwmEnabled = 0; // DWM is not enabled
            if (UIFreshener.IsWindowsVistaOrLater())
            {
                try
                {
                    // No need to check return value; failure means it isn't enabled
                    NativeMethods.DwmIsCompositionEnabled(out isDwmEnabled);
                }
                catch (DllNotFoundException)
                {
                    // The API is not available so we can't be under the DWM
                    // simply ignore the exception 
                }
            }
            return isDwmEnabled != 0;
        }

        /// <summary>
        /// Extends the window frame (glass) behind the client area, if Desktop Window Manager (DWM) composition is enabled.
        /// </summary>
        public static int ExtendGlassIntoClientArea(IntPtr hWnd, int leftMargin, int topMargin, int rightMargin, int bottomMargin)
        {
            // If OS is not Windows Vista or later or DWM Composition is not enabled, return a Not Supported error code
            if (!UIFreshener.IsDwmCompositionEnabled())
            {
                return NativeMethods.COR_E_NOTSUPPORTED;
            }

            // Call the native function to extend the window frame behind the client area
            NativeMethods.MARGINS margins = new NativeMethods.MARGINS()
            {
                cxLeftWidth = leftMargin,
                cyTopHeight = topMargin,
                cxRightWidth = rightMargin,
                cyBottomHeight = bottomMargin
            };
            return NativeMethods.DwmExtendFrameIntoClientArea(hWnd, ref margins);
        }

        internal static class NativeMethods
        {
            public const int COR_E_NOTSUPPORTED = unchecked((int)0x80131515);

            public const string WindowsExplorerTheme = "Explorer";

            [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
            public static extern int SendMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

            [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
            public extern static int SetWindowTheme(IntPtr hWnd, string pszSubAppName, string pszSubIdList);

            /// <summary>
            /// Obtains a value that indicates whether Desktop Window Manager (DWM) composition is enabled.
            /// </summary>
            /// <returns></returns>
            [DllImport("DwmApi.dll", PreserveSig = true)]
            public static extern int DwmIsCompositionEnabled(out int enabled);

            /// <summary>
            /// Extends the window frame behind the client area.
            /// </summary>
            [DllImport("DwmApi.dll", PreserveSig = true)]
            public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref MARGINS margins);

            /// <summary>
            /// Defines the margins of windows that have visual styles applied.
            /// </summary>
            [StructLayout(LayoutKind.Sequential)]
            public struct MARGINS
            {
                public int cxLeftWidth;
                public int cxRightWidth;
                public int cyTopHeight;
                public int cyBottomHeight;
            };


        }

    }
}
