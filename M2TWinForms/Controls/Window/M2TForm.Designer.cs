namespace M2TWinForms.Controls.Window
{
    partial class M2TForm
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
            LB_Title = new Label();
            PN_DragPanel = new Panel();
            CloseButton = new Inputs.Buttons.ColoredImageButton();
            MinimizeButton = new Inputs.Buttons.ColoredImageButton();
            WindowImageButton = new Inputs.Buttons.ColoredImageButton();
            PN_DragPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LB_Title
            // 
            LB_Title.AutoSize = true;
            LB_Title.BackColor = Color.Transparent;
            LB_Title.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_Title.ForeColor = Color.White;
            LB_Title.Location = new Point(52, 10);
            LB_Title.Name = "LB_Title";
            LB_Title.Size = new Size(38, 20);
            LB_Title.TabIndex = 1;
            LB_Title.Text = "Title";
            // 
            // PN_DragPanel
            // 
            PN_DragPanel.BackColor = Color.DimGray;
            PN_DragPanel.Controls.Add(CloseButton);
            PN_DragPanel.Controls.Add(MinimizeButton);
            PN_DragPanel.Controls.Add(WindowImageButton);
            PN_DragPanel.Controls.Add(LB_Title);
            PN_DragPanel.Dock = DockStyle.Top;
            PN_DragPanel.Location = new Point(0, 0);
            PN_DragPanel.Margin = new Padding(3, 2, 3, 2);
            PN_DragPanel.Name = "PN_DragPanel";
            PN_DragPanel.Size = new Size(840, 40);
            PN_DragPanel.TabIndex = 11;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(12, 12, 13);
            CloseButton.BackgroundColorType = Enumerations.ColorType.BackgroundPrimary;
            CloseButton.BaseImage = Properties.Resources.Close;
            CloseButton.ConvertBaseImageToGrayscale = true;
            CloseButton.HoverBackgroundColorType = Enumerations.ColorType.BackgroundHoverPrimary;
            CloseButton.HoverEnabled = true;
            CloseButton.HoverImageColorType = Enumerations.ColorType.ForegroundHoverPrimary;
            CloseButton.ImageColorType = Enumerations.ColorType.ForegroundPrimary;
            CloseButton.ImagePadding = new Padding(0);
            CloseButton.Location = new Point(800, 0);
            CloseButton.Margin = new Padding(4, 3, 4, 3);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(40, 40);
            CloseButton.TabIndex = 14;
            CloseButton.TabStop = false;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.BackColor = Color.FromArgb(12, 12, 13);
            MinimizeButton.BackgroundColorType = Enumerations.ColorType.BackgroundPrimary;
            MinimizeButton.BaseImage = Properties.Resources.Minimize;
            MinimizeButton.ConvertBaseImageToGrayscale = true;
            MinimizeButton.HoverBackgroundColorType = Enumerations.ColorType.BackgroundHoverPrimary;
            MinimizeButton.HoverEnabled = true;
            MinimizeButton.HoverImageColorType = Enumerations.ColorType.ForegroundHoverPrimary;
            MinimizeButton.ImageColorType = Enumerations.ColorType.ForegroundPrimary;
            MinimizeButton.ImagePadding = new Padding(0);
            MinimizeButton.Location = new Point(760, 0);
            MinimizeButton.Margin = new Padding(4, 3, 4, 3);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(40, 40);
            MinimizeButton.TabIndex = 13;
            MinimizeButton.TabStop = false;
            // 
            // WindowImageButton
            // 
            WindowImageButton.BackColor = Color.FromArgb(12, 12, 13);
            WindowImageButton.BackgroundColorType = Enumerations.ColorType.BackgroundPrimary;
            WindowImageButton.BaseImage = null;
            WindowImageButton.ConvertBaseImageToGrayscale = false;
            WindowImageButton.HoverBackgroundColorType = Enumerations.ColorType.BackgroundHoverPrimary;
            WindowImageButton.HoverEnabled = true;
            WindowImageButton.HoverImageColorType = Enumerations.ColorType.ForegroundHoverPrimary;
            WindowImageButton.ImageColorType = Enumerations.ColorType.ForegroundPrimary;
            WindowImageButton.ImagePadding = new Padding(3);
            WindowImageButton.Location = new Point(10, 0);
            WindowImageButton.Margin = new Padding(4, 3, 4, 3);
            WindowImageButton.Name = "WindowImageButton";
            WindowImageButton.Size = new Size(40, 40);
            WindowImageButton.TabIndex = 12;
            WindowImageButton.TabStop = false;
            // 
            // M2TForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(60, 60, 60);
            ClientSize = new Size(840, 400);
            Controls.Add(PN_DragPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "M2TForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            PN_DragPanel.ResumeLayout(false);
            PN_DragPanel.PerformLayout();
            ResumeLayout(false);
        }

        internal Label LB_Title;
        internal Panel PN_DragPanel;
        internal Inputs.Buttons.ColoredImageButton WindowImageButton;
        internal Inputs.Buttons.ColoredImageButton MinimizeButton;
        internal Inputs.Buttons.ColoredImageButton CloseButton;

        #endregion
    }
}