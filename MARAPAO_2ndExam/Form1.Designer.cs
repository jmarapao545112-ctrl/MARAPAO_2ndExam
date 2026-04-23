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
            label6 = new Label();
            label5 = new Label();
            lblCountDisplay = new TextBox();
            btnCountSubtask = new Button();
            listBox1 = new ListBox();
            btnAddSubtask = new Button();
            txtSubtaskTitle = new TextBox();
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
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(btnAddTask);
            panel1.Controls.Add(txtPriority);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 16);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(463, 183);
            panel1.TabIndex = 0;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.PowderBlue;
            btnAddTask.Location = new Point(147, 121);
            btnAddTask.Margin = new Padding(3, 4, 3, 4);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(160, 40);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "+ Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += btnAddTask_Click_1;
            // 
            // txtPriority
            // 
            txtPriority.Location = new Point(241, 68);
            txtPriority.Margin = new Padding(3, 4, 3, 4);
            txtPriority.Name = "txtPriority";
            txtPriority.Size = new Size(197, 27);
            txtPriority.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(241, 44);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 3;
            label3.Text = "Priority (1-5)";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(10, 68);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(197, 27);
            txtTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 44);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Task Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 0;
            label1.Text = "Add New Task";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lblCountDisplay);
            panel2.Controls.Add(btnCountSubtask);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(btnAddSubtask);
            panel2.Controls.Add(txtSubtaskTitle);
            panel2.Location = new Point(14, 207);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(463, 392);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(10, 12);
            label6.Name = "label6";
            label6.Size = new Size(81, 23);
            label6.TabIndex = 6;
            label6.Text = "Subtasks";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(10, 49);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 11;
            label5.Text = "Subtask Title";
            // 
            // lblCountDisplay
            // 
            lblCountDisplay.BackColor = Color.LightCyan;
            lblCountDisplay.Enabled = false;
            lblCountDisplay.Location = new Point(381, 329);
            lblCountDisplay.Margin = new Padding(3, 4, 3, 4);
            lblCountDisplay.Name = "lblCountDisplay";
            lblCountDisplay.Size = new Size(58, 27);
            lblCountDisplay.TabIndex = 10;
            // 
            // btnCountSubtask
            // 
            btnCountSubtask.BackColor = Color.PowderBlue;
            btnCountSubtask.Location = new Point(24, 329);
            btnCountSubtask.Margin = new Padding(3, 4, 3, 4);
            btnCountSubtask.Name = "btnCountSubtask";
            btnCountSubtask.Size = new Size(160, 40);
            btnCountSubtask.TabIndex = 9;
            btnCountSubtask.Text = "Count Subtask";
            btnCountSubtask.UseVisualStyleBackColor = false;
            btnCountSubtask.Click += btnCountSubtask_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(23, 173);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(414, 144);
            listBox1.TabIndex = 8;
            // 
            // btnAddSubtask
            // 
            btnAddSubtask.BackColor = Color.PowderBlue;
            btnAddSubtask.Location = new Point(147, 112);
            btnAddSubtask.Margin = new Padding(3, 4, 3, 4);
            btnAddSubtask.Name = "btnAddSubtask";
            btnAddSubtask.Size = new Size(160, 40);
            btnAddSubtask.TabIndex = 6;
            btnAddSubtask.Text = "+ Add Subtask";
            btnAddSubtask.UseVisualStyleBackColor = false;
            btnAddSubtask.Click += btnAddSubtask_Click;
            // 
            // txtSubtaskTitle
            // 
            txtSubtaskTitle.Location = new Point(11, 73);
            txtSubtaskTitle.Margin = new Padding(3, 4, 3, 4);
            txtSubtaskTitle.Name = "txtSubtaskTitle";
            txtSubtaskTitle.Size = new Size(427, 27);
            txtSubtaskTitle.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(btnRemove);
            panel3.Controls.Add(dgvTasks);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(483, 16);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 583);
            panel3.TabIndex = 2;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.IndianRed;
            btnRemove.Location = new Point(222, 469);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(160, 40);
            btnRemove.TabIndex = 10;
            btnRemove.Text = "Remove Task";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Columns.AddRange(new DataGridViewColumn[] { Id, Title, PriorityLevel });
            dgvTasks.Location = new Point(29, 53);
            dgvTasks.Margin = new Padding(3, 4, 3, 4);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(343, 393);
            dgvTasks.TabIndex = 7;
            dgvTasks.SelectionChanged += dgvTasks_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.Width = 162;
            // 
            // PriorityLevel
            // 
            PriorityLevel.HeaderText = "Priority Level";
            PriorityLevel.MinimumWidth = 6;
            PriorityLevel.Name = "PriorityLevel";
            PriorityLevel.Width = 85;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.PowderBlue;
            btnSearch.Location = new Point(29, 469);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 40);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search Task by ID";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 6;
            label4.Text = "Task Queue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(896, 615);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task Management System";
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
        private Label label6;
        private Label label5;
    }
}
