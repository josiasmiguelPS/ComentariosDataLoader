#nullable disable
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class WebReview
{
    public string IdReview { get; set; }

    public int IdCliente { get; set; }

    public int IdProducto { get; set; }

    public int IdTipoFuente { get; set; }

    public DateOnly Fecha { get; set; }

    public string Comentario { get; set; }

    public byte Rating { get; set; }
}