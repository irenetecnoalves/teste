using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_proposto1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int nHoraTrabalho;
            double valorHora;
            double salario;
            

            num = int.Parse(Console.ReadLine());
            nHoraTrabalho = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
           // salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); a linha do salario não precisa ser ultilizado
           //double.parse porque o valorhora ja foi convertido

            salario = nHoraTrabalho * valorHora;

            Console.WriteLine("O número do  funcionário é "+ num);
            Console.WriteLine("O salarío do Funcionário é " +salario.ToString("F2",CultureInfo.InvariantCulture));
            //poruqe usar o salario.toString para usar uma formatação de cultura especifica

            




        }
    }
}