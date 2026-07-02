#nullable disable
using System;
using System.Collections.Generic;

namespace ComentarioDataLoader.Data.Entities;

public partial class Client
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; }

    public string Email { get; set; }
}