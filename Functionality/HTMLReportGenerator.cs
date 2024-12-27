using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Security;

namespace ParaRep
{
    internal class HTMLReportGenerator
    {
        private StringBuilder report;

        /*private void AddParameters(int count, IEnumerable<string> parameters)
        {
            this.report.AppendFormat("\t<h1>{0} + 1 Command Line Parameters</h1>", count - 1);
            this.report.AppendLine();
            this.report.AppendLine("\t<ol>");
            foreach (string parameter in parameters)
            {
                this.report.AppendFormat("\t\t<li>{0}</li>", SecurityElement.Escape(parameter));
            }
            this.report.AppendLine("\t</ol>");
        }*/

        private void AddEnvironmentVariables(EnvironmentVariableTarget target)
        {
            this.report.AppendLine("\t<table>");
            this.report.AppendFormat("\t\t<tr><th colspan=\"2\">{0}</th></tr>", target.ToString());
            this.report.AppendLine();
            IDictionary environmentVariables = Environment.GetEnvironmentVariables(target);
            foreach (DictionaryEntry var in environmentVariables)
            {
                this.report.AppendLine("\t\t<tr>");
                this.report.AppendFormat("\t\t\t<td>{0}</td>", var.Key);
                this.report.AppendLine();
                this.report.AppendFormat("\t\t\t<td>{0}</td>", var.Value);
                this.report.AppendLine();
                this.report.AppendLine("\t\t</tr>");
            }
            this.report.AppendLine("\t</table>");
        }

        public HTMLReportGenerator(string filePath, IEnumerable<string> parameters)
        {
            this.report = new StringBuilder();

            this.report.AppendLine(Properties.Resources.StringHTMLReportHeader);
            this.report.AppendLine(ParametersExporter.Export(parameters, ParametersExporter.ExportType.Html));
            this.AddEnvironmentVariables(EnvironmentVariableTarget.Process);
            this.AddEnvironmentVariables(EnvironmentVariableTarget.User);
            this.AddEnvironmentVariables(EnvironmentVariableTarget.Machine);
            this.report.AppendLine(Properties.Resources.StringHTMLReportFooter);

            File.WriteAllText(filePath, this.report.ToString());
        }

    }
}
