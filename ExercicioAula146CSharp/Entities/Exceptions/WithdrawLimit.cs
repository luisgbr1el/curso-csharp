using System;

namespace ExercicioAula146CSharp.Entities.Exceptions {
    class WithdrawLimit : ApplicationException {
        public WithdrawLimit(string message) : base(message) {
        }
    }
}
