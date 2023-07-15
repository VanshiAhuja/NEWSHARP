﻿
namespace NEWSHARP
{
    partial class Form2db
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnDbSaveTextFile = new System.Windows.Forms.CheckedListBox();
            this.BtnDbClearData = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnDbLoadDataTxtFile = new System.Windows.Forms.Button();
            this.BtnDbExportwithiID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Table Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(224, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Prd";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(224, 53);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(996, 549);
            this.dataGridView1.TabIndex = 4;
            // 
            // BtnDbSaveTextFile
            // 
            this.BtnDbSaveTextFile.FormattingEnabled = true;
            this.BtnDbSaveTextFile.Location = new System.Drawing.Point(1043, 83);
            this.BtnDbSaveTextFile.Name = "BtnDbSaveTextFile";
            this.BtnDbSaveTextFile.Size = new System.Drawing.Size(301, 304);
            this.BtnDbSaveTextFile.TabIndex = 5;
            // 
            // BtnDbClearData
            // 
            this.BtnDbClearData.BackColor = System.Drawing.Color.Transparent;
            this.BtnDbClearData.FlatAppearance.BorderColor = System.Drawing.Color.DarkViolet;
            this.BtnDbClearData.FlatAppearance.BorderSize = 2;
            this.BtnDbClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDbClearData.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDbClearData.ForeColor = System.Drawing.Color.Black;
            this.BtnDbClearData.Location = new System.Drawing.Point(1043, 408);
            this.BtnDbClearData.Name = "BtnDbClearData";
            this.BtnDbClearData.Size = new System.Drawing.Size(140, 58);
            this.BtnDbClearData.TabIndex = 6;
            this.BtnDbClearData.Text = "Clear Data";
            this.BtnDbClearData.UseVisualStyleBackColor = false;
            this.BtnDbClearData.MouseHover += new System.EventHandler(this.BtnDbClearData_MouseHover);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1204, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save Text";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtnDbLoadDataTxtFile
            // 
            this.BtnDbLoadDataTxtFile.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDbLoadDataTxtFile.Location = new System.Drawing.Point(1043, 482);
            this.BtnDbLoadDataTxtFile.Name = "BtnDbLoadDataTxtFile";
            this.BtnDbLoadDataTxtFile.Size = new System.Drawing.Size(301, 55);
            this.BtnDbLoadDataTxtFile.TabIndex = 8;
            this.BtnDbLoadDataTxtFile.Text = "Load Data";
            this.BtnDbLoadDataTxtFile.UseVisualStyleBackColor = true;
            // 
            // BtnDbExportwithiID
            // 
            this.BtnDbExportwithiID.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDbExportwithiID.Location = new System.Drawing.Point(466, 638);
            this.BtnDbExportwithiID.Name = "BtnDbExportwithiID";
            this.BtnDbExportwithiID.Size = new System.Drawing.Size(221, 29);
            this.BtnDbExportwithiID.TabIndex = 9;
            this.BtnDbExportwithiID.Text = "Export Data ";
            this.BtnDbExportwithiID.UseVisualStyleBackColor = true;
            this.BtnDbExportwithiID.Click += new System.EventHandler(this.BtnDbExportwithiID_Click);
            // 
            // Form2db
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::NEWSHARP.Properties.Resources.bg2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.BtnDbExportwithiID);
            this.Controls.Add(this.BtnDbLoadDataTxtFile);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnDbClearData);
            this.Controls.Add(this.BtnDbSaveTextFile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2db";
            this.Text = "Clear Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox BtnDbSaveTextFile;
        private System.Windows.Forms.Button BtnDbClearData;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnDbLoadDataTxtFile;
        private System.Windows.Forms.Button BtnDbExportwithiID;
    }
}