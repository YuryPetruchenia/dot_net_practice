using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    
        public class foursquare : ISquare
        {
        public string name;
        public int len;
        public foursquare()
        {
            name = "foursquare";
            len = 10;
        }
            
            public int Square()
            {
                return len*len;
            }
        }

        public class circle : ISquare
        {
        public string name;
        const int pi = 3;
        public int r;
        public circle()
        {
            name = "circle";
            r = 10;
        }
            
            public int Square()
            {
                return pi * r^2;
            }
        }

        public class triangle : ISquare
        {
        public string name;
        public int len;
        public int hight;

        public triangle()
        {
            name = "triangle";
            len = 10;
            hight = 7;
        }
            

            public int Square()
            {
                return len * hight / 2;
            }
        }
    }

