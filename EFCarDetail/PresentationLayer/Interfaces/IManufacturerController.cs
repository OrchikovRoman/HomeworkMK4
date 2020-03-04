﻿using PresentationLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Interfaces
{
    public interface IManufacturerController
    {
        IEnumerable<ManufacturerViewModel> GetAll();
        ManufacturerViewModel GetById(int Id);
    }
}
