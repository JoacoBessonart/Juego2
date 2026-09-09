namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Elementos que puede tener un personaje.
    /// </summary>
    public class Inventory
    {
        public Axe Axe { get; private set; }

        public Armor Armor { get; private set; }

        public MagicStaff MagicStaff { get; private set; }

        public Spellbook Spellbook { get; private set; }

        public Sword Sword { get; private set; }

        public Tunic Tunic { get; private set; }

        public void AddAxe(Axe axe)
        {
            this.Axe = axe;
        }

        public void AddArmor(Armor armor)
        {
            this.Armor = armor;
        }

        public void AddMagicStaff(MagicStaff magicStaff)
        {
            this.MagicStaff = magicStaff;
        }

        public void AddSpellbook(Spellbook spellbook)
        {
            this.Spellbook = spellbook;
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

        public void RemoveMagicStaff()
        {
            this.MagicStaff = null;
        }

        public void RemoveSpellbook()
        {
            this.Spellbook = null;
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

            if (this.Axe != null) total += this.Axe.AttackValue;
            if (this.MagicStaff != null) total += this.MagicStaff.AttackValue;
            if (this.Sword != null) total += this.Sword.AttackValue;
            if (this.Spellbook != null) total += this.Spellbook.GetAttackValue();

            return total;
        }

        public int GetDefenseValue()
        {
            int total = 0;

            if (this.Armor != null) total += this.Armor.DefenseValue;
            if (this.MagicStaff != null) total += this.MagicStaff.DefenseValue;
            if (this.Tunic != null) total += this.Tunic.DefenseValue;
            if (this.Spellbook != null) total += this.Spellbook.GetDefenseValue();

            return total;
        }
    }
}
