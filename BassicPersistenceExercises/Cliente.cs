using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

//[Table("tbl_cliente")]
namespace BassicPersistenceExercises
{
    public class Cliente
    {
        public Int64? Id { get; set; }

        [Required]
        [MaxLength(45)]
        private String? _nome;
        public String? Nome { get; set; }

        [Required]
        //[notFuture]
        private DateOnly? _nascimento;
        public DateOnly? Nascimento { get; set; }

        private Byte _idade;
        public Byte Idade { get; set; }
        
        private Genero? _genero;
        public Genero? Genero { get; set; }

        private Boolean? _condicaoCronica;
        public Boolean? CondicaoCronica { get; set; }

        private DateOnly _ultimaConsulta;
        public DateOnly UltimaConsulta { get; set; }
    }
}
