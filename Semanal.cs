using System;

namespace Aula10Sobreposição
{
    public class Semanal : Relatorio
    {
        public override void MostrarRelatorio(){

		base.MostrarRelatorio();

		Console.WriteLine("Mostrando relatório semanal");
        }
    }
}