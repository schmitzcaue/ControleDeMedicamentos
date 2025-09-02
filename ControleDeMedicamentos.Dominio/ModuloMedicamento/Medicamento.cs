using ControleDeMedicamentos.Dominio.Compartilhado;
using ControleDeMedicamentos.Dominio.ModuloFornecedor;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace ControleDeMedicamentos.Dominio.ModuloMedicamento;

public class Medicamento : EntidadeBase<Medicamento>
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int QuantidadeEmEstoque { get; set; }
    public Fornecedor Fornecedor { get; set; }
    public List<RequisicaoEntrada> RequisicoesEntrada { get; set; } = new List<RequisicaoEntrada>();

    public int QuantidadeEmEstoque
    {
        get
        {
            int quantidadeEmEstoque = 0;

            foreach (var req in RequisicoesEntrada)
                quantidadeEmEstoque += req.QuantidadeRequisitada;

            return quantidadeEmEstoque;
        }
    }


    public bool EmFalta
    {
        get { return QuantidadeEmEstoque < 20; }
    }

    public Medicamento() { }

    public Medicamento(string nome, string descricao, Fornecedor fornecedor) : this()
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Descricao = descricao;
        Fornecedor = fornecedor;
    }

    public override void AtualizarRegistro(Medicamento registroEditado)
    {
        Nome = registroEditado.Nome;
        Descricao = registroEditado.Descricao;
        Fornecedor = registroEditado.Fornecedor;
    }
    public void AdicionarAoEstoque(RequisicaoEntrada requisicaoEntrada)
    {
        if (!RequisicoesEntrada.Contains(requisicaoEntrada))
            RequisicoesEntrada.Add(requisicaoEntrada);
    }

    public override string Validar()
    {
        string erros = string.Empty;

        if (string.IsNullOrEmpty(Nome.Trim()))
            erros += "O campo \"Nome\" é obrigatório.";

        if (string.IsNullOrEmpty(Descricao.Trim()))
            erros += "O campo \"Descrição\" é obrigatório.";

        if (Fornecedor == null)
            erros += "O campo \"Fornecedor\" é obrigatório.";

        return erros;
    }
}