using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaConsola1
{
    public class Sistema
    {
        public void Saludo()
        {
            Console.WriteLine("Hola Mundo");
            Console.WriteLine("\nPresione cualquier tecla para Finalizar");
            Console.ReadKey();
        }

        public void Iniciar()
        {
            Saludo();
        }

        
    }



}
