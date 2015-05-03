using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Word;
using System.Net;


using System.IO;


namespace Lib_Controller
{
    public partial class MainForm : Form
    {
        Lib_Controller MyLibController;

        


        public MainForm()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MyLibController == null)
                {
                    OpenFileDialog openExcel = new OpenFileDialog();
                    openExcel.InitialDirectory = "c:\\";
                    openExcel.Filter = "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx"; // Alle Files (*.*)|*.*
                    openExcel.FilterIndex = 2;
                    openExcel.RestoreDirectory = true;
                    openExcel.ShowDialog();

                    MyLibController = new Lib_Controller(openExcel.FileName);
                    bOpen.ForeColor = Color.LightGray;

                    dataGridView1.ColumnCount = 7;
                    dataGridView1.Columns[0].Name = "ID";
                    dataGridView1.Columns[1].Name = "Medium";
                    dataGridView1.Columns[2].Name = "Name";
                    dataGridView1.Columns[3].Name = "ISBN";
                    dataGridView1.Columns[4].Name = "Author";
                    dataGridView1.Columns[5].Name = "Verlag";
                    dataGridView1.Columns[6].Name = "Year";
                    
                    foreach (Medium a in MyLibController.Mediums)
                    {
                        switch (a.GetType().ToString())
                        {
                            case "Lib_Controller.Book":
                                Book mybook = (Book)a;
                                dataGridView1.Rows.Add(a.m__u64ID, "Book", a.m__sName, a.m__sISBN, mybook.m__sAuthor, mybook.m__sPublisher, mybook.m__u64Year );
                                break;
                            case "Lib_Controller.DVD":
                                dataGridView1.Rows.Add(a.m__u64ID, "DVD", a.m__sName, a.m__sISBN);
                                break;
                            case "Lib_Controller.Audio":
                                dataGridView1.Rows.Add(a.m__u64ID, "Audio", a.m__sName, a.m__sISBN);
                                break;
                            default:
                                MessageBox.Show("Reading in not working");
                                break;
                        }
                    }

                    dataGridView2.ColumnCount = 6;
                    dataGridView2.Columns[0].Name = "ID";
                    dataGridView2.Columns[1].Name = "Lastname";
                    dataGridView2.Columns[2].Name = "Firstname";
                    dataGridView2.Columns[3].Name = "Date of Birth";
                    dataGridView2.Columns[4].Name = "Address";
                    dataGridView2.Columns[5].Name = "Lendings";

                    foreach (User a in MyLibController.Users)
                    {
                         dataGridView2.Rows.Add(a.m__u64ID, a.m__sLastname, a.m__sFirstname, a.m__sDateOfBirth, a.m__sAddress, a.m__u64Lendings);
                    }
                }
            }
            catch (Exception)
            {  }
        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                MyLibController.excel_visibility = !MyLibController.excel_visibility;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error: No Excel Opened");
            }
        }



        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("This is a test");
        }

        private void excelShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                excelShowToolStripMenuItem.Checked = !MyLibController.excel_visibility;
                MyLibController.excel_visibility = !MyLibController.excel_visibility;
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error: No Excel Opened");
            }
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (MyLibController == null)
            {
                MessageBox.Show("Error: No Excel Opened");
            }
            else
            {
                try
                {
                    MyLibController.saveFile();
                    MyLibController.closeFile();
                    MyLibController = null;
                    bOpen.ForeColor = Color.Black;
                }
                catch (Exception)
                {
                    MessageBox.Show("Saving or closing not possible.");
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            

            try
            {
                
                int row = 0;
                while (true)
                {
                    if(MyLibController.Mediums[row].m__u64ID == Convert.ToUInt64(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()))
                    {
                        break;
                    }
                    row++;
                }
                MediumEditor myform = new MediumEditor(true);
                //myform.mMedium = MyLibController.Mediums[row];
                myform.ShowText();
                
                myform.Show();
                MessageBox.Show("New Window Closed now?");
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("Keine gültige Auswahl getroffen");
            }
            
            //myform.mMedium = MyLibController.Mediums[dataGridView1.CurrentCell.RowIndex];
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MyLibController != null)
            {
                MediumEditor myform = new MediumEditor(false);
                myform.Show();
            }
            else
            {
                MessageBox.Show("Kein Excel geöffnet");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Uri MyUri = new Uri("http://baselbern.swissbib.ch/Search/Results?lookfor=", UriKind.Absolute);
            //Uri MyUri = new Uri("http://google.ch", UriKind.Absolute);
            Uri MyUri = new Uri("http://www.isbn-check.de/checkisbn.pl?isbn=" + fISBNTester.Text + "&submit=testen&lang=de", UriKind.Absolute);
        //http://www.isbn-check.de/checkisbn.pl?isbn=	**ISBN Nummer**		&submit=testen&lang=de

            HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create(MyUri);
            myReq.MaximumAutomaticRedirections = 4;
            myReq.MaximumResponseHeadersLength = 4;
            myReq.Credentials = CredentialCache.DefaultCredentials;

            HttpWebResponse myRes = (HttpWebResponse)myReq.GetResponse();

            Stream MyStream = myRes.GetResponseStream();
            StreamReader MyStreamReader = new StreamReader(MyStream, Encoding.UTF8);

            string MyString = MyStreamReader.ReadToEnd();
            int start = MyString.IndexOf("<title>");
            int end = MyString.IndexOf("</title>");
            string SubString = MyString.Substring(start + 7, end - start - 7);
            /*
            string a = "<abc>123<B>MA</B>123</abc>";
            int start = a.IndexOf("<B>") + 3;
            int end = a.IndexOf("</B>");
            string neu = a.Substring(start, end - start);*/


            MessageBox.Show(/*MyStreamReader.ReadToEnd()*/ SubString);
            myRes.Close();
            MyStreamReader.Close();
        }
    }
}
