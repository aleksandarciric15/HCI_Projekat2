using System.Drawing;

namespace PuzzleImage
{
    public class CropImage
    {
        public Bitmap[,] method(string filePath)
        {

            Bitmap originalImage = new Bitmap(filePath);

            int width = originalImage.Width;
            int height = originalImage.Height;

            int partWidth = width / 3;
            int partHeight = height / 3;

            Bitmap[,] parts = new Bitmap[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    parts[i, j] = new Bitmap(partWidth, partHeight);

                    using (Graphics g = Graphics.FromImage(parts[i, j]))
                    {
                        g.DrawImage(originalImage, new Rectangle(0, 0, partWidth, partHeight), new Rectangle(i * partWidth, j * partHeight, partWidth, partHeight), GraphicsUnit.Pixel);
                    }
                }
            }

            return parts;
        }
    }
}
