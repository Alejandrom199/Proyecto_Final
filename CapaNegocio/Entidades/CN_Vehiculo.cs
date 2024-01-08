using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_Vehiculo
    {
        private string placa;
        private string marca;
        private string modelo;
        private string color;

        public CN_Vehiculo(string placa, string marca, string modelo, string color)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
        }

        public CN_Vehiculo()
        {
        }

        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Color { get => color; set => color = value; }
    }
}
