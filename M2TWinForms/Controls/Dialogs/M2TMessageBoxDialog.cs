using M2TWinForms.Controls.Window;
using M2TWinForms.Native;
using System.ComponentModel;

namespace M2TWinForms;

public partial class M2TMessageBoxDialog : M2TForm
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public string Message
    {
        get => LB_Message.Text;
        set => LB_Message.Text = value;
    }

    public M2TMessageBoxDialog()
    {
        InitializeComponent();
    }

    private void M2TMessageBoxDialog_Shown(object sender, EventArgs e)
    {
        FitToContents();
    }
    private void TLP_Main_Resize(object sender, EventArgs e)
    {
        FitToContents();
    }

    private void FitToContents()
    {
        var bounds = GetContainingControlsBounds();
        var yMetrics = WindowBorderSystemMetrics.GetForY();
        var xMetrics = WindowBorderSystemMetrics.GetForX();
        var captionHeight = SystemInformation.CaptionHeight;

        this.Size = bounds + new Size(xMetrics.Total * 2, yMetrics.Total * 2 + captionHeight);
    }

    private Size GetContainingControlsBounds()
    {
        int minX = int.MaxValue, minY = int.MaxValue;
        int maxX = int.MinValue, maxY = int.MinValue;

        foreach (Control ctrl in Controls)
        {
            if (!ctrl.Visible)
                continue;
            if (ctrl.Name == "PN_DragPanel")
                continue; // Skip the drag panel

            minX = Math.Min(minX, ctrl.Left);
            minY = Math.Min(minY, ctrl.Top);
            maxX = Math.Max(maxX, ctrl.Right + ctrl.Margin.Right);
            maxY = Math.Max(maxY, ctrl.Bottom + ctrl.Margin.Bottom);
        }

        if (minX == int.MaxValue || minY == int.MaxValue)
            return Size.Empty;

        return new Size(maxX, maxY);
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
        FitToContents();
    }
    public void FocusButton(M2TButton button)
    {
        if (button == null || !PN_Buttons.Controls.Contains(button))
            return;
        button.Focus();
        button.Select();
    }
}
