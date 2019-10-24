using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public interface IEquipament
    {
        IEnumerable<Equipament> GetAllEquipaments();

        Equipament GetEquipament(int equipamentId);

        bool AddEquipament(Equipament equipament);

        bool UpdateEquipament(Equipament equipament);

        bool DeleteEquipament(int equipamentId);
    }
}
