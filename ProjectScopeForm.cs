using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guesstimate
{
    public partial class ProjectScopeForm : Form
    {
        public ProjectEstimateForm ProjectEstimateForm { get; set; }
        public ProjectSession Session { get; set; }

        public ProjectScopeForm(ProjectEstimateForm projectEstimateForm, ProjectSession session)
        {
            ProjectEstimateForm = projectEstimateForm;
            Session = session;
            InitializeComponent();
        }
        
        private void AddTaskButtonClick(object sender, EventArgs e)
        {
            var addTaskForm = new AddTaskForm(this, Session);

            addTaskForm.UpdateAndShow();

            Hide();
        }

        public void UpdateAndShow()
        {
            UpdateTaskList();

            Show();
        }

        private void ProjectScopeFormFormClosed(object sender, FormClosedEventArgs e)
        {
            // Oh no, we need to bring back the other form, but how? I'll show you.
            ProjectEstimateForm.UpdateAndShow();
        }

        private void EditTaskButtonClick(object sender, EventArgs e)
        {
            var projectTask = (ProjectTask) taskList.SelectedItem;

            if(projectTask == null)
            {
                throw new Exception("No task selected to edit");
            }

            var editTaskForm = new EditTaskForm(projectTask, this, Session);

            editTaskForm.UpdateAndShow();
            Hide();
        }

        private void RemoveTasksButtonClick(object sender, EventArgs e)
        {
            foreach (ProjectTask projectTask in taskList.SelectedItems)
            {
                Session.ProjectScope.RemoveTask(projectTask);
            }

            UpdateTaskList();
        }

        private void UpdateTaskList()
        {
            taskList.Items.Clear();

            foreach (var task in Session.ProjectScope.Tasks)
            {
                taskList.Items.Add(task); // notice how task is a ProjectTask but it can be added to the list? because like java it has a ToString() which works
            }

            taskList.ClearSelected();

            UpdateButtons();
        }

        private void UpdateButtons()
        {
            editTaskButton.Enabled = taskList.SelectedItems.Count == 1;
            removeTasksButton.Enabled = taskList.SelectedItems.Count > 0;
        }

        private void TaskListSelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtons();
        }
    }
}
