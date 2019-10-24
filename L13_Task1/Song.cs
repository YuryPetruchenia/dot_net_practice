using System;
using System.Collections.Generic;
using System.Text;

namespace L13_Task1
{
    public class Song
    {
        private string _name;
        private int _length;
        private string _autor;
        private int _date;

        public string Name { get { return _name; } set { _name = value; } }
        public int Length { get { return _length; } set { _length = value; } }
        public string Autor { get { return _autor; } set { _autor = value; } }
        public int Date { get { return _date; } set { _date = value; } }
               
    }
}
