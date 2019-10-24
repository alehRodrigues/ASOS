using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class MySqlBuyOrder : IBuyOrder
    {
        private readonly AppDbContext context;

        public MySqlBuyOrder(AppDbContext context)
        {
            this.context = context;
        }

        public bool AddBuyOrder(BuyOrder buyOrder)
        {
            try
            {
                context.OrdensCompra.Add(buyOrder);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteBuyOrder(int buyOrderId)
        {
            try
            {
                BuyOrder bo = context.OrdensCompra.Find(buyOrderId);
                context.OrdensCompra.Remove(bo);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public IEnumerable<BuyOrder> GetAllBuyOrders()
        {
            try
            {
                return context.OrdensCompra;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BuyOrder GetBuyOrder(int buyOrderId)
        {
            try
            {
                return context.OrdensCompra.Find(buyOrderId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BuyOrder GetBuyOrderByAuthorized()
        {
            throw new NotImplementedException();
        }

        public BuyOrder GetBuyOrderByBuyDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public BuyOrder GetBuyOrderByCheckDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public BuyOrder GetBuyOrderByDepartment(string department)
        {
            throw new NotImplementedException();
        }

        public BuyOrder GetBuyOrderByEquipament(int equipamentId)
        {
            throw new NotImplementedException();
        }

        public BuyOrder GetBuyOrderByOpenDate(DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public BuyOrder GetBuyOrderByRequester(string requester)
        {
            throw new NotImplementedException();
        }

        public BuyOrder GetBuyOrderBySupplier(string supplier)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBuyOrder(BuyOrder buyOrder)
        {
            try
            {
                context.OrdensCompra.Update(buyOrder);
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
