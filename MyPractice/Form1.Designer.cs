﻿namespace MyPractice
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
            this.dgView = new System.Windows.Forms.DataGridView();
            this.dtExpired = new System.Windows.Forms.DateTimePicker();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.txtDesign2 = new System.Windows.Forms.TextBox();
            this.txtItem2 = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtDesign = new System.Windows.Forms.TextBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtcSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Location = new System.Drawing.Point(142, 437);
            this.dgView.Name = "dgView";
            this.dgView.Size = new System.Drawing.Size(309, 150);
            this.dgView.TabIndex = 39;
            // 
            // dtExpired
            // 
            this.dtExpired.Location = new System.Drawing.Point(195, 339);
            this.dtExpired.Name = "dtExpired";
            this.dtExpired.Size = new System.Drawing.Size(193, 20);
            this.dtExpired.TabIndex = 38;
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(195, 306);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 21);
            this.cbColor.TabIndex = 37;
            // 
            // txtDesign2
            // 
            this.txtDesign2.Location = new System.Drawing.Point(195, 278);
            this.txtDesign2.Name = "txtDesign2";
            this.txtDesign2.Size = new System.Drawing.Size(100, 20);
            this.txtDesign2.TabIndex = 36;
            // 
            // txtItem2
            // 
            this.txtItem2.Location = new System.Drawing.Point(195, 245);
            this.txtItem2.Name = "txtItem2";
            this.txtItem2.Size = new System.Drawing.Size(100, 20);
            this.txtItem2.TabIndex = 35;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(195, 206);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 34;
            // 
            // txtDesign
            // 
            this.txtDesign.Location = new System.Drawing.Point(195, 139);
            this.txtDesign.Name = "txtDesign";
            this.txtDesign.Size = new System.Drawing.Size(100, 20);
            this.txtDesign.TabIndex = 33;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(195, 102);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(100, 20);
            this.txtItem.TabIndex = 32;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(404, 391);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 31;
            this.BtnDelete.Text = "de&lete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(270, 391);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 30;
            this.BtnUpdate.Text = "up&date";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(142, 391);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 29;
            this.BtnSave.Text = "sa&ve";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtcSearch
            // 
            this.BtcSearch.Location = new System.Drawing.Point(313, 97);
            this.BtcSearch.Name = "BtcSearch";
            this.BtcSearch.Size = new System.Drawing.Size(75, 23);
            this.BtcSearch.TabIndex = 28;
            this.BtcSearch.Text = "Sear&ch";
            this.BtcSearch.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Expired Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(119, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Color";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Design";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Item Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Product ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Design";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Item Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mater Product";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 638);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.dtExpired);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.txtDesign2);
            this.Controls.Add(this.txtItem2);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtDesign);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtcSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DateTimePicker dtExpired;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.TextBox txtDesign2;
        private System.Windows.Forms.TextBox txtItem2;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtDesign;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtcSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
