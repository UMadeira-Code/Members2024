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
            saveToolStripButton = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            personToolStripButton = new ToolStripButton();
            groupToolStripButton = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            undoToolStripButton = new ToolStripButton();
            redoToolStripButton = new ToolStripButton();
            toolStripSeparator8 = new ToolStripSeparator();
            editToolStripButton = new ToolStripButton();
            deleteToolStripButton = new ToolStripButton();
            statusStrip = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            joinButton = new Button();
            leaveButton = new Button();
            peopleTreeView = new TreeView();
            imageList = new ImageList( components );
            groupsTreeView = new TreeView();
            toolStripButton1 = new ToolStripButton();
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
            menuStrip.Padding = new Padding( 4, 1, 0, 1 );
            menuStrip.Size = new Size( 797, 24 );
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[ ] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem } );
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size( 37, 22 );
            fileToolStripMenuItem.Text = "&File";
            fileToolStripMenuItem.Click +=  OnExit ;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image) resources.GetObject( "newToolStripMenuItem.Image" );
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.N ;
            newToolStripMenuItem.Size = new Size( 146, 22 );
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image) resources.GetObject( "openToolStripMenuItem.Image" );
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.O ;
            openToolStripMenuItem.Size = new Size( 146, 22 );
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size( 143, 6 );
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image) resources.GetObject( "saveToolStripMenuItem.Image" );
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.S ;
            saveToolStripMenuItem.Size = new Size( 146, 22 );
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size( 146, 22 );
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size( 143, 6 );
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image) resources.GetObject( "printToolStripMenuItem.Image" );
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.P ;
            printToolStripMenuItem.Size = new Size( 146, 22 );
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image) resources.GetObject( "printPreviewToolStripMenuItem.Image" );
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size( 146, 22 );
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size( 143, 6 );
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size( 146, 22 );
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[ ] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem } );
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size( 39, 22 );
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Image = (Image) resources.GetObject( "undoToolStripMenuItem.Image" );
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.Z ;
            undoToolStripMenuItem.Size = new Size( 144, 22 );
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Image = (Image) resources.GetObject( "redoToolStripMenuItem.Image" );
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.Y ;
            redoToolStripMenuItem.Size = new Size( 144, 22 );
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size( 141, 6 );
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image) resources.GetObject( "cutToolStripMenuItem.Image" );
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.X ;
            cutToolStripMenuItem.Size = new Size( 144, 22 );
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image) resources.GetObject( "copyToolStripMenuItem.Image" );
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.C ;
            copyToolStripMenuItem.Size = new Size( 144, 22 );
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image) resources.GetObject( "pasteToolStripMenuItem.Image" );
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys =   Keys.Control  |  Keys.V ;
            pasteToolStripMenuItem.Size = new Size( 144, 22 );
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size( 141, 6 );
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size( 144, 22 );
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[ ] { customizeToolStripMenuItem, optionsToolStripMenuItem } );
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size( 46, 22 );
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size( 130, 22 );
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size( 130, 22 );
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange( new ToolStripItem[ ] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem } );
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size( 44, 22 );
            helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size( 122, 22 );
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size( 122, 22 );
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size( 122, 22 );
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size( 119, 6 );
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size( 122, 22 );
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size( 28, 28 );
            toolStrip.Items.AddRange( new ToolStripItem[ ] { toolStripButton1, saveToolStripButton, toolStripSeparator6, personToolStripButton, groupToolStripButton, toolStripSeparator7, undoToolStripButton, redoToolStripButton, toolStripSeparator8, editToolStripButton, deleteToolStripButton } );
            toolStrip.Location = new Point( 0, 24 );
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size( 797, 35 );
            toolStrip.TabIndex = 1;
            toolStrip.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saveToolStripButton.Image = (Image) resources.GetObject( "saveToolStripButton.Image" );
            saveToolStripButton.ImageTransparentColor = Color.Magenta;
            saveToolStripButton.Name = "saveToolStripButton";
            saveToolStripButton.Size = new Size( 32, 32 );
            saveToolStripButton.Text = "Save";
            saveToolStripButton.Click +=  OnSave ;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size( 6, 35 );
            // 
            // personToolStripButton
            // 
            personToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            personToolStripButton.Image = (Image) resources.GetObject( "personToolStripButton.Image" );
            personToolStripButton.ImageTransparentColor = Color.Magenta;
            personToolStripButton.Name = "personToolStripButton";
            personToolStripButton.Size = new Size( 32, 32 );
            personToolStripButton.Text = "Person";
            personToolStripButton.ToolTipText = "Create Person";
            personToolStripButton.Click +=  OnAddPerson ;
            // 
            // groupToolStripButton
            // 
            groupToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            groupToolStripButton.Image = (Image) resources.GetObject( "groupToolStripButton.Image" );
            groupToolStripButton.ImageTransparentColor = Color.Magenta;
            groupToolStripButton.Name = "groupToolStripButton";
            groupToolStripButton.Size = new Size( 32, 32 );
            groupToolStripButton.Text = "Group";
            groupToolStripButton.ToolTipText = "Craete Group";
            groupToolStripButton.Click +=  OnAddGroup ;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size( 6, 35 );
            // 
            // undoToolStripButton
            // 
            undoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            undoToolStripButton.Enabled = false;
            undoToolStripButton.Image = (Image) resources.GetObject( "undoToolStripButton.Image" );
            undoToolStripButton.ImageTransparentColor = Color.Magenta;
            undoToolStripButton.Name = "undoToolStripButton";
            undoToolStripButton.Size = new Size( 32, 32 );
            undoToolStripButton.Text = "Undo";
            undoToolStripButton.ToolTipText = "Undo";
            // 
            // redoToolStripButton
            // 
            redoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            redoToolStripButton.Enabled = false;
            redoToolStripButton.Image = (Image) resources.GetObject( "redoToolStripButton.Image" );
            redoToolStripButton.ImageTransparentColor = Color.Magenta;
            redoToolStripButton.Name = "redoToolStripButton";
            redoToolStripButton.Size = new Size( 32, 32 );
            redoToolStripButton.Text = "Redo";
            redoToolStripButton.ToolTipText = "Redo";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size( 6, 35 );
            // 
            // editToolStripButton
            // 
            editToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            editToolStripButton.Image = (Image) resources.GetObject( "editToolStripButton.Image" );
            editToolStripButton.ImageTransparentColor = Color.Magenta;
            editToolStripButton.Name = "editToolStripButton";
            editToolStripButton.Size = new Size( 32, 32 );
            editToolStripButton.Text = "Edit";
            editToolStripButton.Click +=  OnEdit ;
            // 
            // deleteToolStripButton
            // 
            deleteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            deleteToolStripButton.Image = (Image) resources.GetObject( "deleteToolStripButton.Image" );
            deleteToolStripButton.ImageTransparentColor = Color.Magenta;
            deleteToolStripButton.Name = "deleteToolStripButton";
            deleteToolStripButton.Size = new Size( 32, 32 );
            deleteToolStripButton.Text = "Delete";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size( 28, 28 );
            statusStrip.Items.AddRange( new ToolStripItem[ ] { toolStripStatusLabel1 } );
            statusStrip.Location = new Point( 0, 481 );
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding( 1, 0, 8, 0 );
            statusStrip.Size = new Size( 797, 22 );
            statusStrip.TabIndex = 2;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size( 16, 17 );
            toolStripStatusLabel1.Text = "...";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 49.9999924F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 50.0000038F ) );
            tableLayoutPanel1.Controls.Add( joinButton, 1, 0 );
            tableLayoutPanel1.Controls.Add( leaveButton, 1, 1 );
            tableLayoutPanel1.Controls.Add( peopleTreeView, 0, 0 );
            tableLayoutPanel1.Controls.Add( groupsTreeView, 2, 0 );
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point( 0, 59 );
            tableLayoutPanel1.Margin = new Padding( 1 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.Size = new Size( 797, 422 );
            tableLayoutPanel1.TabIndex = 3;
            // 
            // joinButton
            // 
            joinButton.Anchor = AnchorStyles.Bottom;
            joinButton.Enabled = false;
            joinButton.Image = (Image) resources.GetObject( "joinButton.Image" );
            joinButton.Location = new Point( 379, 178 );
            joinButton.Margin = new Padding( 1 );
            joinButton.Name = "joinButton";
            joinButton.Size = new Size( 37, 32 );
            joinButton.TabIndex = 0;
            joinButton.UseVisualStyleBackColor = true;
            joinButton.Click +=  OnJoinGroup ;
            // 
            // leaveButton
            // 
            leaveButton.Anchor = AnchorStyles.Top;
            leaveButton.Enabled = false;
            leaveButton.Image = (Image) resources.GetObject( "leaveButton.Image" );
            leaveButton.Location = new Point( 379, 212 );
            leaveButton.Margin = new Padding( 1 );
            leaveButton.Name = "leaveButton";
            leaveButton.Size = new Size( 37, 32 );
            leaveButton.TabIndex = 1;
            leaveButton.UseVisualStyleBackColor = true;
            leaveButton.Click +=  OnLeaveGroup ;
            // 
            // peopleTreeView
            // 
            peopleTreeView.Dock = DockStyle.Fill;
            peopleTreeView.FullRowSelect = true;
            peopleTreeView.HideSelection = false;
            peopleTreeView.ImageIndex = 0;
            peopleTreeView.ImageList = imageList;
            peopleTreeView.Location = new Point( 1, 1 );
            peopleTreeView.Margin = new Padding( 1 );
            peopleTreeView.Name = "peopleTreeView";
            tableLayoutPanel1.SetRowSpan( peopleTreeView, 2 );
            peopleTreeView.SelectedImageIndex = 0;
            peopleTreeView.Size = new Size( 376, 420 );
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
            groupsTreeView.FullRowSelect = true;
            groupsTreeView.HideSelection = false;
            groupsTreeView.ImageIndex = 0;
            groupsTreeView.ImageList = imageList;
            groupsTreeView.Location = new Point( 418, 1 );
            groupsTreeView.Margin = new Padding( 1 );
            groupsTreeView.Name = "groupsTreeView";
            tableLayoutPanel1.SetRowSpan( groupsTreeView, 2 );
            groupsTreeView.SelectedImageIndex = 0;
            groupsTreeView.Size = new Size( 378, 420 );
            groupsTreeView.TabIndex = 3;
            groupsTreeView.AfterSelect +=  OnSelectNode ;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image) resources.GetObject( "toolStripButton1.Image" );
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size( 32, 32 );
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click +=  OnLoad ;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF( 7F, 15F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 797, 503 );
            Controls.Add( tableLayoutPanel1 );
            Controls.Add( statusStrip );
            Controls.Add( toolStrip );
            Controls.Add( menuStrip );
            MainMenuStrip = menuStrip;
            Margin = new Padding( 1 );
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
        private ToolStripButton saveToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton personToolStripButton;
        private ToolStripButton groupToolStripButton;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button joinButton;
        private Button leaveButton;
        private TreeView peopleTreeView;
        private TreeView groupsTreeView;
        private ImageList imageList;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton editToolStripButton;
        private ToolStripButton deleteToolStripButton;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton undoToolStripButton;
        private ToolStripButton redoToolStripButton;
        private ToolStripButton toolStripButton1;
    }
}
