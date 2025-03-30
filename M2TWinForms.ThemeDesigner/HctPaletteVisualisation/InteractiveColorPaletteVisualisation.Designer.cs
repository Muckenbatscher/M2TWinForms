namespace M2TWinForms.ThemeDesigner.HctPaletteVisualisation
{
    partial class InteractiveColorPaletteVisualisation
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
            NUD_Tone = new NumericUpDown();
            NUD_Chroma = new NumericUpDown();
            NUD_Hue = new NumericUpDown();
            LB_TonePrompt = new Label();
            LB_ChromaPrompt = new Label();
            LB_HuePrompt = new Label();
            BT_Generate = new Button();
            PN_ChosenColor = new Panel();
            CPV_Palette = new ColorPaletteVisualisation();
            TLP_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Tone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Chroma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Hue).BeginInit();
            SuspendLayout();
            // 
            // TLP_Main
            // 
            TLP_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.ColumnCount = 4;
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 80F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100F));
            TLP_Main.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_Main.Controls.Add(LB_ChromaPrompt, 0, 1);
            TLP_Main.Controls.Add(LB_HuePrompt, 0, 0);
            TLP_Main.Controls.Add(NUD_Tone, 1, 2);
            TLP_Main.Controls.Add(NUD_Chroma, 1, 1);
            TLP_Main.Controls.Add(NUD_Hue, 1, 0);
            TLP_Main.Controls.Add(LB_TonePrompt, 0, 2);
            TLP_Main.Controls.Add(BT_Generate, 2, 0);
            TLP_Main.Controls.Add(PN_ChosenColor, 3, 0);
            TLP_Main.Controls.Add(CPV_Palette, 0, 3);
            TLP_Main.Location = new Point(12, 12);
            TLP_Main.Name = "TLP_Main";
            TLP_Main.RowCount = 4;
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_Main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLP_Main.Size = new Size(1390, 419);
            TLP_Main.TabIndex = 0;
            // 
            // NUD_Tone
            // 
            NUD_Tone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Tone.Location = new Point(83, 88);
            NUD_Tone.Name = "NUD_Tone";
            NUD_Tone.Size = new Size(599, 23);
            NUD_Tone.TabIndex = 19;
            // 
            // NUD_Chroma
            // 
            NUD_Chroma.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Chroma.Location = new Point(83, 48);
            NUD_Chroma.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            NUD_Chroma.Name = "NUD_Chroma";
            NUD_Chroma.Size = new Size(599, 23);
            NUD_Chroma.TabIndex = 18;
            // 
            // NUD_Hue
            // 
            NUD_Hue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Hue.Location = new Point(83, 8);
            NUD_Hue.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            NUD_Hue.Name = "NUD_Hue";
            NUD_Hue.Size = new Size(599, 23);
            NUD_Hue.TabIndex = 17;
            // 
            // LB_TonePrompt
            // 
            LB_TonePrompt.Anchor = AnchorStyles.Left;
            LB_TonePrompt.AutoSize = true;
            LB_TonePrompt.Location = new Point(3, 92);
            LB_TonePrompt.Name = "LB_TonePrompt";
            LB_TonePrompt.Size = new Size(33, 15);
            LB_TonePrompt.TabIndex = 16;
            LB_TonePrompt.Text = "Tone";
            // 
            // LB_ChromaPrompt
            // 
            LB_ChromaPrompt.Anchor = AnchorStyles.Left;
            LB_ChromaPrompt.AutoSize = true;
            LB_ChromaPrompt.Location = new Point(3, 52);
            LB_ChromaPrompt.Name = "LB_ChromaPrompt";
            LB_ChromaPrompt.Size = new Size(50, 15);
            LB_ChromaPrompt.TabIndex = 15;
            LB_ChromaPrompt.Text = "Chroma";
            // 
            // LB_HuePrompt
            // 
            LB_HuePrompt.Anchor = AnchorStyles.Left;
            LB_HuePrompt.AutoSize = true;
            LB_HuePrompt.Location = new Point(3, 12);
            LB_HuePrompt.Name = "LB_HuePrompt";
            LB_HuePrompt.Size = new Size(29, 15);
            LB_HuePrompt.TabIndex = 14;
            LB_HuePrompt.Text = "Hue";
            // 
            // BT_Generate
            // 
            BT_Generate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_Generate.Location = new Point(688, 3);
            BT_Generate.Name = "BT_Generate";
            TLP_Main.SetRowSpan(BT_Generate, 3);
            BT_Generate.Size = new Size(94, 114);
            BT_Generate.TabIndex = 20;
            BT_Generate.Text = "Generate";
            BT_Generate.UseVisualStyleBackColor = true;
            BT_Generate.Click += BT_Generate_Click;
            // 
            // PN_ChosenColor
            // 
            PN_ChosenColor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PN_ChosenColor.Location = new Point(788, 3);
            PN_ChosenColor.Name = "PN_ChosenColor";
            TLP_Main.SetRowSpan(PN_ChosenColor, 3);
            PN_ChosenColor.Size = new Size(599, 114);
            PN_ChosenColor.TabIndex = 21;
            // 
            // CPV_Palette
            // 
            CPV_Palette.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_Main.SetColumnSpan(CPV_Palette, 4);
            CPV_Palette.Location = new Point(3, 123);
            CPV_Palette.Name = "CPV_Palette";
            CPV_Palette.Size = new Size(1384, 293);
            CPV_Palette.TabIndex = 22;
            // 
            // InteractiveColorPaletteVisualisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 443);
            Controls.Add(TLP_Main);
            Name = "InteractiveColorPaletteVisualisation";
            Text = "InteractiveColorPaletteVisualisation";
            TLP_Main.ResumeLayout(false);
            TLP_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Tone).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Chroma).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Hue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_Main;
        private Label LB_ChromaPrompt;
        private Label LB_HuePrompt;
        private NumericUpDown NUD_Tone;
        private NumericUpDown NUD_Chroma;
        private NumericUpDown NUD_Hue;
        private Label LB_TonePrompt;
        private Button BT_Generate;
        private Panel PN_ChosenColor;
        private ColorPaletteVisualisation CPV_Palette;
    }
}