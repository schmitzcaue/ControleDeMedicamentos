//﻿using ControleDeMedicamentos.Dominio.ModuloFuncionario;
//using ControleDeMedicamentos.Dominio.ModuloPrescriao;
//using System.ComponentModel.DataAnnotations;

//namespace ControleDeMedicamentos.WebApp.Models;

//public class CadastrarPrescricaoViewModel
//{
//    [Required(ErrorMessage = "O campo 'Crm' é obrigatório.")]
//    [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo 'Crm' deve conter 6 caracteres.")]
//    public string Nome { get; set; }

//    [Required(ErrorMessage = "O campo 'Telefone' é obrigatório.")]
//    [RegularExpression(
//        @"^\(?\d{2}\)?\s?(9\d{4}|\d{4})-?\d{4}$",
//        ErrorMessage = "O campo 'Telefone' deve seguir o padrão (DDD) 0000-0000 ou (DDD) 00000-0000."
//    )]
//    public string Telefone { get; set; }

//    [Required(ErrorMessage = "O campo 'CPF' é obrigatório.")]
//    [RegularExpression(
//        @"^\d{3}\.\d{3}\.\d{3}-\d{2}$",
//        ErrorMessage = "O campo 'CPF' deve seguir o formato 000.000.000-00."
//    )]
//    public string Cpf { get; set; }

//    public CadastrarPrescricaoViewModel() { }

//    public CadastrarPrescricaoViewModel(string nome, string telefone, string cpf) : this()
//    {
//        Nome = nome;
//        Telefone = telefone;
//        Cpf = cpf;
//    }
//}

//public class EditarrPrescricaoViewModel
//{
//    public Guid Id { get; set; }

//    [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
//    [StringLength(100, MinimumLength = 2, ErrorMessage = "O campo 'Nome' deve conter entre 2 e 100 caracteres.")]
//    public string Nome { get; set; }

//    [Required(ErrorMessage = "O campo 'Telefone' é obrigatório.")]
//    [RegularExpression(
//        @"^\(?\d{2}\)?\s?(9\d{4}|\d{4})-?\d{4}$",
//        ErrorMessage = "O campo 'Telefone' deve seguir o padrão (DDD) 0000-0000 ou (DDD) 00000-0000."
//    )]
//    public string Telefone { get; set; }

//    [Required(ErrorMessage = "O campo 'CPF' é obrigatório.")]
//    [RegularExpression(
//        @"^\d{3}\.\d{3}\.\d{3}-\d{2}$",
//        ErrorMessage = "O campo 'CPF' deve seguir o formato 000.000.000-00."
//    )]
//    public string Cpf { get; set; }

//    public EditarrPrescricaoViewModel() { }

//    public EditarrPrescricaoViewModel(Guid id, string nome, string telefone, string cpf) : this()
//    {
//        Id = id;
//        Nome = nome;
//        Telefone = telefone;
//        Cpf = cpf;
//    }
//}

//public class ExcluirrPrescricaoViewModel
//{
//    public Guid Id { get; set; }
//    public string Nome { get; set; }

//    public ExcluirrPrescricaoViewModel() { }

//    public ExcluirrPrescricaoViewModel(Guid id, string nome) : this()
//    {
//        Id = id;
//        Nome = nome;
//    }
//}

//public class VisualizarrPrescricoesViewModel
//{
//    public List<DetalhesFuncionarioViewModel> Registros { get; }

//    public VisualizarrPrescricoesViewModel(List<Prescricao> funcionarios)
//    {
//        Registros = [];

//        foreach (var f in funcionarios)
//        {
//            var detalhesVM = new DetalhesFuncionarioViewModel(
//                f.Id,
//                f.Nome,
//                f.Telefone,
//                f.Cpf
//            );

//            Registros.Add(detalhesVM);
//        }
//    }
//}

//public class DetalhesPrescricaoViewModel
//{
//    public Guid Id { get; set; }
//    public string Nome { get; set; }
//    public string Telefone { get; set; }
//    public string Cpf { get; set; }

//    public DetalhesPrescricaoViewModel(Guid id, string nome, string telefone, string cpf)
//    {
//        Id = id;
//        Nome = nome;
//        Telefone = telefone;
//        Cpf = cpf;
//    }
//}