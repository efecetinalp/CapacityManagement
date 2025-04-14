using Business.Abstract;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardUI.Utilities
{
    public class DeleteOperation : DatabaseOperation
    {
        IManager _manager;
        IEntity _entity;
        DataGridViewCell _cell;
        string _firstValue;
        string _currentValue;

        public DeleteOperation(IEntity data, IManager manager, DataGridViewCell dataCell, string cellFirstValue, string cellCurrentValue)
            : base(data, manager, dataCell, cellFirstValue, cellCurrentValue, "Delete")
        {
            _manager = manager;
            _entity = data;
            _cell = dataCell;
            _firstValue = cellFirstValue;
            _currentValue = cellCurrentValue;
        }

        public override void WriteOnDatabase()
        {
            Debug.Print("DELETE OPERATION - Cell: " + _cell.ColumnIndex + "-" + _cell.RowIndex + " - First Val: " + _firstValue + " - Current Val: " + _currentValue);


            if (_manager.Delete(_entity).Success)
                Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "DELETE" + " - " + "Project Capacity" + " - " + "Project capacity cell value deleted");
            else
            {
                Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "ERROR" + " - " + "Project Capacity" + " - " + "Error when adding data into database");
            }
        }
    }
}
