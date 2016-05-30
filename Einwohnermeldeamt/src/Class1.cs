using Microsoft.Xna.Framework.Graphics;

namespace GameProject
{
    public class Player
    {
        public int positionX { get; set; }
        public int positionY { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public Texture2D image { get; set; }
        public int centerX { get; set; }
        public int centerY { get; set; }

        public Player(int x, int y, int h, int w)
        {
            positionX = x;
            positionY = y;

            height = h;
            width = w;

            centerX = positionX + width / 2;

            centerY = positionY + height / 2;
        }

        public void move(int x, int y)
        {
            positionX += x;
            positionY += y;
        }
    }
}
