using System;
using System.Collections.Generic;
using System.Text;

namespace GeometryWithInterfaces {
    interface IShapes {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        public void Perimeter();
    }
}
