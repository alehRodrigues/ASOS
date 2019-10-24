using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public interface IBuyOrder
    {
        IEnumerable<BuyOrder> GetAllBuyOrders();

        BuyOrder GetBuyOrder(int buyOrderId);

        BuyOrder GetBuyOrderByOpenDate(DateTime dateTime);
        BuyOrder GetBuyOrderByBuyDate(DateTime dateTime);
        BuyOrder GetBuyOrderByCheckDate(DateTime dateTime);
        BuyOrder GetBuyOrderByDepartment(string department);
        BuyOrder GetBuyOrderByRequester(string requester);
        BuyOrder GetBuyOrderByEquipament(int equipamentId);
        BuyOrder GetBuyOrderBySupplier(string supplier);
        BuyOrder GetBuyOrderByAuthorized();

        bool AddBuyOrder(BuyOrder buyOrder);

        bool UpdateBuyOrder(BuyOrder buyOrder);

        bool DeleteBuyOrder(int buyOrderId);
    }
}
