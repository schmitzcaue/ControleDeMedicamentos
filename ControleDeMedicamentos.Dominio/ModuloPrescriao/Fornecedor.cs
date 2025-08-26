//using ControleDeMedicamentos.Dominio.Compartilhado;
//using ControleDeMedicamentos.Dominio.ModuloFornecedor;
//using ControleDeMedicamentos.Dominio.ModuloPaciente;
//using System.Diagnostics.CodeAnalysis;
//using System.Text.RegularExpressions;

//namespace ControleDeMedicamentos.Dominio.ModuloPrescricao;

//public class Prescricao : EntidadeBase<Prescricao>
//{
//    public string Crm { get; set; }
//    public Paciente Paciente { get; set; }

//    public DateTime Data { get; set; }
//    public Prescricao() { }

//    public Prescricao(string nome, Paciente paciente, DateTime data) : this()
//    {
//        Id = Guid.NewGuid();
//        Crm = nome;
//        Paciente = paciente;
//        Data = data;
//    }

//    public override void AtualizarRegistro(Prescricao registroEditado)
//    {
//        Crm = registroEditado.Crm;
//        Paciente = registroEditado.Paciente;
//        Data = registroEditado.Data;
//    }

//    public override string Validar()
//    {
//        string erros = "";

//        if (string.IsNullOrWhiteSpace(Crm))
//            erros += "O campo 'Crm' é obrigatório.\n";

//        else if (Crm.Length < 2 || Crm.Length > 100)
//            erros += "O campo 'Crm' deve conter entre 2 e 100 caracteres.\n";

//        if (string.IsNullOrWhiteSpace(Paciente))
//            erros += "O campo 'Paciente' é obrigatório.\n";

//        else if (!Regex.IsMatch(Paciente, @"^\(?\d{2}\)?\s?(9\d{4}|\d{4})-?\d{4}$"))
//            erros += "O campo 'Paciente' deve seguir o padrão (DDD) 0000-0000 ou (DDD) 00000-0000.\n";

//        if (string.IsNullOrWhiteSpace(Data))
//            erros += "O campo 'CPF' é obrigatório.\n";

//        if (DataFabricacao > DateTime.Now)
//            erros += "O campo \"Data de Fabricação\" deve conter uma data futura.\n";

//        return erros;
//    }
//}