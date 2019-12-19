using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_de_Fixacao.Entities
{
    class Individual : TaxPayer
    {
        public double Health { get; set; }

        public Individual(string name, double anualIncome, double health) : base(name, anualIncome)
        {
            Health = health;
        }

        public override double TaxAmmout()
        {
            if (AnualIncome < 20000.00)
                return 0.15* AnualIncome - 0.5*Health;
            else
            return 0.25* AnualIncome - 0.5*Health;
        }
    }
}
