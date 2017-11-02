namespace FlyweightAppliance.DomainModel
{
    using System.Drawing;

    public interface ITile
    {
        void Draw(Graphics g, int x, int y, int width, int height);
    }
}