using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryConverter {
    public partial class Form1 : Form {
        Dictionary<byte, List<TextBox>> textBoxes = new();
        List<TextBox> allTB = new();

        public Form1() {
            InitializeComponent();

            List<TextBox> tbs0 = new() {
                BT1,
                BT2,
                BT3,
                BT4,
                BT5,
                BT6,
                BT7,
                BT8
            };
            List<TextBox> tbs1 = new() {
                Bit1,
                Bit2,
                Bit3,
                Bit4,
                Bit5,
                Bit6,
                Bit7,
                Bit8
            };
            List<TextBox> tbs2 = new() {
                B1,
                B2,
                B3,
                B4,
                B5,
                B6,
                B7,
                B8
            };

            textBoxes.Add(0, tbs0);
            textBoxes.Add(1, tbs1);
            textBoxes.Add(2, tbs2);

            allTB.AddRange(tbs0);
            allTB.AddRange(tbs1);
            allTB.AddRange(tbs2);
        }

        private void bit_MouseClick(object sender, MouseEventArgs e) {
            TextBox tbS;
            if ((tbS = sender as TextBox) is null) return;

            ChangeNum(ref tbS);

            SetValue(1, label1);
            SetValue(2, label2);

            ChangeTotal();
        }
        public string ChangeNum(ref TextBox text) => text.Text switch {
            "1" => text.Text = "0",
            _ => text.Text = "1",
        };
        private byte SetValue(byte index, Label label) {
            byte total = 0;
            textBoxes.TryGetValue(index, out var tb);
            var TB = tb.Where(t => t.Text == "1").ToList();

            TB.ForEach(t => {
                int index = int.Parse(t.Name.Remove(0, t.Name.Count() - 1)) - 1;
                total += (byte)Math.Pow(2, index);
            });

            label.Text = total.ToString();
            return total;
        }

        private void operationUpDown_SelectedItemChanged(object sender, EventArgs e) {
            ChangeTotal();
        }
        private void ChangeTotal() {
            textBoxes.TryGetValue(0, out var tbs0);
            textBoxes.TryGetValue(1, out var tbs1);
            textBoxes.TryGetValue(2, out var tbs2);

            switch (operationUpDown.Text) {
                case "+":
                    byte carry = 0;
                    for (int i = 0; i < tbs1.Count; i++) {
                        var tb0 = tbs0.ToArray()[i];
                        var tb1 = tbs1.ToArray()[i];
                        var tb2 = tbs2.ToArray()[i];

                        byte tb1Int = byte.Parse(tb1.Text);
                        byte tb2Int = byte.Parse(tb2.Text);

                        byte num = (byte)((tb1Int ^ tb2Int) ^ carry);
                        tb0.Text = num.ToString();

                        if ((tb1Int & tb2Int) == 1 || ((tb1Int ^ tb2Int) & carry) == 1) {
                            carry = 1;
                        } else {
                            carry = 0;
                        }
                    }
                    break;
                case "&":
                    for (int i = 0; i < tbs1.Count; i++) {
                        var tb0 = tbs0.ToArray()[i];
                        var tb1 = tbs1.ToArray()[i];
                        var tb2 = tbs2.ToArray()[i];

                        tb0.Text = (
                            int.Parse(tb1.Text) &
                            int.Parse(tb2.Text)
                        ).ToString();
                    }
                    break;
                case "|":
                    for (int i = 0; i < tbs1.Count; i++) {
                        var tb0 = tbs0.ToArray()[i];
                        var tb1 = tbs1.ToArray()[i];
                        var tb2 = tbs2.ToArray()[i];

                        tb0.Text = (
                            int.Parse(tb1.Text) |
                            int.Parse(tb2.Text)
                        ).ToString();
                    }
                    break;
                case "^":
                    for (int i = 0; i < tbs1.Count; i++) {
                        var tb0 = tbs0.ToArray()[i];
                        var tb1 = tbs1.ToArray()[i];
                        var tb2 = tbs2.ToArray()[i];

                        tb0.Text = (
                            int.Parse(tb1.Text) ^
                            int.Parse(tb2.Text)
                        ).ToString();
                    }
                    break;
            }
            SetValue(0, label3);
        }

        private void clearButton_Click(object sender, EventArgs e) {
            allTB.ForEach(t => t.Text = "0");

            SetValue(1, label1);
            SetValue(2, label2);

            ChangeTotal();
        }

        private void leftShift_Click(object sender, EventArgs e) {
            textBoxes.TryGetValue(0, out var tbs0);
            textBoxes.TryGetValue(1, out var tbs1);
            textBoxes.TryGetValue(2, out var tbs2);

            tbs0.Shift();
            tbs1.Shift();
            tbs2.Shift();

            SetValue(1, label1);
            SetValue(2, label2);

            ChangeTotal();
        }
        private void rightShift_Click(object sender, EventArgs e) {
            textBoxes.TryGetValue(0, out var tbs0);
            textBoxes.TryGetValue(1, out var tbs1);
            textBoxes.TryGetValue(2, out var tbs2);

            tbs0.Reverse();
            tbs1.Reverse();
            tbs2.Reverse();

            tbs0.Shift();
            tbs1.Shift();
            tbs2.Shift();

            tbs0.Reverse();
            tbs1.Reverse();
            tbs2.Reverse();

            SetValue(1, label1);
            SetValue(2, label2);

            ChangeTotal();
        }

        private void button1_Click(object sender, EventArgs e) {
            allTB.ForEach(t => t.Text = (t.Text == "0") ? "1" : "0");

            SetValue(1, label1);
            SetValue(2, label2);

            ChangeTotal();
        }
    }
}
