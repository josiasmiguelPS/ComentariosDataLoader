#nullable disable
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class FuenteDato
{
    public string IdFuente { get; set; }

    public string TipoFuente { get; set; }

    public DateOnly FechaCarga { get; set; }
}