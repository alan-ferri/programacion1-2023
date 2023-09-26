using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Principal
    {
        public List<VehiculoAutomovil> ListaVehiculoAutomovil = new List<VehiculoAutomovil>();
        public List<VehiculoCamioneta> ListaVehiculoCamioneta = new List<VehiculoCamioneta>();

        public void AltaVehiculoAutomovil(VehiculoAutomovil vehiculoAutomovilP)
        {
            VehiculoAutomovil vehiculoAutomovil = new VehiculoAutomovil();
            vehiculoAutomovil.patente = vehiculoAutomovilP.patente;
            vehiculoAutomovil.marca = vehiculoAutomovilP.marca;
            vehiculoAutomovil.modelo = vehiculoAutomovilP.modelo;
            vehiculoAutomovil.PrecioDia = vehiculoAutomovilP.PrecioDia;
            vehiculoAutomovil.NdeAsientos = vehiculoAutomovilP.NdeAsientos;
            vehiculoAutomovil.NdePuertas = vehiculoAutomovilP.NdePuertas;

            ListaVehiculoAutomovil.Add(vehiculoAutomovil);
        }


        public void BajaVehiculoAutomovil(VehiculoAutomovil vehiculoAutomovilP)
        {
            ListaVehiculoAutomovil.Remove(vehiculoAutomovilP);
        }

        public void ModificarVehiculoAutomovil(VehiculoAutomovil vehiculoAutomovilNuevo)
        {
            var elementoEliminado = ListaVehiculoAutomovil.Find(x => x.patente == vehiculoAutomovilNuevo.patente);

            VehiculoAutomovil vehiculoAutomovilModificado = new VehiculoAutomovil();

            vehiculoAutomovilModificado.patente = vehiculoAutomovilNuevo.patente;
            vehiculoAutomovilModificado.marca = vehiculoAutomovilNuevo.marca;
            vehiculoAutomovilModificado.modelo = vehiculoAutomovilNuevo.modelo;
            vehiculoAutomovilModificado.PrecioDia = vehiculoAutomovilNuevo.PrecioDia;
            vehiculoAutomovilModificado.NdeAsientos = vehiculoAutomovilNuevo.NdeAsientos;
            vehiculoAutomovilModificado.NdePuertas = vehiculoAutomovilNuevo.NdePuertas;

            ListaVehiculoAutomovil.Remove(elementoEliminado);
            ListaVehiculoAutomovil.Add(vehiculoAutomovilNuevo);
        }


        public void AltaVehiculoCamioneta(VehiculoCamioneta vehiculCamionetaP)
        {
            VehiculoCamioneta vehiculoCamioneta = new VehiculoCamioneta();
            vehiculoCamioneta.patente = vehiculCamionetaP.patente;
            vehiculoCamioneta.marca = vehiculCamionetaP.marca;
            vehiculoCamioneta.modelo = vehiculCamionetaP.modelo;
            vehiculoCamioneta.PrecioDia = vehiculCamionetaP.PrecioDia;
            vehiculoCamioneta.CapacidadDeCarga = vehiculCamionetaP.CapacidadDeCarga;


            ListaVehiculoCamioneta.Add(vehiculoCamioneta);
        }

        public void BajaVehiculoCamionetal(VehiculoCamioneta vehiculoCamionetaP)
        {
            ListaVehiculoCamioneta.Remove(vehiculoCamionetaP);
        }

        public void ModificarVehiculoCamioneta(VehiculoCamioneta vehiculoCamionetaNuevo)
        {
            var elementoEliminadoC = ListaVehiculoCamioneta.Find(x => x.patente == vehiculoCamionetaNuevo.patente);

            VehiculoCamioneta vehiculoCamionetaModificado = new VehiculoCamioneta();

            vehiculoCamionetaModificado.patente = vehiculoCamionetaNuevo.patente;
            vehiculoCamionetaModificado.marca = vehiculoCamionetaNuevo.marca;
            vehiculoCamionetaModificado.modelo = vehiculoCamionetaNuevo.modelo;
            vehiculoCamionetaModificado.PrecioDia = vehiculoCamionetaNuevo.PrecioDia;
            vehiculoCamionetaModificado.CapacidadDeCarga = vehiculoCamionetaNuevo.CapacidadDeCarga;


            ListaVehiculoCamioneta.Remove(elementoEliminadoC);
            ListaVehiculoCamioneta.Add(vehiculoCamionetaNuevo);
        }


    }

}
