namespace FlyWeightPattern
{
    public class Bullet
    {
        //extrinsic properties
        private Int32 X;
        private Int32 Y;
        //intrinsic properties
        private BulletType bulletType;
        public Bullet(Int32 x, Int32 y, String color)
        {
            this.X = x;
            this.Y = y;
            this.BulletType = BulletFactory.GetBulletType(color);
        }

        public BulletType BulletType { get => bulletType; set => bulletType = value; }

        public String GetBulletDetails()
        {
            return this.X.ToString() + " " + this.Y + " " + this.BulletType.Color;
        }
    }
}
