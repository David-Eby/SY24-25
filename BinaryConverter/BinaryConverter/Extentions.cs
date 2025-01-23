using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverter {
    public static class Extentions {
        public static List<TextBox> Shift(this List<TextBox> tbs) {
            byte value = 0;
            tbs.ForEach(t => {
                byte newVal = byte.Parse(t.Text);
                t.Text = value.ToString();
                value = newVal;
            });
            return tbs;
        }

        public static int Min(params int[] values) =>
            values.Min();
    }
}
