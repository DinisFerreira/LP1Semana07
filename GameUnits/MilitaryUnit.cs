using System;

namespace GameUnits
{
    public class MilitaryUnit : Unit // Herança!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        // Health property é calculada adicionando XP ao valor base.
        public override int Health
        {
            get => base.Health + XP;
            set => base.Health = value;
        }

        // Cost property é calculada somando AttackPower e XP.
        public override float Cost => AttackPower + XP;

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        // Método de ataque. Incrementa a XP e reduz a saúde da unidade alvo.
        public void Attack(Unit u)
        {
            XP++;
            u.Health -= AttackPower;
        }

        // Método ToString que retorna uma representação em string dos atributos da unidade.
        public override string ToString() =>
            $"{GetType().Name}: HP={Health} COST={Cost:F2} AP={AttackPower} XP={XP}";
    }
}
