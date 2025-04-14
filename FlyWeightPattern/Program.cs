using FlyWeightPattern;

Bullet bullet = new Bullet(5, 3, "Red");
Bullet bulletTwo = new Bullet(5, 3, "Red");
Console.WriteLine(bullet.GetBulletDetails());
Console.WriteLine(bulletTwo.BulletType.Equals(bullet.BulletType).ToString());
