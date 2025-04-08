using Business.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardUI.Utilities
{
    public class DatabaseOperation
    {
        public DatabaseOperation(IEntity data, IManager manager, int cellColumnIndex, int cellRowIndex)
        {
            Data = data;
            Manager = manager;
            CellColumnIndex = cellColumnIndex;
            CellRowIndex = cellRowIndex;
        }

        public IEntity Data { get; }
        public IManager Manager { get; }
        public int CellColumnIndex { get; }
        public int CellRowIndex { get; }

        public virtual void Operation(IEntity data, IManager manager, int cellColumnIndex, int cellRowIndex)
        {
        }
    }
}
