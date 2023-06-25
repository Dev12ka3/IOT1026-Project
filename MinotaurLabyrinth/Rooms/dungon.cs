namespace MinotaurLabyrinth
{
    public class ElementalRoom : Room
    {
        // Add any additional properties or fields specific to the ElementalRoom
        private Monster? _monster;
        
        public override RoomType Type => RoomType.ElementalRoom;

        public override bool IsActive
        {
            get { return _monster != null; }
            protected set { /* In this case, we don't need to set the IsActive property as it is handled by the base class */ }
        }

        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            if (_monster != null && heroDistance <= 2)  // Display sense if hero is close enough
            {
                _monster.DisplaySense(hero, heroDistance);
                return true;  // Message displayed
            }
            return false;  // No message displayed
        }

        public override void Activate(Hero hero, Map map)
        {
            if (_monster != null)
            {
                _monster.Activate(hero, map);
            }
        }

        public override DisplayDetails Display()
        {
            if (_monster != null)
            {
                return _monster.Display();
            }
            else
            {
                return new DisplayDetails("[E]", ConsoleColor.Green);  // Display as an ElementalRoom with a green color
            }
        }
    }
}
