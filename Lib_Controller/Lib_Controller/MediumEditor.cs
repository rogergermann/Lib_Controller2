using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lib_Controller
{
    public partial class MediumEditor : Form
    {
        //public Medium mMedium;
        private Boolean mbEdit_nAdd;

                    //richTextBox1.Text = mymedium.ToString();
        public MediumEditor(bool bEdit_nAdd)
        {
            InitializeComponent();
            mbEdit_nAdd = bEdit_nAdd;
            if (bEdit_nAdd == true)
            {
                // Edit
                radioButton1.Hide();
                radioButton2.Hide();
                radioButton3.Hide();
                bAddMedium.Hide();
            }
            else
            {
                // Add
                bEditMedium.Hide();
            }
        }


        private void Data_Enter(object sender, EventArgs e)
        {
            // Generate Text
        }

        #region RadioButtonControl Show / Hide fields
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // Audio chosen
            nYear.Hide();
            nAuthor.Hide();
            nPublisher.Hide();

            fYear.Hide();
            fAuthor.Hide();
            fPublisher.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //  DVD chosen
            nYear.Hide();
            nAuthor.Hide();
            nPublisher.Hide();

            fYear.Hide();
            fAuthor.Hide();
            fPublisher.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Book chosen
            nYear.Show();
            nAuthor.Show();
            nPublisher.Show();

            fYear.Show();
            fAuthor.Show();
            fPublisher.Show();
        }
        #endregion


        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bEditMedium_Click(object sender, EventArgs e)
        {

        }

        private void bAddMedium_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                // New Book
                //mMedium = new Book(Convert.ToUInt64(fID.Text), fName.Text, fISBN.Text, fBuyDate.Text, fAuthor.Text, fPublisher.Text, Convert.ToUInt64(fYear.Text));
                this.ShowText();
            }
            else if (radioButton2.Checked == true)
            {
                // New DVD
                //mMedium = new DVD(Convert.ToUInt64(fID.Text), fName.Text, fISBN.Text, fBuyDate.Text);
                this.ShowText();
            }
            else if (radioButton3.Checked == true)
            {
                // New Audio
                //mMedium = new Audio(Convert.ToUInt64(fID.Text), fName.Text, fISBN.Text, fBuyDate.Text);
                this.ShowText();
            }
            else
            {
                MessageBox.Show("Chose Medium kind before");
            }  
        }

        public void ShowText()
        {
            try
            {
                if (mbEdit_nAdd == true)
                {
                    /*fID.Text = mMedium.m__u64ID.ToString();
                     fName.Text = mMedium.m__sName;
                     fISBN.Text = mMedium.m__sISBN;
                    
                     //fYear.Text = mMedium.m__sBuyDate;
                 }

                 this.richTextBox1.Text = mMedium.ToString();
                     * */
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No Media available");
            }
        }



    }
}
