using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MARAPAO_2ndExam
{
    public partial class Form1 : Form
    {
        // SECTION 1.2: Collection Choice (Queue for exact chronological order)
        private Queue<AbstractTask> taskQueue = new Queue<AbstractTask>();
        private int idCounter = 1;

        public Form1()
        {
            InitializeComponent();
        }

        // Action: "+ Add Task" Button
        private void btnAddTask_Click_1(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text;
                int priority = int.Parse(txtPriority.Text);

                var newTask = new ProjectTask(idCounter++, title, priority);
                taskQueue.Enqueue(newTask); // Add to Queue (FIFO)
                UpdateTable();

                txtTitle.Clear();
                txtPriority.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Priority must be 1–5"); 
            }
        }

        // Action: "+ Add Subtask" Button
        private void btnAddSubtask_Click(object sender, EventArgs e)
        {
            var parentTask = GetSelectedTask();
            if (parentTask != null && !string.IsNullOrWhiteSpace(txtSubtaskTitle.Text))
            {
                parentTask.SubTasks.Add(new ProjectTask(0, txtSubtaskTitle.Text, 1));
                listBox1.Items.Add(txtSubtaskTitle.Text);
                txtSubtaskTitle.Clear();
            }
            else
            {
                MessageBox.Show("Please select a task from the Queue first.");
            }
        }

        // Action: "Count Subtask" Button
        private void btnCountSubtask_Click_1(object sender, EventArgs e)
        {
            var selectedTask = GetSelectedTask();
            if (selectedTask != null)
            {
                int total = TaskUtility.countAllSubTasks(selectedTask);
                lblCountDisplay.Text = total.ToString(); 
            }
        }

        // Action: "Search Task by ID" Button
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Task ID to find:", "Linear Search");
            if (int.TryParse(input, out int id))
            {
                var result = TaskUtility.calculateTotalWorkload(taskQueue, id);
                if (result != null)
                    MessageBox.Show($"Found: {result.Title}\nPriority: {result.Priority}");
                else
                    MessageBox.Show("Task not found.");
            }
        }

        // Action: "Remove Task" Button
        private void btnRemove_Click_1(object sender, EventArgs e)
        {

            if (taskQueue.Count > 0)
            {
                int highestPriority = taskQueue.Max(t => t.Priority);

                var taskToRemove = taskQueue.First(t => t.Priority == highestPriority);
                var remainingTasks = taskQueue.Where(t => t != taskToRemove);
                taskQueue = new Queue<AbstractTask>(remainingTasks);

                UpdateTable();
                listBox1.Items.Clear();
                lblCountDisplay.Text = "0";

                MessageBox.Show($"Removed Task: {taskToRemove.Title} (Priority: {taskToRemove.Priority})");
            }
            else
            {
                MessageBox.Show("The queue is empty.");
            }
        }

        private void UpdateTable()
        {
            dgvTasks.Rows.Clear();
            foreach (var t in taskQueue)
            {
                int rowIndex = dgvTasks.Rows.Add(t.Id, t.Title, t.Priority);
                dgvTasks.Rows[rowIndex].Tag = t; 
            }
        }

        private AbstractTask GetSelectedTask()
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                return (AbstractTask)dgvTasks.SelectedRows[0].Tag;
            }
            return null;
        }

        // Action: Update Subtask List when clicking different rows
        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            lblCountDisplay.Text = "0"; 

            var selectedTask = GetSelectedTask();

            if (selectedTask != null)
            {
                foreach (var subtask in selectedTask.SubTasks)
                {
                    listBox1.Items.Add(subtask.Title);
                }
            }
        }
    }
}