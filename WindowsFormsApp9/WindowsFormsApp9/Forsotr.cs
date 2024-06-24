using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Forsotr : Form
    {
        public Forsotr()
        {
            InitializeComponent();
        }

        public void UpdateTasksList(List<Task> tasks)
        {
            listViewTasks.Items.Clear();

            foreach (Task task in tasks)
            {
                ListViewItem item = new ListViewItem(task.Title);
                item.SubItems.Add(task.Description);
                item.SubItems.Add(task.Deadline);
                item.SubItems.Add(task.Reward);
                item.SubItems.Add(task.Done ? "Done" : "Not Done");
                item.Tag = task;

                listViewTasks.Items.Add(item);
            }
        }

        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                Task selectedTask = (Task)listViewTasks.SelectedItems[0].Tag;
            }
        }

        private void checkBoxDone_CheckedChanged(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                Task selectedTask = (Task)listViewTasks.SelectedItems[0].Tag;
            }
        }
    }

}
