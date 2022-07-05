using System;
using System.Globalization;
using ComposicaoDeObjetosPratica.Entities;
using ComposicaoDeObjetosPratica.Entities.Enums;



namespace ComposicaoDeObjetosPratica
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //dados do trabalhador e departamento:

            Console.Write("Enter department's name: ");
            string deptname = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/MIdLevel/Senior: ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());//importa ComposicaoDeObjetosPratica.Entities;
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// importa System.Globalization;

            //instanciar os objetos departamento e o worker associado ao departamento
            Department dept = new Department(deptname);
            Worker worker = new Worker(name, level, baseSalary, dept);

            //perguntar quantos contratos, depois ler os dados dos contratos
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());//o metodo parse  aceita o formato (DD/MM/YYYY)
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration(hours): ");
                int hours = int.Parse(Console.ReadLine());

                //depois de recebidos os dados, instanciar um contrato:
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //adicionar o contrato no trabalhador(worker)
                worker.addContract(contract);
            }
            Console.WriteLine();

            Console.Write("Enter month and year to calculate income(MM/YYYY): ");

            //vou receber esses valores numa string e recortar depois em duas substrings(mes e ano)
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Departement.Name);
            Console.WriteLine("income for" + monthAndYear + ": " + worker.Income(year, month).ToString("F2",CultureInfo.InvariantCulture));
           
            


        }
    }
}
