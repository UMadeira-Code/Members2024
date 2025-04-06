using System.ComponentModel;

namespace Members.App
{
    public partial class PromptDialog : Form
    {
        public PromptDialog() : this( "Prompt Dialog", "Value:", string.Empty )
        {
        }

        public PromptDialog( string title, string label, string value = "" )
        {
            InitializeComponent();

            ActiveControl = valueTextBox;
            AcceptButton  = okButton;
            CancelButton  = cancelButton;

            Title = title;
            Label = label;
            Value = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get => this.Text;
            set => this.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Label
        {
            get => labelLabel.Text;
            set => labelLabel.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value
        {
            get => valueTextBox.Text;
            set => valueTextBox.Text = value;
        }
    }
}
