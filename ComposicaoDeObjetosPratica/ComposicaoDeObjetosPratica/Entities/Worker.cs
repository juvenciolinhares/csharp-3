using ComposicaoDeObjetosPratica.Entities.Enums;
using System;
using System.Collections.Generic;

namespace ComposicaoDeObjetosPratica.Entities
{
    internal class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level { get; set; }
        public Double BaseSalary { get; set; }
        //agora vem a composição:

        //criar as propriedades (atributos) do tipo deperatament e HourContrac(essa vai ser uma LISTA de contratos)
        public Department Departement { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//ja instancio a minha lista


        //construtores:

        public Worker()
        {
        }

        //obs.: via de regra, sempre que tiver uma associaçãpo para muitos(LISTA), não incluo no construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department departement)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departement = departement;
        }

        //metodos:

        //adicionar contrato na minha lista de contratos
        public void addContract(HourContract  contract)
        {
            Contracts.Add(contract);
        }

        //remover contrato da lista de contratos
        public void removeContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //quanto o funcionario ganhou:

        public double Income(int year, int month)
        {
            //vou percorrer todos os contratos do func. e adicionar a ele o contrato equivalente aos argumentos informados
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();//totalvalue é a operação que retorna o valor do contrato
                }
               
            }
            return sum;
        }
    }
}
