namespace ExercicioAula137CSharp.Entities {
    class CompanyPayer : Tax{

        public int NumberEmployees { get; set; }

        public CompanyPayer(string name, double anualIncome, int numberEmployees)
            :base(name, anualIncome) {
            NumberEmployees = numberEmployees;
        }

        public override double TaxesPaid() {
            double pay = 0.0;

            if (NumberEmployees > 10) {
                pay = (AnualIncome * 1.4) / 10;
                return pay;
            } else {
                pay = (AnualIncome * 1.6) / 10;
                return pay;
            }
        }

    }
}
