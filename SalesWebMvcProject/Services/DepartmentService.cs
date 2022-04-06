using SalesWebMvcProject.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvcProject.Services {
    public class DepartmentService {
        private readonly SalesWebMvcProjectContext _context;

        public DepartmentService(SalesWebMvcProjectContext context) {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync() {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
