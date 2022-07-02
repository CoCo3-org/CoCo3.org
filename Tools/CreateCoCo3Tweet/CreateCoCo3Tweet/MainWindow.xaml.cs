using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreateCoCo3Tweet
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Label_Drop(object sender, DragEventArgs e)
		{
			System.Windows.DataObject data = (DataObject)e.Data;
			lbListMsg.Items.Add(data.GetText());

			string[] formats = data.GetFormats();
			lbListMsg.Items.Add(string.Join(", ", formats));

			//object dataContext = data.GetData("DragContext");
			//lbListMsg.Items.Add(dataContext.GetType().ToString());

			object memIO = data.GetData("DragImageBits");
			lbListMsg.Items.Add(memIO.GetType().ToString());
			System.IO.MemoryStream memStream = (System.IO.MemoryStream)memIO;
			long length = memStream.Length;
			lbListMsg.Items.Add(length.ToString());

			//object dataContext = data.GetData("FileContents");
			//lbListMsg.Items.Add(dataContext.GetType().ToString());

			//object text = data.GetData("Text");
			//lbListMsg.Items.Add(text.GetType().ToString());
			//lbListMsg.Items.Add(text.ToString());

			//object iostream2 = data.GetData("chromium/x-ignore-file-contents");
			//lbListMsg.Items.Add(iostream2.GetType().ToString());


			//object iostream3 = data.GetData("FileGroupDescriptorW");
			//lbListMsg.Items.Add(iostream3.GetType().ToString());

		}
	}
}
