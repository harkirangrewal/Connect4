namespace Connect_4
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
            this.pb_grid = new System.Windows.Forms.PictureBox();
            this.txtYellow = new System.Windows.Forms.TextBox();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_grid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_grid
            // 
            this.pb_grid.Location = new System.Drawing.Point(30, 47);
            this.pb_grid.Name = "pb_grid";
            this.pb_grid.Size = new System.Drawing.Size(700, 600);
            this.pb_grid.TabIndex = 0;
            this.pb_grid.TabStop = false;
            this.pb_grid.Paint += new System.Windows.Forms.PaintEventHandler(this.pb_grid_Paint);
            // 
            // txtYellow
            // 
            this.txtYellow.Location = new System.Drawing.Point(146, 38);
            this.txtYellow.Name = "txtYellow";
            this.txtYellow.Size = new System.Drawing.Size(100, 26);
            this.txtYellow.TabIndex = 1;
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Location = new System.Drawing.Point(34, 38);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(55, 20);
            this.lblYellow.TabIndex = 2;
            this.lblYellow.Text = "Yellow";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(34, 101);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(39, 20);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "Red";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(146, 95);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 26);
            this.txtRed.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRed);
            this.groupBox1.Controls.Add(this.lblRed);
            this.groupBox1.Controls.Add(this.lblYellow);
            this.groupBox1.Controls.Add(this.txtYellow);
            this.groupBox1.Location = new System.Drawing.Point(781, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 191);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 672);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pb_grid);
            this.Name = "Form1";
            this.Text = "Connect Four";
            ((System.ComponentModel.ISupportInitialize)(this.pb_grid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_grid;
        private System.Windows.Forms.TextBox txtYellow;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

