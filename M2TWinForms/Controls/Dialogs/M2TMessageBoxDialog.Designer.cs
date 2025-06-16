namespace M2TWinForms
{
    partial class M2TMessageBoxDialog
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
            LB_Message = new Label();
            SuspendLayout();
            // 
            // LB_Message
            // 
            LB_Message.AutoSize = true;
            LB_Message.Location = new Point(73, 65);
            LB_Message.Name = "LB_Message";
            LB_Message.Size = new Size(38, 15);
            LB_Message.TabIndex = 12;
            LB_Message.Text = "label1";
            // 
            // M2TMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LB_Message);
            Name = "M2TMessageBox";
            Text = "M2TMessageBox";
            Controls.SetChildIndex(LB_Message, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LB_Message;
    }
}