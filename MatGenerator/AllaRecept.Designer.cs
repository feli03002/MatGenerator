
namespace MatGenerator
{
    partial class AllaRecept
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.RBfavorit = new System.Windows.Forms.RadioButton();
            this.RBfläsk = new System.Windows.Forms.RadioButton();
            this.RBnötkött = new System.Windows.Forms.RadioButton();
            this.RBvegetarisk = new System.Windows.Forms.RadioButton();
            this.RBkyckling = new System.Windows.Forms.RadioButton();
            this.RBfisk = new System.Windows.Forms.RadioButton();
            this.RBglutenfri = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(133, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(341, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBglutenfri);
            this.groupBox1.Controls.Add(this.RBfisk);
            this.groupBox1.Controls.Add(this.RBvegetarisk);
            this.groupBox1.Controls.Add(this.RBkyckling);
            this.groupBox1.Controls.Add(this.RBfläsk);
            this.groupBox1.Controls.Add(this.RBnötkött);
            this.groupBox1.Controls.Add(this.RBfavorit);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 201);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(49, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Inget";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RBfavorit
            // 
            this.RBfavorit.AutoSize = true;
            this.RBfavorit.Location = new System.Drawing.Point(6, 42);
            this.RBfavorit.Name = "RBfavorit";
            this.RBfavorit.Size = new System.Drawing.Size(66, 17);
            this.RBfavorit.TabIndex = 7;
            this.RBfavorit.Text = "Favoriter";
            this.RBfavorit.UseVisualStyleBackColor = true;
            this.RBfavorit.CheckedChanged += new System.EventHandler(this.RBfavorit_CheckedChanged);
            // 
            // RBfläsk
            // 
            this.RBfläsk.AutoSize = true;
            this.RBfläsk.Location = new System.Drawing.Point(6, 88);
            this.RBfläsk.Name = "RBfläsk";
            this.RBfläsk.Size = new System.Drawing.Size(50, 17);
            this.RBfläsk.TabIndex = 9;
            this.RBfläsk.Text = "Fläsk";
            this.RBfläsk.UseVisualStyleBackColor = true;
            this.RBfläsk.CheckedChanged += new System.EventHandler(this.RBfläsk_CheckedChanged);
            // 
            // RBnötkött
            // 
            this.RBnötkött.AutoSize = true;
            this.RBnötkött.Location = new System.Drawing.Point(6, 65);
            this.RBnötkött.Name = "RBnötkött";
            this.RBnötkött.Size = new System.Drawing.Size(60, 17);
            this.RBnötkött.TabIndex = 10;
            this.RBnötkött.Text = "Nötkött";
            this.RBnötkött.UseVisualStyleBackColor = true;
            this.RBnötkött.CheckedChanged += new System.EventHandler(this.RBnötkött_CheckedChanged);
            // 
            // RBvegetarisk
            // 
            this.RBvegetarisk.AutoSize = true;
            this.RBvegetarisk.Location = new System.Drawing.Point(6, 134);
            this.RBvegetarisk.Name = "RBvegetarisk";
            this.RBvegetarisk.Size = new System.Drawing.Size(75, 17);
            this.RBvegetarisk.TabIndex = 11;
            this.RBvegetarisk.Text = "Vegetarisk";
            this.RBvegetarisk.UseVisualStyleBackColor = true;
            this.RBvegetarisk.CheckedChanged += new System.EventHandler(this.RBvegetarisk_CheckedChanged);
            // 
            // RBkyckling
            // 
            this.RBkyckling.AutoSize = true;
            this.RBkyckling.Location = new System.Drawing.Point(6, 111);
            this.RBkyckling.Name = "RBkyckling";
            this.RBkyckling.Size = new System.Drawing.Size(65, 17);
            this.RBkyckling.TabIndex = 12;
            this.RBkyckling.Text = "Kyckling";
            this.RBkyckling.UseVisualStyleBackColor = true;
            this.RBkyckling.CheckedChanged += new System.EventHandler(this.RBkyckling_CheckedChanged);
            // 
            // RBfisk
            // 
            this.RBfisk.AutoSize = true;
            this.RBfisk.Location = new System.Drawing.Point(6, 157);
            this.RBfisk.Name = "RBfisk";
            this.RBfisk.Size = new System.Drawing.Size(44, 17);
            this.RBfisk.TabIndex = 12;
            this.RBfisk.Text = "Fisk";
            this.RBfisk.UseVisualStyleBackColor = true;
            this.RBfisk.CheckedChanged += new System.EventHandler(this.RBfisk_CheckedChanged);
            // 
            // RBglutenfri
            // 
            this.RBglutenfri.AutoSize = true;
            this.RBglutenfri.Location = new System.Drawing.Point(6, 178);
            this.RBglutenfri.Name = "RBglutenfri";
            this.RBglutenfri.Size = new System.Drawing.Size(64, 17);
            this.RBglutenfri.TabIndex = 13;
            this.RBglutenfri.Text = "Glutenfri";
            this.RBglutenfri.UseVisualStyleBackColor = true;
            this.RBglutenfri.CheckedChanged += new System.EventHandler(this.RBglutenfri_CheckedChanged);
            // 
            // AllaRecept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AllaRecept";
            this.Text = "V";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBvegetarisk;
        private System.Windows.Forms.RadioButton RBkyckling;
        private System.Windows.Forms.RadioButton RBfläsk;
        private System.Windows.Forms.RadioButton RBnötkött;
        private System.Windows.Forms.RadioButton RBfavorit;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton RBfisk;
        private System.Windows.Forms.RadioButton RBglutenfri;
    }
}