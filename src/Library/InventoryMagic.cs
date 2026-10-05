namespace Ucu.Poo.RolePlayGame
{
    public class InventoryMagic
    {
        public Item MagicStaff { get; private set; }
        public Item Spellbook { get; private set; }

        public void AddMagicStaff(MagicStaff magicStaff)
        {
            this.MagicStaff = magicStaff;
        }

        public void AddSpellbook(Spellbook spellbook)
        {
            this.Spellbook = spellbook;
        }

        public void RemoveMagicStaff()
        {
            this.MagicStaff = null;
        }

        public void RemoveSpellbook()
        {
            this.Spellbook = null;
        }

        public int GetAttackValue()
        {
            int total = 0;

            if (this.MagicStaff != null)
            {
                total += this.MagicStaff.AttackValue;
            }

            if (this.Spellbook != null)
            {
                total += this.Spellbook.AttackValue;
            }

            return total;
        }

        public int GetDefenseValue()
        {
            int total = 0;

            if (this.MagicStaff != null)
            {
                total += this.MagicStaff.DefenseValue;
            }

            if (this.Spellbook != null)
            {
                total += this.Spellbook.DefenseValue;
            }

            return total;
        }
    }
}
