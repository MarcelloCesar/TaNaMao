using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using TanaMao.Domain.Gerencia.ValueObjects;

namespace TaNaMao.Main
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Descricao temp;

            temp = new Descricao("Este produto não pode estar em contato com crianças?");
            Console.WriteLine(temp.Notifications.ElementAt(0).Message);
            
        }
    }
}
