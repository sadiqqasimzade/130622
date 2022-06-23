using CareoBack.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CareoBack.Services
{
    public class LayoutService
    {
         readonly AppDbContext _context;
        public LayoutService (AppDbContext context)
        {
            _context = context;
        }
        public Dictionary<string,string> Layout()
        {
          return _context.Settings.ToDictionary(s => s.Key, s => s.Value);
        }
    }
}
