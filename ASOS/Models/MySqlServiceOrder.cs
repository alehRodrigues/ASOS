using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class MySqlServiceOrder : IServiceOrder
    {
        private readonly AppDbContext context;

        public MySqlServiceOrder(AppDbContext context)
        {
            this.context = context;
        }

        public bool AddServiceOrder(ServiceOrder serviceOrder)
        {
            try
            {
                context.OrdensServico.Add(serviceOrder);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteServiceOrder(int serviceOrderId)
        {
            ServiceOrder so = context.OrdensServico.Find(serviceOrderId);
            try
            {
                context.OrdensServico.Remove(so);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public IEnumerable<ServiceOrder> GetAllServiceOrders()
        {
            try
            {
                return context.OrdensServico;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ServiceOrder GetServiceOrder(int serviceOrderId)
        {
            try
            {
                return context.OrdensServico.Find(serviceOrderId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public ServiceOrder GetServiceOrderByEquipament(int equipamentId)
        {
            throw new NotImplementedException();
        }

        public ServiceOrder GetServiceOrderByStatus(string status)
        {
            throw new NotImplementedException();
        }

        public ServiceOrder GetServiceOrderByType(string type)
        {
            throw new NotImplementedException();
        }

        public bool UpdateServiceOrder(ServiceOrder serviceOrder)
        {
            try
            {
                context.OrdensServico.Update(serviceOrder);
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
