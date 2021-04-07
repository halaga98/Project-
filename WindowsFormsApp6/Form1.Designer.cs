
namespace WindowsFormsApp6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBrowse = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.labelSizeMode = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnStrecth = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnCenter = new System.Windows.Forms.Button();
            this.btnZoom = new System.Windows.Forms.Button();
            this.btnPicPreset = new System.Windows.Forms.Button();
            this.btnUIPreset = new System.Windows.Forms.Button();
            this.btnDrawBorder = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(12, 30);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(318, 20);
            this.txtBrowse.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(336, 27);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // labelSizeMode
            // 
            this.labelSizeMode.AutoSize = true;
            this.labelSizeMode.Location = new System.Drawing.Point(336, 69);
            this.labelSizeMode.Name = "labelSizeMode";
            this.labelSizeMode.Size = new System.Drawing.Size(51, 13);
            this.labelSizeMode.TabIndex = 2;
            this.labelSizeMode.Text = "Size Mod";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Location = new System.Drawing.Point(13, 57);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(320, 180);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // btnNormal
            // 
            this.btnNormal.Location = new System.Drawing.Point(339, 86);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(75, 23);
            this.btnNormal.TabIndex = 4;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnStrecth
            // 
            this.btnStrecth.Location = new System.Drawing.Point(340, 116);
            this.btnStrecth.Name = "btnStrecth";
            this.btnStrecth.Size = new System.Drawing.Size(75, 23);
            this.btnStrecth.TabIndex = 5;
            this.btnStrecth.Text = "Strecth";
            this.btnStrecth.UseVisualStyleBackColor = true;
            this.btnStrecth.Click += new System.EventHandler(this.btnStrecth_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(339, 146);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(75, 23);
            this.btnAuto.TabIndex = 6;
            this.btnAuto.Text = "Auto";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnCenter
            // 
            this.btnCenter.Location = new System.Drawing.Point(340, 176);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(75, 23);
            this.btnCenter.TabIndex = 7;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.Click += new System.EventHandler(this.btnCenter_Click);
            // 
            // btnZoom
            // 
            this.btnZoom.Location = new System.Drawing.Point(340, 206);
            this.btnZoom.Name = "btnZoom";
            this.btnZoom.Size = new System.Drawing.Size(75, 23);
            this.btnZoom.TabIndex = 8;
            this.btnZoom.Text = "Zoom";
            this.btnZoom.UseVisualStyleBackColor = true;
            this.btnZoom.Click += new System.EventHandler(this.btnZoom_Click);
            // 
            // btnPicPreset
            // 
            this.btnPicPreset.Location = new System.Drawing.Point(13, 265);
            this.btnPicPreset.Name = "btnPicPreset";
            this.btnPicPreset.Size = new System.Drawing.Size(75, 23);
            this.btnPicPreset.TabIndex = 9;
            this.btnPicPreset.Text = "Pic Preset";
            this.btnPicPreset.UseVisualStyleBackColor = true;
            this.btnPicPreset.Click += new System.EventHandler(this.btnPicPreset_Click);
            // 
            // btnUIPreset
            // 
            this.btnUIPreset.Location = new System.Drawing.Point(146, 264);
            this.btnUIPreset.Name = "btnUIPreset";
            this.btnUIPreset.Size = new System.Drawing.Size(75, 23);
            this.btnUIPreset.TabIndex = 10;
            this.btnUIPreset.Text = "UI Preset";
            this.btnUIPreset.UseVisualStyleBackColor = true;
            this.btnUIPreset.Click += new System.EventHandler(this.btnUIPreset_Click);
            // 
            // btnDrawBorder
            // 
            this.btnDrawBorder.Location = new System.Drawing.Point(278, 264);
            this.btnDrawBorder.Name = "btnDrawBorder";
            this.btnDrawBorder.Size = new System.Drawing.Size(75, 23);
            this.btnDrawBorder.TabIndex = 11;
            this.btnDrawBorder.Text = "Draw Border";
            this.btnDrawBorder.UseVisualStyleBackColor = true;
            this.btnDrawBorder.Click += new System.EventHandler(this.btnDrawBorder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(200, 311);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(75, 23);
            this.btnResetForm.TabIndex = 12;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnDrawBorder);
            this.Controls.Add(this.btnUIPreset);
            this.Controls.Add(this.btnPicPreset);
            this.Controls.Add(this.btnZoom);
            this.Controls.Add(this.btnCenter);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnStrecth);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelSizeMode);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtBrowse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Picture Viewer-20170301039 Hüseyin Kıldacı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrowse;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label labelSizeMode;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnStrecth;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnCenter;
        private System.Windows.Forms.Button btnZoom;
        private System.Windows.Forms.Button btnPicPreset;
        private System.Windows.Forms.Button btnUIPreset;
        private System.Windows.Forms.Button btnDrawBorder;
        private System.Windows.Forms.Button btnResetForm;
    }
}

