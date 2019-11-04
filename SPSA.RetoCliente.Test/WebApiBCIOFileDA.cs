using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPSA.RetoCliente.Test
{
    class WebApiBCIOFileDA : BaseTest
    {
        protected override string BusinessComponentUnity => "UnityBCConfiguration.WebApi";
        protected override string DataAccessUnity => "UnityDAConfiguration.IOFile";
    }
}
