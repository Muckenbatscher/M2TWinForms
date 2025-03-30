namespace M2TWinForms.ThemeDesigner.ThemeSourcesVisualisation
{
    partial class SingleColorPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleColorPreview));
            TLP_Main = new TableLayoutPanel();
            LB_RedPrompt = new Label();
            NUD_Blue = new NumericUpDown();
            NUD_Green = new NumericUpDown();
            LB_GreenPrompt = new Label();
            LB_BluePrompt = new Label();
            NUD_Red = new NumericUpDown();
            SL_ThemeMode = new M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection.ThemeModeSelection();
            SL_ContrastLevel = new M2TWinForms.ThemeDesigner.ThemeVisualisation.Selection.ContrastLevelSelection();
            BT_Apply = new Button();
            TB_ColorHtml = new TextBox();
            PN_PreviewColorSelection = new Panel();
            CSV_LoadedTheme = new M2TWinForms.ThemeDesigner.ThemeVisualisation.ColorSchemeVisualisation();
            TLP_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Blue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Red).BeginInit();
            SuspendLayout();
            // 
            // TLP_Main
            // 
            TLP_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.ColumnCount = 5;
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 40F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TLP_Main.Controls.Add(LB_RedPrompt, 0, 1);
            TLP_Main.Controls.Add(NUD_Blue, 1, 3);
            TLP_Main.Controls.Add(NUD_Green, 1, 2);
            TLP_Main.Controls.Add(LB_GreenPrompt, 0, 2);
            TLP_Main.Controls.Add(LB_BluePrompt, 0, 3);
            TLP_Main.Controls.Add(NUD_Red, 1, 1);
            TLP_Main.Controls.Add(SL_ThemeMode, 3, 1);
            TLP_Main.Controls.Add(SL_ContrastLevel, 3, 2);
            TLP_Main.Controls.Add(BT_Apply, 4, 3);
            TLP_Main.Controls.Add(TB_ColorHtml, 1, 0);
            TLP_Main.Controls.Add(PN_PreviewColorSelection, 2, 0);
            TLP_Main.Controls.Add(CSV_LoadedTheme, 0, 4);
            TLP_Main.Location = new Point(14, 10);
            TLP_Main.Name = "TLP_Main";
            TLP_Main.RowCount = 5;
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_Main.Size = new Size(774, 550);
            TLP_Main.TabIndex = 0;
            // 
            // LB_RedPrompt
            // 
            LB_RedPrompt.Anchor = AnchorStyles.Left;
            LB_RedPrompt.AutoSize = true;
            LB_RedPrompt.Location = new Point(3, 52);
            LB_RedPrompt.Name = "LB_RedPrompt";
            LB_RedPrompt.Size = new Size(27, 15);
            LB_RedPrompt.TabIndex = 11;
            LB_RedPrompt.Text = "Red";
            // 
            // NUD_Blue
            // 
            NUD_Blue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Blue.Location = new Point(83, 128);
            NUD_Blue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_Blue.Name = "NUD_Blue";
            NUD_Blue.Size = new Size(271, 23);
            NUD_Blue.TabIndex = 16;
            // 
            // NUD_Green
            // 
            NUD_Green.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Green.Location = new Point(83, 88);
            NUD_Green.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_Green.Name = "NUD_Green";
            NUD_Green.Size = new Size(271, 23);
            NUD_Green.TabIndex = 15;
            // 
            // LB_GreenPrompt
            // 
            LB_GreenPrompt.Anchor = AnchorStyles.Left;
            LB_GreenPrompt.AutoSize = true;
            LB_GreenPrompt.Location = new Point(3, 92);
            LB_GreenPrompt.Name = "LB_GreenPrompt";
            LB_GreenPrompt.Size = new Size(38, 15);
            LB_GreenPrompt.TabIndex = 12;
            LB_GreenPrompt.Text = "Green";
            // 
            // LB_BluePrompt
            // 
            LB_BluePrompt.Anchor = AnchorStyles.Left;
            LB_BluePrompt.AutoSize = true;
            LB_BluePrompt.Location = new Point(3, 132);
            LB_BluePrompt.Name = "LB_BluePrompt";
            LB_BluePrompt.Size = new Size(30, 15);
            LB_BluePrompt.TabIndex = 13;
            LB_BluePrompt.Text = "Blue";
            // 
            // NUD_Red
            // 
            NUD_Red.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Red.Location = new Point(83, 48);
            NUD_Red.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_Red.Name = "NUD_Red";
            NUD_Red.Size = new Size(271, 23);
            NUD_Red.TabIndex = 14;
            // 
            // SL_ThemeMode
            // 
            SL_ThemeMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SL_ThemeMode.Location = new Point(400, 43);
            SL_ThemeMode.Name = "SL_ThemeMode";
            SL_ThemeMode.SelectionPrompt = "Theme Mode";
            SL_ThemeMode.Size = new Size(271, 34);
            SL_ThemeMode.TabIndex = 17;
            // 
            // SL_ContrastLevel
            // 
            SL_ContrastLevel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SL_ContrastLevel.Location = new Point(400, 83);
            SL_ContrastLevel.Name = "SL_ContrastLevel";
            SL_ContrastLevel.SelectionPrompt = "Contrast Level";
            SL_ContrastLevel.Size = new Size(271, 34);
            SL_ContrastLevel.TabIndex = 18;
            // 
            // BT_Apply
            // 
            BT_Apply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Apply.Location = new Point(677, 123);
            BT_Apply.Name = "BT_Apply";
            BT_Apply.Size = new Size(94, 34);
            BT_Apply.TabIndex = 19;
            BT_Apply.Text = "Apply";
            BT_Apply.UseVisualStyleBackColor = true;
            BT_Apply.Click += BT_Apply_Click;
            // 
            // TB_ColorHtml
            // 
            TB_ColorHtml.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_ColorHtml.Location = new Point(83, 8);
            TB_ColorHtml.Name = "TB_ColorHtml";
            TB_ColorHtml.Size = new Size(271, 23);
            TB_ColorHtml.TabIndex = 20;
            TB_ColorHtml.KeyPress += TB_ColorHtml_KeyPress;
            // 
            // PN_PreviewColorSelection
            // 
            PN_PreviewColorSelection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PN_PreviewColorSelection.Location = new Point(360, 3);
            PN_PreviewColorSelection.Name = "PN_PreviewColorSelection";
            TLP_Main.SetRowSpan(PN_PreviewColorSelection, 4);
            PN_PreviewColorSelection.Size = new Size(34, 154);
            PN_PreviewColorSelection.TabIndex = 21;
            // 
            // CSV_LoadedTheme
            // 
            CSV_LoadedTheme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.SetColumnSpan(CSV_LoadedTheme, 5);
            CSV_LoadedTheme.Location = new Point(3, 163);
            CSV_LoadedTheme.Name = "CSV_LoadedTheme";
            CSV_LoadedTheme.Size = new Size(768, 384);
            CSV_LoadedTheme.TabIndex = 22;
            // 
            // SingleColorPreview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 572);
            Controls.Add(TLP_Main);
            Name = "SingleColorPreview";
            Text = "SingleColorPreview";
            TLP_Main.ResumeLayout(false);
            TLP_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Blue).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Green).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Red).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_Main;
        private Label LB_RedPrompt;
        private NumericUpDown NUD_Blue;
        private NumericUpDown NUD_Green;
        private Label LB_GreenPrompt;
        private Label LB_BluePrompt;
        private NumericUpDown NUD_Red;
        private ThemeVisualisation.Selection.ThemeModeSelection SL_ThemeMode;
        private ThemeVisualisation.Selection.ContrastLevelSelection SL_ContrastLevel;
        private Button BT_Apply;
        private TextBox TB_ColorHtml;
        private Panel PN_PreviewColorSelection;
        private ThemeVisualisation.ColorSchemeVisualisation CSV_LoadedTheme;
    }
}