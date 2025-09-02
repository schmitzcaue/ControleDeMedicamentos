using ControleDeMedicamentos.Dominio.ModuloPrescricao;
using ControleDeMedicamentos.Infraestrutura.Arquivos.Compartilhado;

namespace ControleDeMedicamentos.Infraestrutura.Arquivos.ModuloPrescricao;

public class RepositorioRequisicaoMedicamento : RepositorioBaseEmArquivo<Prescricao>
{
    public RepositorioRequisicaoMedicamento(ContextoDados contextoDados) : base(contextoDados) { }

    protected override List<Prescricao> ObterRegistros()
    {
        return contextoDados.Prescricoes;
    }
}