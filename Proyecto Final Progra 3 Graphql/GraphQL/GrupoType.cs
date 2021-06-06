using HotChocolate;
using HotChocolate.Resolvers;
using HotChocolate.Types;
using Proyecto_Final_Progra_3_Graphql.IServicio;
using Proyecto_Final_Progra_3_Graphql.Modelos;
using Proyecto_Final_Progra_3_Graphql.Servicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Progra_3_Graphql.GraphQL
{
    public class GrupoType:ObjectType<Area>
    {
        protected override void Configure(IObjectTypeDescriptor<Area> descriptor)
        {
            descriptor.Field(x=>x.IdArea).Type<IdType>();
            descriptor.Field(x => x.Nombre).Type<StringType>();
            descriptor.Field(x => x.Abreviatura).Type<StringType>();
            descriptor.Field<PacienteResolver>(x => x.GetEstudiantes(default, default));
        }
    }

    public class PacienteResolver
    {
        private readonly IServicioPersona  _serviciopersona;
        public PacienteResolver([Service] IServicioPersona servicioPersona)
        {
            _serviciopersona = servicioPersona;
        }

        public IEnumerable<Persona> GetEstudiantes(Area grupo, IResolverContext ctx)
        {
            return _serviciopersona.GetAll().Where(x => x.IdArea == grupo.IdArea);
        }
    }
}
