namespace SelectYourPower
{
    internal class Weapon
    {
        public Rectangle sprite;
        public int speed;
        public string name;
        public IBulletMover mover;

        public Weapon(string name, Rectangle sprite, IBulletMover mover, int speed)
        {
            this.name = name;
            this.sprite = sprite;
            this.mover = mover;
            this.speed = speed;
        }
    }
}