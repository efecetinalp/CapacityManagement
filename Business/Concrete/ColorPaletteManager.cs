using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorPaletteManager : IColorPaletteService
    {
        IColorPaletteDal _colorPaletteDal;

        public ColorPaletteManager(IColorPaletteDal colorPaletteDal)
        {
            _colorPaletteDal = colorPaletteDal;
        }

        public IResult Add(ColorPalette colorPalette)
        {
            _colorPaletteDal.Add(colorPalette);
            return new SuccessResult();
        }

        public IResult Update(ColorPalette colorPalette)
        {
            _colorPaletteDal.Update(colorPalette);
            return new SuccessResult();
        }

        public IResult Delete(ColorPalette colorPalette)
        {
            _colorPaletteDal.Delete(colorPalette);
            return new SuccessResult();
        }

        public IDataResult<List<ColorPalette>> GetAll()
        {
            List<ColorPalette> result = _colorPaletteDal.GetAll();

            if (result != null)
                return new SuccessDataResult<List<ColorPalette>>(result);
            else
                return new ErrorDataResult<List<ColorPalette>>(result);
        }

        public IDataResult<List<ColorPalette>> GetAllById(int id)
        {
            List<ColorPalette> result = _colorPaletteDal.GetAll(cp => cp.ColorPaletteId == id);

            if (result != null)
                return new SuccessDataResult<List<ColorPalette>>(result);
            else
                return new ErrorDataResult<List<ColorPalette>>(result);
        }

        public IDataResult<ColorPalette> GetByName(string name)
        {
            ColorPalette result = _colorPaletteDal.Get(cp => cp.PaletteDesignation == name);

            if (result != null)
                return new SuccessDataResult<ColorPalette>(result);
            else
                return new ErrorDataResult<ColorPalette>(result);
        }
    }
}
