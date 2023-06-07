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
            label1 = new Label();
            btn_allmember = new Button();
            label_permission = new Label();
            btn_memberAlloc = new Button();
            btn_alltask = new Button();
            btn_readdoc = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_main).BeginInit();
            SuspendLayout();
            // 
            // dgv_main
            // 
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(441, 12);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 2;
            label1.Text = "label1";
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
            // label_permission
            // 
            label_permission.AutoSize = true;
            label_permission.Location = new Point(441, 67);
            label_permission.Name = "label_permission";
            label_permission.Size = new Size(53, 20);
            label_permission.TabIndex = 4;
            label_permission.Text = "label2";
            // 
            // btn_memberAlloc
            // 
            btn_memberAlloc.Location = new Point(238, 31);
            btn_memberAlloc.Name = "btn_memberAlloc";
            btn_memberAlloc.Size = new Size(94, 29);
            btn_memberAlloc.TabIndex = 5;
            btn_memberAlloc.Text = "任务管理";
            btn_memberAlloc.UseVisualStyleBackColor = true;
            btn_memberAlloc.Click += btn_memberAlloc_Click;
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
            btn_readdoc.Location = new Point(666, 31);
            btn_readdoc.Name = "btn_readdoc";
            btn_readdoc.Size = new Size(94, 29);
            btn_readdoc.TabIndex = 7;
            btn_readdoc.Text = "查看文档";
            btn_readdoc.UseVisualStyleBackColor = true;
            btn_readdoc.Click += btn_readdoc_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_readdoc);
            Controls.Add(btn_alltask);
            Controls.Add(btn_memberAlloc);
            Controls.Add(label_permission);
            Controls.Add(btn_allmember);
            Controls.Add(label1);
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
        private Label label1;
        private Button btn_allmember;
        private Label label_permission;
        private Button btn_memberAlloc;
        private Button btn_alltask;
        private Button btn_readdoc;
    }
}