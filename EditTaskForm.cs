using System;
using System.Windows.Forms;
using Guesstimate.Properties;

namespace Guesstimate
{
    public partial class EditTaskForm : Form
    {
        public ProjectTask ProjectTask { get; set; }
        public ProjectScopeForm ProjectScopeForm { get; set; }
        public ProjectSession Session { get; set; }
        public bool AlreadySaved { get; set; }

        public EditTaskForm(ProjectTask projectTask, ProjectScopeForm projectScopeForm, ProjectSession session)
        {
            AlreadySaved = false;
            ProjectTask = projectTask;
            ProjectScopeForm = projectScopeForm;
            Session = session;

            InitializeComponent();
        }

        public void UpdateAndShow()
        {
            taskTitle.Text = ProjectTask.Title;
            rdMin.Value = Math.Round(ProjectTask.ResearchMinMax.MinHours, 2);
            rdMax.Value = Math.Round(ProjectTask.ResearchMinMax.MaxHours, 2);
            developmentMin.Value = Math.Round(ProjectTask.DevelopmentMinMax.MinHours, 2);
            developmentMax.Value = Math.Round(ProjectTask.DevelopmentMinMax.MaxHours, 2);
            qaMin.Value = Math.Round(ProjectTask.QAMinMax.MinHours, 2);
            qaMax.Value = Math.Round(ProjectTask.QAMinMax.MaxHours, 2);

            Show();
        }

        private void AddTaskButtonClick(object sender, EventArgs e)
        {
            Session.ProjectScope.UpdateTask(MakeTaskFromFormValues());
            AlreadySaved = true;
            
            ProjectScopeForm.UpdateAndShow();
            Close();
        }

        private ProjectTask MakeTaskFromFormValues()
        {
            var projectTask = new ProjectTask(taskTitle.Text, new ProjectTaskMinMax(rdMin.Value, rdMax.Value),
                                              new ProjectTaskMinMax(developmentMin.Value, developmentMax.Value),
                                              new ProjectTaskMinMax(qaMin.Value, qaMax.Value));

            projectTask.Guid = ProjectTask.Guid;

            return projectTask;
        }

        private void EditTaskFormClosing(object sender, FormClosingEventArgs e)
        {
            if(AlreadySaved)
            {
                return;
            }

            var answer = MessageBox.Show(Resources.EditTaskForm_SaveChanges, Resources.EditTaskForm_SaveChangesCaption,
                                         MessageBoxButtons.YesNoCancel);

            if(answer == DialogResult.Yes)
            {
                Session.ProjectScope.AddTask(MakeTaskFromFormValues());
                ProjectScopeForm.UpdateAndShow();
                return;
            }
            if(answer == DialogResult.No)
            {
                ProjectScopeForm.UpdateAndShow();
                return;
            }

            e.Cancel = true;
        }

        private void RdMinValueChanged(object sender, EventArgs e)
        {
            if(rdMin.Value <= rdMax.Value)
            {
                return;
            }
            
            rdMax.Value = rdMin.Value;
        }

        private void RdMaxValueChanged(object sender, EventArgs e)
        {
            if(rdMax.Value >= rdMin.Value)
            {
                return;
            }

            rdMin.Value = rdMax.Value;
        }

        private void DevelopmentMinValueChanged(object sender, EventArgs e)
        {
            if (developmentMin.Value <= developmentMax.Value)
            {
                return;
            }

            developmentMax.Value = developmentMin.Value;
        }

        private void DevelopmentMaxValueChanged(object sender, EventArgs e)
        {
            if (developmentMax.Value >= developmentMin.Value)
            {
                return;
            }

            developmentMin.Value = developmentMax.Value;
        }

        private void QAMinValueChanged(object sender, EventArgs e)
        {
            if (qaMin.Value <= qaMax.Value)
            {
                return;
            }

            qaMax.Value = qaMin.Value;
        }

        private void QAMaxValueChanged(object sender, EventArgs e)
        {
            if (qaMax.Value >= qaMin.Value)
            {
                return;
            }

            qaMin.Value = qaMax.Value;
        }
    }
}
