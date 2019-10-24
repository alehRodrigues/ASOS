using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public interface IServiceOrder
    {
        IEnumerable<ServiceOrder> GetAllServiceOrders();
        ServiceOrder GetServiceOrder(int serviceOrderId);
        ServiceOrder GetServiceOrderByStatus(string status);
        ServiceOrder GetServiceOrderByEquipament(int equipamentId);
        ServiceOrder GetServiceOrderByType(string type);
        bool AddServiceOrder(ServiceOrder serviceOrder);
        bool UpdateServiceOrder(ServiceOrder serviceOrder);
        bool DeleteServiceOrder(int serviceOrderId);
    }
}
