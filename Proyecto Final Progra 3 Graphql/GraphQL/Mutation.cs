using Proyecto_Final_Progra_3_Graphql.IServicio;
using Proyecto_Final_Progra_3_Graphql.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Progra_3_Graphql.GraphQL
{
    public class Mutation
    {
        private readonly IServicioPersona _servicioPersona;
        public Mutation(IServicioPersona servicioEstudiante)
        {
            _servicioPersona = servicioEstudiante;
        }

        public Persona CrearEstudiante(CreatePersonaInput inputPersona)
        {
            return _servicioPersona.Create(inputPersona);
        }

        public Persona BorrarEstudiante(DeletePersonaInput inputPersona)
        {
            return _servicioPersona.Delete(inputPersona);
        }      
    }
}
