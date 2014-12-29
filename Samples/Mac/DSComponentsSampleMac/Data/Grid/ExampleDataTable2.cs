﻿using System;
using DSoft.Datatypes.Grid.Data;
using System.Collections.Generic;

namespace DSComponentsSampleMac.Data.Grid
{
	/// <summary>
	/// Example data table2.
	/// </summary>
	public class ExampleDataTable2 : DSDataTable
	{
		public ExampleDataTable2 ()
		{

		}

		public ExampleDataTable2 (String Name) : base(Name)
		{

			var ColumnsDefs = new Dictionary<String,float>();

			ColumnsDefs.Add("Primary",100);
			ColumnsDefs.Add("Code",150);
			ColumnsDefs.Add("Name",300);
			ColumnsDefs.Add("Phone",174);
			ColumnsDefs.Add("Email",300);

			foreach (var aKey in ColumnsDefs.Keys)
			{
				// Create a column
				var dc1 = new DSDataColumn(aKey);
				dc1.Caption = aKey;
				dc1.ReadOnly = true;
				dc1.DataType = typeof(String);
				dc1.AllowSort = true;
				dc1.Width = ColumnsDefs[aKey];

				this.Columns.Add(dc1);
			}

			for (int loop = 0;loop < 21;loop++)
			{
				var dr = new DSDataRow();
				dr["Primary"] = loop;
				dr["Code"] = @"Customer " + loop.ToString();
				dr["Name"] = @"Name of the Customer " + loop.ToString();
				dr["Phone"] = "01234 56789";
				dr["Email"] = "anEmail@acustomer.com";

				this.Rows.Add(dr);
			}



		}
	}
}

