using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class TestClass
    {
        [Test]
        public void GetAttackValue_InventoryWithAxeAndSword_ReturnsTotalAttack()
        {
            Inventory inventory = new Inventory();
            inventory.AddAxe(new Axe(20));
            inventory.AddSword(new Sword(15));

            Assert.That(inventory.GetAttackValue(), Is.EqualTo(35));
        }

        [Test]
        public void Cure_InjuredCharacter_RestoresInitialHealth()
        {
            Dwarve character = new Dwarve("Gimli");
            Dwarve attacker = new Dwarve("Thorin");
            attacker.Inventory.AddAxe(new Axe(30));
            character.ReceiveAttack(attacker);
            Assert.That(character.Health, Is.EqualTo(70));

            character.Cure();

            Assert.That(character.Health, Is.EqualTo(character.InitialHealth));
        }
    }
}
