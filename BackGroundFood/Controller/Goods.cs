﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKho.Controller
{
    class Goods
    {
        public Goods(string ma, int sl)
        {
            MaHH = ma;
            SoLuongNhap = sl;
        }

        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public string DonViTinh { get; set; }
        public double Gia { get; set; }
        public int SoLuongNhap { get; set; }
    }
}
