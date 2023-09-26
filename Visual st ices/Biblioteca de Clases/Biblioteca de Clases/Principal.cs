using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_de_Clases
{
    public class Principal
    {
        public List<MotoDeportiva> ListamotoDeportivas = new List<MotoDeportiva>();
        public List<MotoUtilitaria> ListamotosUtilitarias = new List<MotoUtilitaria>();

        public void AltaMotosDeportivas(MotoDeportiva motosDeportivas)
        {
            MotoDeportiva motosDeportivasP = new MotoDeportiva();
            motosDeportivasP.Id = motosDeportivas.Id;
            motosDeportivasP.Marca = motosDeportivas.Marca;
            motosDeportivasP.Modelo = motosDeportivas.Modelo;
            motosDeportivasP.Cilindrada = motosDeportivas.Cilindrada;

            ListamotoDeportivas.Add(motosDeportivas);
        }
        public void BajaMotosDeportivas(MotoDeportiva motosDeportivas)
        {
            ListamotoDeportivas.Remove(motosDeportivas);
        }

        public void AltaMotosUtilitaria(MotoUtilitaria motosUtilitarias)
        {
            MotoUtilitaria motosUtilitariasP = new MotoUtilitaria();
            motosUtilitariasP.Id = motosUtilitarias.Id;
            motosUtilitariasP.Marca = motosUtilitarias.Marca;
            motosUtilitariasP.Modelo = motosUtilitarias.Modelo;
            motosUtilitariasP.Uso = motosUtilitarias.Uso;

            ListamotosUtilitarias.Add(motosUtilitarias);
        }

        public void BajaMotosUtilitaria(MotoUtilitaria motosUtilitariasP)
        {
            ListamotosUtilitarias.Remove(motosUtilitariasP);
        }
        public void ModificarMotoDeportiva(MotoDeportiva nueva, MotoDeportiva eliminar)
        {
            
            MotoDeportiva motosDeportivasP = new MotoDeportiva();
            motosDeportivasP.Id =nueva.Id;
            motosDeportivasP.Marca = nueva.Marca;
            motosDeportivasP.Modelo = nueva.Modelo;
            motosDeportivasP.Cilindrada = nueva.Cilindrada;
            ListamotoDeportivas.Remove(eliminar);
            ListamotoDeportivas.Add(nueva);
        }
        public void ModificarMotoUtilitaria(MotoUtilitaria nueva, MotoUtilitaria eliminar)
        {

            MotoUtilitaria motosDeportivasP = new MotoUtilitaria();
            motosDeportivasP.Id = nueva.Id;
            motosDeportivasP.Marca = nueva.Marca;
            motosDeportivasP.Modelo = nueva.Modelo;
            motosDeportivasP.Uso = nueva.Uso;
            ListamotosUtilitarias.Remove(eliminar); 
            ListamotosUtilitarias.Add(nueva);
        }



    }
}
