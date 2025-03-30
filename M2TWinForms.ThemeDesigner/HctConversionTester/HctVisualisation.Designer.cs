namespace M2TWinForms.ThemeDesigner.HctConversionTester
{
    partial class HctVisualisation
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
            TLP_MAIN = new TableLayoutPanel();
            TB_RgbColorHtml = new TextBox();
            NUD_Tone = new NumericUpDown();
            NUD_Chroma = new NumericUpDown();
            NUD_Hue = new NumericUpDown();
            LB_TonePrompt = new Label();
            LB_ChromaPrompt = new Label();
            LB_HuePrompt = new Label();
            LB_RedPrompt = new Label();
            LB_HctPrompt = new Label();
            LB_RgbPrompt = new Label();
            LB_GreenPrompt = new Label();
            LB_BluePrompt = new Label();
            NUD_Red = new NumericUpDown();
            NUD_Green = new NumericUpDown();
            NUD_Blue = new NumericUpDown();
            BT_CalculateRgb = new Button();
            BT_CalculateHct = new Button();
            PN_VisualisationRgb = new Panel();
            BT_PaletteGeneration = new Button();
            TLP_MAIN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Tone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Chroma).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Hue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Red).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Green).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Blue).BeginInit();
            SuspendLayout();
            // 
            // TLP_MAIN
            // 
            TLP_MAIN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_MAIN.ColumnCount = 4;
            TLP_MAIN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            TLP_MAIN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_MAIN.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            TLP_MAIN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TLP_MAIN.Controls.Add(TB_RgbColorHtml, 1, 0);
            TLP_MAIN.Controls.Add(NUD_Tone, 3, 3);
            TLP_MAIN.Controls.Add(NUD_Chroma, 3, 2);
            TLP_MAIN.Controls.Add(NUD_Hue, 3, 1);
            TLP_MAIN.Controls.Add(LB_TonePrompt, 2, 3);
            TLP_MAIN.Controls.Add(LB_ChromaPrompt, 2, 2);
            TLP_MAIN.Controls.Add(LB_HuePrompt, 2, 1);
            TLP_MAIN.Controls.Add(LB_RedPrompt, 0, 1);
            TLP_MAIN.Controls.Add(LB_HctPrompt, 2, 0);
            TLP_MAIN.Controls.Add(LB_RgbPrompt, 0, 0);
            TLP_MAIN.Controls.Add(LB_GreenPrompt, 0, 2);
            TLP_MAIN.Controls.Add(LB_BluePrompt, 0, 3);
            TLP_MAIN.Controls.Add(NUD_Red, 1, 1);
            TLP_MAIN.Controls.Add(NUD_Green, 1, 2);
            TLP_MAIN.Controls.Add(NUD_Blue, 1, 3);
            TLP_MAIN.Controls.Add(BT_CalculateRgb, 3, 4);
            TLP_MAIN.Controls.Add(BT_CalculateHct, 1, 4);
            TLP_MAIN.Controls.Add(PN_VisualisationRgb, 0, 5);
            TLP_MAIN.Controls.Add(BT_PaletteGeneration, 3, 6);
            TLP_MAIN.Location = new Point(19, 12);
            TLP_MAIN.Name = "TLP_MAIN";
            TLP_MAIN.RowCount = 7;
            TLP_MAIN.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_MAIN.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            TLP_MAIN.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            TLP_MAIN.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            TLP_MAIN.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_MAIN.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            TLP_MAIN.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            TLP_MAIN.Size = new Size(769, 426);
            TLP_MAIN.TabIndex = 0;
            // 
            // TB_RgbColorHtml
            // 
            TB_RgbColorHtml.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TB_RgbColorHtml.Location = new Point(153, 8);
            TB_RgbColorHtml.Name = "TB_RgbColorHtml";
            TB_RgbColorHtml.Size = new Size(228, 23);
            TB_RgbColorHtml.TabIndex = 1;
            TB_RgbColorHtml.KeyPress += TB_RgbColorHtml_KeyPress;
            // 
            // NUD_Tone
            // 
            NUD_Tone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Tone.Location = new Point(537, 141);
            NUD_Tone.Name = "NUD_Tone";
            NUD_Tone.Size = new Size(229, 23);
            NUD_Tone.TabIndex = 13;
            // 
            // NUD_Chroma
            // 
            NUD_Chroma.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Chroma.Location = new Point(537, 96);
            NUD_Chroma.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            NUD_Chroma.Name = "NUD_Chroma";
            NUD_Chroma.Size = new Size(229, 23);
            NUD_Chroma.TabIndex = 12;
            // 
            // NUD_Hue
            // 
            NUD_Hue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Hue.Location = new Point(537, 51);
            NUD_Hue.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            NUD_Hue.Name = "NUD_Hue";
            NUD_Hue.Size = new Size(229, 23);
            NUD_Hue.TabIndex = 11;
            // 
            // LB_TonePrompt
            // 
            LB_TonePrompt.Anchor = AnchorStyles.Left;
            LB_TonePrompt.AutoSize = true;
            LB_TonePrompt.Location = new Point(387, 145);
            LB_TonePrompt.Name = "LB_TonePrompt";
            LB_TonePrompt.Size = new Size(33, 15);
            LB_TonePrompt.TabIndex = 7;
            LB_TonePrompt.Text = "Tone";
            // 
            // LB_ChromaPrompt
            // 
            LB_ChromaPrompt.Anchor = AnchorStyles.Left;
            LB_ChromaPrompt.AutoSize = true;
            LB_ChromaPrompt.Location = new Point(387, 100);
            LB_ChromaPrompt.Name = "LB_ChromaPrompt";
            LB_ChromaPrompt.Size = new Size(50, 15);
            LB_ChromaPrompt.TabIndex = 6;
            LB_ChromaPrompt.Text = "Chroma";
            // 
            // LB_HuePrompt
            // 
            LB_HuePrompt.Anchor = AnchorStyles.Left;
            LB_HuePrompt.AutoSize = true;
            LB_HuePrompt.Location = new Point(387, 55);
            LB_HuePrompt.Name = "LB_HuePrompt";
            LB_HuePrompt.Size = new Size(29, 15);
            LB_HuePrompt.TabIndex = 5;
            LB_HuePrompt.Text = "Hue";
            // 
            // LB_RedPrompt
            // 
            LB_RedPrompt.Anchor = AnchorStyles.Left;
            LB_RedPrompt.AutoSize = true;
            LB_RedPrompt.Location = new Point(3, 55);
            LB_RedPrompt.Name = "LB_RedPrompt";
            LB_RedPrompt.Size = new Size(27, 15);
            LB_RedPrompt.TabIndex = 2;
            LB_RedPrompt.Text = "Red";
            // 
            // LB_HctPrompt
            // 
            LB_HctPrompt.Anchor = AnchorStyles.Left;
            LB_HctPrompt.AutoSize = true;
            TLP_MAIN.SetColumnSpan(LB_HctPrompt, 2);
            LB_HctPrompt.Location = new Point(387, 12);
            LB_HctPrompt.Name = "LB_HctPrompt";
            LB_HctPrompt.Size = new Size(63, 15);
            LB_HctPrompt.TabIndex = 1;
            LB_HctPrompt.Text = "HCT Color";
            // 
            // LB_RgbPrompt
            // 
            LB_RgbPrompt.Anchor = AnchorStyles.Left;
            LB_RgbPrompt.AutoSize = true;
            LB_RgbPrompt.Location = new Point(3, 12);
            LB_RgbPrompt.Name = "LB_RgbPrompt";
            LB_RgbPrompt.Size = new Size(61, 15);
            LB_RgbPrompt.TabIndex = 0;
            LB_RgbPrompt.Text = "RGB Color";
            // 
            // LB_GreenPrompt
            // 
            LB_GreenPrompt.Anchor = AnchorStyles.Left;
            LB_GreenPrompt.AutoSize = true;
            LB_GreenPrompt.Location = new Point(3, 100);
            LB_GreenPrompt.Name = "LB_GreenPrompt";
            LB_GreenPrompt.Size = new Size(38, 15);
            LB_GreenPrompt.TabIndex = 3;
            LB_GreenPrompt.Text = "Green";
            // 
            // LB_BluePrompt
            // 
            LB_BluePrompt.Anchor = AnchorStyles.Left;
            LB_BluePrompt.AutoSize = true;
            LB_BluePrompt.Location = new Point(3, 145);
            LB_BluePrompt.Name = "LB_BluePrompt";
            LB_BluePrompt.Size = new Size(30, 15);
            LB_BluePrompt.TabIndex = 4;
            LB_BluePrompt.Text = "Blue";
            // 
            // NUD_Red
            // 
            NUD_Red.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Red.Location = new Point(153, 51);
            NUD_Red.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_Red.Name = "NUD_Red";
            NUD_Red.Size = new Size(228, 23);
            NUD_Red.TabIndex = 8;
            // 
            // NUD_Green
            // 
            NUD_Green.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Green.Location = new Point(153, 96);
            NUD_Green.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_Green.Name = "NUD_Green";
            NUD_Green.Size = new Size(228, 23);
            NUD_Green.TabIndex = 9;
            // 
            // NUD_Blue
            // 
            NUD_Blue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NUD_Blue.Location = new Point(153, 141);
            NUD_Blue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            NUD_Blue.Name = "NUD_Blue";
            NUD_Blue.Size = new Size(228, 23);
            NUD_Blue.TabIndex = 10;
            // 
            // BT_CalculateRgb
            // 
            BT_CalculateRgb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_CalculateRgb.Location = new Point(537, 178);
            BT_CalculateRgb.Name = "BT_CalculateRgb";
            BT_CalculateRgb.Size = new Size(229, 34);
            BT_CalculateRgb.TabIndex = 14;
            BT_CalculateRgb.Text = "Calculate RGB";
            BT_CalculateRgb.UseVisualStyleBackColor = true;
            BT_CalculateRgb.Click += BT_CalculateRgb_Click;
            // 
            // BT_CalculateHct
            // 
            BT_CalculateHct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_CalculateHct.Location = new Point(153, 178);
            BT_CalculateHct.Name = "BT_CalculateHct";
            BT_CalculateHct.Size = new Size(228, 34);
            BT_CalculateHct.TabIndex = 15;
            BT_CalculateHct.Text = "Calculate HCT";
            BT_CalculateHct.UseVisualStyleBackColor = true;
            BT_CalculateHct.Click += BT_CalculateHct_Click;
            // 
            // PN_VisualisationRgb
            // 
            PN_VisualisationRgb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TLP_MAIN.SetColumnSpan(PN_VisualisationRgb, 4);
            PN_VisualisationRgb.Location = new Point(3, 218);
            PN_VisualisationRgb.Name = "PN_VisualisationRgb";
            PN_VisualisationRgb.Size = new Size(763, 162);
            PN_VisualisationRgb.TabIndex = 16;
            // 
            // BT_PaletteGeneration
            // 
            BT_PaletteGeneration.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BT_PaletteGeneration.Location = new Point(537, 386);
            BT_PaletteGeneration.Name = "BT_PaletteGeneration";
            BT_PaletteGeneration.Size = new Size(229, 37);
            BT_PaletteGeneration.TabIndex = 17;
            BT_PaletteGeneration.Text = "Generate Palettes";
            BT_PaletteGeneration.UseVisualStyleBackColor = true;
            BT_PaletteGeneration.Click += BT_PaletteGeneration_Click;
            // 
            // HctVisualisation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TLP_MAIN);
            Name = "HctVisualisation";
            Text = "HctVisualisation";
            TLP_MAIN.ResumeLayout(false);
            TLP_MAIN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NUD_Tone).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Chroma).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Hue).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Red).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Green).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUD_Blue).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel TLP_MAIN;
        private Label LB_RedPrompt;
        private Label LB_HctPrompt;
        private Label LB_RgbPrompt;
        private Label LB_GreenPrompt;
        private Label LB_BluePrompt;
        private NumericUpDown NUD_Tone;
        private NumericUpDown NUD_Chroma;
        private NumericUpDown NUD_Hue;
        private Label LB_TonePrompt;
        private Label LB_ChromaPrompt;
        private Label LB_HuePrompt;
        private NumericUpDown NUD_Red;
        private NumericUpDown NUD_Green;
        private NumericUpDown NUD_Blue;
        private Button BT_CalculateRgb;
        private Button BT_CalculateHct;
        private Panel PN_VisualisationRgb;
        private Button BT_PaletteGeneration;
        private TextBox TB_RgbColorHtml;
    }
}