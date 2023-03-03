namespace PiectureViewer
{
    partial class Main
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
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnDeletePicture = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(12, 12);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(186, 44);
            this.btnAddPicture.TabIndex = 0;
            this.btnAddPicture.Text = "Dodaj Obraz";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnDeletePicture
            // 
            this.btnDeletePicture.Location = new System.Drawing.Point(12, 62);
            this.btnDeletePicture.Name = "btnDeletePicture";
            this.btnDeletePicture.Size = new System.Drawing.Size(185, 44);
            this.btnDeletePicture.TabIndex = 1;
            this.btnDeletePicture.Text = "Usuń Obraz";
            this.btnDeletePicture.UseVisualStyleBackColor = true;
            this.btnDeletePicture.Click += new System.EventHandler(this.btnDeletePicture_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPicture.Location = new System.Drawing.Point(204, 12);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(584, 426);
            this.pbPicture.TabIndex = 2;
            this.pbPicture.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btnDeletePicture);
            this.Controls.Add(this.btnAddPicture);
            this.Name = "Main";
            this.Text = "Picture Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnDeletePicture;
        private System.Windows.Forms.PictureBox pbPicture;
    }
}

