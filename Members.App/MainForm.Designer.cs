namespace Members.App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            toolStrip = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            moveRightButton = new Button();
            moveLeftButton = new Button();
            peopleTreeView = new TreeView();
            imageList = new ImageList( components );
            groupsTreeView = new TreeView();
            menuStrip.SuspendLayout();
            toolStrip.SuspendLayout();
            statusStrip.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size( 28, 28 );
            menuStrip.Items.AddRange( new ToolStripItem[ ] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem } );
            menuStrip.Location = new Point( 0, 0 );
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size( 1367, 38 );
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[ ] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem } );
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size( 62, 34 );
            fileToolStripMenuItem.Text = "&File";
            fileToolStripMenuItem.Click +=  OnExit ;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image) resources.GetObject( "newToolStripMenuItem.Image" );
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.N ;
            newToolStripMenuItem.Size = new Size( 257, 40 );
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image) resources.GetObject( "openToolStripMenuItem.Image" );
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.O ;
            openToolStripMenuItem.Size = new Size( 257, 40 );
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size( 254, 6 );
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image) resources.GetObject( "saveToolStripMenuItem.Image" );
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.S ;
            saveToolStripMenuItem.Size = new Size( 257, 40 );
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size( 257, 40 );
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size( 254, 6 );
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image) resources.GetObject( "printToolStripMenuItem.Image" );
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.P ;
            printToolStripMenuItem.Size = new Size( 257, 40 );
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image) resources.GetObject( "printPreviewToolStripMenuItem.Image" );
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size( 257, 40 );
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size( 254, 6 );
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size( 257, 40 );
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[ ] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem } );
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size( 66, 34 );
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.Z ;
            undoToolStripMenuItem.Size = new Size( 252, 40 );
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.Y ;
            redoToolStripMenuItem.Size = new Size( 252, 40 );
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size( 249, 6 );
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image) resources.GetObject( "cutToolStripMenuItem.Image" );
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.X ;
            cutToolStripMenuItem.Size = new Size( 252, 40 );
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image) resources.GetObject( "copyToolStripMenuItem.Image" );
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.C ;
            copyToolStripMenuItem.Size = new Size( 252, 40 );
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image) resources.GetObject( "pasteToolStripMenuItem.Image" );
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.V ;
            pasteToolStripMenuItem.Size = new Size( 252, 40 );
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size( 249, 6 );
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size( 252, 40 );
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[ ] { customizeToolStripMenuItem, optionsToolStripMenuItem } );
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size( 78, 34 );
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size( 228, 40 );
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size( 228, 40 );
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[ ] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem } );
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size( 74, 34 );
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size( 214, 40 );
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size( 214, 40 );
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size( 214, 40 );
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size( 211, 6 );
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size( 214, 40 );
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size( 28, 28 );
            toolStrip.Items.AddRange( new ToolStripItem[ ] { toolStripButton1, toolStripSeparator6, toolStripButton2, toolStripButton3 } );
            toolStrip.Location = new Point( 0, 38 );
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size( 1367, 38 );
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image) resources.GetObject( "toolStripButton1.Image" );
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size( 40, 32 );
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click +=  OnSave ;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size( 6, 38 );
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image) resources.GetObject( "toolStripButton2.Image" );
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size( 40, 32 );
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click +=  OnAddPerson ;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image) resources.GetObject( "toolStripButton3.Image" );
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size( 40, 32 );
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click +=  OnAddGroup ;
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size( 28, 28 );
            statusStrip.Items.AddRange( new ToolStripItem[ ] { toolStripStatusLabel1 } );
            statusStrip.Location = new Point( 0, 966 );
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size( 1367, 39 );
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size( 28, 30 );
            toolStripStatusLabel1.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 49.9999924F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50.0000038F ) );
            tableLayoutPanel1.Controls.Add( moveRightButton, 1, 0 );
            tableLayoutPanel1.Controls.Add( moveLeftButton, 1, 1 );
            tableLayoutPanel1.Controls.Add( peopleTreeView, 0, 0 );
            tableLayoutPanel1.Controls.Add( groupsTreeView, 2, 0 );
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point( 0, 76 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.Size = new Size( 1367, 890 );
            tableLayoutPanel1.TabIndex = 3;
            // 
            // moveRightButton
            // 
            moveRightButton.Anchor = AnchorStyles.Bottom;
            moveRightButton.Image = (Image) resources.GetObject( "moveRightButton.Image" );
            moveRightButton.Location = new Point( 651, 378 );
            moveRightButton.Name = "moveRightButton";
            moveRightButton.Size = new Size( 64, 64 );
            moveRightButton.TabIndex = 0;
            moveRightButton.UseVisualStyleBackColor = true;
            // 
            // moveLeftButton
            // 
            moveLeftButton.Anchor = AnchorStyles.Top;
            moveLeftButton.Image = (Image) resources.GetObject( "moveLeftButton.Image" );
            moveLeftButton.Location = new Point( 651, 448 );
            moveLeftButton.Name = "moveLeftButton";
            moveLeftButton.Size = new Size( 64, 64 );
            moveLeftButton.TabIndex = 1;
            moveLeftButton.UseVisualStyleBackColor = true;
            // 
            // peopleTreeView
            // 
            peopleTreeView.Dock = DockStyle.Fill;
            peopleTreeView.FullRowSelect = true;
            peopleTreeView.HideSelection = false;
            peopleTreeView.ImageIndex = 0;
            peopleTreeView.ImageList = imageList;
            peopleTreeView.Location = new Point( 3, 3 );
            peopleTreeView.Name = "peopleTreeView";
            tableLayoutPanel1.SetRowSpan( peopleTreeView, 2 );
            peopleTreeView.SelectedImageIndex = 0;
            peopleTreeView.Size = new Size( 642, 884 );
            peopleTreeView.TabIndex = 2;
            peopleTreeView.AfterSelect +=  OnSelectNode ;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer) resources.GetObject( "imageList.ImageStream" );
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName( 0, "Person" );
            imageList.Images.SetKeyName( 1, "Group" );
            // 
            // groupsTreeView
            // 
            groupsTreeView.Dock = DockStyle.Fill;
            groupsTreeView.ImageIndex = 0;
            groupsTreeView.ImageList = imageList;
            groupsTreeView.Location = new Point( 721, 3 );
            groupsTreeView.Name = "groupsTreeView";
            tableLayoutPanel1.SetRowSpan( groupsTreeView, 2 );
            groupsTreeView.SelectedImageIndex = 0;
            groupsTreeView.Size = new Size( 643, 884 );
            groupsTreeView.TabIndex = 3;
            groupsTreeView.AfterSelect +=  OnSelectNode ;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF( 12F, 30F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 1367, 1005 );
            Controls.Add( tableLayoutPanel1 );
            Controls.Add( statusStrip );
            Controls.Add( toolStrip );
            Controls.Add( menuStrip );
            MainMenuStrip = menuStrip;
            Name = "MainForm";
            Text = "Members 2024";
            menuStrip.ResumeLayout( false );
            menuStrip.PerformLayout();
            toolStrip.ResumeLayout( false );
            toolStrip.PerformLayout();
            statusStrip.ResumeLayout( false );
            statusStrip.PerformLayout();
            tableLayoutPanel1.ResumeLayout( false );
            ResumeLayout( false );
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStrip toolStrip;
        private StatusStrip statusStrip;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button moveRightButton;
        private Button moveLeftButton;
        private TreeView peopleTreeView;
        private TreeView groupsTreeView;
        private ImageList imageList;
    }
}
