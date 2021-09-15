using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_HTC.Class
{
    class LopClass
    {
        string malop, tenlop, khoahoc, makhoa;

        public LopClass(string malop, string tenlop, string khoahoc, string makhoa)
        {
            this.malop = malop;
            this.tenlop = tenlop;
            this.khoahoc = khoahoc;
            this.makhoa = makhoa;
        }

        public string MaLop
        {
            get { return malop; }
            set { malop = value; }
        }

        public string TenLop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }

        public string KhoaHoc
        {
            get { return khoahoc; }
            set { khoahoc = value; }
        }

        public string MaKhoa
        {
            get { return makhoa; }
            set { makhoa = value; }
        }
    }
}
