
namespace NEWSHARP
{
    partial class Form2DataMerge
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnforBackToHomePage = new System.Windows.Forms.Button();
            this.MergeyourData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Simplify your Data ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // BtnforBackToHomePage
            // 
            this.BtnforBackToHomePage.BackColor = System.Drawing.Color.Transparent;
            this.BtnforBackToHomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnforBackToHomePage.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.BtnforBackToHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnforBackToHomePage.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnforBackToHomePage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnforBackToHomePage.Location = new System.Drawing.Point(353, 453);
            this.BtnforBackToHomePage.Name = "BtnforBackToHomePage";
            this.BtnforBackToHomePage.Size = new System.Drawing.Size(261, 47);
            this.BtnforBackToHomePage.TabIndex = 1;
            this.BtnforBackToHomePage.Text = "Back To Home Page";
            this.BtnforBackToHomePage.UseVisualStyleBackColor = false;
            // 
            // MergeyourData
            // 
            this.MergeyourData.BackColor = System.Drawing.Color.DarkViolet;
            this.MergeyourData.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.MergeyourData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MergeyourData.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MergeyourData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MergeyourData.Location = new System.Drawing.Point(692, 453);
            this.MergeyourData.Name = "MergeyourData";
            this.MergeyourData.Size = new System.Drawing.Size(282, 47);
            this.MergeyourData.TabIndex = 2;
            this.MergeyourData.Text = " Merge your Data";
            this.MergeyourData.UseVisualStyleBackColor = false;
            this.MergeyourData.Click += new System.EventHandler(this.MergeyourData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Say goodbye to data management complexitites ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Candara", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label3.Location = new System.Drawing.Point(332, 267);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(2);
            this.label3.Size = new System.Drawing.Size(665, 63);
            this.label3.TabIndex = 4;
            this.label3.Text = " Merge and Convert Effortlessly";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Candara Light", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(739, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "and Effortlessly merge and convert your data with our user-friendly system.";
            // 
            // Form2DataMerge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImage = global::NEWSHARP.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MergeyourData);
            this.Controls.Add(this.BtnforBackToHomePage);
            this.Controls.Add(this.label1);
            this.Name = "Form2DataMerge";
            this.Text = "Form2DataMerge";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnforBackToHomePage;
        private System.Windows.Forms.Button MergeyourData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}