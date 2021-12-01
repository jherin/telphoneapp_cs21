﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelphoneApp {
    public class People {
        List<Person> perList = new List<Person>();
        public void Add(Person per) {
            perList.Add(per);
        }
        public void AddRange(Person[] parr) {
            perList.AddRange(parr);
        }
        public Person this[int idx] {
            get { return perList[idx]; }
        }
        public int Count {
            get { return perList.Count; }
        }
    }
}
