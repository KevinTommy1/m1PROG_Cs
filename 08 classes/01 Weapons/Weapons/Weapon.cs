﻿namespace SelectYourPower
{
    internal class Weapon
    {
        public Rectangle sprite;
        public int speed;
        public string name;

        public Weapon(string name, Rectangle sprite, int speed)
        {
            this.name = name;
            this.sprite = sprite;
            this.speed = speed;
        }
    }
}