using System;

namespace CoCo3OrgGen
{
	class Program
	{
		static void Main(string[] args)
		{
			Page home = new Page();
			home.Name = "Home";
			home.FileName = "index.html";
			home.Title = "CoCo3.org!";

			Page about = new Page();
			about.Name = "About";

			Page fpga = new Page();
			fpga.Name = "FPGA";

			Page electronics = new Page();
			electronics.Name = "Electronics";

			Page[] pages = { home, about, fpga, electronics };

			//foreach (Page page in pages)
			//	page.Generate();
		}
	}
}
