using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper {
    public partial class Form1 : Form {
        private Button[,] tilesBtn = new Button[10, 10];
        private int[,] tilesInt = new int[10, 10];
        private bool[,] isTileDug = new bool[10, 10];
        private string buttonText;
        private int mineAmount = 0, time = 0, amountOfDigsLeft = 0;
        private bool isGameOver = false;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            LoadBoard();
        }

        private void timer_Tick(object sender, EventArgs e) {
            time++;
            timeLabel.Text = $"Time: {time}";
        }

        private void button_MouseDown(object sender, MouseEventArgs e) {
            if (!isGameOver) {
                Button buttonSender = (Button)sender;
                if (e.Button == MouseButtons.Left) {
                    if (buttonSender.Text != "F") {
                        string buttonNum = buttonSender.Name.Replace("button", "");
                        char[] xyChar = buttonNum.ToCharArray();
                        int x = xyChar[0] - 48;
                        int y = xyChar[1] - 48;
                        buttonText = Dig(x, y);
                        buttonSender.Text = buttonText;
                        if (buttonText == "M") {
                            buttonSender.BackColor = Color.Red;
                        } else {
                            buttonSender.BackColor = Color.Transparent;
                        }
                    }
                } else if (e.Button == MouseButtons.Right) {
                    if (buttonSender.BackColor == Color.Green) {
                        buttonSender.Text = "F";
                        buttonSender.BackColor = Color.Blue;
                        mineAmount--;
                    } else if (buttonSender.BackColor == Color.Blue) {
                        buttonSender.Text = "";
                        buttonSender.BackColor = Color.Green;
                        mineAmount++;
                    }
                    flagsLabel.Text = $"Flags: {mineAmount}";
                }
            }
        }

        private void LoadBoard() {
            int maxMines = 10;
            Random random = new Random();
            while (maxMines > 0) {
                for (int x = 0; x < 10; x++) {
                    for (int y = 0; y < 10; y++) {
                        tilesBtn[x, y] = (Button)(this.Controls[$"button{x}{y}"]);
                        tilesBtn[x, y].BackColor = Color.Green;
                        int rand = random.Next(0, 10);
                        if (rand == 2 && maxMines > 0) {
                            tilesInt[x, y] = -1;
                            maxMines--;
                            mineAmount++;
                            for (int xFor = -1; xFor < 2; xFor++) {
                                for (int yFor = -1; yFor < 2; yFor++) {
                                    if ((x + xFor < 10 && x + xFor >= 0) && (y + yFor < 10 && y + yFor >= 0)) {
                                        if (tilesInt[x + xFor, y + yFor] != -1) {
                                            tilesInt[x + xFor, y + yFor]++;
                                            amountOfDigsLeft++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            flagsLabel.Text = $"Flags: {mineAmount}";
        }

        private string Dig(int x, int y) {
            timer.Enabled = true;
            isTileDug[x, y] = true;

            amountOfDigsLeft = 90;
            foreach (bool tile in isTileDug) {
                if (tile) {
                    amountOfDigsLeft--;
                }
            }

            if (tilesInt[x, y] == 0) {
                for (int xFor = -1; xFor < 2; xFor++) {
                    for (int yFor = -1; yFor < 2; yFor++) {
                        if ((x + xFor < 10 && x + xFor >= 0) && (y + yFor < 10 && y + yFor >= 0)) {
                            if (!isTileDug[x + xFor, y + yFor]) {
                                DigTask(x + xFor, y + yFor);
                            }
                        }
                    }
                }
                if (amountOfDigsLeft <= 0) {
                    isGameOver = true;
                    timer.Enabled = false;
                }
                return "";
            }

            if (tilesInt[x, y] > 0) {
                if (amountOfDigsLeft <= 0) {
                    isGameOver = true;
                    timer.Enabled = false;
                }
                return tilesInt[x, y].ToString();
            }

            amountOfDigsLeft++;
            timer.Enabled = false;
            isGameOver = true;
            return "M";
        }

        private async Task DigTask(int x, int y) {
            await Task.Yield();
            string retVal = Dig(x, y);
            tilesBtn[x, y].Text = retVal;
            tilesBtn[x, y].BackColor = Color.Transparent;
        }

        private void Victory() {

        }

    }
}
