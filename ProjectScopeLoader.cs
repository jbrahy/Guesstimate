using System;
using System.IO;
using Newtonsoft.Json;

namespace Guesstimate
{
    public class ProjectScopeLoader
    {
        // You provide a path to task_templates.json
        public ProjectScope LoadProjectScope(string path)
        {
            if (!File.Exists(path))
            {
                throw new Exception("Project scope file does not exist: " + path);
            }

            ProjectScope projectScope;

            try
            {
                projectScope = JsonConvert.DeserializeObject<ProjectScope>(File.ReadAllText(path));
            }
            catch(Exception)
            {
                throw new Exception("Invalid project scope file format: " + path);
            }

            return projectScope;
        }
    }
}
