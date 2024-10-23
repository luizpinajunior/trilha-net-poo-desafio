using System;

namespace DesafioPOO.Models
{
        public class Nokia : Smartphone
    {
       public Nokia(string numero, string modelo, string IMei, int memoria) : base(numero, modelo, IMei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} para Nokia.");
        }
        
    }
}