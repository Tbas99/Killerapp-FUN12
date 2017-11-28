﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    class ResourceData
    {
        // list that contains all column values
        List<DataColumn> testlist = new List<DataColumn>();

        private string resourceType;
        private string resourceName;
        private string resourceRole;
        private string resourceAvailablePeriod;
        private string resourceUnavailablePeriod;
        private string resourceUnavailablePeriodEnd;

        public string ResourceType { get { return resourceType; } }
        public string ResourceName { get { return resourceName; } }
        public string ResourceRole { get { return resourceRole; } }
        public string ResourceAvailablePeriod { get { return resourceAvailablePeriod; } }
        public string ResourceUnavailablePeriod { get { return resourceUnavailablePeriod; } }
        public string ResourceUnavailablePeriodEnd { get { return resourceUnavailablePeriodEnd; } }

        // Method to store data in variables
        public ResourceData(string type, string name, string role, string availablePeriod = "", string unavailablePeriod = "", string unavailablePeriodEnd = "")
        {
            // create dataset instance(s)
            DataSet database = new DataSet("ProjectManagerDataSet");
            DataTable resourceTable = database.Tables.


            this.resourceType = type;
            this.resourceName = name;
            this.resourceRole = role;
            this.resourceAvailablePeriod = availablePeriod;
            this.resourceUnavailablePeriod = unavailablePeriod;
            this.resourceUnavailablePeriodEnd = unavailablePeriodEnd;

            DataRow resourceTableRow = resourceTable.NewRow();
            resourceTableRow.

            resourceTable.Columns.Add(new DataColumn())

        }
    }
}
