namespace PixelEdits
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scaleUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scaleDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flipHorizontallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.flipVerticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rotateLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoOutLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoShadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.Canvas = new System.Windows.Forms.Panel();
			this.ToolBarPanel = new System.Windows.Forms.Panel();
			this.PrimaryColourPanel = new System.Windows.Forms.Panel();
			this.SecondaryColourPanel = new System.Windows.Forms.Panel();
			this.ColourBackDrop = new System.Windows.Forms.Panel();
			this.GIFNextButton = new System.Windows.Forms.Button();
			this.GIFPrevFrame = new System.Windows.Forms.Button();
			this.SwapColourPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.SizeNumUpDown = new System.Windows.Forms.NumericUpDown();
			this.menuStrip1.SuspendLayout();
			this.ToolBarPanel.SuspendLayout();
			this.ColourBackDrop.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SizeNumUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.autoToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
			this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
			this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripSeparator
			// 
			this.toolStripSeparator.Name = "toolStripSeparator";
			this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
			this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
			this.editToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "&Edit";
			// 
			// undoToolStripMenuItem
			// 
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.undoToolStripMenuItem.Text = "&Undo";
			// 
			// redoToolStripMenuItem
			// 
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.redoToolStripMenuItem.Text = "&Redo";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
			this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cutToolStripMenuItem.Text = "Cu&t";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
			// 
			// selectAllToolStripMenuItem
			// 
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.gridToolStripMenuItem,
            this.fullScreenToolStripMenuItem});
			this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.toolsToolStripMenuItem.Text = "Veiw";
			// 
			// zoomToolStripMenuItem
			// 
			this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem});
			this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
			this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.zoomToolStripMenuItem.Text = "Zoom";
			// 
			// zoomInToolStripMenuItem
			// 
			this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
			this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.zoomInToolStripMenuItem.Text = "Zoom In";
			// 
			// zoomOutToolStripMenuItem
			// 
			this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
			this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
			this.zoomOutToolStripMenuItem.Text = "Zoom Out";
			// 
			// gridToolStripMenuItem
			// 
			this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
			this.gridToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
			this.gridToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.gridToolStripMenuItem.Text = "&Grid";
			// 
			// fullScreenToolStripMenuItem
			// 
			this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
			this.fullScreenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
			this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fullScreenToolStripMenuItem.Text = "&FullScreen";
			this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.fullScreenToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem});
			this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.helpToolStripMenuItem.Text = "&Image";
			// 
			// contentsToolStripMenuItem
			// 
			this.contentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scaleUpToolStripMenuItem,
            this.scaleDownToolStripMenuItem});
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.contentsToolStripMenuItem.Text = "Scale";
			// 
			// scaleUpToolStripMenuItem
			// 
			this.scaleUpToolStripMenuItem.Name = "scaleUpToolStripMenuItem";
			this.scaleUpToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.scaleUpToolStripMenuItem.Text = "Scale Up";
			// 
			// scaleDownToolStripMenuItem
			// 
			this.scaleDownToolStripMenuItem.Name = "scaleDownToolStripMenuItem";
			this.scaleDownToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.scaleDownToolStripMenuItem.Text = "Scale Down";
			// 
			// indexToolStripMenuItem
			// 
			this.indexToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flipHorizontallyToolStripMenuItem,
            this.flipVerticallyToolStripMenuItem});
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.indexToolStripMenuItem.Text = "Flip";
			// 
			// flipHorizontallyToolStripMenuItem
			// 
			this.flipHorizontallyToolStripMenuItem.Name = "flipHorizontallyToolStripMenuItem";
			this.flipHorizontallyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.flipHorizontallyToolStripMenuItem.Text = "Flip Horizontally";
			// 
			// flipVerticallyToolStripMenuItem
			// 
			this.flipVerticallyToolStripMenuItem.Name = "flipVerticallyToolStripMenuItem";
			this.flipVerticallyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.flipVerticallyToolStripMenuItem.Text = "Flip Vertically";
			// 
			// searchToolStripMenuItem
			// 
			this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rotateRightToolStripMenuItem,
            this.rotateLeftToolStripMenuItem});
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.searchToolStripMenuItem.Text = "Rotate";
			// 
			// rotateRightToolStripMenuItem
			// 
			this.rotateRightToolStripMenuItem.Name = "rotateRightToolStripMenuItem";
			this.rotateRightToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.rotateRightToolStripMenuItem.Text = "Rotate Right";
			// 
			// rotateLeftToolStripMenuItem
			// 
			this.rotateLeftToolStripMenuItem.Name = "rotateLeftToolStripMenuItem";
			this.rotateLeftToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.rotateLeftToolStripMenuItem.Text = "Rotate Left";
			// 
			// autoToolStripMenuItem
			// 
			this.autoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoOutLineToolStripMenuItem,
            this.autoShadeToolStripMenuItem,
            this.autoDeleteToolStripMenuItem});
			this.autoToolStripMenuItem.ForeColor = System.Drawing.Color.LightGray;
			this.autoToolStripMenuItem.Name = "autoToolStripMenuItem";
			this.autoToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.autoToolStripMenuItem.Text = "Auto";
			// 
			// autoOutLineToolStripMenuItem
			// 
			this.autoOutLineToolStripMenuItem.Name = "autoOutLineToolStripMenuItem";
			this.autoOutLineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.autoOutLineToolStripMenuItem.Text = "Auto-OutLine";
			// 
			// autoShadeToolStripMenuItem
			// 
			this.autoShadeToolStripMenuItem.Name = "autoShadeToolStripMenuItem";
			this.autoShadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.autoShadeToolStripMenuItem.Text = "Auto-Shade";
			// 
			// autoDeleteToolStripMenuItem
			// 
			this.autoDeleteToolStripMenuItem.Name = "autoDeleteToolStripMenuItem";
			this.autoDeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.autoDeleteToolStripMenuItem.Text = "Auto-Delete";
			// 
			// Canvas
			// 
			this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Canvas.BackColor = System.Drawing.Color.White;
			this.Canvas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Canvas.ForeColor = System.Drawing.Color.LightGray;
			this.Canvas.Location = new System.Drawing.Point(12, 37);
			this.Canvas.Name = "Canvas";
			this.Canvas.Size = new System.Drawing.Size(659, 420);
			this.Canvas.TabIndex = 1;
			this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
			this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
			this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
			this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
			// 
			// ToolBarPanel
			// 
			this.ToolBarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.ToolBarPanel.Controls.Add(this.PrimaryColourPanel);
			this.ToolBarPanel.Controls.Add(this.SecondaryColourPanel);
			this.ToolBarPanel.Controls.Add(this.ColourBackDrop);
			this.ToolBarPanel.Location = new System.Drawing.Point(678, 37);
			this.ToolBarPanel.Name = "ToolBarPanel";
			this.ToolBarPanel.Size = new System.Drawing.Size(110, 241);
			this.ToolBarPanel.TabIndex = 2;
			// 
			// PrimaryColourPanel
			// 
			this.PrimaryColourPanel.BackColor = System.Drawing.Color.Red;
			this.PrimaryColourPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PrimaryColourPanel.Location = new System.Drawing.Point(3, 3);
			this.PrimaryColourPanel.Name = "PrimaryColourPanel";
			this.PrimaryColourPanel.Size = new System.Drawing.Size(35, 35);
			this.PrimaryColourPanel.TabIndex = 0;
			this.PrimaryColourPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrimaryColourPanel_MouseDown);
			// 
			// SecondaryColourPanel
			// 
			this.SecondaryColourPanel.BackColor = System.Drawing.Color.Lime;
			this.SecondaryColourPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SecondaryColourPanel.Location = new System.Drawing.Point(15, 15);
			this.SecondaryColourPanel.Name = "SecondaryColourPanel";
			this.SecondaryColourPanel.Size = new System.Drawing.Size(35, 35);
			this.SecondaryColourPanel.TabIndex = 1;
			this.SecondaryColourPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SecondaryColourPanel_MouseDown);
			// 
			// ColourBackDrop
			// 
			this.ColourBackDrop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ColourBackDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ColourBackDrop.Controls.Add(this.SwapColourPanel);
			this.ColourBackDrop.Location = new System.Drawing.Point(0, 0);
			this.ColourBackDrop.Name = "ColourBackDrop";
			this.ColourBackDrop.Size = new System.Drawing.Size(111, 60);
			this.ColourBackDrop.TabIndex = 2;
			// 
			// GIFNextButton
			// 
			this.GIFNextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.GIFNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.GIFNextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.GIFNextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GIFNextButton.ForeColor = System.Drawing.Color.LightGray;
			this.GIFNextButton.Location = new System.Drawing.Point(735, 370);
			this.GIFNextButton.Name = "GIFNextButton";
			this.GIFNextButton.Size = new System.Drawing.Size(53, 87);
			this.GIFNextButton.TabIndex = 5;
			this.GIFNextButton.Text = "Next Frame";
			this.GIFNextButton.UseVisualStyleBackColor = false;
			// 
			// GIFPrevFrame
			// 
			this.GIFPrevFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.GIFPrevFrame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
			this.GIFPrevFrame.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.GIFPrevFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GIFPrevFrame.ForeColor = System.Drawing.Color.LightGray;
			this.GIFPrevFrame.Location = new System.Drawing.Point(678, 370);
			this.GIFPrevFrame.Name = "GIFPrevFrame";
			this.GIFPrevFrame.Size = new System.Drawing.Size(53, 87);
			this.GIFPrevFrame.TabIndex = 6;
			this.GIFPrevFrame.Text = "Prev Frame";
			this.GIFPrevFrame.UseVisualStyleBackColor = false;
			// 
			// SwapColourPanel
			// 
			this.SwapColourPanel.BackColor = System.Drawing.Color.White;
			this.SwapColourPanel.Location = new System.Drawing.Point(38, 3);
			this.SwapColourPanel.Name = "SwapColourPanel";
			this.SwapColourPanel.Size = new System.Drawing.Size(10, 10);
			this.SwapColourPanel.TabIndex = 3;
			this.SwapColourPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SwapColourPanel_MouseDown);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.SizeNumUpDown);
			this.panel1.Location = new System.Drawing.Point(678, 278);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(110, 86);
			this.panel1.TabIndex = 4;
			// 
			// SizeNumUpDown
			// 
			this.SizeNumUpDown.Location = new System.Drawing.Point(3, 6);
			this.SizeNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.SizeNumUpDown.Name = "SizeNumUpDown";
			this.SizeNumUpDown.Size = new System.Drawing.Size(102, 20);
			this.SizeNumUpDown.TabIndex = 0;
			this.SizeNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.SizeNumUpDown.ValueChanged += new System.EventHandler(this.SizeNumUpDown_ValueChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
			this.ClientSize = new System.Drawing.Size(800, 469);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.ToolBarPanel);
			this.Controls.Add(this.GIFPrevFrame);
			this.Controls.Add(this.GIFNextButton);
			this.Controls.Add(this.Canvas);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Black;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ToolBarPanel.ResumeLayout(false);
			this.ColourBackDrop.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.SizeNumUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scaleUpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scaleDownToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipHorizontallyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem flipVerticallyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rotateRightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rotateLeftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoOutLineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoShadeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoDeleteToolStripMenuItem;
		private System.Windows.Forms.Panel Canvas;
		private System.Windows.Forms.Panel ToolBarPanel;
		private System.Windows.Forms.Button GIFNextButton;
		private System.Windows.Forms.Button GIFPrevFrame;
		private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
		private System.Windows.Forms.Panel SecondaryColourPanel;
		private System.Windows.Forms.Panel PrimaryColourPanel;
		private System.Windows.Forms.Panel ColourBackDrop;
		private System.Windows.Forms.Panel SwapColourPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.NumericUpDown SizeNumUpDown;
	}
}

