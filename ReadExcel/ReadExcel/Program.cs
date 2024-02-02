using ClosedXML;
using ClosedXML.Excel;



class ReadingExcelFile
{
    public static void readExcelFile(string pathToFile)
    {

        using (XLWorkbook wb = new XLWorkbook(pathToFile))
        {

            IXLWorksheet ws = wb.Worksheet(1);
            foreach (IXLRow row in ws.RowsUsed())
            {
                foreach (IXLCell cell in row.CellsUsed())
                {
                    Console.WriteLine(cell.Value.ToString());
                }
            }


        }


    }


}



class RunReadingExcelFile
{
    static void Main(string[] args)

    {

        string xlPath = @"C:\Users\User\OneDrive\Documents\Book1.xlsx";

        //call the program
        ReadingExcelFile.readExcelFile(xlPath);

    }
}