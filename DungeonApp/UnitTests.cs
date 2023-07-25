using Xunit;
using DungeonLibrary;
using System;


namespace DungeonApp
{
    public class UnitTests
    {
        [Fact]
        public void Test_Player_Life()
        {

            //Triple-A Unit Test
            //1. Arrange
            //2. Act
            //3. Assert

            #region Arrange

            Player tp = new Player("Mr. Bill", 75, 50, 100, 100, Race.Human, Weapon.type);

            decimal expectedLife = 100;

            #endregion

            #region Act

            decimal actualLife = tp.Life;

            #endregion

            #region Assert

            Assert.Equal(expectedLife, actualLife);

            #endregion
        }


        [Fact]
        public void Test_Monster_Life()
        {

            //Triple-A Unit Test
            //1. Arrange
            //2. Act
            //3. Assert

            #region Arrange

            Monster nm = new Monster("testMonster", 30, 20, 20, 20, 5, 2, "Monster4Testing");

            decimal expectedLife2 = 20;

            #endregion

            #region Act

            decimal actualLife2 = nm.Life;

            #endregion

            #region Assert

            Assert.Equal(expectedLife2, actualLife2);

            #endregion
        }


        [Fact]
        public void Test_Weapon()
        {

            //Triple-A Unit Test
            //1. Arrange
            //2. Act
            //3. Assert

            #region Arrange

            Weapon tw = new Weapon("Stick", 15, 60, 50, true, WeaponType.Axe);

            decimal expectedMinDamage = 15;

            #endregion

            #region Act

            decimal actualMinDamage = tw.MinDamage;

            #endregion

            #region Assert

            Assert.Equal(expectedMinDamage, actualMinDamage);

            #endregion
        }


        [Fact]
        public void Test_Monster_Min_Damage()
        {

            //Triple-A Unit Test
            //1. Arrange
            //2. Act
            //3. Assert

            #region Arrange

            Monster tmmnd = new Monster("testMonster", 30, 20, 20, 20, 5, 2, "Monster4Testing");

            decimal expectedMinDamage = 2;

            #endregion

            #region Act

            decimal actualMinDamage = tmmnd.MinDamage;

            #endregion

            #region Assert

            Assert.Equal(expectedMinDamage, actualMinDamage);

            #endregion
        }

        [Fact]
        public void Test_Monster_Max_Damage()
        {

            //Triple-A Unit Test
            //1. Arrange
            //2. Act
            //3. Assert

            #region Arrange

            Monster tmmxd = new Monster("testMonster", 30, 20, 20, 20, 5, 2, "Monster4Testing");

            decimal expectedMaxDamage = 5;

            #endregion

            #region Act

            decimal actualMaxDamage = tmmxd.MaxDamage;

            #endregion

            #region Assert

            Assert.Equal(expectedMaxDamage, actualMaxDamage);

            #endregion
        }
    }
}
