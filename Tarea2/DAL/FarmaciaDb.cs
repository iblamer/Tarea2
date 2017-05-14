using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Tarea2.DAL
{
    public class FarmaciaDb : DbContext
    {
        public FarmaciaDb() : base ("name = ConStr")
        {

        }

        public virtual DbSet<Models.Usuarios> Usuario { get; set; }
        public virtual DbSet<Models.TipoUsuarios> Tipo { get; set; }
    }
}