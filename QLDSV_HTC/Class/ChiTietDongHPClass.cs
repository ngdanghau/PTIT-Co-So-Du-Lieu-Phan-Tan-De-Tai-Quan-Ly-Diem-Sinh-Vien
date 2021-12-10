using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_HTC.Class
{
    class ChiTietDongHPClass
    {
        string masv, nienkhoa, nienkhoa_new;
        int hocky, tiendadong, tiendadong_new, hocky_new;
        DateTime ngaydong, ngaydong_new;

        public ChiTietDongHPClass(string masv, string nienkhoa, int hocky, int tiendadong, string nienkhoa_new, int hocky_new, int tiendadong_new, DateTime ngaydong, DateTime ngaydong_new)
        {
            this.masv = masv;
            this.nienkhoa = nienkhoa;
            this.nienkhoa_new = nienkhoa_new;
            this.hocky = hocky;
            this.hocky_new = hocky_new;
            this.tiendadong = tiendadong;
            this.tiendadong_new = tiendadong_new;
            this.ngaydong = ngaydong;
            this.ngaydong_new = ngaydong_new;
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
        public DateTime NgayDong
        {
            get { return ngaydong; }
            set { ngaydong = value; }
        }

        public DateTime NgayDongNew
        {
            get { return ngaydong_new; }
            set { ngaydong_new = value; }
        }

        public int TienDaDong
        {
            get { return tiendadong; }
            set { tiendadong = value; }
        }

        public int TienDaDongNew
        {
            get { return tiendadong_new; }
            set { tiendadong_new = value; }
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
