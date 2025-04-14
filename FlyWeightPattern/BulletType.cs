namespace FlyWeightPattern
{
    public class BulletType
    {
        String color;
        public BulletType(String color)
        {
            this.Color = color;
        }

        public string Color { get => color; set => color = value; }
    }
}
