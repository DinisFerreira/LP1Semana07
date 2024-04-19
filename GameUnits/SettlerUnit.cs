using System;

namespace GameUnits
{
    public class SettlerUnit : Unit
    {
        // Construtor define o movimento como 1 e a saúde como 3.
        public SettlerUnit() : base(1, 3)
        {
        }

        // Propriedade Cost retorna sempre 5.
        public override float Cost => 5f;
    }
}
