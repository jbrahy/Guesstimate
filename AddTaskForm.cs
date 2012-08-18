using System;
using System.Windows.Forms;
using Guesstimate.Properties;

namespace Guesstimate
{
    public partial class AddTaskForm : Form
    {
        public ProjectScopeForm ProjectScopeForm { get; set; }
        public ProjectSession Session { get; set; }
        public bool AlreadySaved { get; set; }

        public AddTaskForm(ProjectScopeForm projectScopeForm, ProjectSession session)
        {
            AlreadySaved = false;
            ProjectScopeForm = projectScopeForm;
            Session = session;

            InitializeComponent();
        }

        public void UpdateAndShow()
        {
            taskTemplateList.Items.Clear();

            taskTemplateList.Items.Add(new ProjectTaskTemplate("Blank Template", new ProjectTaskMinMax(0, 0),
                                                               new ProjectTaskMinMax(0, 0), new ProjectTaskMinMax(0, 0)));

            foreach(var taskTemplate in Session.ProjectTaskTemplates.Templates)
            {
                taskTemplateList.Items.Add(taskTemplate);
            }

            var blankTemplate = (ProjectTaskTemplate)taskTemplateList.Items[0];

            taskTemplateList.SelectedItem = blankTemplate;

            TemplateChanged(blankTemplate);

            Show();
        }

        private void TemplateChanged(ProjectTaskTemplate newTemplate)
        {
            taskTitle.Text = newTemplate.TaskTitle;
            rdMin.Value = Math.Round(newTemplate.TaskResearchMinMax.MinHours, 2);
            rdMax.Value = Math.Round(newTemplate.TaskResearchMinMax.MaxHours, 2);
            developmentMin.Value = Math.Round(newTemplate.TaskDevelopmentMinMax.MinHours, 2);
            developmentMax.Value = Math.Round(newTemplate.TaskDevelopmentMinMax.MaxHours, 2);
            qaMin.Value = Math.Round(newTemplate.TaskQAMinMax.MinHours, 2);
            qaMax.Value = Math.Round(newTemplate.TaskQAMinMax.MaxHours, 2);
        }

        private ProjectTaskTemplate MakeTemplateFromFormValues()
        {
            return new ProjectTaskTemplate(taskTitle.Text, new ProjectTaskMinMax(rdMin.Value, rdMax.Value),
                new ProjectTaskMinMax(developmentMin.Value, developmentMax.Value),
                new ProjectTaskMinMax(qaMin.Value, qaMax.Value));
        }

        private void TaskTemplateListSelectedIndexChanged(object sender, EventArgs e)
        {
            TemplateChanged((ProjectTaskTemplate)taskTemplateList.SelectedItem);
        }

        private void AddTaskButtonClick(object sender, EventArgs e)
        {
            Session.ProjectScope.AddTask(MakeTaskFromFormValues());

            AlreadySaved = true;

            ProjectScopeForm.UpdateAndShow();
            Close();
        }

        private ProjectTask MakeTaskFromFormValues()
        {
            return new ProjectTask(taskTitle.Text, new ProjectTaskMinMax(rdMin.Value, rdMax.Value),
                new ProjectTaskMinMax(developmentMin.Value, developmentMax.Value),
                new ProjectTaskMinMax(qaMin.Value, qaMax.Value));
        }

        private void AddTaskFormClosing(object sender, FormClosingEventArgs e)
        {
            if(AlreadySaved)
            {
                return;
            }

            var answer = MessageBox.Show(Resources.AddTaskForm_AddTaskToScope, Resources.AddTaskForm_AddTaskToScopeCaption,
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

        private void SaveTaskAsTemplateButtonClick(object sender, EventArgs e)
        {
            Session.ProjectTaskTemplates.AddTemplate(MakeTemplateFromFormValues());
            Session.ProjectTaskTemplatesPersister.PersistTemplates(Session.ProjectTaskTemplates, Session.TemplatesPath);

            ProjectScopeForm.UpdateAndShow();
            Close();
        }

        private void RdMinValueChanged(object sender, EventArgs e)
        {
            if (rdMin.Value <= rdMax.Value)
            {
                return;
            }

            rdMax.Value = rdMin.Value;
        }

        private void RdMaxValueChanged(object sender, EventArgs e)
        {
            if (rdMax.Value >= rdMin.Value)
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
