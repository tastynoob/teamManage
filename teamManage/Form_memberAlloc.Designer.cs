namespace teamManage
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
            label1 = new Label();
            label_memberStatus = new Label();
            dgv_data = new DataGridView();
            textBox_val = new TextBox();
            btn_search_name = new Button();
            btn_search_task = new Button();
            btn_yourtasks = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_data).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "您的状态";
            // 
            // label_memberStatus
            // 
            label_memberStatus.AutoSize = true;
            label_memberStatus.Location = new Point(87, 9);
            label_memberStatus.Name = "label_memberStatus";
            label_memberStatus.Size = new Size(24, 20);
            label_memberStatus.TabIndex = 1;
            label_memberStatus.Text = "无";
            // 
            // dgv_data
            // 
            dgv_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_data.Location = new Point(12, 169);
            dgv_data.Name = "dgv_data";
            dgv_data.ReadOnly = true;
            dgv_data.RowHeadersWidth = 51;
            dgv_data.RowTemplate.Height = 29;
            dgv_data.Size = new Size(776, 269);
            dgv_data.TabIndex = 2;
            dgv_data.CellContentClick += dgv_data_CellContentClick;
            // 
            // textBox_val
            // 
            textBox_val.BorderStyle = BorderStyle.FixedSingle;
            textBox_val.Location = new Point(12, 125);
            textBox_val.Name = "textBox_val";
            textBox_val.Size = new Size(125, 27);
            textBox_val.TabIndex = 3;
            // 
            // btn_search_name
            // 
            btn_search_name.Location = new Point(143, 123);
            btn_search_name.Name = "btn_search_name";
            btn_search_name.Size = new Size(130, 29);
            btn_search_name.TabIndex = 4;
            btn_search_name.Text = "按人员名称搜索";
            btn_search_name.UseVisualStyleBackColor = true;
            btn_search_name.Click += btn_search_name_Click;
            // 
            // btn_search_task
            // 
            btn_search_task.Location = new Point(279, 125);
            btn_search_task.Name = "btn_search_task";
            btn_search_task.Size = new Size(122, 29);
            btn_search_task.TabIndex = 5;
            btn_search_task.Text = "按任务名称搜索";
            btn_search_task.UseVisualStyleBackColor = true;
            btn_search_task.Click += btn_search_task_Click;
            // 
            // btn_yourtasks
            // 
            btn_yourtasks.Location = new Point(12, 44);
            btn_yourtasks.Name = "btn_yourtasks";
            btn_yourtasks.Size = new Size(116, 29);
            btn_yourtasks.TabIndex = 6;
            btn_yourtasks.Text = "您的任务列表";
            btn_yourtasks.UseVisualStyleBackColor = true;
            btn_yourtasks.Click += btn_yourtasks_Click;
            // 
            // Form_memberAlloc
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_yourtasks);
            Controls.Add(btn_search_task);
            Controls.Add(btn_search_name);
            Controls.Add(textBox_val);
            Controls.Add(dgv_data);
            Controls.Add(label_memberStatus);
            Controls.Add(label1);
            Name = "Form_memberAlloc";
            Text = "Form_memberAlloc";
            ((System.ComponentModel.ISupportInitialize)dgv_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label_memberStatus;
        private DataGridView dgv_data;
        private TextBox textBox_val;
        private Button btn_search_name;
        private Button btn_search_task;
        private Button btn_yourtasks;
    }
}