using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal abstract class Vehiculo
    {


        //public Vehiculo(string? marca)
        //{
        //    Marca = marca;
        //    //AñoCreacion = añoCreacion;
        //    //Velocidad = velocidad;
        //}

        public string? Marca { get; set; }
        public int AñoCreacion { get; set; }

        public int Velocidad { get; private set; }
        public abstract int  VelocidadMaxima { get; }


        public virtual void darReversa()
        {
            Console.WriteLine("dar reversa");
        }

        public abstract void SonarClaxon();


        internal void Acelerar(int incremento = 1)
        {
            if (Velocidad >= VelocidadMaxima)
            {
                Console.WriteLine("lA VELOCIDAD MAXIMA YA HA SIDO ALCANZADA");
            }
            else if (Velocidad + incremento > VelocidadMaxima) ;               
                {

                incremento = VelocidadMaxima - Velocidad;

                }

            Velocidad += incremento;
            


        }

    }

   


    //_____________________________________________

        internal class  Carro: Vehiculo
        {
        //public Carro(string? marca) : base(marca)
        //{
        //}

        public override int VelocidadMaxima => 120;

        public void EncerderRadio()
            {
                Console.WriteLine("encenrder radio");
            }

        public override void SonarClaxon()
        {
            Console.WriteLine("pi pi pi pi");
        }
    }


    internal class bocho : Carro
    {
        //public bocho(string? marca) : base(marca)
        //{
        //}
    }


    //__________________________________

    internal class Camion: Vehiculo
        {
        //public Camion(string? marca) : base(marca)
        //{
        //}

        public override int VelocidadMaxima => 100;

        public override void darReversa()
        {
            base.darReversa();
            Console.WriteLine("alarma alarmas alarma");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("piiiiiiiiiiiiii");
        }
    }
    //____________________________________________________

    internal class vicicleta : Vehiculo
    {
        //public vicicleta(string? marca) : base(marca)
        //{
        //}

        public override int VelocidadMaxima => 12;
        public override void SonarClaxon()
        {
            Console.WriteLine("rin rin riin");
        }
    }


   // ____________________
}