using System;

namespace Aula10Sobreposição
{
    public class Relatorio
    {
        public DateTime data1 { get; set; } = DateTime.Now;
	
        public virtual void MostrarRelatorio(){
		Console.WriteLine("Mostrando relatorio geral");
        }
    }
}