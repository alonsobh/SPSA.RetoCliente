using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSA.RetoCliente.Test
{
    class DirectBCInmemoryDA : BaseTest
    {
        protected override string BusinessComponentUnity => "UnityBCConfiguration.DirectCall";
        protected override string DataAccessUnity => "UnityDAConfiguration.InMemory";
    }
}
