namespace Members.App
{
    public partial class PromptForm : Form
    {
        public PromptForm() : this( "Prompt Dialog", "Value:", string.Empty )
        {
        }

        public PromptForm( string title, string label, string value = "" )
        {
            InitializeComponent();

            ActiveControl = valueTextBox;
            AcceptButton  = okButton;
            CancelButton  = cancelButton;

            Title = title;
            Label = label;
            Value = value;
        }

        public string Title
        {
            get => this.Text;
            set => this.Text = value;
        }

        public string Label
        {
            get => labelLabel.Text;
            set => labelLabel.Text = value;
        }

        public string Value
        {
            get => valueTextBox.Text;
            set => valueTextBox.Text = value;
        }
    }
}
