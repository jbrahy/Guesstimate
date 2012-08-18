using System;

namespace Guesstimate
{
    public class ProjectTask
    {
        public string Title { get; set; }
        public ProjectTaskMinMax ResearchMinMax { get; set; }
        public ProjectTaskMinMax DevelopmentMinMax { get; set; }
        public ProjectTaskMinMax QAMinMax { get; set; }
        public Guid Guid;

        public ProjectTask(string title, ProjectTaskMinMax researchMinMax, ProjectTaskMinMax developmentMinMax, ProjectTaskMinMax qaMinMax)
        {
            Title = title;
            ResearchMinMax = researchMinMax;
            DevelopmentMinMax = developmentMinMax;
            QAMinMax = qaMinMax;
            Guid = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
