namespace teamManage
{
    partial class Form_allDoc
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
            btn_select = new Button();
            btn_upload = new Button();
            label_filename = new Label();
            textBox_description = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            SuspendLayout();
            // 
            // dgv_data
            // 
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new Point(12, 147);
            dgv_data.Name = "dgv_data";
            dgv_data.ReadOnly = true;
            dgv_data.RowHeadersWidth = 51;
            dgv_data.RowTemplate.Height = 29;
            dgv_data.Size = new Size(776, 291);
            dgv_data.TabIndex = 0;
            dgv_data.CellContentDoubleClick += dgv_data_CellContentDoubleClick;
            // 
            // btn_select
            // 
            btn_select.Location = new Point(12, 21);
            btn_select.Name = "btn_select";
            btn_select.Size = new Size(107, 29);
            btn_select.TabIndex = 1;
            btn_select.Text = "上传新文档";
            btn_select.UseVisualStyleBackColor = true;
            btn_select.Click += btn_select_Click;
            // 
            // btn_upload
            // 
            btn_upload.Location = new Point(51, 68);
            btn_upload.Name = "btn_upload";
            btn_upload.Size = new Size(68, 28);
            btn_upload.TabIndex = 2;
            btn_upload.Text = "上传";
            btn_upload.UseVisualStyleBackColor = true;
            btn_upload.Click += btn_upload_Click;
            // 
            // label_filename
            // 
            label_filename.AutoSize = true;
            label_filename.Location = new Point(141, 25);
            label_filename.Name = "label_filename";
            label_filename.Size = new Size(84, 20);
            label_filename.TabIndex = 3;
            label_filename.Text = "文件名称：";
            // 
            // textBox_description
            // 
            textBox_description.BorderStyle = BorderStyle.FixedSingle;
            textBox_description.Location = new Point(200, 73);
            textBox_description.Name = "textBox_description";
            textBox_description.Size = new Size(125, 27);
            textBox_description.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(141, 76);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 5;
            label1.Text = "描述";
            // 
            // Form_allDoc
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textBox_description);
            Controls.Add(label_filename);
            Controls.Add(btn_upload);
            Controls.Add(btn_select);
            Controls.Add(dgv_data);
            Name = "Form_allDoc";
            Text = "Form_allDoc";
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_data;
        private Button btn_select;
        private Button btn_upload;
        private Label label_filename;
        private TextBox textBox_description;
        private Label label1;
    }
}