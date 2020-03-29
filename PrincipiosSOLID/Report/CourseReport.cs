using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SRP.Report
{
    public class CourseReport
    {
        private readonly List<CourseReportEntry> _entries;

        public CourseReport()
        {
            _entries = new List<CourseReportEntry>();
        }

        public void AddEntry(CourseReportEntry entry) => _entries.Add(entry);
        public void RemoveEntry(CourseReportEntry entry) => _entries.Remove(entry);
        
        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Curso:  {x.Name}, Estudiantes: {x.Students}, Valoración: {x.Rating}"));

    }
}
