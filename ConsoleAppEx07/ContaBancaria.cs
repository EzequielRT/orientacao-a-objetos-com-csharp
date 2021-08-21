using System;
using System.Globalization;

namespace ConsoleAppEx07
{
    class ContaBancaria
    {
        // Atributo
        private string _titular;

        // Propriedades
        public int NmrDaConta { get; private set; }
        public double Saldo { get; private set; }

        // Construtores
        public ContaBancaria(string nome, int nmrDaConta)
        {
            this._titular = nome;
            this.NmrDaConta = nmrDaConta;
            this.Saldo = 0.00;
        }

        public ContaBancaria(string nome, int nmrDaConta, double depositoInicial) : this(nome, nmrDaConta)
        {
            Deposito(depositoInicial);
        }

        // Propriedade customizada
        public string Nome
        {
            get { return this._titular; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    this._titular = value;
                }
            }
        }

        // Demais métodos da classe
        public void Deposito(double valorDepositado)
        {
            this.Saldo += valorDepositado;
        }

        public void Saque(double valorDoSaque)
        {
            this.Saldo -= (valorDoSaque + 5.00);
        }

        public override string ToString()
        {
            return
                $"Conta {this.NmrDaConta}, Titular: {this._titular}, Saldo: $ {this.Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
