using ProjectName.ToolTrigger.TemplatesGenerator.Extensions;
using ProjectName.ToolTrigger.TemplatesGenerator.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectName.ToolTrigger.TemplatesGenerator
{
    static class BuildProjectTemplate
    {
        public static void LoopProjectDirectory(string directory, FolderStructure folder)
        {
            string projectName = directory.Split('\\').Last();

            Console.WriteLine($"Loop Project {directory}");
            VSTemplate vsTemplate = new VSTemplate();
            vsTemplate.Type = "Project";
            vsTemplate.Version = "3.0.0";
            vsTemplate.TemplateData = new VSTemplateTemplateData();
            vsTemplate.TemplateData.Name = projectName;
            vsTemplate.TemplateData.SortOrder = 1000;
            vsTemplate.TemplateData.CreateNewFolder = true;
            vsTemplate.TemplateData.ProvideDefaultName = true;
            vsTemplate.TemplateData.EnableLocationBrowseButton = true;
            vsTemplate.TemplateData.CreateInPlace = true;
            vsTemplate.TemplateData.LocationField = "Enabled";
            vsTemplate.TemplateData.ProjectType = "CSharp";
            vsTemplate.TemplateContent = new VSTemplateTemplateContent();
            vsTemplate.TemplateContent.Project = new VSTemplateTemplateContentProject();

            ProjectContent(vsTemplate, directory);

            string xml = vsTemplate.ToXml();
            string templateFile = $"{directory}\\{projectName}.vstemplate";
            File.WriteAllText(templateFile, xml);
            FolderStructure subFolder = new FolderStructure()
            {
                ProjectName = projectName,
                ProjectTemplateFile = templateFile
            };
            folder.Folders.Add(subFolder);
        }


        private static void ProjectContent(VSTemplate vsTemplate, string currentDirectory)
        {
            VSTemplateTemplateContentProject project = new VSTemplateTemplateContentProject();
            project.ReplaceParameters = true;
            string csProjName = DirectoryExtensions.GetCsProjName(currentDirectory);
            project.TargetFileName = csProjName;
            project.File = csProjName;
            //Lop foolders
            List<VSTemplateTemplateContentProjectFolder> folders = new List<VSTemplateTemplateContentProjectFolder>();
            Console.WriteLine($"Loop {currentDirectory}");
            string[] subSubDirectories = Directory.GetDirectories(currentDirectory);

            foreach (var d in subSubDirectories.Where(a => DirectoryExtensions.IsValidDirectory(a)))
            {
                string[] projectPath = d.Split('\\');
                string folderName = projectPath[projectPath.Length - 1];
                VSTemplateTemplateContentProjectFolder folder = new VSTemplateTemplateContentProjectFolder();
                folder.Name = folderName;
                folder.TargetFolderName = folderName;

                //LoopItems
                List<VSTemplateTemplateContentProjectFolderProjectItem> items = new List<VSTemplateTemplateContentProjectFolderProjectItem>();

                foreach (var item in Directory.GetFiles(d))
                {
                    VSTemplateTemplateContentProjectFolderProjectItem projectItem = new VSTemplateTemplateContentProjectFolderProjectItem();
                    projectItem.ReplaceParameters = true;
                    string[] itempPath = item.Split('\\');
                    string itemName = itempPath[itempPath.Length - 1];
                    projectItem.TargetFileName = itemName;
                    projectItem.Value = itemName;
                    items.Add(projectItem);
                }
                folder.ProjectItem = items.ToArray();
                folders.Add(folder);
                //TODO: this should loop the folders too.

            }
            project.Folder = folders.ToArray();


            //LoopItems
            List<VSTemplateTemplateContentProjectProjectItem> projectItems = new List<VSTemplateTemplateContentProjectProjectItem>();

            foreach (var item in Directory.GetFiles(currentDirectory).Where(a => !a.Contains(".csproj") && !a.Contains(".vstemplate")))
            {
                VSTemplateTemplateContentProjectProjectItem projectItem = new VSTemplateTemplateContentProjectProjectItem();
                projectItem.ReplaceParameters = true;
                string[] itempPath = item.Split('\\');
                string itemName = itempPath[itempPath.Length - 1];
                projectItem.TargetFileName = itemName;
                projectItem.Value = itemName;
                projectItems.Add(projectItem);
            }

            project.ProjectItem = projectItems.ToArray();
            vsTemplate.TemplateContent.Project = project;

        }

    }
}
