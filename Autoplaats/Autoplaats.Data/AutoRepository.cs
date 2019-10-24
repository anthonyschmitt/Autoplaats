using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autoplaats.Data.Contextinterface;


namespace Autoplaats.Data
{

    public class AutoRepository
    {
        private readonly IAutoContext _context;

        public AutoRepository(IAutoContext context)
        {
            _context = context;
        }
        public void AddAuto(IAuto newAuto)
        {
            _context.AddAuto(newAuto);
        }
    }
}
