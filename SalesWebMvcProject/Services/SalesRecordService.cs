using Microsoft.EntityFrameworkCore;
using SalesWebMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvcProject.Services {
    public class SalesRecordService {
        private readonly SalesWebMvcProjectContext _context;

        public SalesRecordService(SalesWebMvcProjectContext context) {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate) {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue) {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue) {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();

        }
        public async Task<List<IGrouping<Department, SalesRecord>>> FindByDateGroupingAsync(DateTime? minDate, DateTime? maxDate) {
            var result = from obj in _context.SalesRecord select obj;
            if (minDate.HasValue) {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue) {
                result = result.Where(x => x.Date <= maxDate.Value);
            }
            var returnSales = await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending (x => x.Date)
                .ToListAsync();
            return returnSales.GroupBy(x => x.Seller.Department).ToList();
        }
    }

}



