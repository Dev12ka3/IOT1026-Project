namespace MinotaurLabyrinth
{
    public class Sword : Room
    {
        private readonly Monster[] _monsters;

        public Sword(Monster[] monsters)
        {
            _monsters = monsters;
        }

        static Sword()
        {
            RoomFactory.Instance.Register(RoomType.Sword, () => new Sword(null));
        }

        public override RoomType Type { get; } = RoomType.Sword;

        public override DisplayDetails Display()
        {
            return new DisplayDetails($"[{Type.ToString()[0]}]", ConsoleColor.Yellow);
        }

        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            if (heroDistance == 0)
            {
                if (hero.HasSword)
                {
                    ConsoleHelper.WriteLine("This is the sword room, but you've already picked up the sword!", ConsoleColor.DarkCyan);
                }
                else
                {
                    ConsoleHelper.WriteLine("You can sense that the sword is nearby!", ConsoleColor.DarkCyan);
                    if (_monsters != null && _monsters.Length > 0)
                    {
                        ConsoleHelper.WriteLine("Beware! The room is guarded by powerful elemental monsters:", ConsoleColor.DarkCyan);
                        foreach (var monster in _monsters)
                        {
                            ConsoleHelper.WriteLine($"- {monster.Name} ({monster.Element} monster)", ConsoleColor.DarkCyan);
                        }
                    }
                }
                return true;
            }
            return false;
        }
    }
}
