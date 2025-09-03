using ControleDeMedicamentos.Dominio.ModuloPrescricao;
using ControleDeMedicamentos.Infraestrutura.Arquivos.Compartilhado;

namespace ControleDeMedicamentos.Infraestrutura.Arquivo.ModuloPrescricao;

public class RepositorioPrescricaoEmArquivo : RepositorioBaseEmArquivo<Prescricao>
{
    public RepositorioPrescricaoEmArquivo(ContextoDados contextoDados) : base(contextoDados) { }

    protected override List<Prescricao> ObterRegistros()
    {
        return contextoDados.Prescricoes;
    }
}