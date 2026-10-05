namespace Ucu.Poo.RolePlayGame
{
    public class Vamplu : Enemy
    {
        public Vamplu(string name, int victoryPoints)
            : base(name, victoryPoints)
        {
            this.Inventory.AddArmor(new Armor(30));
        }
    }
}
