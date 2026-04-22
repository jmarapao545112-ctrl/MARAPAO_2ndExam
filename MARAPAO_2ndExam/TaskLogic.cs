using System;
using System.Collections.Generic;

namespace MARAPAO_2ndExam
{
    // SECTION 1: Base class using Encapsulation and Inheritance
    public abstract class AbstractTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        private int priority;

        // SECTION 3: Priority validation (1-5)
        public int Priority
        {
            get => priority;
            set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentException("Error: Invalid Priority");
                priority = value;
            }
        }

        public List<AbstractTask> SubTasks { get; set; } = new List<AbstractTask>();

        public AbstractTask(int id, string title, int priority)
        {
            Id = id;
            Title = title;
            Priority = priority;
        }
    }

    public class ProjectTask : AbstractTask
    {
        public ProjectTask(int id, string title, int priority) : base(id, title, priority) { }
    }

    public static class TaskUtility
    {
        // SECTION 1: Linear Search implementation
        public static AbstractTask calculateTotalWorkload(IEnumerable<AbstractTask> tasks, int id)
        {
            foreach (var task in tasks)
            {
                if (task.Id == id) return task;
            }
            return null;
        }

        // SECTION 2: Recursive function to count sub-tasks
        public static int countAllSubTasks(AbstractTask t)
        {
            if (t.SubTasks.Count == 0) return 0; // Base Case

            int count = t.SubTasks.Count;
            foreach (var sub in t.SubTasks)
            {
                count += countAllSubTasks(sub); // Recursive Step
            }
            return count;
        }
    }
}