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
                MessageBox.Show(ex.Message); // Shows "Error: Invalid Priority" if outside 1-5
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
                lblCountDisplay.Text = total.ToString(); // Shows recursive result
            }
        }

        // Action: "Search Task by ID" Button
        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            // Simple input dialog to get ID
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

            // 1. Find out which task is currently highlighted
            var selectedTask = GetSelectedTask();

            if (selectedTask != null)
            {
                // 2. Keep the Queue requirement, but filter out the task we want to delete
                var remainingTasks = taskQueue.Where(t => t.Id != selectedTask.Id);
                taskQueue = new Queue<AbstractTask>(remainingTasks);

                // 3. Refresh the UI
                UpdateTable();
                listBox1.Items.Clear();
                lblCountDisplay.Text = "0";
            }
            else
            {
                MessageBox.Show("Please select a task from the list to remove.");
            }
        }

        private void UpdateTable()
        {
            dgvTasks.Rows.Clear();
            foreach (var t in taskQueue)
            {
                int rowIndex = dgvTasks.Rows.Add(t.Id, t.Title, t.Priority);
                dgvTasks.Rows[rowIndex].Tag = t; // Store the object in the row tag
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
            // 1. Clear the old subtasks from the screen
            listBox1.Items.Clear();
            lblCountDisplay.Text = "0"; // Reset the count display

            // 2. Get the task that was just clicked
            var selectedTask = GetSelectedTask();

            // 3. If a task is selected, load only its subtasks into the ListBox
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