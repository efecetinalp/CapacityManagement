using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class ColorCode : IEntity
    {
        [Key]
        public int ColorId { get; set; }
        public int ColorPaletteId { get; set; }
        public string ColorDesignation { get; set; }
        public string ColorType { get; set; }
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }
}
