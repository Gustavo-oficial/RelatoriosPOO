using System;

namespace Aula10Sobreposição
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensal relatorio = new Mensal();

            // relatorio.data1;

            relatorio.MostrarRelatorio();

            Anual ano = new Anual();

            ano.MostrarRelatorio();
        }
    }
}
