using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelToIOffice
{
    class JSONBuilder
    {
        private ExcelUserModel userModel;
        private object[,] sheet;
        private int currentRow = 1;
        private int maxRow;

        public JSONBuilder(ExcelManager em, ExcelUserModel um)
        {
            userModel = um;
            sheet = em.getWholeSheet();
            maxRow = sheet.GetLength(0);
        }

        public string getNextUserJson()
        {
            if(currentRow <= maxRow)
            {
                StringBuilder sb = new StringBuilder("{");
                foreach(ExcelUserModel.FieldInfo field in userModel.getFields())
                {
                    string key = field.databaseName;
                    string value = sheet[currentRow, field.excelColumn].ToString();
                    sb.Append("\"");
                    sb.Append(key);
                    sb.Append("\": \"");
                    sb.Append(value);
                    sb.Append("\",");
                }
                sb.Length--; // This removes the trailing comma
                sb.Append("}");
                currentRow++;
                return sb.ToString();
            }else
            {
                return "NO MORE ROWS";
            }
        }
    }
}
