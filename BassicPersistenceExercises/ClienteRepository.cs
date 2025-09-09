using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BassicPersistenceExercises
{
    public class ClienteRepository
    {
        public static void Save(Cliente cliente)
        {
            try
            {
                using (Repository dbContext = new Repository())
                {
                    if (cliente.Id == 0)
                    {
                        dbContext.Clientes.Add(cliente);
                    }
                    else
                    {
                        dbContext.Entry(cliente).State
                            = EntityState.Modified;
                    }

                    dbContext.SaveChanges();
                }
            }

            catch (Exception)
            {
                throw;
            }
        }
    }
}
