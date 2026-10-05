using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class VictoryPointsTests
    {
        [Test]
        public void ReceiveAttack_NonFatalAttack_DoesNotGiveVictoryPoints()
        {
            Dwarve hero = new Dwarve("Gimli");
            Goblin enemy = new Goblin("Duende", 10);
            hero.Inventory.AddAxe(new Axe(30));

            enemy.ReceiveAttack(hero);

            Assert.That(enemy.Health, Is.EqualTo(70));
            Assert.That(hero.VictoryPoints, Is.EqualTo(0));
        }

        [Test]
        public void ReceiveAttack_HeroKillsTwoEnemies_AccumulatesVictoryPoints()
        {
            Wizard hero = new Wizard("Gandalf");
            Goblin firstEnemy = new Goblin("Duende", 10);
            Goblin secondEnemy = new Goblin("Otro duende", 20);
            hero.InventoryMagic.AddMagicStaff(new MagicStaff(100, 0));

            firstEnemy.ReceiveAttack(hero);
            secondEnemy.ReceiveAttack(hero);

            Assert.That(firstEnemy.Health, Is.EqualTo(0));
            Assert.That(secondEnemy.Health, Is.EqualTo(0));
            Assert.That(hero.VictoryPoints, Is.EqualTo(30));
        }

        [Test]
        public void ReceiveAttack_EnemyKillsEnemy_DoesNotAccumulateVictoryPoints()
        {
            Goblin attacker = new Goblin("Atacante", 20);
            Goblin target = new Goblin("Duende", 10);
            attacker.Inventory.AddAxe(new Axe(100));

            target.ReceiveAttack(attacker);

            Assert.That(target.Health, Is.EqualTo(0));
            Assert.That(attacker.VictoryPoints, Is.EqualTo(20));
        }
    }
}
