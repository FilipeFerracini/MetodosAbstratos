using System.Globalization;

namespace Exercicio_de_Fixacao.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxAmmout();
        public override string ToString()
        {
            return Name + ": $ " + TaxAmmout().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
