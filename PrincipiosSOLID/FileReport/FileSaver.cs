using SRP.Report;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SRP.FileReport
{
    public class FileSaver
    {
        public void SaveToFile(string directoryPath, string fileName, CourseReport report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
