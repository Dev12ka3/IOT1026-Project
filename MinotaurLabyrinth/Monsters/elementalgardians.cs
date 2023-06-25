namespace MinotaurLabyrinth
{
    public class FireGuardian : Monster
    {
        public override void Activate(Hero hero, Map map)
        {
            if (!hero.HasSword)
            {
                ConsoleHelper.WriteLine("The Fire Guardian unleashes a powerful flame attack, burning you to ashes!", ConsoleColor.DarkRed);
                hero.IsAlive = false;
            }
            else if (hero.Strength >= 9)
            {
                ConsoleHelper.WriteLine("You engage in a fierce battle with the Fire Guardian using your mighty sword. After a long struggle, you emerge victorious!", ConsoleColor.DarkRed);
                // Add any additional logic for defeating the Fire Guardian here
            }
            else
            {
                ConsoleHelper.WriteLine("The Fire Guardian overpowers you with its intense flames. Your strength is not enough to defeat it!", ConsoleColor.DarkRed);
                // Add any additional logic for the hero being unable to defeat the Fire Guardian here
            }
        }

        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            // Implement the display sense logic for the Fire Guardian
            // This could include messages specific to sensing the Fire Guardian
            return false;
        }

        public override DisplayDetails Display()
        {
            return new DisplayDetails("[F]", ConsoleColor.DarkRed);
        }
    }

    public class WaterGuardian : Monster
    {
        public override void Activate(Hero hero, Map map)
        {
            if (!hero.HasSword)
            {
                ConsoleHelper.WriteLine("The Water Guardian conjures a massive tidal wave, sweeping you away and drowning you!", ConsoleColor.Blue);
                hero.IsAlive = false;
            }
            else if (hero.Strength >= 0.9)
            {
                ConsoleHelper.WriteLine("You face the Water Guardian, utilizing your sword and swift movements to outmaneuver its watery attacks. Eventually, you manage to defeat it!", ConsoleColor.Blue);
                // Add any additional logic for defeating the Water Guardian here
            }
            else
            {
                ConsoleHelper.WriteLine("The Water Guardian overwhelms you with its relentless water-based attacks. Your strength is insufficient to overcome it!", ConsoleColor.Blue);
                // Add any additional logic for the hero being unable to defeat the Water Guardian here
            }
        }

        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            // Implement the display sense logic for the Water Guardian
            // This could include messages specific to sensing the Water Guardian
            return false;
        }

        public override DisplayDetails Display()
        {
            return new DisplayDetails("[W]", ConsoleColor.Blue);
        }
    }

    public class EarthGuardian : Monster
    {
        public override void Activate(Hero hero, Map map)
        {
            if (!hero.HasSword)
            {
                ConsoleHelper.WriteLine("The Earth Guardian summons a mighty earthquake, causing the ground beneath you to collapse. You fall into the abyss!", ConsoleColor.DarkGreen);
                hero.IsAlive = false;
            }
            else if (hero.Strength >= 0.9)
            {
                ConsoleHelper.WriteLine("With your strong sword and unwavering determination, you engage in a fierce battle with the Earth Guardian. Eventually, you manage to overcome its powerful defenses and defeat it!", ConsoleColor.DarkGreen);
                // Add any additional logic for defeating the Earth Guardian here
            }
            else
            {
                ConsoleHelper.WriteLine("The Earth Guardian's formidable strength proves too much for you. Despite your efforts, you are unable to defeat it!", ConsoleColor.DarkGreen);
                // Add any additional logic for the hero being unable to defeat the Earth Guardian here
            }
        }

        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            // Implement the display sense logic for the Earth Guardian
            // This could include messages specific to sensing the Earth Guardian
            return false;
        }

        public override DisplayDetails Display()
        {
            return new DisplayDetails("[E]", ConsoleColor.DarkGreen);
        }
    }
}
