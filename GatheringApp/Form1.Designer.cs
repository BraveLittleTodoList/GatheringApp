
namespace GatheringApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ilGatheringAreaImages = new System.Windows.Forms.ImageList(this.components);
            this.pbGatheringImage = new System.Windows.Forms.PictureBox();
            this.cbGatheringSelect = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGatheringImage)).BeginInit();
            this.SuspendLayout();
            // 
            // ilGatheringAreaImages
            // 
            this.ilGatheringAreaImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilGatheringAreaImages.ImageStream")));
            this.ilGatheringAreaImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilGatheringAreaImages.Images.SetKeyName(0, "Forest.jpg");
            this.ilGatheringAreaImages.Images.SetKeyName(1, "Desert.png");
            this.ilGatheringAreaImages.Images.SetKeyName(2, "Grasslands.jpg");
            this.ilGatheringAreaImages.Images.SetKeyName(3, "Marsh.jpg");
            this.ilGatheringAreaImages.Images.SetKeyName(4, "Mountain.jpg");
            // 
            // pbGatheringImage
            // 
            this.pbGatheringImage.Enabled = false;
            this.pbGatheringImage.Location = new System.Drawing.Point(12, 39);
            this.pbGatheringImage.Name = "pbGatheringImage";
            this.pbGatheringImage.Size = new System.Drawing.Size(354, 233);
            this.pbGatheringImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGatheringImage.TabIndex = 0;
            this.pbGatheringImage.TabStop = false;
            this.pbGatheringImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbGatheringSelect
            // 
            this.cbGatheringSelect.FormattingEnabled = true;
            this.cbGatheringSelect.Items.AddRange(new object[] {
            "Forest",
            "Desert",
            "Grasslands",
            "Marsh",
            "Mountain"});
            this.cbGatheringSelect.Location = new System.Drawing.Point(130, 278);
            this.cbGatheringSelect.Name = "cbGatheringSelect";
            this.cbGatheringSelect.Size = new System.Drawing.Size(139, 21);
            this.cbGatheringSelect.TabIndex = 1;
            this.cbGatheringSelect.Text = "Select a Gathering Area";
            this.cbGatheringSelect.SelectedIndexChanged += new System.EventHandler(this.cbGatheringSelect_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 512);
            this.Controls.Add(this.cbGatheringSelect);
            this.Controls.Add(this.pbGatheringImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbGatheringImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ilGatheringAreaImages;
        private System.Windows.Forms.PictureBox pbGatheringImage;
        private System.Windows.Forms.ComboBox cbGatheringSelect;
    }
}

