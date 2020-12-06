using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LabCSH
{
    public enum PlayerType {
        Machine, SmartMachine
    }

    public class PlayerComparer : IComparer<Player>
    {
        public int Compare(Player x, Player y)
        {
            return x.Name.CompareTo(y.Name) * -1;
        }
    }
    public abstract class Player: ICloneable, IComparable, IComparer
    {

        public string Name { get; set; }
        public char Symbol { get; set; }

        public PlayerType type { get; set; }

        public Player(string NAME, char SYMB) {
            Name = NAME;
            Symbol = SYMB;
        }
        //public abstract Pair invent_move(Game game);

        public virtual string ProveUrSelf() {
            return "i cant indentify myself";
        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            s.Append(Name);
            s.Append(" ");
            s.Append(Symbol);
            return s.ToString();
        }

        public override bool Equals(object obj)
        {
            return obj is Player player &&
                   Name == player.Name &&
                   Symbol == player.Symbol;
        }

        public static bool operator == (Player left, Player right)
        {
            if (object.ReferenceEquals(left, null))
            {
                return object.ReferenceEquals(right, null);
            }

            return left.Equals(right);

        }
        public static bool operator !=(Player left, Player right)
        {
            return !(left==right);
        }

        public string Serialize() {
            return JsonConvert.SerializeObject(this);
        }

        public abstract object Clone();

        public int CompareTo(object obj)
        {
            return this.Name.CompareTo((obj as Player).Name);
        }

        public int Compare(object x, object y)
        {
            return (x as Player).Name.CompareTo((y as Player).Name)*-1;
        }
    }
}