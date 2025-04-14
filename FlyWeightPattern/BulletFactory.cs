namespace FlyWeightPattern
{
    public static class BulletFactory
    {
        private static readonly Dictionary<String, BulletType> bulletTypeCollection;

        static BulletFactory()
        {
            bulletTypeCollection = new Dictionary<String, BulletType>();
        }
        public static BulletType GetBulletType(String color)
        {
            if (!bulletTypeCollection.ContainsKey(color))
            {
                bulletTypeCollection.Add(color, new BulletType(color));
            }
            return bulletTypeCollection[color];
        }


    }
}
