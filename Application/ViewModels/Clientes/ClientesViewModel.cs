﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels.Clientes
{
    public class ClientesViewModel
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Contacto { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
    }
}
