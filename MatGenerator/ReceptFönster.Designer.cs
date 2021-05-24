
namespace MatGenerator
{
    partial class ReceptFönster
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
            this.labelNamn = new System.Windows.Forms.Label();
            this.textBoxSteg = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(52, 32);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(35, 13);
            this.labelNamn.TabIndex = 0;
            this.labelNamn.Text = "label1";
            // 
            // textBoxSteg
            // 
            this.textBoxSteg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSteg.Location = new System.Drawing.Point(263, 12);
            this.textBoxSteg.Name = "textBoxSteg";
            this.textBoxSteg.ReadOnly = true;
            this.textBoxSteg.Size = new System.Drawing.Size(541, 441);
            this.textBoxSteg.TabIndex = 1;
            this.textBoxSteg.Text = "";
            // 
            // ReceptFönster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxSteg);
            this.Controls.Add(this.labelNamn);
            this.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.Name = "ReceptFönster";
            this.Text = "ReceptFönster";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.RichTextBox textBoxSteg;
    }
}