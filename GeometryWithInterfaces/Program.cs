using System;
using System.Security.Cryptography;

namespace GeometryWithInterfaces {
    class Program {
        static void Main(string[] args) {
            var quad1 = new Quadrillateral {
                Side1 = 10, Side2 = 10, Side3 = 10, Side4 = 10
            };
            var rec1 = new Rectangle {
                Side1 = 10, Side2 = 10
            };
            var sq1 = new Square {
                Side1 = 12
            };

            IShapes[] shapes = new IShapes[10];
            shapes[0] = quad1;
            shapes[1] = rec1;
            shapes[2] = sq1;

            foreach (var shape in shapes) {
                if (shape == null) continue;
                shape.Perimeter();
            }
        }
    }
}
