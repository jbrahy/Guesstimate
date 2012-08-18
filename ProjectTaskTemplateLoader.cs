using System.IO;
using Newtonsoft.Json;

namespace Guesstimate
{
    public class ProjectTaskTemplatesLoader
    {
        // You provide a path to task_templates.json
        public ProjectTaskTemplates LoadTemplates(string path)
        {
            if(!File.Exists(path))
            {
                return new ProjectTaskTemplates();
            }

            var templates = JsonConvert.DeserializeObject<ProjectTaskTemplates>(File.ReadAllText(path)) ??
                            new ProjectTaskTemplates();

            return templates;
        }
    }
}
