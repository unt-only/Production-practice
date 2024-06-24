using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Plan_sot : Form
    {
        public event EventHandler TaskAdded;

        private List<Task> tasks = new List<Task>();

        public Plan_sot()
        {
            InitializeComponent();
        }
        public List<Task> GetTasks()
        {
            return tasks;
        }
        private void buttonAddTask_Click(object sender, EventArgs e)
        {
            Task newTask = new Task
            {
                Title = textBoxTitle.Text,
                Description = textBoxDescription.Text,
                Deadline = textBoxDeadline.Text,
                Reward = textBoxReward.Text,
                Done = false
            };

            tasks.Add(newTask);

            textBoxTitle.Clear();
            textBoxDescription.Clear();
            textBoxDeadline.Clear();
            textBoxReward.Clear();

            TaskAdded?.Invoke(this, EventArgs.Empty);
        }
    }
}
