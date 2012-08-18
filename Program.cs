using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Guesstimate
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var configurationDirectory = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "Guesstimate");

            var taskTemplatesPath = Path.Combine(configurationDirectory, "task_templates.json");

            var projectTaskTemplatesLoader = new ProjectTaskTemplatesLoader();

            var taskTemplates = projectTaskTemplatesLoader.LoadTemplates(taskTemplatesPath);

            var templatePersister = new ProjectTaskTemplatesPersister();

            templatePersister.PersistTemplates(taskTemplates, taskTemplatesPath);

            var session = new ProjectSession(taskTemplatesPath, projectTaskTemplatesLoader, templatePersister,
                new ProjectScopeLoader(), new ProjectScopePersister(), taskTemplates, new ProjectScope());

            Application.Run(new ProjectEstimateForm(session));
        }
    }
}
