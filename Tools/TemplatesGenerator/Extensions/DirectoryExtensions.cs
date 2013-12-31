using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ProjectName.ToolTrigger.TemplatesGenerator.Extensions
{
    public static class DirectoryExtensions
    {
        public static bool IsProject(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            if (!files.Any(a => a.Contains(".csproj")))
            {
                return false;
            }
            Console.WriteLine("ProjectFound");
            return true;
        }


        public static bool IsValidDirectory(string name)
        {
            List<string> ignoredDirectories = new List<string> {"bin",
                                  "obj",
                                  ".idea",
                                  ".vs"};

            foreach (string ignored in ignoredDirectories)
            {
                if (name.Contains(ignored))
                {
                    return false;
                }
            }
            return true;
        }

        public static string GetCsProjName(string directory)
        {
            string[] files = Directory.GetFiles(directory);
            return files.FirstOrDefault(a => a.Contains(".csproj")).Split("\\").Last() ??
            throw new InvalidProgramException("there shoudl be a .csproj in here");
        }
    }
}
