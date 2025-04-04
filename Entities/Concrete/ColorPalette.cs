using Core.Entities;

namespace Entities.Concrete
{
    public class ColorPalette : IEntity
    {
        public int ColorPaletteId { get; set; }
        public string PaletteDesignation { get; set; }
        public string PaletteType { get; set; }
    }
}
