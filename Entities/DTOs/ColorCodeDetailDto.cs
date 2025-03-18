using Core.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ColorCodeDetailDto : IDto
    {
        public int ColorId { get; set; }
        public int ColorPaletteId { get; set; }
        public string PaletteDesignation { get; set; }
        public string ColorDesignation { get; set; }
        public string PaletteType { get; set; }
        public string ColorType { get; set; }
        public Color GetColorCode { get; set; }
    }
}
