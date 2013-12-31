using System.Collections.Generic;

namespace ProjectName.ToolTrigger.TemplatesGenerator.Model
{
    public class ProjectStructure
    {
        public string SolutionFolder { get; set; }
        public string ProjectName { get; set; }
        public string ProjectTemplateFile { get; set; }
        public List<ProjectStructure> Project { get; set; } = new List<ProjectStructure>();
    }
}
