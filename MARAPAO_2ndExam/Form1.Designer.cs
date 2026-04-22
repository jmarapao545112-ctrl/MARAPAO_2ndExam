namespace MARAPAO_2ndExam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            fontDialog1 = new FontDialog();
            panel1 = new Panel();
            btnAddTask = new Button();
            txtPriority = new TextBox();
            label3 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            lblCountDisplay = new TextBox();
            btnCountSubtask = new Button();
            listBox1 = new ListBox();
            btnAddSubtask = new Button();
            txtSubtaskTitle = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            btnRemove = new Button();
            dgvTasks = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            PriorityLevel = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAddTask);
            panel1.Controls.Add(txtPriority);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 119);
            panel1.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.Location = new Point(129, 80);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(136, 23);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "+ Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click_1;
            // 
            // txtPriority
            // 
            txtPriority.Location = new Point(211, 51);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(173, 23);
            txtPriority.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 33);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 3;
            label3.Text = "Priority (1-5)";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(9, 51);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(173, 23);
            txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 33);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Task Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Add New Task";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCountDisplay);
            panel2.Controls.Add(btnCountSubtask);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(btnAddSubtask);
            panel2.Controls.Add(txtSubtaskTitle);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(12, 137);
            panel2.Name = "panel2";
            panel2.Size = new Size(405, 244);
            panel2.TabIndex = 1;
            // 
            // lblCountDisplay
            // 
            lblCountDisplay.Enabled = false;
            lblCountDisplay.Location = new Point(333, 203);
            lblCountDisplay.Name = "lblCountDisplay";
            lblCountDisplay.Size = new Size(51, 23);
            lblCountDisplay.TabIndex = 10;
            // 
            // btnCountSubtask
            // 
            btnCountSubtask.Location = new Point(21, 202);
            btnCountSubtask.Name = "btnCountSubtask";
            btnCountSubtask.Size = new Size(136, 23);
            btnCountSubtask.TabIndex = 9;
            btnCountSubtask.Text = "Count Subtask";
            btnCountSubtask.UseVisualStyleBackColor = true;
            btnCountSubtask.Click += btnCountSubtask_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(21, 87);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(363, 109);
            listBox1.TabIndex = 8;
            // 
            // btnAddSubtask
            // 
            btnAddSubtask.Location = new Point(119, 58);
            btnAddSubtask.Name = "btnAddSubtask";
            btnAddSubtask.Size = new Size(136, 23);
            btnAddSubtask.TabIndex = 6;
            btnAddSubtask.Text = "+ Add Subtask";
            btnAddSubtask.UseVisualStyleBackColor = true;
            btnAddSubtask.Click += btnAddSubtask_Click;
            // 
            // txtSubtaskTitle
            // 
            txtSubtaskTitle.Location = new Point(10, 29);
            txtSubtaskTitle.Name = "txtSubtaskTitle";
            txtSubtaskTitle.Size = new Size(374, 23);
            txtSubtaskTitle.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 11);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 7;
            label5.Text = "Subtasks";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRemove);
            panel3.Controls.Add(dgvTasks);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(423, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(349, 369);
            panel3.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(178, 304);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(150, 23);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove Task";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Columns.AddRange(new DataGridViewColumn[] { Id, Title, PriorityLevel });
            dgvTasks.Location = new Point(25, 25);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(303, 273);
            dgvTasks.TabIndex = 7;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.Width = 150;
            // 
            // PriorityLevel
            // 
            PriorityLevel.HeaderText = "Priority Level";
            PriorityLevel.Name = "PriorityLevel";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(25, 304);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(147, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search Task by ID";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 7);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 6;
            label4.Text = "Task Queue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private FontDialog fontDialog1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnAddTask;
        private TextBox txtPriority;
        private Label label3;
        private TextBox txtTitle;
        private Label label2;
        private Label label5;
        private Label label4;
        private Button btnRemove;
        private Button btnSearch;
        private ListBox listBox1;
        private Button btnAddSubtask;
        private TextBox txtSubtaskTitle;
        private DataGridView dgvTasks;
        private TextBox lblCountDisplay;
        private Button btnCountSubtask;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn PriorityLevel;
    }
}
