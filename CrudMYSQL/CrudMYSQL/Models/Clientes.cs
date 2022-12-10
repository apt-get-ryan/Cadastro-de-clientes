using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudMYSQL.Models
{
    [Table("Clientes")]
    public class Clientes
    {

        [Key]
        [Display(Name ="Código")]
        [Column("Id")]
        public int Id { get; set; }


        [Display(Name = "Nome")]
        [MaxLength(50)]
        [Column("Nome")]
        public string Nome { get; set; }


        [Display(Name = "Nascimento")]
        [Column("Nascimento", TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateOnly Nascimento { get; set; }


        [Display(Name = "Cpf")]
        [MaxLength(14)]
        [Column("Cpf")]
        public string Cpf { get; set; }


        [Display(Name = "Cnpj")]
        [MaxLength(18)]
        [Column("Cnpj")]
        public string Cnpj { get; set; }


        [Display(Name = "Telefone 1")]
        [MaxLength(15)]
        [Column("Telefone1")]
        public string Telefone1 { get; set; }


        [Display(Name = "Telefone 2")]
        [MaxLength(15)]
        [Column("Telefone2")]
        public string Telefone2 { get; set; }


        [Display(Name = "Celular")]
        [MaxLength(15)]
        [Column("Celular")]
        public string Celular { get; set; }


        [Display(Name = "Email 1")]
        [MaxLength(300)]
        [Column("Email1")]
        public string Email1 { get; set; }


        [Display(Name = "Email 2")]
        [MaxLength(300)]
        [Column("Email2")]
        public string Email2 { get; set; }


        [Display(Name = "Data de cadastro")]
        [Column("Data_cadastro", TypeName = "Date")]
        [DataType(DataType.Date)]
        public DateOnly DataCadastro { get; set; }


        [Display(Name = "Cep")]
        [MaxLength(9)]
        [Column("Cep")]
        public string Cep { get; set; }


        [Display(Name = "Cidade")]
        [MaxLength(40)]
        [Column("Cidade")]
        public string Cidade { get; set; }


        [Display(Name = "Bairro")]
        [MaxLength(50)]
        [Column("Bairro")]
        public string Bairro { get; set; }


        [Display(Name = "Endereco")]
        [MaxLength(40)]
        [Column("Endereco")]
        public string Endereco { get; set; }


        [Display(Name = "Numero")]
        [MaxLength(7)]
        [Column("Numero")]
        public string Numero { get; set; }


        [Display(Name = "Uf")]
        [MaxLength(2)]
        [Column("Uf")]
        public string Uf { get; set; }


        [Display(Name = "Obs")]
        [MaxLength(300)]
        [Column("Obs")]
        public string Obs { get; set; }


        [Display(Name = "Ativo")]
        [MaxLength(3)]
        [Column("Ativo")]
        public  string Ativo { get; set; }


}
}
