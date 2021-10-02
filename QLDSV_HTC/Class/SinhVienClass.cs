using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDSV_HTC.Class
{
    class SinhVienClass
    {
        string MaSV, Ho, Ten, Phai, DiaChi, NgaySinh, MaLop, DaNghiHoc;


        public SinhVienClass(string maSV, string ho, string ten, string phai, string diaChi, string ngaySinh, string daNghiHoc, string maLop)
        {
            MaSV = maSV;
            Ho = ho;
            Ten = ten;
            Phai = phai;
            DiaChi = diaChi;
            NgaySinh = ngaySinh;
            DaNghiHoc = daNghiHoc;
            MaLop = maLop;
        }

        public string maSV
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        public string ho
        {
            get { return Ho; }
            set { ho = value; }
        }
        public string ten
        {
            get { return Ten; }
            set { Ten = value; }
        }
        public string phai
        {
            get { return Phai; }
            set { Phai = value; }
        }
        public string diaChi
        {
            get { return DiaChi; }
            set { DiaChi = value; }
        }
        public string ngaySinh
        {
            get { return NgaySinh; }
            set { NgaySinh = value; }
        }
        public string maLop
        {
            get { return MaLop; }
            set { MaLop = value; }
        }
        public string daNghiHoc
        {
            get { return DaNghiHoc; }
            set { DaNghiHoc = value; }
        }
    }
}
