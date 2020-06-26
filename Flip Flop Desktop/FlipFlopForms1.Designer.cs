namespace Flip_Flop_Desktop
{
    partial class FlipFlopForms1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlipFlopForms1));
            this.textboxA = new System.Windows.Forms.TextBox();
            this.textboxB = new System.Windows.Forms.TextBox();
            this.textboxC = new System.Windows.Forms.TextBox();
            this.textboxD = new System.Windows.Forms.TextBox();
            this.textboxAnd1 = new System.Windows.Forms.TextBox();
            this.textboxAnd2 = new System.Windows.Forms.TextBox();
            this.textboxOr = new System.Windows.Forms.TextBox();
            this.lightBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxA
            // 
            this.textboxA.Location = new System.Drawing.Point(37, 114);
            this.textboxA.Name = "textboxA";
            this.textboxA.Size = new System.Drawing.Size(73, 20);
            this.textboxA.TabIndex = 1;
            this.textboxA.WordWrap = false;
            this.textboxA.TextChanged += new System.EventHandler(this.textboxA_TextChanged);
            // 
            // textboxB
            // 
            this.textboxB.Location = new System.Drawing.Point(37, 156);
            this.textboxB.Name = "textboxB";
            this.textboxB.Size = new System.Drawing.Size(73, 20);
            this.textboxB.TabIndex = 2;
            this.textboxB.TextChanged += new System.EventHandler(this.textboxB_TextChanged);
            // 
            // textboxC
            // 
            this.textboxC.Location = new System.Drawing.Point(37, 244);
            this.textboxC.Name = "textboxC";
            this.textboxC.Size = new System.Drawing.Size(73, 20);
            this.textboxC.TabIndex = 3;
            this.textboxC.TextChanged += new System.EventHandler(this.textboxC_TextChanged);
            // 
            // textboxD
            // 
            this.textboxD.Location = new System.Drawing.Point(37, 292);
            this.textboxD.Name = "textboxD";
            this.textboxD.Size = new System.Drawing.Size(73, 20);
            this.textboxD.TabIndex = 4;
            this.textboxD.TextChanged += new System.EventHandler(this.textboxD_TextChanged);
            // 
            // textboxAnd1
            // 
            this.textboxAnd1.Location = new System.Drawing.Point(286, 130);
            this.textboxAnd1.Name = "textboxAnd1";
            this.textboxAnd1.ReadOnly = true;
            this.textboxAnd1.Size = new System.Drawing.Size(43, 20);
            this.textboxAnd1.TabIndex = 5;
            // 
            // textboxAnd2
            // 
            this.textboxAnd2.Location = new System.Drawing.Point(286, 275);
            this.textboxAnd2.Name = "textboxAnd2";
            this.textboxAnd2.ReadOnly = true;
            this.textboxAnd2.Size = new System.Drawing.Size(43, 20);
            this.textboxAnd2.TabIndex = 6;
            // 
            // textboxOr
            // 
            this.textboxOr.Location = new System.Drawing.Point(549, 199);
            this.textboxOr.Name = "textboxOr";
            this.textboxOr.ReadOnly = true;
            this.textboxOr.Size = new System.Drawing.Size(76, 20);
            this.textboxOr.TabIndex = 7;
            // 
            // lightBox
            // 
            this.lightBox.Image = global::Flip_Flop_Desktop.Properties.Resources.lightOff;
            this.lightBox.Location = new System.Drawing.Point(669, 130);
            this.lightBox.Name = "lightBox";
            this.lightBox.Size = new System.Drawing.Size(119, 171);
            this.lightBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lightBox.TabIndex = 8;
            this.lightBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(644, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Created by Izzudin Ar Rafiq(111910024)";
            // 
            // FlipFlopForms1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightBox);
            this.Controls.Add(this.textboxOr);
            this.Controls.Add(this.textboxAnd2);
            this.Controls.Add(this.textboxAnd1);
            this.Controls.Add(this.textboxD);
            this.Controls.Add(this.textboxC);
            this.Controls.Add(this.textboxB);
            this.Controls.Add(this.textboxA);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FlipFlopForms1";
            this.Text = "Flip Flop 1";
            this.Load += new System.EventHandler(this.FlipFlopForms1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxA;
        private System.Windows.Forms.TextBox textboxB;
        private System.Windows.Forms.TextBox textboxC;
        private System.Windows.Forms.TextBox textboxD;
        private System.Windows.Forms.TextBox textboxAnd1;
        private System.Windows.Forms.TextBox textboxAnd2;
        private System.Windows.Forms.TextBox textboxOr;
        private System.Windows.Forms.PictureBox lightBox;
        private System.Windows.Forms.Label label1;
    }
}