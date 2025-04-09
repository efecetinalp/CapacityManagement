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


        public DatabaseOperation(IEntity data, IManager manager, DataGridViewCell dataCell, string cellFirstValue, string cellCurrentValue, string operationType)
        {
            Data = data;
            Manager = manager;
            DataCell = dataCell;
            CellFirstValue = cellFirstValue;
            CellCurrentValue = cellCurrentValue;
            OperationType = operationType;
        }

        public IEntity Data { get; }
        public IManager Manager { get; }
        public DataGridViewCell DataCell { get; }
        public string CellFirstValue { get; }
        public string CellCurrentValue { get; set; }
        public string OperationType { get; }

        public virtual void WriteOnDatabase()
        {
        }
    }
}
