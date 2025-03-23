using M2TWinForms.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms.Controls.Inputs.Text
{
    public partial class M2TRichTextBoxSingleLine : M2TRichTextBox, IThemedControl
    {
        public M2TRichTextBoxSingleLine() : base()
        {
            InitializeComponent();
            this.Multiline = false;
            SetPreferredHeight();
        }

        private void M2TRichTextBoxSingleLine_FontChanged(object sender, EventArgs e)
        {
            SetPreferredHeight();
        }

        private void SetPreferredHeight()
        {
            this.Height = this.PreferredHeight;
            this.MinimumSize = new Size(0, this.PreferredHeight);
            this.MaximumSize = new Size(int.MaxValue, this.PreferredHeight);
        }
    }
}
