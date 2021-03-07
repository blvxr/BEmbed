
namespace BotGUI
{
    partial class PageOne
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Title = new System.Windows.Forms.ColumnHeader();
            this.Content = new System.Windows.Forms.ColumnHeader();
            this.lblList = new System.Windows.Forms.Label();
            this.txtEmbedTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.boxChannels = new System.Windows.Forms.ComboBox();
            this.txtThumbnail = new System.Windows.Forms.TextBox();
            this.bttnRemoveEmbed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(436, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HH Servers";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Location = new System.Drawing.Point(126, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 40);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(314, 389);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 40);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.Color.DimGray;
            this.txtImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtImage.Location = new System.Drawing.Point(20, 79);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(197, 23);
            this.txtImage.TabIndex = 24;
            this.txtImage.Text = "Image URL";
            // 
            // btnSend
            // 
            this.btnSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSend.Location = new System.Drawing.Point(129, 389);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(179, 40);
            this.btnSend.TabIndex = 23;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.DimGray;
            this.txtContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtContent.Location = new System.Drawing.Point(20, 134);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(397, 77);
            this.txtContent.TabIndex = 22;
            this.txtContent.Text = "Content";
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.DimGray;
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtTitle.Location = new System.Drawing.Point(20, 105);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(397, 23);
            this.txtTitle.TabIndex = 21;
            this.txtTitle.Text = "Title";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DimGray;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Content});
            this.listView1.ForeColor = System.Drawing.Color.Fuchsia;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 293);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(397, 90);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 100;
            // 
            // Content
            // 
            this.Content.Text = "Content";
            this.Content.Width = 340;
            // 
            // lblList
            // 
            this.lblList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblList.Location = new System.Drawing.Point(168, 266);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(100, 23);
            this.lblList.TabIndex = 28;
            this.lblList.Text = "Embed List:";
            this.lblList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEmbedTitle
            // 
            this.txtEmbedTitle.BackColor = System.Drawing.Color.DimGray;
            this.txtEmbedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtEmbedTitle.Location = new System.Drawing.Point(20, 53);
            this.txtEmbedTitle.Name = "txtEmbedTitle";
            this.txtEmbedTitle.Size = new System.Drawing.Size(197, 23);
            this.txtEmbedTitle.TabIndex = 29;
            this.txtEmbedTitle.Text = "Embed Title";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.Color.DimGray;
            this.txtAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAuthor.Location = new System.Drawing.Point(220, 53);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(197, 23);
            this.txtAuthor.TabIndex = 30;
            this.txtAuthor.Text = "Author";
            // 
            // boxChannels
            // 
            this.boxChannels.BackColor = System.Drawing.Color.DimGray;
            this.boxChannels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.boxChannels.FormattingEnabled = true;
            this.boxChannels.Location = new System.Drawing.Point(20, 399);
            this.boxChannels.Name = "boxChannels";
            this.boxChannels.Size = new System.Drawing.Size(103, 23);
            this.boxChannels.Sorted = true;
            this.boxChannels.TabIndex = 32;
            // 
            // txtThumbnail
            // 
            this.txtThumbnail.BackColor = System.Drawing.Color.DimGray;
            this.txtThumbnail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtThumbnail.Location = new System.Drawing.Point(220, 79);
            this.txtThumbnail.Name = "txtThumbnail";
            this.txtThumbnail.Size = new System.Drawing.Size(197, 23);
            this.txtThumbnail.TabIndex = 33;
            this.txtThumbnail.Text = "Thumbnail URL";
            // 
            // bttnRemoveEmbed
            // 
            this.bttnRemoveEmbed.Location = new System.Drawing.Point(374, 294);
            this.bttnRemoveEmbed.Name = "bttnRemoveEmbed";
            this.bttnRemoveEmbed.Size = new System.Drawing.Size(42, 25);
            this.bttnRemoveEmbed.TabIndex = 34;
            this.bttnRemoveEmbed.Text = "X";
            this.bttnRemoveEmbed.UseVisualStyleBackColor = true;
            this.bttnRemoveEmbed.Click += new System.EventHandler(this.bttnRemoveEmbed_Click);
            // 
            // PageOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.bttnRemoveEmbed);
            this.Controls.Add(this.txtThumbnail);
            this.Controls.Add(this.boxChannels);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtEmbedTitle);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Name = "PageOne";
            this.Size = new System.Drawing.Size(436, 441);
            this.Load += new System.EventHandler(this.PageOne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Content;
        private System.Windows.Forms.TextBox txtEmbedTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox boxChannels;
        private System.Windows.Forms.TextBox txtThumbnail;
        private System.Windows.Forms.Button bttnRemoveEmbed;
    }
}
