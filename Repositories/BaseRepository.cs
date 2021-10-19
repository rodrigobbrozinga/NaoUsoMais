using NaoUsoMais.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaoUsoMais.Repositories
{
    public class BaseRepository<T> where T : BaseModel
    {
        protected readonly ApplicationContext contexto;
        protected readonly Microsoft.EntityFrameworkCore.DbSet<T> dbSet;

        public BaseRepository(ApplicationContext contexto)
        {
            this.contexto = contexto;
            dbSet = contexto.Set<T>();
        }
    }
}
