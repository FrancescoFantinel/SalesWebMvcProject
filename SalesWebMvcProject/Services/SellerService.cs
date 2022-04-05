using SalesWebMvcProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvcProject.Services {
    public class SellerService {
        private readonly SalesWebMvcProjectContext _context;

        public SellerService(SalesWebMvcProjectContext context) {
            _context = context;
        }
        
        public List<Seller> FindAll() {
            return _context.Seller.ToList();
        }
    }
}
