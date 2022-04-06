using System;

namespace SalesWebMvcProject.Services.Exceptions {
    public class NotFoundException : ApplicationException {
        public NotFoundException(string message) : base(message) {
        }
    }
}
