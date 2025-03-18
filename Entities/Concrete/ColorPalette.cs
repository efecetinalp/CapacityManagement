using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ColorPalette : IEntity
    {
        public int ColorPaletteId { get; set; }
        public string PaletteDesignation { get; set; }
        public string PaletteType { get; set; }
    }
}
