using M2TWinForms.Themes.MaterialDesign;
using System.ComponentModel;

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
            MaximizeButton = new M2TWinForms.Controls.Inputs.Buttons.ColoredImageButton();
            CloseButton = new M2TWinForms.Controls.Inputs.Buttons.ColoredImageButton();
            MinimizeButton = new M2TWinForms.Controls.Inputs.Buttons.ColoredImageButton();
            WindowImageButton = new M2TWinForms.Controls.Inputs.Buttons.ColoredImageButton();
            PN_DragPanel.SuspendLayout();
            SuspendLayout();
            // 
            // LB_Title
            // 
            LB_Title.AutoSize = true;
            LB_Title.BackColor = Color.Transparent;
            LB_Title.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LB_Title.ForeColor = Color.White;
            LB_Title.Location = new Point(44, 8);
            LB_Title.Name = "LB_Title";
            LB_Title.Size = new Size(38, 20);
            LB_Title.TabIndex = 1;
            LB_Title.Text = "Title";
            // 
            // PN_DragPanel
            // 
            PN_DragPanel.Controls.Add(MaximizeButton);
            PN_DragPanel.Controls.Add(CloseButton);
            PN_DragPanel.Controls.Add(MinimizeButton);
            PN_DragPanel.Controls.Add(WindowImageButton);
            PN_DragPanel.Controls.Add(LB_Title);
            PN_DragPanel.Dock = DockStyle.Top;
            PN_DragPanel.Location = new Point(0, 0);
            PN_DragPanel.Margin = new Padding(0);
            PN_DragPanel.Name = "PN_DragPanel";
            PN_DragPanel.Size = new Size(840, 36);
            PN_DragPanel.TabIndex = 11;
            // 
            // MaximizeButton
            // 
            MaximizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximizeButton.BackColor = Color.FromArgb(238, 232, 218);
            MaximizeButton.BackgroundColorRole = ColorRoles.SurfaceContainerHigh;
            MaximizeButton.BaseImage = Properties.Resources.Maximize;
            MaximizeButton.ConvertBaseImageToGrayscale = true;
            MaximizeButton.HoverBackgroundColorRole = ColorRoles.SurfaceContainer;
            MaximizeButton.HoverEnabled = true;
            MaximizeButton.HoverImageColorRole = ColorRoles.OnSurface;
            MaximizeButton.ImageColorRole = ColorRoles.OnSurface;
            MaximizeButton.ImagePadding = new Padding(3);
            MaximizeButton.Location = new Point(768, 0);
            MaximizeButton.Name = "MaximizeButton";
            MaximizeButton.Size = new Size(36, 36);
            MaximizeButton.TabIndex = 15;
            MaximizeButton.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(238, 232, 218);
            CloseButton.BackgroundColorRole = ColorRoles.SurfaceContainerHigh;
            CloseButton.BaseImage = Properties.Resources.Close;
            CloseButton.ConvertBaseImageToGrayscale = true;
            CloseButton.HoverBackgroundColorRole = ColorRoles.SurfaceContainer;
            CloseButton.HoverEnabled = true;
            CloseButton.HoverImageColorRole = ColorRoles.Error;
            CloseButton.ImageColorRole = ColorRoles.Error;
            CloseButton.ImagePadding = new Padding(0);
            CloseButton.Location = new Point(804, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(36, 36);
            CloseButton.TabIndex = 14;
            CloseButton.TabStop = false;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.BackColor = Color.FromArgb(238, 232, 218);
            MinimizeButton.BackgroundColorRole = ColorRoles.SurfaceContainerHigh;
            MinimizeButton.BaseImage = Properties.Resources.Minimize;
            MinimizeButton.ConvertBaseImageToGrayscale = true;
            MinimizeButton.HoverBackgroundColorRole = ColorRoles.SurfaceContainer;
            MinimizeButton.HoverEnabled = true;
            MinimizeButton.HoverImageColorRole = ColorRoles.OnSurface;
            MinimizeButton.ImageColorRole = ColorRoles.OnSurface;
            MinimizeButton.ImagePadding = new Padding(0, 2, 0, -2);
            MinimizeButton.Location = new Point(732, 0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(36, 36);
            MinimizeButton.TabIndex = 13;
            MinimizeButton.TabStop = false;
            // 
            // WindowImageButton
            // 
            WindowImageButton.BackColor = Color.FromArgb(238, 232, 218);
            WindowImageButton.BackgroundColorRole = ColorRoles.SurfaceContainerHigh;
            WindowImageButton.BaseImage = Properties.Resources.WindowIcon;
            WindowImageButton.ConvertBaseImageToGrayscale = false;
            WindowImageButton.HoverBackgroundColorRole = ColorRoles.SurfaceContainer;
            WindowImageButton.HoverEnabled = true;
            WindowImageButton.HoverImageColorRole = ColorRoles.OnSurface;
            WindowImageButton.ImageColorRole = ColorRoles.OnSurface;
            WindowImageButton.ImagePadding = new Padding(0);
            WindowImageButton.Location = new Point(5, 0);
            WindowImageButton.Name = "WindowImageButton";
            WindowImageButton.Size = new Size(36, 36);
            WindowImageButton.TabIndex = 12;
            WindowImageButton.TabStop = false;
            // 
            // M2TForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(840, 400);
            Controls.Add(PN_DragPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "M2TForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterParent;
            Resize += M2TForm_Resize;
            PN_DragPanel.ResumeLayout(false);
            PN_DragPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Label LB_Title;
        private Panel PN_DragPanel;
        private Inputs.Buttons.ColoredImageButton WindowImageButton;
        private Inputs.Buttons.ColoredImageButton MinimizeButton;
        private Inputs.Buttons.ColoredImageButton CloseButton;
        private Inputs.Buttons.ColoredImageButton MaximizeButton;

        #endregion
    }
}