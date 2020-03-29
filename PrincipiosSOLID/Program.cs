using System;
using SRP.FileReport;
using SRP.Report;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            var report = new CourseReport();
            var fileSaver = new FileSaver();
            report.AddEntry(new CourseReportEntry() { Name = "Arlington", Rating = 3, Students = 20 });
            report.AddEntry(new CourseReportEntry() { Name = "Jose", Rating = 2, Students = 20 });

            Console.WriteLine(report.ToString());

            fileSaver.SaveToFile(@"Reports", "ResultReport.txt", report);
        }
    }
}
