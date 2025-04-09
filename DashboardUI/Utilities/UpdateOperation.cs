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
    public class UpdateOperation : DatabaseOperation
    {
        public UpdateOperation(IEntity data, IManager manager, DataGridViewCell dataCell, string cellFirstValue, string cellCurrentValue) 
            : base(data, manager, dataCell, cellFirstValue, cellCurrentValue, "Update")
        {
        }

        public override void WriteOnDatabase()
        {
            Debug.Print("Update operation test worked");

            //if (manager.Update(data).Success)
            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "UPDATE" + " - " + "Project Capacity" + " - " + "Project capacity cell value updated");
            //else
            //{
            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "ERROR" + " - " + "Project Capacity" + " - " + "Error when adding data into database");
            //}
        }
    }
}
