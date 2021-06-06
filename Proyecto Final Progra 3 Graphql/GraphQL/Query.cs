using HotChocolate.Types;
using Proyecto_Final_Progra_3_Graphql.IServicio;
using Proyecto_Final_Progra_3_Graphql.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Progra_3_Graphql.GraphQL
{
    public class Query
    {
        private readonly IServicioGrupo _servicioGrupo;
        private readonly IServicioPersona _servicioPersona;
        public Query(IServicioGrupo servicioGrupo,IServicioPersona servicioPersona)
        {
            _servicioGrupo = servicioGrupo;
            _servicioPersona = servicioPersona;
        }

        [UsePaging(SchemaType =typeof(GrupoType))]
        [UseFiltering]
        public IQueryable<Area> Grupos => _servicioGrupo.GetAll();
        [UsePaging(SchemaType = typeof(PersonaType))]
        [UseFiltering]
        public IQueryable<Persona> personas => _servicioPersona.GetAll();
       
    }
}
