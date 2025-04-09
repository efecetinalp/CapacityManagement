using Business.Abstract;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorPaletteManager : IColorPaletteService
    {
        IColorPaletteDal _colorPaletteDal;

        public ColorPaletteManager(IColorPaletteDal colorPaletteDal)
        {
            _colorPaletteDal = colorPaletteDal;
        }

        public IResult Add(IEntity colorPalette)
        {
            _colorPaletteDal.Add(colorPalette as ColorPalette);
            return new SuccessResult();
        }

        public IResult Update(IEntity colorPalette)
        {
            _colorPaletteDal.Update(colorPalette as ColorPalette);
            return new SuccessResult();
        }

        public IResult Delete(IEntity colorPalette)
        {
            _colorPaletteDal.Delete(colorPalette as ColorPalette);
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
