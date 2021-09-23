using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_HTC.Class
{
    class HocPhiClass
    {
        string masv, nienkhoa;
        int hocky, hocphi;

        public HocPhiClass(string masv, string nienkhoa, int hocky, int hocphi)
        {
            this.masv = masv;
            this.nienkhoa = nienkhoa;
            this.hocky = hocky;
            this.hocphi = hocphi;
        }

        public string MaSV
        {
            get { return masv; }
            set { masv = value; }
        }

        public string NienKhoa
        {
            get { return nienkhoa; }
            set { nienkhoa = value; }
        }

        public int HocPhi
        {
            get { return hocphi; }
            set { hocphi = value; }
        }

        public int HocKy
        {
            get { return hocky; }
            set { hocky = value; }
        }
    }
}
