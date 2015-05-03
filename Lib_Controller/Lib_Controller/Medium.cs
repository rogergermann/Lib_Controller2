using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Controller
{
    abstract class Medium
    {
        public UInt64 m__u64ID      { get; private set; }
        public string m__sName      { get; private set; }
        public string m__sISBN      { get; private set; }
        //public string m__sDate      { get; private set; }         // dd.mm.yyyy

        public string m__sBuyDate   { get; private set; }

        public UInt64 m__u64Lendings;
        public UInt64 m__u64Lender;
        public UInt64 m__u64Reservator;
        public string m__sReturnDate;   // dd.mm.yyyy

        public Medium(UInt64 u64ID, string sName, string sISBN, string sBuyDate)
        {
            m__u64ID = u64ID;
            m__sName = sName;
            m__sISBN = sISBN;

            m__sBuyDate = sBuyDate;

            m__u64Lendings = 0;
            m__u64Lender = 0;
            m__u64Reservator = 0;
            m__sReturnDate = "12.10.9999";
        }

        public virtual string ToString()
        {
            return string.Format(m__u64ID.ToString() + " " + m__sName + " " + m__sISBN + " " + m__sBuyDate);
        }
    }

    class Book : Medium
    {
        public string m__sAuthor;
        public string m__sPublisher;
        public UInt64 m__u64Year;       // yyyy

        public Book(UInt64 u64ID, string sName, string sISBN, string sBuyDate, string sAuthor, string sPublisher, UInt64 u64Year) :
            base(u64ID, sName, sISBN, sBuyDate)
        {
            m__sAuthor = sAuthor;
            m__sPublisher = sPublisher;
            m__u64Year = u64Year;
        }
        public override string ToString()
        {
            return string.Format(m__u64ID.ToString() + " " + m__sName + " " + m__sISBN + " " + m__sBuyDate + " " + m__sAuthor + " " + m__sPublisher + " " + m__u64Year.ToString());
        }
    }

    class DVD : Medium
    {
        public DVD(UInt64 u64ID, string sName, string sISBN, string sBuyDate) :
            base(u64ID, sName, sISBN, sBuyDate)
        {
            // Nothing to do here
        }
    }

    class Audio : Medium
    {
        public Audio(UInt64 u64ID, string sName, string sISBN, string sBuyDate) :
            base (u64ID, sName, sISBN, sBuyDate)
        {
            // Nothing to do here
        }

        
    }
}




        