using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib_Controller
{
    class User
    {
        public UInt64 m__u64ID;
        public string m__sLastname;
        public string m__sFirstname;
        public string m__sDateOfBirth;  // dd.mm.yyyy
        public string m__sAddress;
        public UInt64 m__u64Lendings;

        public User(UInt64 u64ID, string sLastname, string sFirstname, string sDateOfBirth, string sAddress)
        {
            m__u64ID = u64ID;
            m__sLastname = sLastname;
            m__sFirstname = sFirstname;
            m__sDateOfBirth = sDateOfBirth;
            m__sAddress = sAddress;
            m__u64Lendings = 0;
        }
    }
}
