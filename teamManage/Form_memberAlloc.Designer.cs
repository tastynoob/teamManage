﻿namespace teamManage
{
    partial class Form_memberAlloc
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
            dgv_data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            SuspendLayout();
            // 
            // dgv_data
            // 
            dgv_data.AllowUserToAddRows = false;
            dgv_data.AllowUserToDeleteRows = false;
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new Point(12, 12);
            dgv_data.MultiSelect = false;
            dgv_data.Name = "dgv_data";
            dgv_data.RowHeadersWidth = 51;
            dgv_data.RowTemplate.Height = 29;
            dgv_data.Size = new Size(776, 426);
            dgv_data.TabIndex = 0;
            dgv_data.CellValueChanged += dgv_data_CellValueChanged;
            // 
            // Form_memberAlloc
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgv_data);
            Name = "Form_memberAlloc";
            Text = "Form_memberAlloc";
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_data;
    }
}