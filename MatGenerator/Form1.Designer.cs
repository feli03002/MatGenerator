
namespace MatGenerator
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genereraVeckaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inställningarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inställningarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 45);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(366, 366);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menyToolStripMenuItem
            // 
            this.menyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genereraVeckaToolStripMenuItem,
            this.inställningarToolStripMenuItem,
            this.inställningarToolStripMenuItem1});
            this.menyToolStripMenuItem.Name = "menyToolStripMenuItem";
            this.menyToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.menyToolStripMenuItem.Text = "Meny";
            // 
            // genereraVeckaToolStripMenuItem
            // 
            this.genereraVeckaToolStripMenuItem.Name = "genereraVeckaToolStripMenuItem";
            this.genereraVeckaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genereraVeckaToolStripMenuItem.Text = "Generera vecka";
            this.genereraVeckaToolStripMenuItem.Click += new System.EventHandler(this.genereraVeckaToolStripMenuItem_Click);
            // 
            // inställningarToolStripMenuItem
            // 
            this.inställningarToolStripMenuItem.Name = "inställningarToolStripMenuItem";
            this.inställningarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inställningarToolStripMenuItem.Text = "Lägg till recept";
            this.inställningarToolStripMenuItem.Click += new System.EventHandler(this.inställningarToolStripMenuItem_Click);
            // 
            // inställningarToolStripMenuItem1
            // 
            this.inställningarToolStripMenuItem1.Name = "inställningarToolStripMenuItem1";
            this.inställningarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.inställningarToolStripMenuItem1.Text = "Alla recept";
            this.inställningarToolStripMenuItem1.Click += new System.EventHandler(this.inställningarToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Veckans recept";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 411);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inställningarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inställningarToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem genereraVeckaToolStripMenuItem;
    }
}

