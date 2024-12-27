namespace ParaRep
{
    using System;
    using System.IO;
    using System.Security;
    using System.Text;
    using System.Windows.Forms;
    using System.Collections.Generic;

    internal static class ParametersExporter
    {

        public enum ExportType { Text, CommaDelimited, TabDelimited, Xml, Html, Batch };

        public static string Export(IEnumerable<string> parameters, ExportType exportType)
        {
            StringBuilder exportString = new StringBuilder();

            switch (exportType)
            {
                case ExportType.Xml:
                    exportString.AppendLine("<parameters>");
                    break;
                case ExportType.Html:
                    exportString.AppendLine(Properties.Resources.StringHTMLReportHeader);
                    exportString.Append("\t");
                    //exportString.AppendFormat(Properties.Resources.StringHTMLExportH1, count);
                    exportString.AppendLine();
                    exportString.AppendLine("\t<ol>");
                    break;
            }

            foreach (string parameter in parameters)
            {
                switch (exportType)
                {
                    case ExportType.Text:
                        exportString.AppendLine(parameter);
                        break;
                    case ExportType.CommaDelimited:
                        exportString.AppendFormat("\"{0}\", ", parameter);
                        break;
                    case ExportType.TabDelimited:
                        exportString.AppendFormat("{0}\t", parameter);
                        break;
                    case ExportType.Xml:
                        // Use SecurityElement.Escape to replace invalid XML characters in the
                        // parameter string with their valid XML equivalent, before exporting to XML
                        exportString.AppendFormat("\t<parameter>{0}</parameter>", SecurityElement.Escape(parameter));
                        exportString.AppendLine();
                        break;
                    case ExportType.Html:
                        // Use SecurityElement.Escape to replace invalid XML characters in the
                        // parameter string with their valid XML equivalent, before exporting to HTML
                        exportString.AppendFormat("\t\t<li>{0}</li>", SecurityElement.Escape(parameter));
                        exportString.AppendLine();
                        break;
                }
            }

            switch (exportType)
            {
                case ExportType.Xml:
                    exportString.AppendLine("</parameters>");
                    break;
                case ExportType.Html:
                    exportString.AppendLine("\t</ol>");
                    exportString.AppendLine(Properties.Resources.StringHTMLReportFooter);
                    break;
            }

            return exportString.ToString();
        }

        public static void Copy(IEnumerable<string> parameters, ExportType exportType)
        {
            string export = ParametersExporter.Export(parameters, exportType);
            if (!string.IsNullOrEmpty(export))
            {
                Clipboard.SetText(export);
            }
        }

        public static void Save(string filePath, IEnumerable<string> parameters, ExportType exportType)
        {
            string export = ParametersExporter.Export(parameters, exportType);
            if (!string.IsNullOrEmpty(export))
            {
                File.WriteAllText(filePath, export);
            }
        }
    }
}
