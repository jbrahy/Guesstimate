using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Guesstimate
{
    public class ProjectScope
    {
        public List<ProjectTask> Tasks; 
        
        public ProjectScope()
        {
            Tasks = new List<ProjectTask>();
        }

        public void AddTask(ProjectTask projectTask)
        {
            // what if the task already exists in our scope? we should throw an exception
            if(FindTask(projectTask) != null)
            {
                throw new Exception("Task already exists in project scope");
            }

            Tasks.Add(projectTask);
        }

        private ProjectTask FindTask(ProjectTask projectTask)
        {
            return FindTask(projectTask.Guid);
        }

        // Find task by Guid instead
        private ProjectTask FindTask(Guid taskGuid)
        {
            return Tasks.FirstOrDefault(task => task.Guid == taskGuid);
        }

        public void RemoveTask(ProjectTask projectTask)
        {
            RemoveTask(projectTask.Guid);
        }

        public void RemoveTask(Guid taskGuid)
        {
            Tasks.RemoveAll(task => task.Guid == taskGuid);
        }

        public void UpdateTask(ProjectTask projectTask)
        {
            UpdateTask(projectTask.Guid, projectTask);
        }

        private void UpdateTask(Guid taskGuid, ProjectTask projectTask)
        {
            for(int x = 0; x < Tasks.Count; x++)
            {
                var task = Tasks[x];

                if(task.Guid != taskGuid)
                {
                    continue;
                }

                Tasks[x] = projectTask;
                break;
            }
        }

        public override string ToString()
        {
            string projectScope = "Breakdown of project scope" + Environment.NewLine + "---";

            foreach (var task in Tasks)
            {
                projectScope += Environment.NewLine + Environment.NewLine + task + " (R&D)" + Environment.NewLine + "Minimum Hours: " +
                                task.ResearchMinMax.MinHours.ToString(CultureInfo.InvariantCulture) +
                                Environment.NewLine + "Maximum Hours: " +
                                task.ResearchMinMax.MaxHours.ToString(CultureInfo.InvariantCulture);

                projectScope += Environment.NewLine + Environment.NewLine + task + " (Development Cycle)" + Environment.NewLine + "Minimum Hours: " +
                                task.DevelopmentMinMax.MinHours.ToString(CultureInfo.InvariantCulture) +
                                Environment.NewLine + "Maximum Hours: " +
                                task.DevelopmentMinMax.MaxHours.ToString(CultureInfo.InvariantCulture);

                projectScope += Environment.NewLine + Environment.NewLine + task + " (Q&A Period)" + Environment.NewLine + "Minimum Hours: " +
                                task.QAMinMax.MinHours.ToString(CultureInfo.InvariantCulture) +
                                Environment.NewLine + "Maximum Hours: " +
                                task.QAMinMax.MaxHours.ToString(CultureInfo.InvariantCulture);
            }

            return projectScope;
        }
    }
}
