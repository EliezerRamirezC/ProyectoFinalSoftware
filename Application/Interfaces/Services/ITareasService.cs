﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ViewModels.Tareas;

namespace Application.Interfaces.Services
{
    public interface ITareasService : IGenericService<SaveTareasViewModel, TareasViewModel>
    {
    }
}
