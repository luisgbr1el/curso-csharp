using ExercicioAula146CSharp.Entities.Exceptions;

namespace ExercicioAula146CSharp.Entities {
    class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() {

        }

        public Account(int number, string holder, double balance, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public double Withdraw(double amount) {
            if (amount > WithdrawLimit) {
                throw new WithdrawLimit("The amount exceeds withdraw limit");
            } else {
                return Balance -= amount;
            }
            
        }
    }
}
