using System.ComponentModel.DataAnnotations;
namespace ClienteAPI.Models
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }
        public string EmailCliente { get; set; }
        public string SenhaCliente { get; set; }
    }
}