using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinotaurLabyrinthTest
{
    [TestClass]
    public class GuardianTests
    {
        private MinotaurLabyrinth.Hero CreateHero()
        {
            MinotaurLabyrinth.Location startLocation = new MinotaurLabyrinth.Location(0, 0); // Choose the desired starting location
            return new MinotaurLabyrinth.Hero(startLocation);
        }

        private MinotaurLabyrinth.Map CreateMap()
        {
            int rows = 5; // Choose the desired number of rows
            int columns = 5; // Choose the desired number of columns
            return new MinotaurLabyrinth.Map(rows, columns);
        }

        [TestMethod]
        public void FireGuardian_Activate_HeroWithoutSword_DeathMessageDisplayed()
        {
            // Arrange
            MinotaurLabyrinth.Hero hero = CreateHero();
            hero.HasSword = false;
            MinotaurLabyrinth.Map map = CreateMap();
            MinotaurLabyrinth.FireGuardian fireGuardian = new MinotaurLabyrinth.FireGuardian();
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            fireGuardian.Activate(hero, map);

            // Assert
            Assert.IsFalse(hero.IsAlive);
            Assert.AreEqual("The Fire Guardian unleashes a powerful flame attack, burning you to ashes!", stringWriter.ToString().Trim());
        }

        [TestMethod]
        public void FireGuardian_Activate_HeroWithLowStrength_VictoryMessageDisplayed()
        {
            // Arrange
            MinotaurLabyrinth.Hero hero = CreateHero();
            hero.HasSword = true;
            hero.Strength = 90;
            MinotaurLabyrinth.Map map = CreateMap();
            MinotaurLabyrinth.FireGuardian fireGuardian = new MinotaurLabyrinth.FireGuardian();
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            fireGuardian.Activate(hero, map);

            // Assert
            Assert.IsTrue(hero.IsAlive);
            Assert.AreEqual("You engage in a fierce battle with the Fire Guardian using your mighty sword. After a long struggle, you emerge victorious!", stringWriter.ToString().Trim());
        }

        [TestMethod]
        public void FireGuardian_Activate_HeroWithHighStrength_DeathMessageDisplayed()
        {
            // Arrange
            MinotaurLabyrinth.Hero hero = CreateHero();
            hero.HasSword = true;
            hero.Strength = 100;
            MinotaurLabyrinth.Map map = CreateMap();
            MinotaurLabyrinth.FireGuardian fireGuardian = new MinotaurLabyrinth.FireGuardian();
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            fireGuardian.Activate(hero, map);

            // Assert
            Assert.IsFalse(hero.IsAlive);
            Assert.AreEqual("The Fire Guardian is too powerful for you to defeat. It overwhelms you with its fiery attacks, ending your journey.", stringWriter.ToString().Trim());
        }

        [TestMethod]
        public void WaterGuardian_Activate_HeroWithSword_VictoryMessageDisplayed()
        {
            // Arrange
            MinotaurLabyrinth.Hero hero = CreateHero();
            hero.HasSword = true;
            MinotaurLabyrinth.Map map = CreateMap();
            MinotaurLabyrinth.WaterGuardian waterGuardian = new MinotaurLabyrinth.WaterGuardian();
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act
            waterGuardian.Activate(hero, map);

            // Assert
            Assert.IsTrue(hero.IsAlive);
            Assert.AreEqual("You engage in a fierce battle with the Water Guardian using your mighty sword. With a decisive strike, you defeat the guardian and emerge victorious!", stringWriter.ToString().Trim());
        }
    }
}
