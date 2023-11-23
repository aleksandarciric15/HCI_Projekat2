using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using Image = System.Windows.Controls.Image;

namespace PuzzleImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string imageName = "image1"; // user enters this
        private static string imageFile = ".\\Images\\" + imageName + ".png";
        Dictionary<int, Stopwatch> results = new Dictionary<int, Stopwatch>();
        private Boolean solved = false;

        Stopwatch timer = new Stopwatch();
        DispatcherTimer timerTick = new DispatcherTimer();

        private int moves = 0;
        private int IndexOfBlankPage = 0;
        private int pictureBoxIndex = 0;
        private List<BitmapImage> listOriginalPictures = new List<BitmapImage>();
        private Image[] images;
        private BitmapImage blankImage = null;
        private Bitmap[,] bitmaps;

        private Dictionary<int, List<int>> mappings = new Dictionary<int, List<int>>();

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;

            mappings.Add(0, new List<int> { 1, 3 });
            mappings.Add(1, new List<int> { 0, 2, 4 });
            mappings.Add(2, new List<int> { 1, 5 });
            mappings.Add(3, new List<int> { 0, 4, 6 });
            mappings.Add(4, new List<int> { 1, 3, 5, 7 });
            mappings.Add(5, new List<int> { 2, 4, 8 });
            mappings.Add(6, new List<int> { 3, 7 });
            mappings.Add(7, new List<int> { 6, 4, 8 });
            mappings.Add(8, new List<int> { 5, 7 });

            bitmaps = new CropImage().method(imageFile);
            SetBitmapImages();

            originalImage.Source = ConvertBitmapToBitmapImage(new Bitmap(imageFile));

            images = new Image[] { im1, im2, im3, im4, im5, im6, im7, im8, im9 };

            timerTick.Interval = TimeSpan.FromSeconds(1);
            timerTick.Tick += timerElapsedTime_Tick;
            btnPause.IsEnabled = false;
        }


        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Pause_Click(object sender, RoutedEventArgs e)
        {
            if ("PAUZIRAJ".Equals(btnPause.Content))
            {
                timer.Stop();
                timerTick.Stop();
                wrpPanel.Visibility = Visibility.Collapsed;
                btnShuffle.IsEnabled = false;
                btnPause.Content = "NASTAVI";
            }
            else
            {
                timer.Start();
                timerTick.Start();
                wrpPanel.Visibility = Visibility.Visible;
                btnShuffle.IsEnabled = true;
                btnPause.Content = "PAUZIRAJ";
            }
        }

        private void Shuffle_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBoxResult.None;
            if (!"00:00:00".Equals(lblTimeElapsed.Content))
            {
                result = MessageBox.Show("Da li zaista želite restartovati?", "", MessageBoxButton.YesNo, MessageBoxImage.Question);
            }
            if (result == MessageBoxResult.Yes || "00:00:00".Equals(lblTimeElapsed.Content))
            {
                Shuffle();
                solved = false;
                timer.Reset();
                timerTick.Stop();
                btnPause.IsEnabled = false;
                lblTimeElapsed.Content = "00:00:00";
                moves = 0;
                lblMovesMade.Content = "Broj poteza: 0";
            }
        }

        private void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 9 };
                Random r = new Random();
                for (int i = 0; i < 9; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    images[i].Source = listOriginalPictures[j];
                    if (j == 9) IndexOfBlankPage = i;
                }
            } while (checkWin());
        }

        private bool checkWin()
        {
            int i = 0;
            for (int j = 0; j < 8; j++, i++)
            {
                if (images[i].Source != listOriginalPictures[j]) break;
            }
            if (i == 8) return true;
            return false;
        }



        private void ClickPictureBoxEvent(object sender, MouseButtonEventArgs e)
        {
            if ("PAUZIRAJ".Equals(btnPause.Content) && !solved)
            {
                Image clickedImage = sender as Image;

                if (clickedImage == null)
                {
                    return;
                }

                pictureBoxIndex = Array.IndexOf(images, clickedImage);
                ExecuteFunction();
            }
        }


        private void ExecuteFunction()
        {
            if ("00:00:00".Equals(lblTimeElapsed.Content))
            {
                timer.Start();
                timerTick.Start();
                btnPause.IsEnabled = true;
            }
            if (IndexOfBlankPage != pictureBoxIndex)
            {
                if (mappings[IndexOfBlankPage].Contains(pictureBoxIndex))
                {
                    images[IndexOfBlankPage].Source = images[pictureBoxIndex].Source;
                    images[pictureBoxIndex].Source = blankImage;
                    IndexOfBlankPage = pictureBoxIndex;
                    lblMovesMade.Content = "Broj poteza: " + (++moves);
                    if (checkWin())
                    {
                        timer.Stop();
                        timerTick.Stop();
                        btnPause.IsEnabled = false;
                        images[8].Source = listOriginalPictures[8];
                        MessageBox.Show("Cestitam! Uspjesno ste slozili sliku!");
                        results.Add(moves, timer);
                        moves = 0;
                        ShowBestResult();
                        lblMovesMade.Content = "Broj poteza: 0";
                        lblTimeElapsed.Content = "00:00:00";
                        solved = true;
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
            if ("PAUZIRAJ".Equals(btnPause.Content) && !solved)
            {
                if (e.Key == Key.NumPad4)
                {
                    List<int> nums = new List<int> { 0, 3, 6, 1, 4, 7 };
                    if (nums.Contains(IndexOfBlankPage))
                    {
                        pictureBoxIndex = IndexOfBlankPage + 1;
                        ExecuteFunction();
                    }

                }
                else if (e.Key == Key.NumPad8)
                {
                    List<int> nums = new List<int> { 0, 1, 2, 3, 4, 5 };
                    if (nums.Contains(IndexOfBlankPage))
                    {
                        pictureBoxIndex = IndexOfBlankPage + 3;
                        ExecuteFunction();
                    }
                }
                else if (e.Key == Key.NumPad6)
                {
                    List<int> nums = new List<int> { 1, 2, 5, 4, 8, 7 };
                    if (nums.Contains(IndexOfBlankPage))
                    {
                        pictureBoxIndex = IndexOfBlankPage - 1;
                        ExecuteFunction();
                    }
                }
                else if (e.Key == Key.NumPad2)
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
                lblTimeElapsed.Content = timer.Elapsed.ToString().Remove(8);
            }

            if (timer.Elapsed.Minutes.ToString() == "3")
            {
                timer.Reset();
                timerTick.Stop();
                lblMovesMade.Content = "Broj poteza: 0";
                lblTimeElapsed.Content = "00:00:00";
                moves = 0;
                btnPause.IsEnabled = false;
                MessageBox.Show("Vrijeme je isteklo! Probajte ponovo!");
                Shuffle();
            }
        }


        private void SetBitmapImages()
        {
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[0,0]));
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[1,0]));
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[2,0]));
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[0,1]));
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[1,1]));
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[2,1]));
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[0,2]));
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[1,2]));
            listOriginalPictures.Add(ConvertBitmapToBitmapImage(bitmaps[2,2]));
            listOriginalPictures.Add(blankImage);
            
        }

        private BitmapImage ConvertBitmapToBitmapImage(Bitmap bitmap)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (var memory = new System.IO.MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;

                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
            }

            return bitmapImage;
        }

    }
}
