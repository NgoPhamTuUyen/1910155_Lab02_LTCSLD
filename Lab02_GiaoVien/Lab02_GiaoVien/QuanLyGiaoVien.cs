﻿using System.Collections.Generic;

namespace Lab02_GiaoVien
{
    public class QuanLyGiaoVien
    {
        public List<GiaoVien> dsGiaoVien;
        public QuanLyGiaoVien()
        {
            dsGiaoVien = new List<GiaoVien>();
        }
        
        public GiaoVien this[int index]
        {
            get { return dsGiaoVien[index]; }
            set { dsGiaoVien[index] = value; }
        }

        public bool Them(GiaoVien giaoVien)
        {
            var already = dsGiaoVien.Exists(gv => gv.MaSo == giaoVien.MaSo);
            if (already) return false;

            dsGiaoVien.Add(giaoVien);

            return true;
        }

        public GiaoVien Tim(string value, Tim kieuTim)
        {
            GiaoVien giaoVien = null;

            switch (kieuTim)
            {
                case Lab02_GiaoVien.Tim.TheoHoTen:
                    giaoVien = dsGiaoVien.Find(gv => Utils.NormalizeVietnameseString(gv.HoTen).ToLower() == Utils.NormalizeVietnameseString(value).ToLower());
                    break;
                case Lab02_GiaoVien.Tim.TheoMa:
                    giaoVien = dsGiaoVien.Find(gv => gv.MaSo == value);
                    break;
                case Lab02_GiaoVien.Tim.TheoSDT:
                    giaoVien = dsGiaoVien.Find(gv => gv.SoDT == value);
                    break;
            }

            return giaoVien;
        }
    }
}
