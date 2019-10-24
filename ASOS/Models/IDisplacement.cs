using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public interface IDisplacement
    {
        IEnumerable<Displacement> GetAllDisplacements();

        Displacement GetDisplacement(int displacemnetId);

        Displacement GetDisplacementByServiceOrders(int serviceOrderId);

        Displacement GetDisplacementBySupplier(string supplier);

        bool AddDisplacement(Displacement displacement);

        bool UpdateDisplacement(Displacement displacement);

        bool DeleteDisplacement(int displacementId);
    }
}
