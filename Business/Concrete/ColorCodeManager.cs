using Business.Abstract;
using Core.Entities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class ColorCodeManager : IColorCodeService
    {
        IColorCodeDal _colorCodeDal;

        public ColorCodeManager(IColorCodeDal colorCodeDal)
        {
            _colorCodeDal = colorCodeDal;
        }

        public IResult Add(IEntity colorCode)
        {
            _colorCodeDal.Add(colorCode as ColorCode);
            return new SuccessResult();
        }

        public IResult Update(IEntity colorCode)
        {
            _colorCodeDal.Update(colorCode as ColorCode);
            return new SuccessResult();
        }

        public IResult Delete(IEntity colorCode)
        {
            _colorCodeDal.Delete(colorCode as ColorCode);
            return new SuccessResult();
        }

        public IDataResult<List<ColorCode>> GetAll()
        {
            List<ColorCode> result = _colorCodeDal.GetAll();

            if (result != null)
                return new SuccessDataResult<List<ColorCode>>(result);
            else
                return new ErrorDataResult<List<ColorCode>>(result);
        }

        public IDataResult<List<ColorCode>> GetAllById(int id)
        {
            List<ColorCode> result = _colorCodeDal.GetAll(cc => cc.ColorId == id);

            if (result != null)
                return new SuccessDataResult<List<ColorCode>>(result);
            else
                return new ErrorDataResult<List<ColorCode>>(result);
        }

        public IDataResult<ColorCode> GetByName(string name)
        {
            ColorCode result = _colorCodeDal.Get(cc => cc.ColorDesignation == name);

            if (result != null)
                return new SuccessDataResult<ColorCode>(result);
            else
                return new ErrorDataResult<ColorCode>(result);
        }

        public IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetails()
        {
            List<ColorCodeDetailDto> result = _colorCodeDal.GetColorCodeDetails();

            if (result != null)
                return new SuccessDataResult<List<ColorCodeDetailDto>>(result);
            else
                return new ErrorDataResult<List<ColorCodeDetailDto>>(result);
        }

        public IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetailsByPaletteId(int paletteId)
        {
            List<ColorCodeDetailDto> result = _colorCodeDal.GetColorCodeDetails(cc => cc.ColorPaletteId == paletteId);

            if (result != null)
                return new SuccessDataResult<List<ColorCodeDetailDto>>(result);
            else
                return new ErrorDataResult<List<ColorCodeDetailDto>>(result);
        }

        public IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetailsByPaletteName(string paletteName)
        {
            List<ColorCodeDetailDto> result = _colorCodeDal.GetColorCodeDetails(cc => cc.PaletteDesignation == paletteName);

            if (result != null)
                return new SuccessDataResult<List<ColorCodeDetailDto>>(result);
            else
                return new ErrorDataResult<List<ColorCodeDetailDto>>(result);
        }
    }
}
