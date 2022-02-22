namespace ExercicioAula137CSharp.Entities {
    class IndividualPayer : Tax {

        public double HealthExpenditures { get; set; }

        public IndividualPayer() {

        }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures)
        :base(name, anualIncome) {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid() {
            double pay = 0.0;
            if (AnualIncome < 20000.00) {
                pay = (AnualIncome * 1.5) / 10;
                pay -= HealthExpenditures / 2;

                return pay;
            } else {
                pay = (AnualIncome * 2.5) / 10;
                pay -= HealthExpenditures / 2;
                return pay;
            }
            
        }
    }
}
