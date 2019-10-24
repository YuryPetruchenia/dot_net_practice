using System;
using System.Collections.Generic;
using System.Text;

namespace L13_Task1
{
    class Song
    {
        private string _name;
        private int _length;
        private string _autor;
        private DateTime _date;

        public string Name { get { return _name; } set { Name = _name; } }
        public int Length { get { return _length; } set { Length = _length; } }
        public string Autor { get { return _autor; } set { Autor = _autor; } }
        public DateTime Date { get { return _date; } set { Date = _date; } }


    }
}
