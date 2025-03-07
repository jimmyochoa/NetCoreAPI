namespace Proyecto.DTOs;

public class ProductoDto
{
    public double ProductoId { get; set; }

    public string? ProductoDescrip { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaHoraReg { get; set; }

    public decimal? Precio { get; set; }

    public string? CategNombre { get; set; }

    public string? MarcaNombre { get; set; }

    public string? ModeloNombre { get; set; }
}