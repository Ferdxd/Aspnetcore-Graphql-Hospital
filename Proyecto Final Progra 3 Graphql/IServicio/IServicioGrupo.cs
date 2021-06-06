using Proyecto_Final_Progra_3_Graphql.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto_Final_Progra_3_Graphql.IServicio
{
    public interface IServicioGrupo
    {
        IQueryable<Area> GetAll();
    }
}
