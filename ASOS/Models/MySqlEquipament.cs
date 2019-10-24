using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASOS.Models
{
    public class MySqlEquipament : IEquipament
    {
        private readonly AppDbContext context;

        public MySqlEquipament(AppDbContext context)
        {
            this.context = context;
        }

        public bool AddEquipament(Equipament equipament)
        {
            try
            {
                context.Equipaments.Add(equipament);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool DeleteEquipament(int id)
        {
            Equipament equip = context.Equipaments.Find(id);

            if(equip != null)
            {
                try
                {
                    context.Equipaments.Remove(GetEquipament(id));
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }

            return false;
            
        }

        public IEnumerable<Equipament> GetAllEquipaments()
        {
            try
            {
                return context.Equipaments;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Equipament GetEquipament(int id)
        {
            try
            {
                return context.Equipaments.Find(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateEquipament(Equipament equipament)
        {
            try
            {
                context.Equipaments.Update(equipament);
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
