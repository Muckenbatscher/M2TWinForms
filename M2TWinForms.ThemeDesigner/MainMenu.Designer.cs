using M2TWinForms;

namespace M2TWinForms.ThemeDesigner
{
    partial class MainMenu
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
            TLP_Main = new TableLayoutPanel();
            LB_ThemePreviewsPrompt = new M2TLabel();
            LB_ColorExperiments = new M2TLabel();
            BT_ThemeBuilderJson = new M2TButton();
            BT_HctConverter = new M2TButton();
            BT_PaletteGeneration = new M2TButton();
            BT_CoreColors = new M2TButton();
            BT_SingleColor = new M2TButton();
            TLP_Main.SuspendLayout();
            SuspendLayout();
            // 
            // TLP_Main
            // 
            TLP_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.ColumnCount = 3;
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            TLP_Main.Controls.Add(LB_ThemePreviewsPrompt, 0, 0);
            TLP_Main.Controls.Add(LB_ColorExperiments, 0, 2);
            TLP_Main.Controls.Add(BT_ThemeBuilderJson, 0, 1);
            TLP_Main.Controls.Add(BT_HctConverter, 0, 3);
            TLP_Main.Controls.Add(BT_PaletteGeneration, 1, 3);
            TLP_Main.Controls.Add(BT_CoreColors, 1, 1);
            TLP_Main.Controls.Add(BT_SingleColor, 2, 1);
            TLP_Main.Location = new Point(12, 42);
            TLP_Main.Name = "TLP_Main";
            TLP_Main.RowCount = 4;
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TLP_Main.Size = new Size(776, 396);
            TLP_Main.TabIndex = 0;
            // 
            // LB_ThemePreviewsPrompt
            // 
            LB_ThemePreviewsPrompt.Anchor = AnchorStyles.Left;
            LB_ThemePreviewsPrompt.AutoSize = true;
            LB_ThemePreviewsPrompt.ForeColorRole = M2TLabelTextColorRoleSelection.Primary;
            LB_ThemePreviewsPrompt.Location = new Point(3, 2);
            LB_ThemePreviewsPrompt.Name = "LB_ThemePreviewsPrompt";
            LB_ThemePreviewsPrompt.Size = new Size(93, 15);
            LB_ThemePreviewsPrompt.TabIndex = 0;
            LB_ThemePreviewsPrompt.Text = "Theme Previews";
            // 
            // LB_ColorExperiments
            // 
            LB_ColorExperiments.Anchor = AnchorStyles.Left;
            LB_ColorExperiments.AutoSize = true;
            LB_ColorExperiments.ForeColorRole = M2TLabelTextColorRoleSelection.Primary;
            LB_ColorExperiments.Location = new Point(3, 200);
            LB_ColorExperiments.Name = "LB_ColorExperiments";
            LB_ColorExperiments.Size = new Size(103, 15);
            LB_ColorExperiments.TabIndex = 1;
            LB_ColorExperiments.Text = "Color Experiments";
            // 
            // BT_ThemeBuilderJson
            // 
            BT_ThemeBuilderJson.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_ThemeBuilderJson.ColorRole = M2TButtonColorRoleSelection.PrimaryContainer;
            BT_ThemeBuilderJson.FlatStyle = FlatStyle.Flat;
            BT_ThemeBuilderJson.Location = new Point(3, 23);
            BT_ThemeBuilderJson.Name = "BT_ThemeBuilderJson";
            BT_ThemeBuilderJson.Size = new Size(252, 172);
            BT_ThemeBuilderJson.TabIndex = 2;
            BT_ThemeBuilderJson.Text = "Theme Builder Json";
            BT_ThemeBuilderJson.UseVisualStyleBackColor = false;
            BT_ThemeBuilderJson.Click += BT_ThemeBuilderJson_Click;
            // 
            // BT_HctConverter
            // 
            BT_HctConverter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_HctConverter.ColorRole = M2TButtonColorRoleSelection.SurfaceContainer;
            BT_HctConverter.FlatStyle = FlatStyle.Flat;
            BT_HctConverter.Location = new Point(3, 221);
            BT_HctConverter.Name = "BT_HctConverter";
            BT_HctConverter.Size = new Size(252, 172);
            BT_HctConverter.TabIndex = 3;
            BT_HctConverter.Text = "HCT Color Conversion";
            BT_HctConverter.UseVisualStyleBackColor = false;
            BT_HctConverter.Click += BT_HctConverter_Click;
            // 
            // BT_PaletteGeneration
            // 
            BT_PaletteGeneration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_PaletteGeneration.ColorRole = M2TButtonColorRoleSelection.SurfaceContainer;
            BT_PaletteGeneration.FlatStyle = FlatStyle.Flat;
            BT_PaletteGeneration.Location = new Point(261, 221);
            BT_PaletteGeneration.Name = "BT_PaletteGeneration";
            BT_PaletteGeneration.Size = new Size(252, 172);
            BT_PaletteGeneration.TabIndex = 4;
            BT_PaletteGeneration.Text = "Palette Generation";
            BT_PaletteGeneration.UseVisualStyleBackColor = false;
            BT_PaletteGeneration.Click += BT_PaletteGeneration_Click;
            // 
            // BT_CoreColors
            // 
            BT_CoreColors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_CoreColors.ColorRole = M2TButtonColorRoleSelection.SecondaryContainer;
            BT_CoreColors.FlatStyle = FlatStyle.Flat;
            BT_CoreColors.Location = new Point(261, 23);
            BT_CoreColors.Name = "BT_CoreColors";
            BT_CoreColors.Size = new Size(252, 172);
            BT_CoreColors.TabIndex = 5;
            BT_CoreColors.Text = "Core Colors";
            BT_CoreColors.UseVisualStyleBackColor = false;
            BT_CoreColors.Click += BT_CoreColors_Click;
            // 
            // BT_SingleColor
            // 
            BT_SingleColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_SingleColor.ColorRole = M2TButtonColorRoleSelection.TertiaryContainer;
            BT_SingleColor.FlatStyle = FlatStyle.Flat;
            BT_SingleColor.Location = new Point(519, 23);
            BT_SingleColor.Name = "BT_SingleColor";
            BT_SingleColor.Size = new Size(254, 172);
            BT_SingleColor.TabIndex = 6;
            BT_SingleColor.Text = "Single Color";
            BT_SingleColor.UseVisualStyleBackColor = false;
            BT_SingleColor.Click += BT_SingleColor_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TLP_Main);
            Name = "MainMenu";
            Text = "MainMenu";
            Controls.SetChildIndex(TLP_Main, 0);
            TLP_Main.ResumeLayout(false);
            TLP_Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_Main;
        private M2TLabel LB_ThemePreviewsPrompt;
        private M2TLabel LB_ColorExperiments;
        private M2TButton BT_ThemeBuilderJson;
        private M2TButton BT_HctConverter;
        private M2TButton BT_PaletteGeneration;
        private M2TButton BT_CoreColors;
        private M2TButton BT_SingleColor;
    }
}