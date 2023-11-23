using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleImage
{
    public partial class Form1 : Form
    {
        public static string imageName = "image1"; // user enters this
        private static string imageFile = ".\\Images\\" + imageName + ".png";
        private static string outputFolder = "\\Images\\WorkingImage\\";
        Dictionary<int, Stopwatch> results = new Dictionary<int, Stopwatch>();

        Stopwatch timer = new Stopwatch();

        private int moves = 0;
        private int IndexOfBlankPage = 0;
        private int pictureBoxIndex = 0;
        private List<Bitmap> listOriginalPictures = new List<Bitmap>();
        private Bitmap blankImage = null;

        private Dictionary<int, List<int>> mappings = new Dictionary<int, List<int>>();


        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            mappings.Add(0, new List<int>{1, 3});
            mappings.Add(1, new List<int>{0, 2, 4});
            mappings.Add(2, new List<int>{1, 5});
            mappings.Add(3, new List<int>{0, 4, 6});
            mappings.Add(4, new List<int>{1, 3, 5, 7});
            mappings.Add(5, new List<int>{2, 4, 8});
            mappings.Add(6, new List<int>{3, 7});
            mappings.Add(7, new List<int>{6, 4, 8});
            mappings.Add(8, new List<int>{5, 7});

            Bitmap[,] bitmaps = new CropImage().method(imageFile, outputFolder);

            listOriginalPictures.AddRange(new Bitmap[] { bitmaps[0, 0], bitmaps[1, 0], bitmaps[2, 0],
            bitmaps[0,1], bitmaps[1,1], bitmaps[2,1], bitmaps[0,2], bitmaps[1,2], bitmaps[2,2], blankImage});

            originalImage.Image = new Bitmap(imageFile);
            originalImage.SizeMode = PictureBoxSizeMode.Zoom;

            lblMovesMade.Text += moves;
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (btnPause.Text == "PAUZIRAJ")
            {
                timer.Stop();
                groupBox1.Visible = false;
                btnPause.Text = "NASTAVI";
            }
            else
            {
                timer.Start();
                groupBox1.Visible = true;
                btnPause.Text = "PAUZIRAJ";
            }
        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            DialogResult result = new DialogResult();
            if (lblTimeElapsed.Text != "00:00:00")
            {
                result = MessageBox.Show("Da li zaista zelite restartovati?","" ,MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (result == DialogResult.Yes || lblTimeElapsed.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimeElapsed.Text = "00:00:00";
                moves = 0;
                lblMovesMade.Text = "Broj poteza: 0";
            }
        }

        private void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 , 9 };
                Random r = new Random();
                for (int i=0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)groupBox1.Controls[i]).Image = listOriginalPictures[j];
                    if (j == 9) IndexOfBlankPage = i;
                }
            } while (checkWin());
        }

        private bool checkWin()
        {
            int i = 0;
            for (int j=0; j < 8; j++, i++)
            {
                if ((groupBox1.Controls[i] as PictureBox).Image != listOriginalPictures[j]) break;
            }
            if (i == 8) return true;
            return false;
        }

        private void ClickPictureBoxEvent(object sender, EventArgs e)
        {
            if (btnPause.Text == "PAUZIRAJ")
            {
                pictureBoxIndex = groupBox1.Controls.IndexOf(sender as Control);
                ExecuteFunction();
            }
        }

        private void ExecuteFunction()
        {
            if (lblTimeElapsed.Text == "00:00:00")
            {
                timer.Start();
            }
            if (IndexOfBlankPage != pictureBoxIndex)
            {
                List<int> fourNeighbours = new List<int>(new int[] { pictureBoxIndex - 1, pictureBoxIndex - 3,
                    pictureBoxIndex + 1, pictureBoxIndex + 3});
                if (mappings[IndexOfBlankPage].Contains(pictureBoxIndex))
                {
                    ((PictureBox)groupBox1.Controls[IndexOfBlankPage]).Image = ((PictureBox)groupBox1.Controls[pictureBoxIndex]).Image;
                    ((PictureBox)groupBox1.Controls[pictureBoxIndex]).Image = blankImage;
                    IndexOfBlankPage = pictureBoxIndex;
                    lblMovesMade.Text = "Broj poteza: " + (++moves);
                    if (checkWin())
                    {
                        timer.Stop();
                        (groupBox1.Controls[8] as PictureBox).Image = listOriginalPictures[8];
                        MessageBox.Show("Cestitam! Uspjesno ste slozili sliku!");
                        results.Add(moves, timer);
                        moves = 0;
                        ShowBestResult();
                        lblMovesMade.Text = "Broj poteza: 0";
                        lblTimeElapsed.Text = "00:00:00";
                        timer.Reset();
                    }
                }
            }
        }

        private void ShowBestResult()
        {
            if (results.Count > 0)
            {
                var minPair = results.OrderBy(kv => kv.Key).First();
                MessageBox.Show("Nabolji rezultat je: Broj poteza=" + minPair.Key);
            }
            else
            {
                MessageBox.Show("Niko do sada nije rijeso slagalicu!");
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (btnPause.Text == "PAUZIRAJ")
            {
                if (e.KeyCode == Keys.NumPad4)
                {
                    List<int> nums = new List<int> { 0, 3, 6, 1, 4, 7 };
                    if (nums.Contains(IndexOfBlankPage))
                    {
                        pictureBoxIndex = IndexOfBlankPage + 1;
                        ExecuteFunction();
                    }

                }
                else if (e.KeyCode == Keys.NumPad8)
                {
                    List<int> nums = new List<int> { 0, 1, 2, 3, 4, 5 };
                    if (nums.Contains(IndexOfBlankPage))
                    {
                        pictureBoxIndex = IndexOfBlankPage + 3;
                        ExecuteFunction();
                    }
                }
                else if (e.KeyCode == Keys.NumPad6)
                {
                    List<int> nums = new List<int> { 1, 2, 5, 4, 8, 7 };
                    if (nums.Contains(IndexOfBlankPage))
                    {
                        pictureBoxIndex = IndexOfBlankPage - 1;
                        ExecuteFunction();
                    }
                }
                else if (e.KeyCode == Keys.NumPad2)
                {
                    List<int> nums = new List<int> { 3, 4, 5, 6, 7, 8 };
                    if (nums.Contains(IndexOfBlankPage))
                    {
                        pictureBoxIndex = IndexOfBlankPage - 3;
                        ExecuteFunction();
                    }
                }
            }
        }

        private void timerElapsedTime_Tick(object sender, EventArgs e)
        {
            if (timer.Elapsed.ToString() != "00:00:00")
            {
                lblTimeElapsed.Text = timer.Elapsed.ToString().Remove(8);
            }
            if (timer.Elapsed.ToString() == "00:00:00")
            {
                btnPause.Enabled = false;
            }
            else
            { 
                btnPause.Enabled = true;
            }

            if (timer.Elapsed.Minutes.ToString() == "3")
            {
                timer.Reset();
                lblMovesMade.Text = "Broj poteza: 0";
                lblTimeElapsed.Text = "00:00:00";
                moves = 0;
                btnPause.Enabled = false;
                MessageBox.Show("Vrijeme je isteklo! Probajte ponovo!");
                Shuffle();
            }
        }
        
    }
}
