using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProjectName.ToolTrigger.TemplatesGenerator.Extensions;
using ProjectName.ToolTrigger.TemplatesGenerator.Model;

namespace ProjectName.ToolTrigger.TemplatesGenerator
{
    public class TemplateGenerator
    {
        private readonly string _baseDirectory;

        public TemplateGenerator(string baseDirectory)
        {
            _baseDirectory = baseDirectory;
        }

        /// <summary>
        /// Version 1, do not mind to much the code, it has to be refined an refactored.
        /// Its is not fully functionall at the moment.
        /// </summary>
        public void Execute()
        {

            Console.WriteLine("Lets generate the Template!");
            Console.WriteLine($"Loop Directories in {_baseDirectory}");
            string[] subDirectories = Directory.GetDirectories(_baseDirectory);
            List<ProjectStructure> folderStructure = new List<ProjectStructure>();
            foreach (string directory in subDirectories.Where(a => DirectoryExtensions.IsValidDirectory(a)))
            {
                ProjectStructure folder = new ProjectStructure()
                {
                    SolutionFolder = directory.Split('\\').Last()
                };
                LoopProjectSubDirectory(directory, folder);
                folderStructure.Add(folder);
            }

            BuildMainTemplate.Execute(_baseDirectory, folderStructure);
        }

        private void LoopProjectSubDirectory(string directory, ProjectStructure folder)
        {
            Console.WriteLine($"Loop {directory}");
            string[] subSubDirectories = Directory.GetDirectories(directory);
            foreach (var d in subSubDirectories.Where(a => DirectoryExtensions.IsValidDirectory(a)))
            {

                LoopDirectory(d, folder);

            }

        }
        private void LoopDirectory(string directory, ProjectStructure folder)
        {
            Console.WriteLine($"Loop {directory}");
            if (DirectoryExtensions.IsProject(directory))
            {
                BuildProjectTemplate.LoopProjectDirectory(directory, folder);
            }
            //LOop Folder (get files)
            LoopProjectSubDirectory(directory, folder);
        }


    }
}
