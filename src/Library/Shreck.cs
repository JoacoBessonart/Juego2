namespace Ucu.Poo.RolePlayGame
{
    public class Shreck : Enemy
    {
        public Shreck(string name, int victoryPoints)
            : base(name, victoryPoints)
        {
            this.Inventory.AddAxe(new Axe(40));
        }
    }
}