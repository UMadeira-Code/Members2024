using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Members.App
{
    public partial class PromptForm : Form
    {
        public PromptForm()
        {
            InitializeComponent();

            ActiveControl = valueTextBox;
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
