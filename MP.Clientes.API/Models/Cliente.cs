﻿namespace MP.Clientes.API.Models
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public bool Excluido { get; private set; }
        public Endereco Endereco { get; private set; }

        public Cliente(string nome,string email, string cpf)
        {
            Nome = nome;
            Email = email;
            Cpf = cpf;
            Excluido = false;
        }

    }
    
    public class Endereco
    {

    }
}
