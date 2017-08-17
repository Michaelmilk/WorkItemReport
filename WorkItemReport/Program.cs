using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TfsReport;

namespace WorkItemReport
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkItemReportGenerator.GenerateCompletedWorkItemsReport();
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
