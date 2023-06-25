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
            else if (hero.Strength <= 90)
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
            if (heroDistance == 1)
            {
                ConsoleHelper.WriteLine("You sense the presence of a guardian nearby.", ConsoleColor.Yellow);
                ConsoleHelper.WriteLine("You feel the heat radiating from the Fire Guardian.", ConsoleColor.Yellow);
                // Add specific attributes or alerts for sensing the Fire Guardian at distance 1
            }
            else if (heroDistance == 2)
            {
                ConsoleHelper.WriteLine("You sense the presence of a guardian in the distance.", ConsoleColor.Yellow);
                ConsoleHelper.WriteLine("The intensity of heat increases. The Fire Guardian is near.", ConsoleColor.Yellow);
                // Add specific attributes or alerts for sensing the Fire Guardian at distance 2
            }

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
            else if (hero.Strength <= 90)
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
            if (heroDistance == 1)
            {
                ConsoleHelper.WriteLine("You sense the presence of a guardian nearby.", ConsoleColor.Yellow);
                ConsoleHelper.WriteLine("You hear the sound of flowing water from the Water Guardian.", ConsoleColor.Yellow);
                // Add specific attributes or alerts for sensing the Water Guardian at distance 1
            }
            else if (heroDistance == 2)
            {
                ConsoleHelper.WriteLine("You sense the presence of a guardian in the distance.", ConsoleColor.Yellow);
                ConsoleHelper.WriteLine("The sound of flowing water grows louder. The Water Guardian is near.", ConsoleColor.Yellow);
                // Add specific attributes or alerts for sensing the Water Guardian at distance 2
            }

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
                ConsoleHelper.WriteLine("The Earth Guardian summons a mighty earthquake, causing the ground beneath you to collapse. You fall into the abyss!", ConsoleColor.DarkMagenta);
                hero.IsAlive = false;
            }
            else if (hero.Strength <= 90)
            {
                ConsoleHelper.WriteLine("With your strong sword and unwavering determination, you engage in a fierce battle with the Earth Guardian. Eventually, you manage to overcome its powerful defenses and defeat it!", ConsoleColor.DarkMagenta);
                // Add any additional logic for defeating the Earth Guardian here
            }
            else
            {
                ConsoleHelper.WriteLine("The Earth Guardian's formidable strength proves too much for you. Despite your efforts, you are unable to defeat it!", ConsoleColor.DarkMagenta);
                // Add any additional logic for the hero being unable to defeat the Earth Guardian here
            }
        }

        public override bool DisplaySense(Hero hero, int heroDistance)
        {
            if (heroDistance == 1)
            {
                ConsoleHelper.WriteLine("You sense the presence of a guardian nearby.", ConsoleColor.Yellow);
                ConsoleHelper.WriteLine("You feel the ground trembling beneath you near the Earth Guardian.", ConsoleColor.Yellow);
                // Add specific attributes or alerts for sensing the Earth Guardian at distance 1
            }
            else if (heroDistance == 2)
            {
                ConsoleHelper.WriteLine("You sense the presence of a guardian in the distance.", ConsoleColor.Yellow);
                ConsoleHelper.WriteLine("The ground continues to shake. The Earth Guardian is near.", ConsoleColor.Yellow);
                // Add specific attributes or alerts for sensing the Earth Guardian at distance 2
            }

            return false;
        }


        public override DisplayDetails Display()
        {
            return new DisplayDetails("[E]", ConsoleColor.DarkMagenta);
        }
    }
}
