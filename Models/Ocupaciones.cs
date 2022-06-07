using System.ComponentModel.DataAnnotations;

public class Ocupaciones
{
    [Key]
    public int OcupacionId { get; set; }
    
    [Required(ErrorMessage = "Favor Completar este campo")]
    public string Descripcion { get; set; }

    [Range(1, 1_000_000, ErrorMessage = ("Favor completar este campo"))]
    public double Salario { get; set; }
}