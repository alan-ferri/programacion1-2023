using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_Ejercicio_2
{
    public class Principal
    {
        public List<Televisor> televisores = new List<Televisor>();
        public List<Smartphone> smartphones = new List<Smartphone>();
        public void AgregarTelevisor(Televisor televisor)
        {
            televisores.Add(televisor);
        }
        public void AgregarSmartphone(Smartphone smartphone)
        {
            smartphones.Add(smartphone);
        }
        public void EliminarTelevisor(Televisor televisor)
        {
            televisores.Remove(televisor);
        }
        public void EliminarSmartphone(Smartphone smartphone)
        {
            smartphones.Remove(smartphone);
        }
        public void ModificarTelevisor(Televisor a_eliminar, Televisor a_agregar)
        {
            televisores.Remove(a_eliminar);
            televisores.Add(a_agregar);
        }
        public void ModificarSmartphone(Smartphone a_eliminar, Smartphone a_agregar)
        {
            smartphones.Remove(a_eliminar);
            smartphones.Add(a_agregar);
        }
    }
}
