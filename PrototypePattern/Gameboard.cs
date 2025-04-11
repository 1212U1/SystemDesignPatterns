using System.Text;

namespace PrototypePattern
{
    public class Gameboard : IPrototype<Gameboard>
    {
        public List<Gamepiece> pieces;
        public Gameboard() { pieces = new List<Gamepiece>(); }
        public void AddGamePieces(Gamepiece gamepiece)
        {
            pieces.Add(gamepiece);
        }

        public Gameboard Clone()
        {
            Gameboard gameboard = new Gameboard();
            foreach (Gamepiece gamepiece in pieces)
            {
                gameboard.AddGamePieces(gamepiece.Clone());
            }
            return gameboard;
        }
        public String GetBoardState()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Gamepiece gamepiece in pieces)
            {
                stringBuilder.AppendLine(gamepiece.Color + " " + gamepiece.Position);
            }
            return stringBuilder.ToString();
        }
    }
}
