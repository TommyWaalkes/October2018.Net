using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MonsterFighter.Models
{
    public class Combatant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }

        public void AttackEnemy(Combatant opponent)
        {
            opponent.Hp -= this.Attack;
        }

        public bool IsDead()
        {
            if(Hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class Fighter : Combatant
    {
        public int Gold { get; set; }
        public int Lives { get; set; }
    }

    public class Monster : Combatant
    {
        public int GoldDropped { get; set; }
    }

    public class CombatantContext : DbContext 
    {
        DbSet<Monster> Monsters { get; set; }
        DbSet<Fighter> Fighters { get; set; }

        public System.Data.Entity.DbSet<MonsterFighter.Models.Combatant> Combatants { get; set; }
    }
}