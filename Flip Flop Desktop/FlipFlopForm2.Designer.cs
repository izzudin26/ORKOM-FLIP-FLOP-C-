namespace Flip_Flop_Desktop
{
    partial class FlipFlopForm2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxOr1 = new System.Windows.Forms.TextBox();
            this.inputD = new System.Windows.Forms.TextBox();
            this.inputB = new System.Windows.Forms.TextBox();
            this.inputC = new System.Windows.Forms.TextBox();
            this.inputA = new System.Windows.Forms.TextBox();
            this.textboxAnd1 = new System.Windows.Forms.TextBox();
            this.textboxAnd2 = new System.Windows.Forms.TextBox();
            this.textboxOr2 = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.lightbox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightbox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flip_Flop_Desktop.Properties.Resources.flip2;
            this.pictureBox1.Location = new System.Drawing.Point(21, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textboxOr1
            // 
            this.textboxOr1.Location = new System.Drawing.Point(188, 100);
            this.textboxOr1.Name = "textboxOr1";
            this.textboxOr1.ReadOnly = true;
            this.textboxOr1.Size = new System.Drawing.Size(27, 20);
            this.textboxOr1.TabIndex = 1;
            // 
            // inputD
            // 
            this.inputD.Location = new System.Drawing.Point(32, 283);
            this.inputD.Name = "inputD";
            this.inputD.Size = new System.Drawing.Size(55, 20);
            this.inputD.TabIndex = 2;
            this.inputD.TextChanged += new System.EventHandler(this.inputD_TextChanged);
            // 
            // inputB
            // 
            this.inputB.Location = new System.Drawing.Point(32, 132);
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(55, 20);
            this.inputB.TabIndex = 3;
            this.inputB.TextChanged += new System.EventHandler(this.inputB_TextChanged);
            // 
            // inputC
            // 
            this.inputC.Location = new System.Drawing.Point(32, 232);
            this.inputC.Name = "inputC";
            this.inputC.Size = new System.Drawing.Size(55, 20);
            this.inputC.TabIndex = 4;
            this.inputC.TextChanged += new System.EventHandler(this.inputC_TextChanged);
            // 
            // inputA
            // 
            this.inputA.Location = new System.Drawing.Point(32, 83);
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(55, 20);
            this.inputA.TabIndex = 4;
            this.inputA.TextChanged += new System.EventHandler(this.inputA_TextChanged);
            // 
            // textboxAnd1
            // 
            this.textboxAnd1.Location = new System.Drawing.Point(176, 283);
            this.textboxAnd1.Name = "textboxAnd1";
            this.textboxAnd1.ReadOnly = true;
            this.textboxAnd1.Size = new System.Drawing.Size(27, 20);
            this.textboxAnd1.TabIndex = 5;
            // 
            // textboxAnd2
            // 
            this.textboxAnd2.Location = new System.Drawing.Point(384, 100);
            this.textboxAnd2.Name = "textboxAnd2";
            this.textboxAnd2.ReadOnly = true;
            this.textboxAnd2.Size = new System.Drawing.Size(38, 20);
            this.textboxAnd2.TabIndex = 6;
            // 
            // textboxOr2
            // 
            this.textboxOr2.Location = new System.Drawing.Point(384, 267);
            this.textboxOr2.Name = "textboxOr2";
            this.textboxOr2.ReadOnly = true;
            this.textboxOr2.Size = new System.Drawing.Size(38, 20);
            this.textboxOr2.TabIndex = 7;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(600, 165);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(52, 20);
            this.resultBox.TabIndex = 8;
            // 
            // lightbox
            // 
            this.lightbox.Image = global::Flip_Flop_Desktop.Properties.Resources.lightOff;
            this.lightbox.Location = new System.Drawing.Point(658, 71);
            this.lightbox.Name = "lightbox";
            this.lightbox.Size = new System.Drawing.Size(123, 204);
            this.lightbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.lightbox.TabIndex = 9;
            this.lightbox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Created by Izzudin Ar Rafiq(111910024)";
            // 
            // FlipFlopForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightbox);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.textboxOr2);
            this.Controls.Add(this.textboxAnd2);
            this.Controls.Add(this.textboxAnd1);
            this.Controls.Add(this.inputA);
            this.Controls.Add(this.inputC);
            this.Controls.Add(this.inputB);
            this.Controls.Add(this.inputD);
            this.Controls.Add(this.textboxOr1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FlipFlopForm2";
            this.Text = "Flip Flop 2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lightbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textboxOr1;
        private System.Windows.Forms.TextBox inputD;
        private System.Windows.Forms.TextBox inputC;
        private System.Windows.Forms.TextBox inputA;
        private System.Windows.Forms.TextBox textboxAnd1;
        private System.Windows.Forms.TextBox textboxAnd2;
        private System.Windows.Forms.TextBox textboxOr2;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.TextBox inputB;
        private System.Windows.Forms.PictureBox lightbox;
        private System.Windows.Forms.Label label1;
    }
}