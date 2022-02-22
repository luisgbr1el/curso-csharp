namespace ExercicioAula137CSharp.Entities {
    abstract class Tax {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Tax() {

        }

        public Tax(string name, double anualIncome) {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double TaxesPaid();
    }
}
