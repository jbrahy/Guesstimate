using System;
using System.IO;
using Newtonsoft.Json;

namespace Guesstimate
{
    public class ProjectTaskTemplatesPersister
    {
        public void PersistTemplates(ProjectTaskTemplates projectTaskTemplates, string path)
        {
            var directory = Path.GetDirectoryName(path);

            if(directory == null)
            {
                throw new Exception("Unable to persist project task templates to " + path);
            }

            if(!Directory.Exists(directory))
            {
                try
                {
                    Directory.CreateDirectory(directory);
                }
                catch(Exception)
                {
                    throw new Exception("Unable to persist project task templates to " + path);
                }
            }

            File.WriteAllText(path, JsonConvert.SerializeObject(projectTaskTemplates));
        }
    }
}
