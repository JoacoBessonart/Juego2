namespace Ucu.Poo.RolePlayGame
{
    public class Encounter
    {
        public Hero[] Heroes { get; private set; }
        public Enemy[] Enemies { get; private set; }

        public Encounter(Hero[] heroes, Enemy[] enemies)
        {
            this.Heroes = heroes;
            this.Enemies = enemies;
        }

        public void DoEncounter()
        {
            while (this.HasLivingHeroes() && this.HasLivingEnemies())
            {
                int heroIndex = 0;

                foreach (Enemy enemy in this.Enemies)
                {
                    if (enemy.Health > 0 && this.HasLivingHeroes())
                    {
                        while (this.Heroes[heroIndex].Health == 0)
                        {
                            heroIndex++;

                            if (heroIndex == this.Heroes.Length)
                            {
                                heroIndex = 0;
                            }
                        }

                        this.Heroes[heroIndex].ReceiveAttack(enemy);
                        heroIndex++;

                        if (heroIndex == this.Heroes.Length)
                        {
                            heroIndex = 0;
                        }
                    }
                }

                foreach (Hero hero in this.Heroes)
                {
                    if (hero.Health > 0)
                    {
                        foreach (Enemy enemy in this.Enemies)
                        {
                            if (enemy.Health > 0)
                            {
                                enemy.ReceiveAttack(hero);
                            }
                        }
                    }
                }
            }

            foreach (Hero hero in this.Heroes)
            {
                if (hero.VictoryPoints >= 5)
                {
                    hero.Cure();
                    hero.AddVictoryPoints(-5);
                }
            }
        }

        private bool HasLivingHeroes()
        {
            foreach (Hero hero in this.Heroes)
            {
                if (hero.Health > 0)
                {
                    return true;
                }
            }

            return false;
        }

        private bool HasLivingEnemies()
        {
            foreach (Enemy enemy in this.Enemies)
            {
                if (enemy.Health > 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
