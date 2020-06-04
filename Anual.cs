using System;

namespace Aula10Sobreposição
{
    public class Anual : Relatorio
    {
        public override void MostrarRelatorio(){

		base.MostrarRelatorio();

		Console.WriteLine("Mostrando relatório por ano");
        }
    }
}