using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_HTC.Class
{
    class RoleClass
    {
        public string TENKHOA
        {
            get;
            set;
        }

        public string TENSERVER
        {
            get;
            set;
        }

        public RoleClass(string id, string n)
        {
            TENKHOA = n;
            TENSERVER = id;
        }
    }
}
