﻿using ProjectName.ToolTrigger.TemplatesGenerator.Extensions;
using ProjectName.ToolTrigger.TemplatesGenerator.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectName.ToolTrigger.TemplatesGenerator
{
    public static class BuildMainTemplate
    {

        public static void Execute(string baseDirectory, List<ProjectStructure> folderStructure)
        {

            //HERE DO THE MAIN vstemplate
            Console.WriteLine("Main VSTemplate");
            VSTemplate vsTemplate = new VSTemplate();
            vsTemplate.Version = "3.0.0";
            vsTemplate.Type = "ProjectGroup";
            vsTemplate.TemplateData = new VSTemplateTemplateData();
            vsTemplate.TemplateData.Name = "BackEnd Project"; //TODO: Change Name
            vsTemplate.TemplateData.ProjectType = "CSharp";
            vsTemplate.TemplateData.Description = "BackEnd Project"; // TODO: change
            vsTemplate.TemplateData.Icon = "templateIcon.png";
            vsTemplate.TemplateContent = new VSTemplateTemplateContent();
            List<VSTemplateTemplateContentProjectCollection> projects = new List<VSTemplateTemplateContentProjectCollection>();
            VSTemplateTemplateContentProjectCollection project = new VSTemplateTemplateContentProjectCollection();

            List<VSTemplateTemplateContentProjectCollectionProjectTemplateLink> templates = new List<VSTemplateTemplateContentProjectCollectionProjectTemplateLink>();
            //TODO:fix this to loop subfolders properly
            List<VSTemplateTemplateContentProjectCollectionSolutionFolder> folders = new List<VSTemplateTemplateContentProjectCollectionSolutionFolder>();
            foreach(var folder in folderStructure)//.SelectMany(a=>a.Project)
            {

                VSTemplateTemplateContentProjectCollectionSolutionFolder solutionFolder =new VSTemplateTemplateContentProjectCollectionSolutionFolder();
                solutionFolder.Name = folder.SolutionFolder;
                List<VSTemplateTemplateContentProjectCollectionSolutionFolderProjectTemplateLink> templateProjecs = 
                 new List<VSTemplateTemplateContentProjectCollectionSolutionFolderProjectTemplateLink>();


                foreach(var subProject in folder.Project)
                {
                    VSTemplateTemplateContentProjectCollectionSolutionFolderProjectTemplateLink sb = new VSTemplateTemplateContentProjectCollectionSolutionFolderProjectTemplateLink()
                    {
                        ProjectName = subProject.ProjectName.Replace("ProjectName", "$projectname$"),
                        Value = subProject.ProjectTemplateFile.Replace($"{baseDirectory}\\", "")
                    };
                    templateProjecs.Add(sb);
                }

                solutionFolder.ProjectTemplateLink = templateProjecs.ToArray();

                //VSTemplateTemplateContentProjectCollectionProjectTemplateLink template = new VSTemplateTemplateContentProjectCollectionProjectTemplateLink()
                //{
                //    ProjectName = folder.ProjectName.Replace("ProjectName", "$projectname$"),
                //    Value = folder.ProjectTemplateFile.Replace($"{baseDirectory}\\", "")
                //};
                //templates.Add(template);
                folders.Add(solutionFolder);
            }

            project.ProjectTemplateLink = templates.ToArray();

            project.SolutionFolder = folders.ToArray();

            projects.Add(project);
            vsTemplate.TemplateContent.ProjectCollection = projects.ToArray();


            string xml = vsTemplate.ToXml();
            string templateFile = $"{baseDirectory}\\myProject.vstemplate";
            File.WriteAllText(templateFile, xml);
        }
    }
}
