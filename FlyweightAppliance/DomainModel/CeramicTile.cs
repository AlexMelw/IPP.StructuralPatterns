namespace FlyweightAppliance.DomainModel
{
    using System.Drawing;

    public class CeramicTile : ITile
    {
        public static int ObjectCounter = 0;

        Brush paintBrush;

        #region CONSTRUCTORS

        //public int X { get; set; }
        //public int Y { get; set; }
        //public int Width { get; set; }
        //public int Height { get; set; }

        public CeramicTile()
        {
            paintBrush = Brushes.Red;

            //X = x;
            //Y = y;
            //Width = width;
            //Height = height;

            ++ObjectCounter;
        }

        #endregion

        public void Draw(Graphics g, int x, int y, int width, int height)
        {
            g.FillRectangle(paintBrush, x, y, width, height);
        }
    }
}