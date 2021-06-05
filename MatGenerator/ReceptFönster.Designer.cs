
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
            this.CBfavorit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(12, 18);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(35, 13);
            this.labelNamn.TabIndex = 0;
            this.labelNamn.Text = "label1";
            // 
            // textBoxSteg
            // 
            this.textBoxSteg.Dock = System.Windows.Forms.DockStyle.Right;
            this.textBoxSteg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSteg.Location = new System.Drawing.Point(180, 0);
            this.textBoxSteg.Name = "textBoxSteg";
            this.textBoxSteg.ReadOnly = true;
            this.textBoxSteg.Size = new System.Drawing.Size(487, 450);
            this.textBoxSteg.TabIndex = 1;
            this.textBoxSteg.Text = "";
            // 
            // CBfavorit
            // 
            this.CBfavorit.AutoSize = true;
            this.CBfavorit.Location = new System.Drawing.Point(12, 53);
            this.CBfavorit.Name = "CBfavorit";
            this.CBfavorit.Size = new System.Drawing.Size(58, 17);
            this.CBfavorit.TabIndex = 2;
            this.CBfavorit.Text = "Favorit";
            this.CBfavorit.UseVisualStyleBackColor = true;
            this.CBfavorit.CheckedChanged += new System.EventHandler(this.CBfavorit_CheckedChanged);
            // 
            // ReceptFönster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 450);
            this.Controls.Add(this.CBfavorit);
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
        private System.Windows.Forms.CheckBox CBfavorit;
    }
}