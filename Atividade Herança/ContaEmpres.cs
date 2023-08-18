using System.Security.Cryptography;

namespace Atividade_Herança
{
    internal class ContaEmpres : Conta
    {
        public double anuidade { get; set; }
        public double limiteEmp { get; set; }
        public double totalEmp { get; set; }


        public ContaEmpres(int numCon, int agencia, string titularCon, double saldo, double anuidade, double limiteEmp):base(numCon,agencia,titularCon, saldo)
        {
            this.anuidade = anuidade;
            this.limiteEmp = limiteEmp;
            this.totalEmp = totalEmp;
        }
        public void Emprestimo(double valor)
        {

        }

        public void Sacar(double valorr)
        {

        }
    }
}