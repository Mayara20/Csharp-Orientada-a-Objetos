using System;
using System.Collections.Generic;
using System.Text;

namespace Referencia_vs_tipo_valor {
        struct Point {

        public double X, Y;

        public override string ToString() {
            return "(" + X + "," + Y + ")";
        }

    }
}
