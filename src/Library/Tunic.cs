namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Túnica que aporta defensa.
    /// </summary>
    public class Tunic
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Tunic(int defenseValue)
        {
            this.AttackValue = 0;
            this.DefenseValue = defenseValue;
        }
    }
}
