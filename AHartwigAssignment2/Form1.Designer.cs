namespace AHartwigAssignment2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbTL = new System.Windows.Forms.PictureBox();
            this.pbTM = new System.Windows.Forms.PictureBox();
            this.pbTR = new System.Windows.Forms.PictureBox();
            this.pbML = new System.Windows.Forms.PictureBox();
            this.pbMM = new System.Windows.Forms.PictureBox();
            this.pbMR = new System.Windows.Forms.PictureBox();
            this.pbBL = new System.Windows.Forms.PictureBox();
            this.pbBM = new System.Windows.Forms.PictureBox();
            this.pbBR = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbML)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBR)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AHartwigAssignment2.Properties.Resources.tttboard;
            this.pictureBox1.Location = new System.Drawing.Point(21, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pbTL
            // 
            this.pbTL.BackColor = System.Drawing.Color.Transparent;
            this.pbTL.Location = new System.Drawing.Point(37, 55);
            this.pbTL.Name = "pbTL";
            this.pbTL.Size = new System.Drawing.Size(82, 82);
            this.pbTL.TabIndex = 2;
            this.pbTL.TabStop = false;
            this.pbTL.Click += new System.EventHandler(this.image_click);
            // 
            // pbTM
            // 
            this.pbTM.BackColor = System.Drawing.Color.Transparent;
            this.pbTM.Location = new System.Drawing.Point(131, 55);
            this.pbTM.Name = "pbTM";
            this.pbTM.Size = new System.Drawing.Size(82, 82);
            this.pbTM.TabIndex = 3;
            this.pbTM.TabStop = false;
            this.pbTM.Click += new System.EventHandler(this.image_click);
            // 
            // pbTR
            // 
            this.pbTR.BackColor = System.Drawing.Color.Transparent;
            this.pbTR.Location = new System.Drawing.Point(223, 55);
            this.pbTR.Name = "pbTR";
            this.pbTR.Size = new System.Drawing.Size(82, 82);
            this.pbTR.TabIndex = 4;
            this.pbTR.TabStop = false;
            this.pbTR.Click += new System.EventHandler(this.image_click);
            // 
            // pbML
            // 
            this.pbML.BackColor = System.Drawing.Color.Transparent;
            this.pbML.Location = new System.Drawing.Point(37, 147);
            this.pbML.Name = "pbML";
            this.pbML.Size = new System.Drawing.Size(82, 82);
            this.pbML.TabIndex = 5;
            this.pbML.TabStop = false;
            this.pbML.Click += new System.EventHandler(this.image_click);
            // 
            // pbMM
            // 
            this.pbMM.BackColor = System.Drawing.Color.Transparent;
            this.pbMM.Location = new System.Drawing.Point(130, 147);
            this.pbMM.Name = "pbMM";
            this.pbMM.Size = new System.Drawing.Size(82, 82);
            this.pbMM.TabIndex = 6;
            this.pbMM.TabStop = false;
            this.pbMM.Click += new System.EventHandler(this.image_click);
            // 
            // pbMR
            // 
            this.pbMR.BackColor = System.Drawing.Color.Transparent;
            this.pbMR.Location = new System.Drawing.Point(223, 147);
            this.pbMR.Name = "pbMR";
            this.pbMR.Size = new System.Drawing.Size(82, 82);
            this.pbMR.TabIndex = 7;
            this.pbMR.TabStop = false;
            this.pbMR.Click += new System.EventHandler(this.image_click);
            // 
            // pbBL
            // 
            this.pbBL.BackColor = System.Drawing.Color.Transparent;
            this.pbBL.Location = new System.Drawing.Point(37, 241);
            this.pbBL.Name = "pbBL";
            this.pbBL.Size = new System.Drawing.Size(82, 82);
            this.pbBL.TabIndex = 8;
            this.pbBL.TabStop = false;
            this.pbBL.Click += new System.EventHandler(this.image_click);
            // 
            // pbBM
            // 
            this.pbBM.BackColor = System.Drawing.Color.Transparent;
            this.pbBM.Location = new System.Drawing.Point(130, 240);
            this.pbBM.Name = "pbBM";
            this.pbBM.Size = new System.Drawing.Size(82, 82);
            this.pbBM.TabIndex = 9;
            this.pbBM.TabStop = false;
            this.pbBM.Click += new System.EventHandler(this.image_click);
            // 
            // pbBR
            // 
            this.pbBR.BackColor = System.Drawing.Color.Transparent;
            this.pbBR.Location = new System.Drawing.Point(222, 240);
            this.pbBR.Name = "pbBR";
            this.pbBR.Size = new System.Drawing.Size(82, 82);
            this.pbBR.TabIndex = 10;
            this.pbBR.TabStop = false;
            this.pbBR.Click += new System.EventHandler(this.image_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 350);
            this.Controls.Add(this.pbBR);
            this.Controls.Add(this.pbBM);
            this.Controls.Add(this.pbBL);
            this.Controls.Add(this.pbMR);
            this.Controls.Add(this.pbMM);
            this.Controls.Add(this.pbML);
            this.Controls.Add(this.pbTR);
            this.Controls.Add(this.pbTM);
            this.Controls.Add(this.pbTL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbML)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbTL;
        private System.Windows.Forms.PictureBox pbTM;
        private System.Windows.Forms.PictureBox pbTR;
        private System.Windows.Forms.PictureBox pbML;
        private System.Windows.Forms.PictureBox pbMM;
        private System.Windows.Forms.PictureBox pbMR;
        private System.Windows.Forms.PictureBox pbBL;
        private System.Windows.Forms.PictureBox pbBM;
        private System.Windows.Forms.PictureBox pbBR;
    }
}

