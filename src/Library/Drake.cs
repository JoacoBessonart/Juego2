public class Drake : Enemy
{
    public Spellbook Spellbook { get; }

    public Drake(string name, int victoryPoints)
        : base(name, victoryPoints)
    {

        this.Spellbook = new Spellbook();
        this.Spellbook.AddSpell(new Spell(45, 0));
    }
}