namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Mago del juego.
    /// </summary>
    public class Wizard
    {
        public string Name { get; private set; }

        public Inventory Inventory { get; private set; }

        public int Health { get; private set; }

        public int InitialHealth { get; private set; }

        public Wizard(string name)
        {
            this.Name = name;
            this.InitialHealth = 100;
            this.Health = this.InitialHealth;
            this.Inventory = new Inventory();
        }

        public int GetAttackValue()
        {
            return this.Inventory.GetAttackValue();
        }

        public int GetDefenseValue()
        {
            return this.Inventory.GetDefenseValue();
        }

        public void ReceiveAttack(int power)
        {
            this.Health -= power;

            if (this.Health < 0) this.Health = 0;
        }

        public void Cure()
        {
            this.Health = this.InitialHealth;
        }
    }
}
