using System;
using System.Collections.Generic;
using System.Linq;

namespace Guesstimate
{
    public class ProjectTaskTemplates
    {
        public List<ProjectTaskTemplate> Templates; 
        
        public ProjectTaskTemplates()
        {
            Templates = new List<ProjectTaskTemplate>();
        }

        public void AddTemplate(ProjectTaskTemplate projectTaskTemplate)
        {
            if(FindTemplate(projectTaskTemplate) != null)
            {
                throw new Exception("Template " + projectTaskTemplate + "already exists in templates");
            }

            Templates.Add(projectTaskTemplate);
        }

        public ProjectTaskTemplate FindTemplate(ProjectTaskTemplate projectTaskTemplate)
        {
            return FindTemplate(projectTaskTemplate.Guid);
        }

        public ProjectTaskTemplate FindTemplate(Guid templateGuid)
        {
            return Templates.FirstOrDefault(template => template.Guid == templateGuid);
        }

        public void RemoveTemplate(ProjectTaskTemplate projectTaskTemplate)
        {
            RemoveTemplate(projectTaskTemplate.Guid);
        }

        public void RemoveTemplate(Guid templateGuid)
        {
            Templates.RemoveAll(template => template.Guid == templateGuid);
        }
    }
}
