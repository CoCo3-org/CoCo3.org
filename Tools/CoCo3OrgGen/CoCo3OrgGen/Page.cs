using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace CoCo3OrgGen
{
	public class Page
	{
		public string Name { get; set; }
		public string FileName { get; set; }
		public string Title { get; set; }

		public void Init()
		{
			if (this.FileName == null)
				this.FileName = this.Name.ToLower() + ".html";
		}

		public void Generate(Page[] pages)
		{
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("<!doctype html>");
			sb.AppendLine("<html>");
			sb.AppendLine("<head>");

			sb.AppendLine("\t" + "<title>" + this.Title + "</title>");
			sb.AppendLine("\t" + "<style type=\"text/css\">");
			sb.AppendLine("\t\t" + "body { font-family:tahoma,arial,helvetica; font-size:14px; }");
			sb.AppendLine("\t\t" + "h1 { font-weight:bold; font-size:16px; }");
			sb.AppendLine("\t\t" + "h2 { font-weight:bold; font-size:14px; }");

			// sb.AppendLine("\t\t" + "");

			sb.AppendLine("\t" + "</style>");


			sb.AppendLine("</head>");
			sb.AppendLine("<body>");

			sb.AppendLine("\t" + "<form id=\"form1\">");

			sb.AppendLine("\t\t" + "<div style=\"padding: 20px; \">");
			
			sb.AppendLine("\t\t\t" + "");
			sb.AppendLine("\t\t\t" + "");
			sb.AppendLine("\t\t\t" + "");
			sb.AppendLine("\t\t\t" + "");
			sb.AppendLine("\t\t\t" + "");


			sb.AppendLine("\t\t" + "</div>");

			sb.AppendLine("\t" + "</form>");

			sb.AppendLine("</body>");
			sb.AppendLine("</html>");

			StreamWriter sw = new StreamWriter(this.FileName, false);
			sw.WriteLine(sb.ToString());
			sw.Close();
		}
	}
}
