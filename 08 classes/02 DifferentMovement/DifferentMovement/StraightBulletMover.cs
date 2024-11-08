﻿namespace SelectYourPower
{
    class StraightBulletMover : IBulletMover
    {
        public void MoveBullet(Bullet bullet, float frameTime)
        {
            bullet.gameObject.position.x += bullet.speed * frameTime;
        }
    }

    class DiagonalBulletMover : IBulletMover
    {
        public void MoveBullet(Bullet bullet, float frameTime)
        {
            bullet.gameObject.position.x += bullet.speed * frameTime;
            bullet.gameObject.position.y += bullet.speed * frameTime;
        }
    }

    class DownwardBulletMover : IBulletMover
    {
        public void MoveBullet(Bullet bullet, float frameTime)
        {
            bullet.gameObject.position.y += bullet.speed * frameTime;
        }
    }
}