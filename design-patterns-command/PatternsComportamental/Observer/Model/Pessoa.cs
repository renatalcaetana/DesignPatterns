﻿namespace DesignPatters.PatternsComportamental.Observer.Model
{
    public class Pessoa
    {
        public Pessoa(int id, string nome, string email)
        {
            Id = id;
            Nome = nome;
            Email = email;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

    }
}
