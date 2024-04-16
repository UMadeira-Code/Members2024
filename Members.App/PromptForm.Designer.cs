namespace Members.App
{
    partial class PromptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            okButton = new Button();
            cancelButton = new Button();
            valueTextBox = new TextBox();
            labelLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle( SizeType.Percent, 100F ) );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.ColumnStyles.Add( new ColumnStyle() );
            tableLayoutPanel1.Controls.Add( okButton, 1, 2 );
            tableLayoutPanel1.Controls.Add( cancelButton, 2, 2 );
            tableLayoutPanel1.Controls.Add( valueTextBox, 0, 1 );
            tableLayoutPanel1.Controls.Add( labelLabel, 0, 0 );
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point( 0, 0 );
            tableLayoutPanel1.Margin = new Padding( 2 );
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding( 8 );
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle( SizeType.Percent, 50F ) );
            tableLayoutPanel1.RowStyles.Add( new RowStyle() );
            tableLayoutPanel1.Size = new Size( 698, 174 );
            tableLayoutPanel1.TabIndex = 0;
            // 
            // okButton
            // 
            okButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right ;
            okButton.DialogResult = DialogResult.OK;
            okButton.Location = new Point( 419, 123 );
            okButton.Name = "okButton";
            okButton.Size = new Size( 131, 40 );
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            cancelButton.Anchor =   AnchorStyles.Top  |  AnchorStyles.Right ;
            cancelButton.DialogResult = DialogResult.Cancel;
            cancelButton.Location = new Point( 556, 123 );
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size( 131, 40 );
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // valueTextBox
            // 
            valueTextBox.Anchor =    AnchorStyles.Top  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            tableLayoutPanel1.SetColumnSpan( valueTextBox, 3 );
            valueTextBox.Location = new Point( 11, 67 );
            valueTextBox.Name = "valueTextBox";
            valueTextBox.Size = new Size( 676, 35 );
            valueTextBox.TabIndex = 2;
            // 
            // labelLabel
            // 
            labelLabel.Anchor =    AnchorStyles.Bottom  |  AnchorStyles.Left   |  AnchorStyles.Right ;
            labelLabel.AutoSize = true;
            labelLabel.Location = new Point( 11, 34 );
            labelLabel.Name = "labelLabel";
            labelLabel.Size = new Size( 402, 30 );
            labelLabel.TabIndex = 3;
            labelLabel.Text = "label1";
            // 
            // PromptForm
            // 
            AutoScaleDimensions = new SizeF( 12F, 30F );
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size( 698, 174 );
            Controls.Add( tableLayoutPanel1 );
            Name = "PromptForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PromptForm";
            tableLayoutPanel1.ResumeLayout( false );
            tableLayoutPanel1.PerformLayout();
            ResumeLayout( false );
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button okButton;
        private Button cancelButton;
        private TextBox valueTextBox;
        private Label labelLabel;
    }
}