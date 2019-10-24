using System;
using System.Collections.Generic;
using System.Text;
using Autoplaats;
using Autoplaats.Data;
using Autoplaats.Data.Helper;
using Autoplaats.Data.Contextinterface;
using Autoplaats.Interfaces;

namespace Autoplaats.Logic
{
    class AutoLogic
    {
        private AutoRepository Repository { get; }

        public AutoLogic(IAutoContext context)
        {
            Repository = new AutoRepository(context);
        }
        void AddAuto(IAuto newAuto)
        {
            Repository.AddAuto(newAuto);
        }

    }
}
