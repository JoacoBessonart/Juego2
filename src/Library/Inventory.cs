namespace Ucu.Poo.RolePlayGame
{
    public class Inventory
    {
        public IItem Axe { get; private set; }
        public IItem Armor { get; private set; }
        public IItem Sword { get; private set; }
        public IItem Tunic { get; private set; }

        public void AddAxe(Axe axe)
        {
            this.Axe = axe;
        }

        public void AddArmor(Armor armor)
        {
            this.Armor = armor;
        }

        public void AddSword(Sword sword)
        {
            this.Sword = sword;
        }

        public void AddTunic(Tunic tunic)
        {
            this.Tunic = tunic;
        }

        public void RemoveAxe()
        {
            this.Axe = null;
        }

        public void RemoveArmor()
        {
            this.Armor = null;
        }

        public void RemoveSword()
        {
            this.Sword = null;
        }

        public void RemoveTunic()
        {
            this.Tunic = null;
        }

        public int GetAttackValue()
        {
            int total = 0;

            if (this.Axe != null)
            {
                total += this.Axe.AttackValue;
            }

            if (this.Sword != null)
            {
                total += this.Sword.AttackValue;
            }

            return total;
        }

        public int GetDefenseValue()
        {
            int total = 0;

            if (this.Armor != null)
            {
                total += this.Armor.DefenseValue;
            }

            if (this.Tunic != null)
            {
                total += this.Tunic.DefenseValue;
            }

            return total;
        }
    }
}
