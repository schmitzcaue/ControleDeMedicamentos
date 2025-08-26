﻿using ControleDeMedicamentos.Dominio.Compartilhado;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;

namespace ControleDeMedicamentos.Dominio.ModuloPaciente;
public class Paciente : EntidadeBase<Paciente>
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string CartaoDoSus { get; set; }
    public string Cpf { get; set; }

    public Paciente() { }

    public Paciente(string nome, string telefone, string cpf, string cartaoDoSus) : this()
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Telefone = telefone;
        CartaoDoSus = cartaoDoSus;
        Cpf = cpf;
    }

    public override void AtualizarRegistro(Paciente registroEditado)
    {
        Nome = registroEditado.Nome;
        Telefone = registroEditado.Telefone;
        CartaoDoSus = registroEditado.CartaoDoSus;
        Cpf = registroEditado.Cpf;
    }

    public override string Validar()
    {
        string erros = "";

        if (string.IsNullOrWhiteSpace(Nome))
            erros += "O campo 'Nome' é obrigatório.\n";

        if (Nome.Length < 3 || Nome.Length > 100)
            erros += "O campo 'Nome' deve conter entre 3 e 100 caracteres.\n";

        if (!Regex.IsMatch(Telefone, @"^\(?\d{2}\)?\s?(9\d{4}|\d{4})-?\d{4}$"))
            erros += "O campo 'Telefone' é deve seguir o padrão (DDD) 0000-0000 ou (DDD) 00000-0000.\n";

        if (!Regex.IsMatch(CartaoDoSus, @"^\d{3}\s?\d{4}\s?\d{4}\s?\d{4}$"))
            erros += "O campo 'Cartão do Sus' é precisa conter 15 números.\n";

        if (!Regex.IsMatch(Cpf, @"^\d{3}\.\d{3}\.\d{3}-\d{2}$"))
            erros += "O campo 'CPF' deve seguir o formato 000.000.000-00.\n";

        return erros;
    }
}