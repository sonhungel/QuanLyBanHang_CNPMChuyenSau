﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5.dataClass
{
    public class Item
    {
        public Item(string id, string Name, float Price, int Total)
        {
            this.iD = id;
            this.name = Name;
            this.price = Price;
            this.total = Total;
        }
        public Item(DataRow row)
        {
            this.iD = row["IDITEM"].ToString();
            this.name = row["NAMEITEM"].ToString();
            this.price = (float)Convert.ToDouble(row["PRICE"].ToString());
            this.total = (int)row["TOTAL"];
        }
        //public Item(DataRow row)
        //{
        //    this.iD = row["Mã hàng"].ToString();
        //    this.name = row["Tên hàng"].ToString();
        //    this.price = (float)Convert.ToDouble(row["Đơn giá"].ToString());
        //    this.total = (int)row["Tồn kho"];
        //}
        private float price;
        private int total;
        private string name;
        private string iD;

        public string ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public int Total { get => total; set => total = value; }
        public float Price { get => price; set => price = value; }
    }
}
