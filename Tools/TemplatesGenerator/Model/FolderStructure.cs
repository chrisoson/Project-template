using System.Collections.Generic;

namespace ProjectName.ToolTrigger.TemplatesGenerator.Model
{
    public class FolderStructure
    {
        public string SolutionFolder { get; set; }
        public string ProjectName { get; set; }
        public string ProjectTemplateFile { get; set; }
        public List<FolderStructure> Folders { get; set; } = new List<FolderStructure>();
    }
}
