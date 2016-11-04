using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToIOffice
{
    class ExcelUserModel
    {
        public struct FieldInfo
        {
            public string databaseName;
            public int excelColumn;
        }
        private List<FieldInfo> fields;

        public ExcelUserModel()
        {
            fields = new List<FieldInfo>();
        }

        public void addField(string dbName, int exColumn) 
        {
            /* TODO: Add check for out of bounds columns */
            FieldInfo fieldInfo;
            fieldInfo.databaseName = dbName;
            fieldInfo.excelColumn = exColumn;
            fields.Add(fieldInfo);
        }

        public void addField(string dbName, string exColumnStr)
        {
            char[] charArray = exColumnStr.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            int sum = 0;
            int count = 0;
            foreach(char c in reversedString)
            {
                int digitMultiplier = (int)Math.Pow((double)26, (double)count);
                sum += ((int)c % 32)*digitMultiplier;
                count++;
            }
            // 16384 is the max valid column
            addField(dbName, sum);
        }

        public List<FieldInfo> getFields() { return fields; }
    }
}
