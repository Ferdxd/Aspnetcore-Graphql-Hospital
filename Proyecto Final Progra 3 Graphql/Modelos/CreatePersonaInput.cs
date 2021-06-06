using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Progra_3_Graphql.Modelos
{
    public class CreatePersonaInput
    {
        public string Nombre { get; set; }
        public int Area { get; set; }
        public string Sexo { get; set; }
    }
}
