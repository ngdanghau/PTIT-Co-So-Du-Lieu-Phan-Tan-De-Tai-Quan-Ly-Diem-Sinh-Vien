using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_HTC.Class
{
    class HocPhiClass
    {
        string masv, nienkhoa, nienkhoa_new;
        int hocky, hocphi, hocphi_new, hocky_new;

        public HocPhiClass(string masv, string nienkhoa, int hocky, int hocphi, string nienkhoa_new, int hocky_new, int hocphi_new)
        {
            this.masv = masv;
            this.nienkhoa = nienkhoa;
            this.nienkhoa_new = nienkhoa_new;
            this.hocky = hocky;
            this.hocky_new = hocky_new;
            this.hocphi = hocphi;
            this.hocphi_new = hocphi_new;
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
        
        public string NienKhoaNew
        {
            get { return nienkhoa_new; }
            set { nienkhoa_new = value; }
        }

        public int HocPhi
        {
            get { return hocphi; }
            set { hocphi = value; }
        }

        public int HocPhiNew
        {
            get { return hocphi_new; }
            set { hocphi_new = value; }
        }

        public int HocKy
        {
            get { return hocky; }
            set { hocky = value; }
        } 
        
        public int HocKyNew
        {
            get { return hocky_new; }
            set { hocky_new = value; }
        }
    }
}
