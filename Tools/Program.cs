using System;
using ProjectName.ToolTrigger.TemplatesGenerator;

namespace ProjectName.ToolTrigger
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseDirectory = @"C:\repos\ProjectTemplate\src"; //TODO: this should come as an arg.
            TemplateGenerator templateGenerator = new TemplateGenerator(baseDirectory);
            templateGenerator.Execute();

        }
    }
}
