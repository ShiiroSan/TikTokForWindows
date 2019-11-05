namespace TikTokForWindows
{
    partial class PageDisplayForm
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
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.GetNewVideo = new System.Windows.Forms.Button();
            this.likeNum = new System.Windows.Forms.Label();
            this.authorPic = new System.Windows.Forms.PictureBox();
            this.picLike = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picCom = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picShare = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.authorPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShare)).BeginInit();
            this.SuspendLayout();
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(12, 12);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(763, 498);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            // 
            // GetNewVideo
            // 
            this.GetNewVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GetNewVideo.Location = new System.Drawing.Point(781, 24);
            this.GetNewVideo.Name = "GetNewVideo";
            this.GetNewVideo.Size = new System.Drawing.Size(144, 37);
            this.GetNewVideo.TabIndex = 1;
            this.GetNewVideo.Text = "Get new videos";
            this.GetNewVideo.UseVisualStyleBackColor = true;
            this.GetNewVideo.Click += new System.EventHandler(this.GetNewVideo_Click);
            // 
            // likeNum
            // 
            this.likeNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.likeNum.AutoSize = true;
            this.likeNum.Location = new System.Drawing.Point(824, 77);
            this.likeNum.Name = "likeNum";
            this.likeNum.Size = new System.Drawing.Size(65, 13);
            this.likeNum.TabIndex = 2;
            this.likeNum.Text = "authorName";
            // 
            // authorPic
            // 
            this.authorPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.authorPic.Location = new System.Drawing.Point(781, 67);
            this.authorPic.Name = "authorPic";
            this.authorPic.Size = new System.Drawing.Size(37, 32);
            this.authorPic.TabIndex = 3;
            this.authorPic.TabStop = false;
            // 
            // picLike
            // 
            this.picLike.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLike.Location = new System.Drawing.Point(781, 145);
            this.picLike.Name = "picLike";
            this.picLike.Size = new System.Drawing.Size(37, 32);
            this.picLike.TabIndex = 5;
            this.picLike.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(824, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "numLike";
            // 
            // picCom
            // 
            this.picCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picCom.Location = new System.Drawing.Point(781, 195);
            this.picCom.Name = "picCom";
            this.picCom.Size = new System.Drawing.Size(37, 32);
            this.picCom.TabIndex = 7;
            this.picCom.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(824, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "numCom";
            // 
            // picShare
            // 
            this.picShare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picShare.Location = new System.Drawing.Point(781, 245);
            this.picShare.Name = "picShare";
            this.picShare.Size = new System.Drawing.Size(37, 32);
            this.picShare.TabIndex = 9;
            this.picShare.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(824, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "numShare";
            // 
            // PageDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 522);
            this.Controls.Add(this.picShare);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picLike);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.authorPic);
            this.Controls.Add(this.likeNum);
            this.Controls.Add(this.GetNewVideo);
            this.Controls.Add(this.geckoWebBrowser1);
            this.Name = "PageDisplayForm";
            this.Text = "PageDisplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.authorPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gecko.GeckoWebBrowser geckoWebBrowser1;
        private System.Windows.Forms.Button GetNewVideo;
        private System.Windows.Forms.Label likeNum;
        private System.Windows.Forms.PictureBox authorPic;
        private System.Windows.Forms.PictureBox picLike;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picShare;
        private System.Windows.Forms.Label label3;
    }
}