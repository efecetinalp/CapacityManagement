using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorCodeDal : EfEntityRepositoryBase<ColorCode, CapacityDBContext>, IColorCodeDal
    {
        public List<ColorCodeDetailDto> GetColorCodeDetails(Expression<Func<ColorCodeDetailDto, bool>> filter = null)
        {
            using (CapacityDBContext context = new CapacityDBContext())
            {
                var result = from cc in context.ColorCodes
                             join cp in context.ColorPalettes on cc.ColorPaletteId equals cp.ColorPaletteId
                             select new ColorCodeDetailDto
                             {
                                 ColorId = cc.ColorId,
                                 ColorPaletteId = cp.ColorPaletteId,
                                 PaletteType = cp.PaletteType,
                                 ColorType = cc.ColorType,
                                 PaletteDesignation = cp.PaletteDesignation,
                                 ColorDesignation = cc.ColorDesignation,
                                 GetColorCode = System.Drawing.Color.FromArgb(cc.Red,cc.Green, cc.Blue)
                             };
                return result.Where(filter).ToList();
            }
        }
    }
}
