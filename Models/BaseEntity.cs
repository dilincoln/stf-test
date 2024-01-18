using System.ComponentModel.DataAnnotations;

namespace stf_test.Models;
public class BaseEntity
{
    [Key]
    public int Id { get; set; }

    public DateTime DataAtualizacao { get; set; }

    public DateTime DataCriacao { get; set; }
}