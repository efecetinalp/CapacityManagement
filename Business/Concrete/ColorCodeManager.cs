using Business.Abstract;
using Business.Constants;
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
    public class ColorCodeManager : IColorCodeService
    {
        IColorCodeDal _colorCodeDal;

        public ColorCodeManager(IColorCodeDal colorCodeDal)
        {
            _colorCodeDal = colorCodeDal;
        }

        public IResult Add(ColorCode colorCode)
        {
            _colorCodeDal.Add(colorCode);
            return new SuccessResult();
        }

        public IResult Update(ColorCode colorCode)
        {
            _colorCodeDal.Update(colorCode);
            return new SuccessResult();
        }

        public IResult Delete(ColorCode colorCode)
        {
            _colorCodeDal.Delete(colorCode);
            return new SuccessResult();
        }

        public IDataResult<List<ColorCode>> GetAll()
        {
            List<ColorCode> result = _colorCodeDal.GetAll();

            if (result.Count == 0)
                return new ErrorDataResult<List<ColorCode>>(result);
            else
                return new SuccessDataResult<List<ColorCode>>(result);
        }

        public IDataResult<List<ColorCode>> GetAllById(int id)
        {
            List<ColorCode> result = _colorCodeDal.GetAll(cc => cc.ColorId == id);

            if (result.Count == 0)
                return new ErrorDataResult<List<ColorCode>>(result);
            else
                return new SuccessDataResult<List<ColorCode>>(result);
        }

        public IDataResult<ColorCode> GetByName(string name)
        {
            ColorCode result = _colorCodeDal.Get(cc => cc.ColorDesignation == name);

            if (result != null)
                return new ErrorDataResult<ColorCode>(result);
            else
                return new SuccessDataResult<ColorCode>(result);
        }

        public IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetails()
        {
            List<ColorCodeDetailDto> result = _colorCodeDal.GetColorCodeDetails();

            if (result.Count == 0)
                return new ErrorDataResult<List<ColorCodeDetailDto>>(result);
            else
                return new SuccessDataResult<List<ColorCodeDetailDto>>(result);
        }

        public IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetailsByPaletteId(int paletteId)
        {
            List<ColorCodeDetailDto> result = _colorCodeDal.GetColorCodeDetails(cc => cc.ColorPaletteId == paletteId);

            if (result.Count == 0)
                return new ErrorDataResult<List<ColorCodeDetailDto>>(result);
            else
                return new SuccessDataResult<List<ColorCodeDetailDto>>(result);
        }

        public IDataResult<List<ColorCodeDetailDto>> GetColorCodeDetailsByPaletteName(string paletteName)
        {
            List<ColorCodeDetailDto> result = _colorCodeDal.GetColorCodeDetails(cc => cc.PaletteDesignation == paletteName);

            if (result.Count == 0)
                return new ErrorDataResult<List<ColorCodeDetailDto>>(result);
            else
                return new SuccessDataResult<List<ColorCodeDetailDto>>(result);
        }
    }
}
