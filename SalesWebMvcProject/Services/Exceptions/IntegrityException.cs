using System;

namespace SalesWebMvcProject.Services.Exceptions {
    public class IntegrityException : ApplicationException {
        public IntegrityException(string message) : base(message) { 
        }

    }
}
