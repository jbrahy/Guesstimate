using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Guesstimate
{
    public class ProjectScopePersister
    {
        public void PersistProjectScope(ProjectScope projectScope, string path)
        {
            var directory = Path.GetDirectoryName(path);

            if (directory == null)
            {
                throw new Exception("Unable to persist project scope to " + path);
            }

            if (!Directory.Exists(directory))
            {
                try
                {
                    Directory.CreateDirectory(directory);
                }
                catch (Exception)
                {
                    throw new Exception("Unable to persist project scope to directory " + directory);
                }
            }

            File.WriteAllText(path, JsonConvert.SerializeObject(projectScope));
        }
    }
}
