using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestIntegration.App
{
    public class CustomService
    {
        public CustomRecord GetRecord(int Id)
        {
            string[] names = { "John", "Mark", "George", "Adam" };
            if (Id - 1 > names.Length)
                throw new ArgumentException("Id not found.");

            return new CustomRecord(Id, names[Id]);
        }

        public CustomRecord AddRecord(CustomRecord customRecord)
        {
            return customRecord;
        }
    }
}
