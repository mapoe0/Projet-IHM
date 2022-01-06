
namespace WindowsFormsApp2
{
    partial class Hand
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hand));
            this.label1 = new System.Windows.Forms.Label();
            this.backImageBtn = new System.Windows.Forms.PictureBox();
            this.bonesPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.backImageBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonesPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backImageBtn
            // 
            this.backImageBtn.Image = global::WindowsFormsApp2.Properties.Resources.back_button;
            this.backImageBtn.Location = new System.Drawing.Point(25, 25);
            this.backImageBtn.Margin = new System.Windows.Forms.Padding(2);
            this.backImageBtn.Name = "backImageBtn";
            this.backImageBtn.Size = new System.Drawing.Size(28, 38);
            this.backImageBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backImageBtn.TabIndex = 2;
            this.backImageBtn.TabStop = false;
            this.backImageBtn.Click += new System.EventHandler(this.backImageBtn_Click);
            // 
            // bonesPictureBox
            // 
            this.bonesPictureBox.Location = new System.Drawing.Point(252, 72);
            this.bonesPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.bonesPictureBox.Name = "bonesPictureBox";
            this.bonesPictureBox.Size = new System.Drawing.Size(265, 344);
            this.bonesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bonesPictureBox.TabIndex = 0;
            this.bonesPictureBox.TabStop = false;
            this.bonesPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.bonesPictureBox_Paint);
            this.bonesPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bonesPictureBox_MouseClick);
            this.bonesPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bonesPictureBox_MouseMove);
            // 
            // Hand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 571);
            this.Controls.Add(this.backImageBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bonesPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Hand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hand_FormClosed);
            this.Load += new System.EventHandler(this.Hand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.backImageBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bonesPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox bonesPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox backImageBtn;
    }
}