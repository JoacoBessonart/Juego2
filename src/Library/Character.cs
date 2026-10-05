namespace Ucu.Poo.RolePlayGame
{
    public abstract class Character
    {
        public string Name { get; private set; }
        public Inventory Inventory { get; private set; }
        public int Health { get; private set; }
        public int InitialHealth { get; private set; }

        public Character(string name)
        {
            this.Name = name;
            this.InitialHealth = 100;
            this.Health = this.InitialHealth;
            this.Inventory = new Inventory();
        }

        public virtual int GetAttackValue()
        {
            return this.Inventory.GetAttackValue();
        }

        public virtual int GetDefenseValue()
        {
            return this.Inventory.GetDefenseValue();
        }

        public virtual void ReceiveAttack(Character attacker)
        {
            if (attacker != null)
            {
                int damage = attacker.GetAttackValue() - this.GetDefenseValue();

                // La defensa puede bloquear el ataque, pero no recuperar vida.
                if (damage > 0)
                {
                    this.Health -= damage;
                }

                if (this.Health < 0)
                {
                    this.Health = 0;
                }
            }
        }

        public void Cure()
        {
            this.Health = this.InitialHealth;
        }
    }
}
