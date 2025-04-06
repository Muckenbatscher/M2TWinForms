namespace M2TWinForms.ThemeDesigner.ThemeSourcesVisualisation
{
    partial class CoreColorsPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoreColorsPreview));
            TLP_Main = new TableLayoutPanel();
            BT_NeutralVariant = new Button();
            BT_Tertiary = new Button();
            BT_Neutral = new Button();
            BT_Secondary = new Button();
            BT_Error = new Button();
            LB_PrimaryPrompt = new Label();
            LB_SecondaryPrompt = new Label();
            LB_TertiaryPrompt = new Label();
            SL_ThemeMode = new M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection.ThemeModeSelection();
            SL_ContrastLevel = new M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection.ContrastLevelSelection();
            BT_Apply = new Button();
            LB_NeutralVariantPrompt = new Label();
            LB_NeutralPrompt = new Label();
            LB_ErrorPrompt = new Label();
            BT_Primary = new Button();
            CSV_Theme = new M2TWinForms.ThemeDesigner.ThemeVisualisation.ColorSchemeVisualisation();
            CB_NormalizeChroma = new CheckBox();
            TLP_Main.SuspendLayout();
            SuspendLayout();
            // 
            // TLP_Main
            // 
            TLP_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.ColumnCount = 4;
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            TLP_Main.Controls.Add(BT_NeutralVariant, 3, 2);
            TLP_Main.Controls.Add(BT_Tertiary, 1, 2);
            TLP_Main.Controls.Add(BT_Neutral, 3, 1);
            TLP_Main.Controls.Add(BT_Secondary, 1, 1);
            TLP_Main.Controls.Add(BT_Error, 3, 0);
            TLP_Main.Controls.Add(LB_PrimaryPrompt, 0, 0);
            TLP_Main.Controls.Add(LB_SecondaryPrompt, 0, 1);
            TLP_Main.Controls.Add(LB_TertiaryPrompt, 0, 2);
            TLP_Main.Controls.Add(SL_ThemeMode, 0, 3);
            TLP_Main.Controls.Add(SL_ContrastLevel, 0, 4);
            TLP_Main.Controls.Add(BT_Apply, 3, 4);
            TLP_Main.Controls.Add(LB_NeutralVariantPrompt, 2, 2);
            TLP_Main.Controls.Add(LB_NeutralPrompt, 2, 1);
            TLP_Main.Controls.Add(LB_ErrorPrompt, 2, 0);
            TLP_Main.Controls.Add(BT_Primary, 1, 0);
            TLP_Main.Controls.Add(CSV_Theme, 0, 5);
            TLP_Main.Controls.Add(CB_NormalizeChroma, 3, 3);
            TLP_Main.Location = new Point(12, 12);
            TLP_Main.Name = "TLP_Main";
            TLP_Main.RowCount = 6;
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_Main.Size = new Size(865, 609);
            TLP_Main.TabIndex = 0;
            // 
            // BT_NeutralVariant
            // 
            BT_NeutralVariant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_NeutralVariant.Location = new Point(651, 83);
            BT_NeutralVariant.Name = "BT_NeutralVariant";
            BT_NeutralVariant.Size = new Size(211, 34);
            BT_NeutralVariant.TabIndex = 6;
            BT_NeutralVariant.UseVisualStyleBackColor = true;
            // 
            // BT_Tertiary
            // 
            BT_Tertiary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Tertiary.Location = new Point(219, 83);
            BT_Tertiary.Name = "BT_Tertiary";
            BT_Tertiary.Size = new Size(210, 34);
            BT_Tertiary.TabIndex = 3;
            BT_Tertiary.UseVisualStyleBackColor = true;
            // 
            // BT_Neutral
            // 
            BT_Neutral.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Neutral.Location = new Point(651, 43);
            BT_Neutral.Name = "BT_Neutral";
            BT_Neutral.Size = new Size(211, 34);
            BT_Neutral.TabIndex = 5;
            BT_Neutral.UseVisualStyleBackColor = true;
            // 
            // BT_Secondary
            // 
            BT_Secondary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Secondary.Location = new Point(219, 43);
            BT_Secondary.Name = "BT_Secondary";
            BT_Secondary.Size = new Size(210, 34);
            BT_Secondary.TabIndex = 2;
            BT_Secondary.UseVisualStyleBackColor = true;
            // 
            // BT_Error
            // 
            BT_Error.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Error.Location = new Point(651, 3);
            BT_Error.Name = "BT_Error";
            BT_Error.Size = new Size(211, 34);
            BT_Error.TabIndex = 4;
            BT_Error.UseVisualStyleBackColor = true;
            // 
            // LB_PrimaryPrompt
            // 
            LB_PrimaryPrompt.Anchor = AnchorStyles.Left;
            LB_PrimaryPrompt.AutoSize = true;
            LB_PrimaryPrompt.Location = new Point(3, 12);
            LB_PrimaryPrompt.Name = "LB_PrimaryPrompt";
            LB_PrimaryPrompt.Size = new Size(51, 15);
            LB_PrimaryPrompt.TabIndex = 2;
            LB_PrimaryPrompt.Text = "Primary:";
            // 
            // LB_SecondaryPrompt
            // 
            LB_SecondaryPrompt.Anchor = AnchorStyles.Left;
            LB_SecondaryPrompt.AutoSize = true;
            LB_SecondaryPrompt.Location = new Point(3, 52);
            LB_SecondaryPrompt.Name = "LB_SecondaryPrompt";
            LB_SecondaryPrompt.Size = new Size(65, 15);
            LB_SecondaryPrompt.TabIndex = 3;
            LB_SecondaryPrompt.Text = "Secondary:";
            // 
            // LB_TertiaryPrompt
            // 
            LB_TertiaryPrompt.Anchor = AnchorStyles.Left;
            LB_TertiaryPrompt.AutoSize = true;
            LB_TertiaryPrompt.Location = new Point(3, 92);
            LB_TertiaryPrompt.Name = "LB_TertiaryPrompt";
            LB_TertiaryPrompt.Size = new Size(49, 15);
            LB_TertiaryPrompt.TabIndex = 4;
            LB_TertiaryPrompt.Text = "Tertiary:";
            // 
            // SL_ThemeMode
            // 
            SL_ThemeMode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.SetColumnSpan(SL_ThemeMode, 2);
            SL_ThemeMode.Location = new Point(3, 123);
            SL_ThemeMode.Name = "SL_ThemeMode";
            SL_ThemeMode.SelectionPrompt = "Theme Mode";
            SL_ThemeMode.Size = new Size(426, 34);
            SL_ThemeMode.TabIndex = 7;
            // 
            // SL_ContrastLevel
            // 
            SL_ContrastLevel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.SetColumnSpan(SL_ContrastLevel, 2);
            SL_ContrastLevel.Location = new Point(3, 163);
            SL_ContrastLevel.Name = "SL_ContrastLevel";
            SL_ContrastLevel.SelectionPrompt = "Contrast Level";
            SL_ContrastLevel.Size = new Size(426, 34);
            SL_ContrastLevel.TabIndex = 8;
            // 
            // BT_Apply
            // 
            BT_Apply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Apply.Location = new Point(651, 163);
            BT_Apply.Name = "BT_Apply";
            BT_Apply.Size = new Size(211, 34);
            BT_Apply.TabIndex = 9;
            BT_Apply.Text = "Apply";
            BT_Apply.UseVisualStyleBackColor = true;
            BT_Apply.Click += BT_Apply_Click;
            // 
            // LB_NeutralVariantPrompt
            // 
            LB_NeutralVariantPrompt.Anchor = AnchorStyles.Left;
            LB_NeutralVariantPrompt.AutoSize = true;
            LB_NeutralVariantPrompt.Location = new Point(435, 92);
            LB_NeutralVariantPrompt.Name = "LB_NeutralVariantPrompt";
            LB_NeutralVariantPrompt.Size = new Size(88, 15);
            LB_NeutralVariantPrompt.TabIndex = 6;
            LB_NeutralVariantPrompt.Text = "Neutral Variant:";
            // 
            // LB_NeutralPrompt
            // 
            LB_NeutralPrompt.Anchor = AnchorStyles.Left;
            LB_NeutralPrompt.AutoSize = true;
            LB_NeutralPrompt.Location = new Point(435, 52);
            LB_NeutralPrompt.Name = "LB_NeutralPrompt";
            LB_NeutralPrompt.Size = new Size(49, 15);
            LB_NeutralPrompt.TabIndex = 5;
            LB_NeutralPrompt.Text = "Neutral:";
            // 
            // LB_ErrorPrompt
            // 
            LB_ErrorPrompt.Anchor = AnchorStyles.Left;
            LB_ErrorPrompt.AutoSize = true;
            LB_ErrorPrompt.Location = new Point(435, 12);
            LB_ErrorPrompt.Name = "LB_ErrorPrompt";
            LB_ErrorPrompt.Size = new Size(35, 15);
            LB_ErrorPrompt.TabIndex = 8;
            LB_ErrorPrompt.Text = "Error:";
            // 
            // BT_Primary
            // 
            BT_Primary.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Primary.Location = new Point(219, 3);
            BT_Primary.Name = "BT_Primary";
            BT_Primary.Size = new Size(210, 34);
            BT_Primary.TabIndex = 1;
            BT_Primary.UseVisualStyleBackColor = true;
            // 
            // CSV_Theme
            // 
            TLP_Main.SetColumnSpan(CSV_Theme, 4);
            CSV_Theme.Location = new Point(3, 203);
            CSV_Theme.Name = "CSV_Theme";
            CSV_Theme.Size = new Size(858, 403);
            CSV_Theme.TabIndex = 10;
            // 
            // CB_NormalizeChroma
            // 
            CB_NormalizeChroma.Anchor = AnchorStyles.Left;
            CB_NormalizeChroma.AutoSize = true;
            CB_NormalizeChroma.Location = new Point(651, 130);
            CB_NormalizeChroma.Name = "CB_NormalizeChroma";
            CB_NormalizeChroma.Size = new Size(126, 19);
            CB_NormalizeChroma.TabIndex = 11;
            CB_NormalizeChroma.Text = "Normalize Chroma";
            CB_NormalizeChroma.UseVisualStyleBackColor = true;
            // 
            // CoreColorsPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 633);
            Controls.Add(TLP_Main);
            Name = "CoreColorsPreview";
            Text = "CoreColorsPreview";
            TLP_Main.ResumeLayout(false);
            TLP_Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_Main;
        private ThemeVisualisation.Selection.ThemeModeSelection SL_ThemeMode;
        private ThemeVisualisation.Selection.ContrastLevelSelection SL_ContrastLevel;
        private Button BT_NeutralVariant;
        private Button BT_Tertiary;
        private Button BT_Neutral;
        private Button BT_Secondary;
        private Button BT_Error;
        private Label LB_PrimaryPrompt;
        private Label LB_SecondaryPrompt;
        private Label LB_TertiaryPrompt;
        private Button BT_Apply;
        private Label LB_NeutralVariantPrompt;
        private Label LB_NeutralPrompt;
        private Label LB_ErrorPrompt;
        private Button BT_Primary;
        private ThemeVisualisation.ColorSchemeVisualisation CSV_Theme;
        private CheckBox CB_NormalizeChroma;
    }
}