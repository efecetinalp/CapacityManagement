using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface IColorCodeService : IManager
    {
        IDataResult<List<ColorCode>> GetAll();
        IDataResult<List<ColorCode>> GetAllById(int id);
        IDataResult<ColorCode> GetByName(string name);

        //IResult Add(ColorCode colorCode);
        //IResult Update(ColorCode colorCode);
        //IResult Delete(ColorCode colorCode);

        IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetails();
        IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetailsByPaletteId(int paletteId);
        IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetailsByPaletteName(string paletteName);
    }
}
