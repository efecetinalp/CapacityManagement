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
    public interface IColorPaletteService
    {
        IDataResult<List<ColorPalette>> GetAll();
        IDataResult<List<ColorPalette>> GetAllById(int id);
        IDataResult<ColorPalette> GetByName(string name);

        IResult Add(ColorPalette colorPalette);
        IResult Update(ColorPalette colorPalette);
        IResult Delete(ColorPalette colorPalette);
    }
}
