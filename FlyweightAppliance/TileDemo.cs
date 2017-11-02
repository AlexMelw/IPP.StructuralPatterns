namespace FlyweightAppliance
{
    using System;
    using System.Windows.Forms;
    using DomainModel;

    public partial class TileDemo : Form
    {
        private readonly Random _random = new Random();

        #region CONSTRUCTORS

        public TileDemo() => InitializeComponent();

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            for (int i = 0; i < 20; i++)
            {
                ITile ceramicTile = TileFactory.GetTile("Ceramic");
                ceramicTile.Draw(
                    e.Graphics,
                    GetRandomNumber(),
                    GetRandomNumber(),
                    GetRandomNumber(),
                    GetRandomNumber());
            }

            for (int i = 0; i < 20; i++)
            {
                ITile stoneTile = TileFactory.GetTile("Stone");
                stoneTile.Draw(
                    e.Graphics,
                    GetRandomNumber(),
                    GetRandomNumber(),
                    GetRandomNumber(),
                    GetRandomNumber());
            }

            toolStripStatusLabel1.Text =
                $@"Total Objects Created : {Convert.ToString(CeramicTile.ObjectCounter + StoneTile.ObjectCounter)}";
        }

        private int GetRandomNumber() => _random.Next(100);
    }
}