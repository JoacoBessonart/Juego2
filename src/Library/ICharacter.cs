namespace Ucu.Poo.RolePlayGame
{
    public interface ICharacter
    {
        string Name { get; }
        int Health { get; }
        int InitialHealth { get; }
        int GetAttackValue();
        int GetDefenseValue();
        void ReceiveAttack(ICharacter attacker);
        void Cure();
    }
}
