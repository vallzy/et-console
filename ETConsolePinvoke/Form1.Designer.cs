namespace ETConsolePinvoke
{
    partial class Splash1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFound = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblConFound = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.findET = new System.Windows.Forms.Timer(this.components);
            this.findWin = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ET Status:";
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFound.ForeColor = System.Drawing.Color.Red;
            this.lblFound.Location = new System.Drawing.Point(237, 27);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(105, 25);
            this.lblFound.TabIndex = 1;
            this.lblFound.Text = "Not found";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ET Console:";
            // 
            // lblConFound
            // 
            this.lblConFound.AutoSize = true;
            this.lblConFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConFound.ForeColor = System.Drawing.Color.Red;
            this.lblConFound.Location = new System.Drawing.Point(237, 60);
            this.lblConFound.Name = "lblConFound";
            this.lblConFound.Size = new System.Drawing.Size(105, 25);
            this.lblConFound.TabIndex = 3;
            this.lblConFound.Text = "Not found";
            this.lblConFound.TextChanged += new System.EventHandler(this.lblConFound_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Waiting...";
            // 
            // findET
            // 
            this.findET.Enabled = true;
            this.findET.Interval = 500;
            this.findET.Tick += new System.EventHandler(this.FindET_Tick);
            // 
            // findWin
            // 
            this.findWin.Enabled = true;
            this.findWin.Interval = 500;
            this.findWin.Tick += new System.EventHandler(this.FindWin_Tick);
            // 
            // Splash1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 98);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblConFound);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Splash1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Using ET Console...";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFound;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblConFound;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer findET;
        private System.Windows.Forms.Timer findWin;
    }
}

