namespace teamManage
{
    partial class MainForm
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
            dgv_main = new DataGridView();
            btn_allproject = new Button();
            btn_allmember = new Button();
            btn_taskAlloc = new Button();
            btn_alltask = new Button();
            btn_readdoc = new Button();
            btn_memberAlloc = new Button();
            label_permission = new Label();
            btn_report = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_main).BeginInit();
            SuspendLayout();
            // 
            // dgv_main
            // 
            dgv_main.AllowUserToAddRows = false;
            dgv_main.AllowUserToDeleteRows = false;
            dgv_main.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_main.Location = new Point(12, 110);
            dgv_main.Name = "dgv_main";
            dgv_main.RowHeadersWidth = 51;
            dgv_main.RowTemplate.Height = 29;
            dgv_main.Size = new Size(776, 328);
            dgv_main.TabIndex = 0;
            dgv_main.CellEndEdit += dgv_main_CellEndEdit;
            // 
            // btn_allproject
            // 
            btn_allproject.Location = new Point(12, 12);
            btn_allproject.Name = "btn_allproject";
            btn_allproject.Size = new Size(94, 29);
            btn_allproject.TabIndex = 1;
            btn_allproject.Text = "所有项目";
            btn_allproject.UseVisualStyleBackColor = true;
            btn_allproject.Click += btn_allproject_Click;
            // 
            // btn_allmember
            // 
            btn_allmember.Location = new Point(12, 58);
            btn_allmember.Name = "btn_allmember";
            btn_allmember.Size = new Size(94, 29);
            btn_allmember.TabIndex = 3;
            btn_allmember.Text = "所有人员";
            btn_allmember.UseVisualStyleBackColor = true;
            btn_allmember.Click += btn_allmember_Click;
            // 
            // btn_taskAlloc
            // 
            btn_taskAlloc.Location = new Point(212, 31);
            btn_taskAlloc.Name = "btn_taskAlloc";
            btn_taskAlloc.Size = new Size(94, 29);
            btn_taskAlloc.TabIndex = 5;
            btn_taskAlloc.Text = "任务管理";
            btn_taskAlloc.UseVisualStyleBackColor = true;
            btn_taskAlloc.Click += btn_taskAlloc_Click;
            // 
            // btn_alltask
            // 
            btn_alltask.Location = new Point(112, 31);
            btn_alltask.Name = "btn_alltask";
            btn_alltask.Size = new Size(94, 29);
            btn_alltask.TabIndex = 6;
            btn_alltask.Text = "所有任务";
            btn_alltask.UseVisualStyleBackColor = true;
            btn_alltask.Click += btn_alltask_Click;
            // 
            // btn_readdoc
            // 
            btn_readdoc.Location = new Point(412, 31);
            btn_readdoc.Name = "btn_readdoc";
            btn_readdoc.Size = new Size(94, 29);
            btn_readdoc.TabIndex = 7;
            btn_readdoc.Text = "查看文档";
            btn_readdoc.UseVisualStyleBackColor = true;
            btn_readdoc.Click += btn_readdoc_Click;
            // 
            // btn_memberAlloc
            // 
            btn_memberAlloc.Location = new Point(312, 31);
            btn_memberAlloc.Name = "btn_memberAlloc";
            btn_memberAlloc.Size = new Size(94, 29);
            btn_memberAlloc.TabIndex = 8;
            btn_memberAlloc.Text = "人员分配";
            btn_memberAlloc.UseVisualStyleBackColor = true;
            btn_memberAlloc.Click += btn_memberAlloc_Click;
            // 
            // label_permission
            // 
            label_permission.AutoSize = true;
            label_permission.Location = new Point(441, 67);
            label_permission.Name = "label_permission";
            label_permission.Size = new Size(53, 20);
            label_permission.TabIndex = 4;
            label_permission.Text = "label2";
            // 
            // btn_report
            // 
            btn_report.Location = new Point(512, 31);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(94, 29);
            btn_report.TabIndex = 9;
            btn_report.Text = "每周报告";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_report);
            Controls.Add(btn_memberAlloc);
            Controls.Add(btn_readdoc);
            Controls.Add(btn_alltask);
            Controls.Add(btn_taskAlloc);
            Controls.Add(label_permission);
            Controls.Add(btn_allmember);
            Controls.Add(btn_allproject);
            Controls.Add(dgv_main);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgv_main).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_main;
        private Button btn_allproject;
        private Button btn_allmember;
        private Button btn_taskAlloc;
        private Button btn_alltask;
        private Button btn_readdoc;
        private Button btn_memberAlloc;
        private Label label_permission;
        private Button btn_report;
    }
}