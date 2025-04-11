namespace PrototypePattern
{
    public class Gamepiece : IPrototype<Gamepiece>
    {
        private String color;
        private Int32 position;
        public Gamepiece(String color, Int32 position)
        {
            this.Color = color;
            this.Position = position;
        }

        public string Color { get => color; set => color = value; }
        public int Position { get => position; set => position = value; }

        public Gamepiece Clone()
        {
            return new Gamepiece(color, position);
        }
    }
}
