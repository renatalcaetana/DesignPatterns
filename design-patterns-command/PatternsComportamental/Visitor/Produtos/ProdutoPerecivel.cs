﻿using DesignPatters.PatternsComportamental.Visitor.Interfaces;

namespace DesignPatters.PatternsComportamental.Visitor.Produtos
{
    public class ProdutoPerecivel : IProduct
    {
        public ProdutoPerecivel(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }

        public string Nome { get; set; }
        public double Peso { get; set; }

        public double GetImposto(IVisitor visitor)
        {
             return visitor.CalcularImpostoProdutoPerecivel(this);
        }
    }
}