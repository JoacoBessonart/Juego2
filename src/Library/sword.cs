namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Espada que aporta ataque.
    /// </summary>
    public class Sword
    {
        public int AttackValue { get; private set; }

        public int DefenseValue { get; private set; }

        public Sword(int attackValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = 0;
        }
    }
}
