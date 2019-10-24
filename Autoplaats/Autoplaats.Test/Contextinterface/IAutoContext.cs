using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autoplaats.Interfaces;



namespace Autoplaats.Data.Contextinterface
{
    public interface IAutoContext
    {
        void AddAuto(IAuto newAuto);
    }
}
