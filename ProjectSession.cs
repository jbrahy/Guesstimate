namespace Guesstimate
{
    public class ProjectSession
    {
        public ProjectTaskTemplatesLoader ProjectTaskTemplatesLoader { get; set; }
        public ProjectTaskTemplatesPersister ProjectTaskTemplatesPersister { get; set; }
        public ProjectScopeLoader ProjectScopeLoader { get; set; }
        public ProjectScopePersister ProjectScopePersister { get; set; }
        public ProjectTaskTemplates ProjectTaskTemplates { get; set; }
        public ProjectScope ProjectScope { get; set; }

        public string TemplatesPath { get; set; }

        public ProjectSession(string templatesPath, ProjectTaskTemplatesLoader projectTaskTemplatesLoader, ProjectTaskTemplatesPersister projectTaskTemplatesPersister, ProjectScopeLoader projectScopeLoader, ProjectScopePersister projectScopePersister, ProjectTaskTemplates projectTaskTemplates, ProjectScope projectScope)
        {
            TemplatesPath = templatesPath;
            ProjectTaskTemplatesLoader = projectTaskTemplatesLoader;
            ProjectTaskTemplatesPersister = projectTaskTemplatesPersister;
            ProjectScopeLoader = projectScopeLoader;
            ProjectScopePersister = projectScopePersister;
            ProjectTaskTemplates = projectTaskTemplates;
            ProjectScope = projectScope;
        }
    }
}
