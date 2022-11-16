using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS
{
    internal class Nueva_Estadistica
    {
        int cantidad;
        double numero;
        double media;
        //vectores
        double mediaV;
        double mediana;
        double moda;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public double Numero
        {
            get { return numero; }
            set { numero = value+numero; }
        }
        public double Media(double num,int cant)
        {
            media = num/cant;
            return media;
        }

    }
}
