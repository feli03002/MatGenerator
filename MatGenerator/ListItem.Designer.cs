
namespace MatGenerator
{
    partial class ListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titel_label = new System.Windows.Forms.Label();
            this.desc_label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Raderaknapp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titel_label
            // 
            this.titel_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titel_label.Location = new System.Drawing.Point(3, 5);
            this.titel_label.Name = "titel_label";
            this.titel_label.Size = new System.Drawing.Size(251, 23);
            this.titel_label.TabIndex = 1;
            this.titel_label.Text = "Namn";
            this.titel_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // desc_label
            // 
            this.desc_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_label.Location = new System.Drawing.Point(4, 28);
            this.desc_label.Name = "desc_label";
            this.desc_label.Size = new System.Drawing.Size(270, 24);
            this.desc_label.TabIndex = 2;
            this.desc_label.Text = "Beskrivning";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Raderaknapp);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.desc_label);
            this.panel1.Controls.Add(this.titel_label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 59);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(253, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Öppna";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Raderaknapp
            // 
            this.Raderaknapp.Location = new System.Drawing.Point(253, 31);
            this.Raderaknapp.Name = "Raderaknapp";
            this.Raderaknapp.Size = new System.Drawing.Size(75, 23);
            this.Raderaknapp.TabIndex = 4;
            this.Raderaknapp.Text = "Radera";
            this.Raderaknapp.UseVisualStyleBackColor = true;
            this.Raderaknapp.Click += new System.EventHandler(this.Raderaknapp_Click);
            // 
            // ListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ListItem";
            this.Size = new System.Drawing.Size(334, 62);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label titel_label;
        private System.Windows.Forms.Label desc_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Raderaknapp;
    }
}
