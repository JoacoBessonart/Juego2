namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Armadura que aporta defensa.
    /// </summary>
    public class Armor
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Armor(int defenseValue)
        {
            this.AttackValue = 0;
            this.DefenseValue = defenseValue;
        }
    }
}
