using System.ComponentModel.DataAnnotations;
 namespace  registro_clase.entidades
{
    public class Actores { 
    [Key]
    public int AutorId { get; set; }
    public string Nombres { get; set; }
    public decimal SalarioAnual { get; set; }
    
}
    
}
