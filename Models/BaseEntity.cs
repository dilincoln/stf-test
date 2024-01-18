using System.ComponentModel.DataAnnotations;

namespace STFTest.Models;
public class BaseEntity
{
    [Key]
    public int Id { get; set; }

    public DateTime DataAtualizacao { get; set; }

    public DateTime DataCriacao { get; set; }
}