﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Category
    {
        public  string ID { get; private set; }
        public  string Name { get; private set; }
        public Category(string name)
        {
            Name = name;
        }
    }
}
