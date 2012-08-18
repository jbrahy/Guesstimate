using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guesstimate.Properties;

namespace Guesstimate
{
    public partial class ProjectEstimateForm : Form
    {
        public ProjectSession Session { get; set; }

        public ProjectEstimateForm(ProjectSession session)
        {
            Session = session;
            InitializeComponent();

            UpdateAndShow();
        }

        private void ManageProjectScopeButtonClick(object sender, EventArgs e)
        {
            var projectScopeForm = new ProjectScopeForm(this, Session);

            projectScopeForm.UpdateAndShow();
            Hide();
        }

        public void UpdateAndShow()
        {
            if (Session.ProjectScope.Tasks.Count == 0)
            {
                qaMin.Text = qaMax.Text = rdMin.Text = rdMax.Text = developmentMin.Text = developmentMax.Text = "-";
            }
            else
            {
                decimal minTotalQA = 0;
                decimal maxTotalQA = 0;
                decimal minTotalRd = 0;
                decimal maxTotalRd = 0;
                decimal minTotalDevelopment = 0;
                decimal maxTotalDevelopment = 0;

                foreach (var projectTask in Session.ProjectScope.Tasks)
                {
                    minTotalQA += projectTask.QAMinMax.MinHours;
                    maxTotalQA += projectTask.QAMinMax.MaxHours;
                    minTotalDevelopment += projectTask.DevelopmentMinMax.MinHours;
                    maxTotalDevelopment += projectTask.DevelopmentMinMax.MaxHours;
                    minTotalRd += projectTask.ResearchMinMax.MinHours;
                    maxTotalRd += projectTask.ResearchMinMax.MaxHours;
                }

                qaMin.Text = minTotalQA.ToString(CultureInfo.InvariantCulture);
                qaMax.Text = maxTotalQA.ToString(CultureInfo.InvariantCulture);
                rdMin.Text = minTotalRd.ToString(CultureInfo.InvariantCulture);
                rdMax.Text = maxTotalRd.ToString(CultureInfo.InvariantCulture);
                developmentMin.Text = minTotalDevelopment.ToString(CultureInfo.InvariantCulture);
                developmentMax.Text = maxTotalDevelopment.ToString(CultureInfo.InvariantCulture);
            }

            Show();
        }

        private void SaveGuesstimationProjectButtonClick(object sender, EventArgs e)
        {
            ShowSaveDialog();
        }

        private void ShowSaveDialog()
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = Resources.ProjectEstimateForm_SaveGuesstimationProjectFilter;
            saveDialog.Title = Resources.ProjectEstimateForm_SaveGuesstimationProject;
            saveDialog.ShowDialog();

            // Get the path from their input.
            var path = saveDialog.FileName;

            if (path == "")
            {
                return;
            }

            try
            {
                Session.ProjectScopePersister.PersistProjectScope(Session.ProjectScope, path);
            }
            catch (Exception)
            {
                throw new Exception("You do not have permission to save to " + path);
            }
        }

        private void LoadGuesstimationProjectButtonClick(object sender, EventArgs e)
        {
            var shouldLoad = BeforeLoadingNewProject();

            if(!shouldLoad)
            {
                return;
            }

            var openDialog = new OpenFileDialog();
            openDialog.Filter = Resources.ProjectEstimateForm_LoadGuesstimationProjectFilter;
            openDialog.Title = Resources.ProjectEstimateForm_LoadGuesstimationProject;
            openDialog.ShowDialog();

            if(openDialog.FileName == "")
            {
                return;
            }

            var projectScope = Session.ProjectScopeLoader.LoadProjectScope(openDialog.FileName);

            Session.ProjectScope = projectScope;

            UpdateAndShow();
        }

        private bool BeforeLoadingNewProject()
        {
            if (Session.ProjectScope.Tasks.Count == 0)
            {
                return true;
            }

            var answer = MessageBox.Show(Resources.ProjectEstimateForm_SaveCurrentGuesstimationProject,
                                             Resources.ProjectEstimateForm_SaveCurrentGuesstimationProjectCaption, MessageBoxButtons.YesNoCancel);

            if (answer == DialogResult.Yes)
            {
                ShowSaveDialog();
                return true;
            }
            
            return answer == DialogResult.No;
        }

        private void ProjectEstimateFormFormClosing(object sender, FormClosingEventArgs e)
        {

            var answer = MessageBox.Show(Resources.ProjectEstimateForm_SaveCurrentGuesstimationProject,
                                             Resources.ProjectEstimateForm_SaveCurrentGuesstimationProjectCaption, MessageBoxButtons.YesNoCancel);

            if (answer == DialogResult.Yes)
            {
                ShowSaveDialog();
                return;
            }
            if(answer == DialogResult.No)
            {
                return;
            }

            e.Cancel = true;
        }

        private void ExportBreakdownButtonClick(object sender, EventArgs e)
        {
            var breakdown = Session.ProjectScope.ToString();

            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "TXT File|.txt";
            saveDialog.Title = "Save Text Breakdown?";
            saveDialog.ShowDialog();

            // Get the path from their input.
            var path = saveDialog.FileName;

            if (path == "")
            {
                return;
            }

            try
            {
                File.WriteAllText(path, breakdown);
            }
            catch (Exception)
            {
                throw new Exception("You do not have permission to save to " + path);
            }
        }
    }
}
