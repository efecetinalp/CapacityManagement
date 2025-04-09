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
        public DeleteOperation(IEntity data, IManager manager, DataGridViewCell dataCell, string cellFirstValue, string cellCurrentValue) 
            : base(data, manager, dataCell, cellFirstValue, cellCurrentValue, "Delete")
        {
        }

        public override void WriteOnDatabase()
        {
            Debug.Print("Delete operation test worked");

            //if (manager.Delete(data).Success)
            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "DELETE" + " - " + "Project Capacity" + " - " + "Project capacity cell value deleted");
            //else
            //{
            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "ERROR" + " - " + "Project Capacity" + " - " + "Error when adding data into database");
            //}
        }
    }
}
