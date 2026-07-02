#nullable disable
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class SurveysPart1
{
    public int IdOpinion { get; set; }

    public int IdCliente { get; set; }

    public int IdProducto { get; set; }

    public DateOnly Fecha { get; set; }

    public string Comentario { get; set; }

    public byte Clasificacion { get; set; }

    public int IdTipoFuente { get; set; }

    public int PuntajeSatisfaccion { get; set; }
}