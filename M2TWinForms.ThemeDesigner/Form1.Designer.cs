namespace M2TWinForms.ThemeDesigner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TLP_ThemeColors = new TableLayoutPanel();
            BT_Apply = new Button();
            CSV_LoadedTheme = new M2TWinForms.ThemeDesigner.ThemeVisualisation.ColorSchemeVisualisation();
            TB_FilePath = new TextBox();
            CB_SelectedTheme = new ComboBox();
            LB_PathPrompt = new Label();
            BT_Browse = new Button();
            TLP_ThemeColors.SuspendLayout();
            SuspendLayout();
            // 
            // TLP_ThemeColors
            // 
            TLP_ThemeColors.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_ThemeColors.ColumnCount = 5;
            TLP_ThemeColors.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TLP_ThemeColors.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TLP_ThemeColors.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TLP_ThemeColors.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 180F));
            TLP_ThemeColors.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TLP_ThemeColors.Controls.Add(BT_Apply, 4, 0);
            TLP_ThemeColors.Controls.Add(CSV_LoadedTheme, 0, 1);
            TLP_ThemeColors.Controls.Add(TB_FilePath, 1, 0);
            TLP_ThemeColors.Controls.Add(CB_SelectedTheme, 3, 0);
            TLP_ThemeColors.Controls.Add(LB_PathPrompt, 0, 0);
            TLP_ThemeColors.Controls.Add(BT_Browse, 2, 0);
            TLP_ThemeColors.Location = new Point(12, 12);
            TLP_ThemeColors.Name = "TLP_ThemeColors";
            TLP_ThemeColors.RowCount = 2;
            TLP_ThemeColors.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_ThemeColors.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_ThemeColors.Size = new Size(776, 426);
            TLP_ThemeColors.TabIndex = 0;
            // 
            // BT_Apply
            // 
            BT_Apply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Apply.Location = new Point(679, 3);
            BT_Apply.Name = "BT_Apply";
            BT_Apply.Size = new Size(94, 34);
            BT_Apply.TabIndex = 6;
            BT_Apply.Text = "Apply";
            BT_Apply.UseVisualStyleBackColor = true;
            BT_Apply.Click += BT_Apply_Click;
            // 
            // CSV_LoadedTheme
            // 
            CSV_LoadedTheme.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_ThemeColors.SetColumnSpan(CSV_LoadedTheme, 5);
            CSV_LoadedTheme.Location = new Point(3, 43);
            CSV_LoadedTheme.Name = "CSV_LoadedTheme";
            CSV_LoadedTheme.Size = new Size(770, 380);
            CSV_LoadedTheme.TabIndex = 1;
            // 
            // TB_FilePath
            // 
            TB_FilePath.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_FilePath.Location = new Point(103, 8);
            TB_FilePath.Name = "TB_FilePath";
            TB_FilePath.Size = new Size(290, 23);
            TB_FilePath.TabIndex = 2;
            // 
            // CB_SelectedTheme
            // 
            CB_SelectedTheme.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            CB_SelectedTheme.DropDownStyle = ComboBoxStyle.DropDownList;
            CB_SelectedTheme.FormattingEnabled = true;
            CB_SelectedTheme.Location = new Point(499, 8);
            CB_SelectedTheme.Name = "CB_SelectedTheme";
            CB_SelectedTheme.Size = new Size(174, 23);
            CB_SelectedTheme.TabIndex = 3;
            // 
            // LB_PathPrompt
            // 
            LB_PathPrompt.Anchor = AnchorStyles.Left;
            LB_PathPrompt.AutoSize = true;
            LB_PathPrompt.Location = new Point(3, 12);
            LB_PathPrompt.Name = "LB_PathPrompt";
            LB_PathPrompt.Size = new Size(52, 15);
            LB_PathPrompt.TabIndex = 4;
            LB_PathPrompt.Text = "Filepath:";
            // 
            // BT_Browse
            // 
            BT_Browse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Browse.Location = new Point(399, 3);
            BT_Browse.Name = "BT_Browse";
            BT_Browse.Size = new Size(94, 34);
            BT_Browse.TabIndex = 5;
            BT_Browse.Text = "Browse";
            BT_Browse.UseVisualStyleBackColor = true;
            BT_Browse.Click += BT_Browse_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TLP_ThemeColors);
            Name = "Form1";
            Text = "Form1";
            TLP_ThemeColors.ResumeLayout(false);
            TLP_ThemeColors.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_ThemeColors;
        private ThemeVisualisation.ColorSchemeVisualisation CSV_LoadedTheme;
        private TextBox TB_FilePath;
        private ComboBox CB_SelectedTheme;
        private Label LB_PathPrompt;
        private Button BT_Browse;
        private Button BT_Apply;
    }
}
