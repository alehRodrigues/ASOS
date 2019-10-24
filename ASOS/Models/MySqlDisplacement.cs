using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class MySqlDisplacement : IDisplacement
    {
        private readonly AppDbContext context;

        public MySqlDisplacement(AppDbContext context)
        {
            this.context = context;
        }

        public bool AddDisplacement(Displacement displacement)
        {
            try
            {
                context.Deslocamentos.Add(displacement);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteDisplacement(int displacementId)
        {
            try
            {
                Displacement dl = context.Deslocamentos.Find(displacementId);
                context.Deslocamentos.Remove(dl);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public IEnumerable<Displacement> GetAllDisplacements()
        {
            try
            {
                return context.Deslocamentos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Displacement GetDisplacement(int displacemnetId)
        {
            try
            {
                return context.Deslocamentos.Find(displacemnetId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Displacement GetDisplacementByServiceOrders(int serviceOrderId)
        {
            throw new NotImplementedException();
        }

        public Displacement GetDisplacementBySupplier(string supplier)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDisplacement(Displacement displacement)
        {
            try
            {
                context.Deslocamentos.Update(displacement);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
