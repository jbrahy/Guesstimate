using System;

namespace Guesstimate
{
    public class ProjectTaskTemplate
    {
        public Guid Guid { get; set; }
        public string TaskTitle { get; set; }
        public ProjectTaskMinMax TaskResearchMinMax { get; set; }
        public ProjectTaskMinMax TaskDevelopmentMinMax { get; set; }
        public ProjectTaskMinMax TaskQAMinMax { get; set; }

        public ProjectTaskTemplate(string taskTitle, ProjectTaskMinMax taskResearchMinMax, ProjectTaskMinMax taskDevelopmentMinMax, ProjectTaskMinMax taskQAMinMax)
        {
            TaskTitle = taskTitle;
            TaskResearchMinMax = taskResearchMinMax;
            TaskDevelopmentMinMax = taskDevelopmentMinMax;
            TaskQAMinMax = taskQAMinMax;
            Guid = Guid.NewGuid();
        }

        public ProjectTask Generate()
        {
            var projectTask = new ProjectTask(TaskTitle, TaskResearchMinMax, TaskDevelopmentMinMax, TaskQAMinMax);

            return projectTask;
        }

        public override string ToString()
        {
            return TaskTitle;
        }
    }
}
