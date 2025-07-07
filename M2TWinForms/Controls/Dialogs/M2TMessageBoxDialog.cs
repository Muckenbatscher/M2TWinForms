using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M2TWinForms
{
    public partial class M2TMessageBoxDialog : M2TForm
    {
        public string Message
        {
            get => LB_Message.Text;
            set => LB_Message.Text = value;
        }

        public M2TMessageBoxDialog()
        {
            InitializeComponent();
        }
        public void AddButtons(IEnumerable<M2TButton> buttons)
        {
            if (buttons == null || !buttons.Any())
                return;

            PN_Buttons.Controls.Clear();

            var currentButtonLocationOffset = 0;
            var buttonWidthsIncludingMargin = buttons.Select(x => x.Width + x.Margin.Horizontal);
            var minimumRequiredWidth = buttonWidthsIncludingMargin.Sum();
            if (minimumRequiredWidth > PN_Buttons.Width)
                PN_Buttons.Width = minimumRequiredWidth;

            int buttonTabIndex = buttons.Count();
            foreach (var button in buttons.Reverse())
            {
                button.Dock = DockStyle.None;
                button.Height = PN_Buttons.Height - button.Margin.Vertical;
                PN_Buttons.Controls.Add(button);
                var locationX = PN_Buttons.Width - currentButtonLocationOffset - button.Width - button.Margin.Horizontal;
                var locationY = button.Margin.Top;
                button.Location = new Point(locationX, locationY);
                button.TabIndex = buttonTabIndex;
                currentButtonLocationOffset = PN_Buttons.Width - locationX;
                buttonTabIndex -= 1;
            }
        }
        public void FocusButton(M2TButton button)
        {
            if (button == null || !PN_Buttons.Controls.Contains(button))
                return;
            button.Focus();
            button.Select();
        }
    }
}
