using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace enemyCreator.Tests
{
    [TestClass]
    public class enemyProgramTests
    {
        Random rand = new Random();
        [TestMethod]
        public void enemy_1_2_3_4or5returned()
        {
            // arrange настроить необходимые данные
            int enemySpriteCounter = 1;
            int expected = 1;
            
            // act действие
            enemyProgram c = new enemyProgram();
            int actual = c.enemy(enemySpriteCounter);
            // assert понять, работает ли код правильнг
            Assert.AreEqual(expected, actual);
            

        }
    }
}
