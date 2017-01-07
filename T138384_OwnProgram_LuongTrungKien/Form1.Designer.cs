namespace T138384_OwnProgram_LuongTrungKien
{
    partial class frmOwnProgram
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblSocers = new System.Windows.Forms.Label();
            this.lblHightSocers = new System.Windows.Forms.Label();
            this.lblTxt = new System.Windows.Forms.Label();
            this.tmStart = new System.Windows.Forms.Timer(this.components);
            this.tmRun = new System.Windows.Forms.Timer(this.components);
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.picImagestone2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picImagestone = new System.Windows.Forms.PictureBox();
            this.picImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImagestone2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagestone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 9);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(12, 9);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 25);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Chơi lại";
            this.btnRestart.UseVisualStyleBackColor = true;
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(622, 29);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(75, 25);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Cách chơi";
            this.btnHelp.UseVisualStyleBackColor = true;
            // 
            // lblSocers
            // 
            this.lblSocers.AutoSize = true;
            this.lblSocers.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocers.Location = new System.Drawing.Point(439, 9);
            this.lblSocers.Name = "lblSocers";
            this.lblSocers.Size = new System.Drawing.Size(54, 17);
            this.lblSocers.TabIndex = 3;
            this.lblSocers.Text = "Điểm: 0";
            // 
            // lblHightSocers
            // 
            this.lblHightSocers.AutoSize = true;
            this.lblHightSocers.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHightSocers.Location = new System.Drawing.Point(554, 9);
            this.lblHightSocers.Name = "lblHightSocers";
            this.lblHightSocers.Size = new System.Drawing.Size(108, 17);
            this.lblHightSocers.TabIndex = 4;
            this.lblHightSocers.Text = "Điểm cao nhất: 0";
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxt.Location = new System.Drawing.Point(208, 308);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(16, 17);
            this.lblTxt.TabIndex = 7;
            this.lblTxt.Text = "  ";
            // 
            // tmStart
            // 
            this.tmStart.Interval = 1;
            // 
            // tmRun
            // 
            this.tmRun.Interval = 1;
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(12, 9);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 25);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.Location = new System.Drawing.Point(12, 12);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 25);
            this.btnContinue.TabIndex = 11;
            this.btnContinue.Text = "Tiếp tục";
            this.btnContinue.UseVisualStyleBackColor = true;
            // 
            // picImagestone2
            // 
            this.picImagestone2.Image = global::T138384_OwnProgram_LuongTrungKien.Properties.Resources.Vatcan;
            this.picImagestone2.Location = new System.Drawing.Point(328, 220);
            this.picImagestone2.Name = "picImagestone2";
            this.picImagestone2.Size = new System.Drawing.Size(52, 62);
            this.picImagestone2.TabIndex = 13;
            this.picImagestone2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::T138384_OwnProgram_LuongTrungKien.Properties.Resources.Duong;
            this.pictureBox1.Location = new System.Drawing.Point(12, 280);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(704, 10);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // picImagestone
            // 
            this.picImagestone.Image = global::T138384_OwnProgram_LuongTrungKien.Properties.Resources.Vatcan;
            this.picImagestone.Location = new System.Drawing.Point(645, 220);
            this.picImagestone.Name = "picImagestone";
            this.picImagestone.Size = new System.Drawing.Size(52, 62);
            this.picImagestone.TabIndex = 9;
            this.picImagestone.TabStop = false;
            // 
            // picImage
            // 
            this.picImage.Image = global::T138384_OwnProgram_LuongTrungKien.Properties.Resources.Convat;
            this.picImage.Location = new System.Drawing.Point(69, 220);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(52, 62);
            this.picImage.TabIndex = 8;
            this.picImage.TabStop = false;
            // 
            // frmOwnProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 344);
            this.Controls.Add(this.picImagestone2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.picImagestone);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.lblHightSocers);
            this.Controls.Add(this.lblSocers);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmOwnProgram";
            this.Text = "Own Program";
            this.Load += new System.EventHandler(this.frmOwnProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagestone2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImagestone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label lblSocers;
        private System.Windows.Forms.Label lblHightSocers;
        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.Timer tmStart;
        private System.Windows.Forms.Timer tmRun;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.PictureBox picImagestone;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picImagestone2;
    }
}

