using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorCodeService
    {
        IDataResult<List<ColorCode>> GetAll();
        IDataResult<List<ColorCode>> GetAllById(int id);
        IDataResult<ColorCode> GetByName(string name);

        IResult Add(ColorCode colorCode);
        IResult Update(ColorCode colorCode);
        IResult Delete(ColorCode colorCode);

        IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetails();
        IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetailsByPaletteId(int paletteId);
        IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetailsByPaletteName(string paletteName);
    }
}
