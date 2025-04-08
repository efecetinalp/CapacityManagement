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
    public class CreateOperation : DatabaseOperation
    {
        public CreateOperation(IEntity data, IManager manager, int cellColumnIndex, int cellRowIndex) : base(data, manager, cellColumnIndex, cellRowIndex)
        {
        }

        public override void Operation(IEntity data, IManager manager, int cellColumnIndex, int cellRowIndex)
        {
            Debug.Print("Create operation test worked");

            //if (manager.Add(data).Success)
            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "CREATE" + " - " + "Project Capacity" + " - "  + "Project capacity cell value added");
            //else
            //{
            //    Debug.Print(DateTime.Now + " - " + Environment.UserName + " - " + "ERROR" + " - " + "Project Capacity" + " - " + "Error when adding data into database");
            //}
        }
    }
}
