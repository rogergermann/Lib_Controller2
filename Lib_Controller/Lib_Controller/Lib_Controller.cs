using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.CSharp.RuntimeBinder;
//using System.Runtime.InteropServices.COMException;
using System.Runtime.InteropServices;




namespace Lib_Controller
{
    class Lib_Controller
    {
        public List<User> Users = new List<User>();
        public List<Medium> Mediums = new List<Medium>();
        public Microsoft.Office.Interop.Excel.Application excelApp;
        public Microsoft.Office.Interop.Excel.Workbooks workBooks;
        public Microsoft.Office.Interop.Excel.Workbook workBook;
        public Microsoft.Office.Interop.Excel.Worksheet workSheet;

        private bool _excel_open = false;
        public bool excel_open
        {
            get
            {
                return _excel_open;
            }
            set
            {

            }
        }


        private bool _excel_visibility = false;
        public bool excel_visibility
        {
            get
            {
                return _excel_visibility;
            }
            set
            {
                _excel_visibility = value;

                // If Excel is open, then show or hide
                if (_excel_open == true)
                {
                    excelApp.Visible = value;
                }
            }
        }


        public Lib_Controller(string path)
        {
            excelApp = new Microsoft.Office.Interop.Excel.Application();
            workBooks = excelApp.Workbooks;
            if (path != null)
            {
                workBook = workBooks.Open(path);
                _excel_open = true;
            }
            

            excelApp.Visible = excel_visibility;
            // Medium einlesen
            workSheet = workBook.Worksheets.get_Item(1);

            for (UInt64 u64I = 2; workSheet.Range["A" + u64I, Type.Missing].Value2 != null; u64I++)
            {
                try
                {
                    string ArticleKind = workSheet.Range["B" + u64I, Type.Missing].Value2.ToString();
                    string Name = workSheet.Range["C" + u64I, Type.Missing].Value2.ToString();
                    string ISBN = workSheet.Range["D" + u64I, Type.Missing].Value2.ToString();
                    string BuyDate = workSheet.Range["H" + u64I, Type.Missing].Value2.ToString();
                    UInt64 ID = Convert.ToUInt64(workSheet.Range["A" + u64I, Type.Missing].Value2.ToString());
                    
                    
                    switch (ArticleKind)
                    {
                        case "DVD":
                            Mediums.Add(new DVD(ID, Name, ISBN, BuyDate));
                            break;
                        case "Book":
                            string Author = workSheet.Range["E" + u64I, Type.Missing].Value2.ToString();
                            string Publisher = workSheet.Range["F" + u64I, Type.Missing].Value2.ToString();
                            UInt64 Year = Convert.ToUInt64(workSheet.Range["G" + u64I, Type.Missing].Value2.ToString());
                            Mediums.Add(new Book(ID, Name, ISBN, BuyDate, Author, Publisher, Year));
                            break;
                        case "Audio":
                            Mediums.Add(new Audio(ID, Name, ISBN, BuyDate));
                            break;
                        default:
                            MessageBox.Show("Line #" + (u64I+1) + " is invalid");
                            break;
                    }
                }
                catch (RuntimeBinderException)
                {
                    MessageBox.Show("Error in Line " + (u64I + 1));
                }
                catch (COMException)
                {
                    MessageBox.Show("Error in Line " + (u64I + 1));
                } 
                catch (FormatException)
                {
                    MessageBox.Show("Enter a Number in Field A and G on Line " + (u64I + 1));
                }
            }

            // Users einlesen
            workSheet = workBook.Worksheets.get_Item(2);

            for (UInt64 u64I = 2; workSheet.Range["A" + u64I, Type.Missing].Value2 != null; u64I++)
            {
                try
                {
                    string Lastname = workSheet.Range["B" + u64I, Type.Missing].Value2.ToString();
                    string Firstname = workSheet.Range["C" + u64I, Type.Missing].Value2.ToString();
                    string DateOfBirth = workSheet.Range["D" + u64I, Type.Missing].Value2.ToString();
                    string Address = workSheet.Range["E" + u64I, Type.Missing].Value2.ToString();
                    UInt64 ID = Convert.ToUInt64(workSheet.Range["A" + u64I, Type.Missing].Value2.ToString());

                    Users.Add(new User(ID, Lastname, Firstname, DateOfBirth, Address));
                }
                catch (RuntimeBinderException)
                {
                    MessageBox.Show("Error in Line " + (u64I + 1));
                }
                catch (COMException)
                {
                    MessageBox.Show("Error in Line " + (u64I + 1));
                }
                catch (FormatException)
                {
                    MessageBox.Show("Enter a Number in Field A on Line " + (u64I + 1));
                }
            }

            MessageBox.Show("Excel erfolgreich eingelesen.\nAnzahl Benutzer: " + Users.Count.ToString() + "\nAnzahl Medien: " + Mediums.Count.ToString());
        }

        public void Lend_Article(User Lender, Medium Article)
        {
            Lender.m__u64Lendings++;
            Article.m__u64Lender = Lender.m__u64ID;
            Article.m__u64Reservator = 0;
        }

        public void Reservate_Article(User Reservator, Medium Article)
        {
            Article.m__u64Reservator = Reservator.m__u64ID;
        }

        public void Return_Article(User Lender, Medium Article)
        {
            Lender.m__u64Lendings--;
            Article.m__u64Lender = 0;
            if (Article.m__u64Reservator != 0)
            {
                // Show: Book is reservated!
            }
        }

        public void saveStuff()
        {
            // Save Everything in Excel
        }

        public void saveFile()
        {
            excelApp.SaveWorkspace();
        }

        public void closeFile()
        {
            //GC.Collect();
            //GC.WaitForPendingFinalizers();

            excelApp.SaveWorkspace();

            Marshal.FinalReleaseComObject(workSheet);
            Marshal.FinalReleaseComObject(workBook);
            
            workBooks.Close();
            Marshal.FinalReleaseComObject(workBooks);

            excelApp.Quit();
            Marshal.FinalReleaseComObject(excelApp);
        }

        public void getMedia()
        {

        }
    }
}
