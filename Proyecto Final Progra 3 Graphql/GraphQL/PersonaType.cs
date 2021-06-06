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
    public class PersonaType:ObjectType<Persona>
    {
        protected override void Configure(IObjectTypeDescriptor<Persona> descriptor)
        {
            descriptor.Field(x=>x.DPI).Type<IdType>();
            descriptor.Field(x => x.Nombre).Type<StringType>();
            descriptor.Field<GrupoResolver>(x => x.GetGrupo(default, default));
        }
    }

    public class GrupoResolver
    {
        private readonly IServicioGrupo _servicioGrupo;
        public GrupoResolver([Service] ServicioGrupo servicioGrupo)
        {
            _servicioGrupo = servicioGrupo;
        }

        public Area GetGrupo(Persona persona,IResolverContext ctx)
        {
            return _servicioGrupo.GetAll().Where(x => x.IdArea == persona.IdArea).FirstOrDefault();
        }
    }
}
