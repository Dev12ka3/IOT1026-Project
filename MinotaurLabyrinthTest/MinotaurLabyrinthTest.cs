using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MinotaurLabyrinth.Tests
{
    [TestClass]
    public class GuardianTests
    {
        [TestMethod]
        public void FireGuardian_Activate_HeroHasSword_WinsAndIncreasesStrength()
        {
            // Arrange
            var hero = new Hero { HasSword = true, Strength = 80 };
            var map = new Map();
            var guardian = new FireGuardian();

            // Act
            guardian.Activate(hero, map);

            // Assert
            Assert.IsTrue(hero.IsAlive);
            Assert.AreEqual(110, hero.Strength);
        }

        [TestMethod]
        public void FireGuardian_Activate_HeroHasNoSword_Dies()
        {
            // Arrange
            var hero = new Hero { HasSword = false, Strength = 80 };
            var map = new Map();
            var guardian = new FireGuardian();

            // Act
            guardian.Activate(hero, map);

            // Assert
            Assert.IsFalse(hero.IsAlive);
            Assert.AreEqual(0, hero.Strength);
        }

        [TestMethod]
        public void WaterGuardian_Activate_HeroHasSword_WinsAndIncreasesStrength()
        {
            // Arrange
            var hero = new Hero { HasSword = true, Strength = 70 };
            var map = new Map();
            var guardian = new WaterGuardian();

            // Act
            guardian.Activate(hero, map);

            // Assert
            Assert.IsTrue(hero.IsAlive);
            Assert.AreEqual(90, hero.Strength);
        }

        [TestMethod]
        public void WaterGuardian_Activate_HeroHasNoSword_Dies()
        {
            // Arrange
            var hero = new Hero { HasSword = false, Strength = 70 };
            var map = new Map();
            var guardian = new WaterGuardian();

            // Act
            guardian.Activate(hero, map);

            // Assert
            Assert.IsFalse(hero.IsAlive);
            Assert.AreEqual(0, hero.Strength);
        }

        // Add more test methods for other scenarios and edge cases

        // You can also add tests for the DisplaySense and Display methods if needed
    }
}
