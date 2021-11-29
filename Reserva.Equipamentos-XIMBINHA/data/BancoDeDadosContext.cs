using MySql.Data.EntityFramework;
using Reserva.Equipamentos_XIMBINHA.Models;
using System.Data.Entity;

namespace Reserva.Equipamentos_XIMBINHA.data
{

    //marcaçao
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    //conexao
    public class BancoDeDadosContext : DbContext
    {

        public DbSet<CadastroEquipamentoModel> CadastroEquipamento { get; set; }
        public DbSet<CadastroUsuarioModel> CadastroUsuario { get; set; }

        //construtor
        public BancoDeDadosContext() : base("StringConexaoBancoDeDados")
        {

        }
    }
}