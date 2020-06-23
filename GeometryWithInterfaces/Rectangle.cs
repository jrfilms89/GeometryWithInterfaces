using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryWithInterfaces {
    class Rectangle : IShapes {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public void Perimeter() {
            Console.WriteLine(Side1 + Side2 + Side1 + Side2);
        }

        public Rectangle(int s1, int s2) {
            Side1 = s1;
            Side2 = s2;
        }
        public Rectangle() {

        }
    }
}
