using System;

namespace SalesWebMvcProject.Services.Exceptions {
    public class DbConcurrencyException : ApplicationException {

        public DbConcurrencyException(string message) : base(message) {
        }
    }
}
