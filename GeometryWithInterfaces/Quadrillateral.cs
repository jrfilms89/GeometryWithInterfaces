using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryWithInterfaces {
    class Quadrillateral : IShapes{
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public void Perimeter() {
            Console.WriteLine(Side1 + Side2 + Side3 + Side4);
        }

        public Quadrillateral(int s1, int s2, int s3, int s4) {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
            Side4 = s4;
        }
        public Quadrillateral() {

        }
    }
}
