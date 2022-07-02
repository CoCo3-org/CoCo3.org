namespace Testing123
{
	partial class FrmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.rtTweet = new System.Windows.Forms.RichTextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.tsbtnLoad = new System.Windows.Forms.ToolStripButton();
			this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnInsertLink = new System.Windows.Forms.ToolStripButton();
			this.tsbtnInsertLnkList = new System.Windows.Forms.ToolStripButton();
			this.lvLinks = new System.Windows.Forms.ListView();
			this.ch1 = new System.Windows.Forms.ColumnHeader();
			this.ch2 = new System.Windows.Forms.ColumnHeader();
			this.ch3 = new System.Windows.Forms.ColumnHeader();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.tsbtnReadDir = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.rtTweet);
			this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lvLinks);
			this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
			this.splitContainer1.Size = new System.Drawing.Size(940, 601);
			this.splitContainer1.SplitterDistance = 280;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 0;
			// 
			// rtTweet
			// 
			this.rtTweet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtTweet.Location = new System.Drawing.Point(0, 27);
			this.rtTweet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.rtTweet.Name = "rtTweet";
			this.rtTweet.Size = new System.Drawing.Size(940, 253);
			this.rtTweet.TabIndex = 1;
			this.rtTweet.Text = "";
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLoad,
            this.tsbtnSave,
            this.toolStripSeparator1,
            this.tsbtnInsertLink,
            this.tsbtnInsertLnkList,
            this.toolStripSeparator2,
            this.toolStripButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(940, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// tsbtnLoad
			// 
			this.tsbtnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLoad.Image")));
			this.tsbtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnLoad.Name = "tsbtnLoad";
			this.tsbtnLoad.Size = new System.Drawing.Size(29, 24);
			this.tsbtnLoad.Text = "Load Tweet";
			this.tsbtnLoad.Click += new System.EventHandler(this.tsbtnLoad_Click);
			// 
			// tsbtnSave
			// 
			this.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
			this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnSave.Name = "tsbtnSave";
			this.tsbtnSave.Size = new System.Drawing.Size(29, 24);
			this.tsbtnSave.Text = "Save Tweet";
			this.tsbtnSave.Click += new System.EventHandler(this.tsbtnSave_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// tsbtnInsertLink
			// 
			this.tsbtnInsertLink.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnInsertLink.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsertLink.Image")));
			this.tsbtnInsertLink.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnInsertLink.Name = "tsbtnInsertLink";
			this.tsbtnInsertLink.Size = new System.Drawing.Size(29, 24);
			this.tsbtnInsertLink.Text = "Insert Link";
			this.tsbtnInsertLink.Click += new System.EventHandler(this.tsbtnInsertLink_Click);
			// 
			// tsbtnInsertLnkList
			// 
			this.tsbtnInsertLnkList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnInsertLnkList.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInsertLnkList.Image")));
			this.tsbtnInsertLnkList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnInsertLnkList.Name = "tsbtnInsertLnkList";
			this.tsbtnInsertLnkList.Size = new System.Drawing.Size(29, 24);
			this.tsbtnInsertLnkList.Text = "Insert Link List";
			// 
			// lvLinks
			// 
			this.lvLinks.AllowDrop = true;
			this.lvLinks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3});
			this.lvLinks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvLinks.FullRowSelect = true;
			this.lvLinks.GridLines = true;
			this.lvLinks.LabelEdit = true;
			this.lvLinks.Location = new System.Drawing.Point(0, 27);
			this.lvLinks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lvLinks.Name = "lvLinks";
			this.lvLinks.Size = new System.Drawing.Size(940, 289);
			this.lvLinks.TabIndex = 1;
			this.lvLinks.UseCompatibleStateImageBehavior = false;
			this.lvLinks.View = System.Windows.Forms.View.Details;
			this.lvLinks.DragDrop += new System.Windows.Forms.DragEventHandler(this.lvLinks_DragDropAsync);
			this.lvLinks.DragEnter += new System.Windows.Forms.DragEventHandler(this.lvLinks_DragEnter);
			this.lvLinks.DoubleClick += new System.EventHandler(this.lvLinks_DoubleClick);
			// 
			// ch1
			// 
			this.ch1.Text = "#";
			// 
			// ch2
			// 
			this.ch2.Text = "Title";
			this.ch2.Width = 350;
			// 
			// ch3
			// 
			this.ch3.Text = "URL";
			this.ch3.Width = 350;
			// 
			// toolStrip2
			// 
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnReadDir});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(940, 27);
			this.toolStrip2.TabIndex = 0;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// tsbtnReadDir
			// 
			this.tsbtnReadDir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbtnReadDir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnReadDir.Image")));
			this.tsbtnReadDir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnReadDir.Name = "tsbtnReadDir";
			this.tsbtnReadDir.Size = new System.Drawing.Size(29, 24);
			this.tsbtnReadDir.Text = "Read Dir";
			this.tsbtnReadDir.Click += new System.EventHandler(this.tsbtnReadDir_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// FrmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(940, 601);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "FrmMain";
			this.Text = "Form1";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private SplitContainer splitContainer1;
		private RichTextBox rtTweet;
		private ToolStrip toolStrip1;
		private ToolStripButton tsbtnInsertLink;
		private ListView lvLinks;
		private ColumnHeader ch1;
		private ColumnHeader ch2;
		private ColumnHeader ch3;
		private ToolStrip toolStrip2;
		private ToolStripButton tsbtnReadDir;
		private ToolStripButton tsbtnInsertLnkList;
		private ToolStripButton tsbtnSave;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton tsbtnLoad;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton toolStripButton1;
	}
}