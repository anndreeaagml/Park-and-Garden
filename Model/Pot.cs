﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Park_and_Garden.Model
{
    //Made by Dominik János Haskó

    class Pot : Product
    {
        private string _color;
        private string _size;
        public Pot(string name, int cost, int stock, string url, string color, string size) : base(name, cost, stock,url)
        {
            Color = color;
            Size = size;

        }

        public string Color { get; set; }
        public string Size { get; set; }
    }
}
