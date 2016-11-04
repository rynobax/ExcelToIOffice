using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToIOffice
{
    static class Extensions
    {
        public static bool HasProperty(this object objectToCheck, string propertyName)
        {
            var type = objectToCheck.GetType();
            var found = type.GetProperty(propertyName);
            return found != null;
        }
    }
}
