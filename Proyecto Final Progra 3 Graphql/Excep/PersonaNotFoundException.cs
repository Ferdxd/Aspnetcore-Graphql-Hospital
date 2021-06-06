using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Progra_3_Graphql.Excep
{
    public class PersonaNotFoundException:Exception
    {
        public int PersonaId { get; internal set; }

    }
}
