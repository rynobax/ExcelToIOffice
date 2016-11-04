using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelToIOffice
{
    class ExcelManager
    {
        private Excel.Application excelApp = null;

        private Excel.Workbook workbook = null;

        private Excel.Worksheet worksheet = null;

        private bool ignoreFirstRow = false;

        /* Singleton Pattern */

        private static ExcelManager instance;

        private ExcelManager()
        {
            excelApp = new Excel.Application();
        }

        public static ExcelManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ExcelManager();
                }
                return instance;
            }
        }
        
        /* Public Methods */

        public void openFile(string filePath)
        {
            workbook = excelApp.Workbooks.Open(
                    /* Filename */ filePath,
                    /* UpdateLinks */ Type.Missing,
                    /* ReadOnly */ true,
                    /* Format */ Type.Missing,
                    /* Password */ Type.Missing,
                    /* WriteResPassword */ Type.Missing,
                    /* IgnoreReadOnlyRecommended */ Type.Missing,
                    /* Origin */ Type.Missing,
                    /* Delimter */ Type.Missing,
                    /* Editable */ Type.Missing,
                    /* Notify */ Type.Missing,
                    /* Converter */ Type.Missing,
                    /* AddToMru */ Type.Missing,
                    /* Local */ Type.Missing,
                    /* CorruptLoad */ Type.Missing);

        worksheet = null;
    }

        /* Methods for managing sheets */

        public void SetActiveSheet(int sheetNum)
        {
            if(sheetNum > workbook.Worksheets.Count || sheetNum <= 0)
            {
                Console.WriteLine("Sheet is out of bounds.  Active sheet is not being changed.");
            }
            else
            {
                Console.WriteLine("Setting active sheet to " + sheetNum);
                worksheet = (Excel.Worksheet)workbook.Worksheets[sheetNum];
            }
        }

        public void CloseFile()
        {
            if(workbook == null)
            {
                Console.WriteLine("No file is open.  Cannot close what has not been opened.");
            }else
            {
                workbook.Close(false, Type.Missing, Type.Missing);
                Console.ReadLine();
            }
        }

        ~ExcelManager()
        {
            CloseFile();
            excelApp.Quit();
        }

        /* Methods for reading a sheet */

        public void setIgnoreFirstRow(bool answer)
        {
            ignoreFirstRow = answer;
        }

        public object[,] getWholeSheet()
        {
            if(worksheet == null)
            {
                Console.WriteLine("No active sheet!!!");
                return null;
            }else
            {
                object[,] valueArray = null;

                int startColumn = 1;
                int startRow = 1;
                if (ignoreFirstRow)
                {
                    startRow = 2;
                }
                Excel.Range startCell = worksheet.Cells[startRow, startColumn];

                int endColumn = worksheet.Cells.Find("*", System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSearchOrder.xlByColumns, Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Column;
                int endRow = worksheet.Cells.Find("*", System.Reflection.Missing.Value, System.Reflection.Missing.Value, System.Reflection.Missing.Value, Excel.XlSearchOrder.xlByRows, Excel.XlSearchDirection.xlPrevious, false, System.Reflection.Missing.Value, System.Reflection.Missing.Value).Row;
                Excel.Range endCell = worksheet.Cells[endRow, endColumn];

                Excel.Range noHeaderRange = worksheet.Range[startCell, endCell];

                valueArray = (object[,])noHeaderRange.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);
                return valueArray;
            }
        }


        /* Methods for doing stuff with a sheet */

        public string[] getSheets()
        {
            if(workbook != null)
            {
                int sheetCount = workbook.Sheets.Count;
                string[] sheets = new string[sheetCount];
                int i = 0;
                foreach(Excel.Worksheet sheet in workbook.Sheets)
                {
                    sheets[i] = sheet.Name;
                    i++;
                }
                return sheets;
            }else
            {
                return null;
            }
        }

        public void printRegion(object[,] valueArray)
        {
            if(valueArray == null)
            {
                Console.WriteLine("Nothing in the region!");
            }else
            {
                Console.WriteLine("---Begin region---");
                for (int row = 1; row <= valueArray.GetLength(0); ++row)
                {
                    for (int col = 1; col <= valueArray.GetLength(1); ++col)
                    {
                        //access each cell
                        Console.WriteLine(valueArray[row, col].ToString());
                    }
                }
                Console.WriteLine("---End region---");
            }
        }
        
    }
}
