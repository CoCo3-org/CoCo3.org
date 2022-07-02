namespace Testing123
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
		}

		private void ReadDir(string path)
		{
			string[] files = Directory.GetFiles(path);
			int count = 1;
			foreach (string file in files)
			{
				if (file.EndsWith(".url"))
				{
					string fileName = Path.GetFileNameWithoutExtension(file);
					System.Diagnostics.Debug.WriteLine(fileName);

					ListViewItem item = new ListViewItem(fileName);
					item.Text = count++.ToString();

					item.SubItems.Add(fileName);

					lvLinks.Items.Add(item);

					string url = "";
					StreamReader sr = new StreamReader(file);
					while (!sr.EndOfStream)
					{
						string ln = sr.ReadLine();
						if (ln.StartsWith("URL="))
						{
							url = ln.Substring(4);
							int amprs = url.IndexOf('&');
							if (amprs > 0)
								url = url.Substring(0, amprs);
							break;
						}
					}
					sr.Close();

					item.SubItems.Add(url);
				}
			}
		}

		private void InsertLink(int x)
		{
			string link_title = lvLinks.Items[x].SubItems[1].Text;
			string link_url = lvLinks.Items[x].SubItems[2].Text;
			string anchor = "<strong><a href=\"" + link_url + "\">" + link_title + "</a></strong> ";

			rtTweet.Text = rtTweet.Text.Substring(0, rtTweet.SelectionStart) + anchor + rtTweet.Text.Substring(rtTweet.SelectionStart);
		}

		private void tsbtnSave_Click(object sender, EventArgs e)
		{
			StreamWriter SW = new StreamWriter(@"C:\Temp\Tweet.txt");
			SW.WriteLine(rtTweet.Text);

			foreach (ListViewItem item in lvLinks.Items)
			{
				SW.WriteLine(item.SubItems[1].Text);
				SW.WriteLine(item.SubItems[2].Text);
			}

			SW.Close();
		}

		private void tsbtnLoad_Click(object sender, EventArgs e)
		{
			StreamReader sr = new StreamReader(@"C:\Temp\Tweet.txt");
			rtTweet.Text = sr.ReadLine();

			int count = 0;
			while (!sr.EndOfStream)
			{
				ListViewItem item = new ListViewItem(count.ToString());
				item.SubItems.Add(sr.ReadLine());
				item.SubItems.Add(sr.ReadLine());
				count++;
				lvLinks.Items.Add(item);
			}
			sr.Close();
		}

		private void tsbtnReadDir_Click(object sender, EventArgs e) 
		{
			FolderBrowserDialog dialog = new FolderBrowserDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string path = dialog.SelectedPath;
				this.ReadDir(path);
			}
		}

		// REMOVE THESE ... use {}

		private void lvLinks_DoubleClick(object sender, EventArgs e) 
		{
			// Point rtbPos = this.rtTweet.PointToClient(Cursor.Position);
			// int iCharIndx = this.rtTweet.GetCharIndexFromPosition(rtbPos);

			// rtTweet.Text = rtTweet.Text.Substring(0, iCharIndx) + "{ " + iCharIndx + " }";

			this.InsertLink(lvLinks.SelectedIndices[0]);
		}

		private void tsbtnInsertLink_Click(object sender, EventArgs e) 
		{
			this.InsertLink(lvLinks.SelectedIndices[0]);
		}

		private void lvLinks_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.All;
		}

		private void lvLinks_DragDropAsync(object sender, DragEventArgs e)
		{
			DataObject dataObject = (DataObject)e.Data;

			if (dataObject.ContainsFileDropList())
			{
				int count = 0;
				foreach (string path in dataObject.GetFileDropList())
				{
					if (path.EndsWith(".url")) 
					{
						string fileName = Path.GetFileNameWithoutExtension(path);
						System.Diagnostics.Debug.WriteLine(fileName);

						ListViewItem item = new ListViewItem(fileName);
						item.Text = count++.ToString();

						item.SubItems.Add(fileName);

						lvLinks.Items.Add(item);

						string url = "";
						StreamReader sr = new StreamReader(path);
						while (!sr.EndOfStream)
						{
							string ln = sr.ReadLine();
							if (ln.StartsWith("URL="))
							{
								url = ln.Substring(4);
								int amprs = url.IndexOf('&');
								if (amprs > 0)
									url = url.Substring(0, amprs);
								break;
							}
						}
						sr.Close();

						item.SubItems.Add(url);
					}
				}
			}
			else if (dataObject.ContainsText())
			{
				string url = dataObject.GetText();
	
				if (url.StartsWith("http://") || url.StartsWith("https://"))
				{
					HtmlAgilityPack.HtmlWeb web = new HtmlAgilityPack.HtmlWeb();
					HtmlAgilityPack.HtmlDocument doc = web.Load(url);
					string title = doc.DocumentNode.SelectSingleNode("//title").InnerText;

					ListViewItem item = new ListViewItem(lvLinks.Items.Count.ToString());
					item.SubItems.Add(title);
					item.SubItems.Add(url);

					lvLinks.Items.Add(item);
				}
			}
			else
			{
				string[] formats = dataObject.GetFormats();
				System.Diagnostics.Debug.WriteLine("UNKNOWN!! " + string.Join(", ", formats));
			}
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			string txt = rtTweet.Text;

			string curSpan = "";
			bool idxFlag = false;
			string tweet_entry = "";
			int currIdx = -1;

			System.Diagnostics.Debug.WriteLine(txt);
			for (int x = 0; x < txt.Length; x++)
			{
				if (txt[x] == '{')
				{
					// System.Diagnostics.Debug.Write('\n');
					System.Diagnostics.Debug.WriteLine("[" + curSpan + "]");
					tweet_entry += curSpan;
					curSpan = "";
					idxFlag = true;
				}

				else if (txt[x] == ':' && idxFlag)
				{
					//System.Diagnostics.Debug.Write('\n');
					System.Diagnostics.Debug.WriteLine("[idx(" + curSpan + ")]");
					currIdx = int.Parse(curSpan);
					curSpan = "";
					idxFlag = false;
				}

				else if (txt[x] == '}')
				{
					//System.Diagnostics.Debug.Write('\n');
					System.Diagnostics.Debug.WriteLine("[anchor text(" + curSpan + ")]");
					tweet_entry += "<strong><a href=\"" + lvLinks.Items[currIdx].SubItems[2].Text + "\">" + curSpan + "</a></strong>";
					curSpan = "";
					currIdx = -1;
				}

				else
				{
					curSpan += txt[x];
					//System.Diagnostics.Debug.Write(txt[x]);
				}
			}
			tweet_entry += curSpan;
			System.Diagnostics.Debug.WriteLine("[" + curSpan + "]");

			System.Diagnostics.Debug.WriteLine(tweet_entry);
		}
	}
}