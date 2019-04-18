using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization.Formatters;
using System.Threading;
using System.Threading.Tasks;
using AM.Common.Activities.BaseActivities;
using AM.Core.ActivityDesignBase.Attributes;
using AM.Logging;

namespace AM.Skeleton.Activities
{
    /// <summary>
    /// Activity to asynchronously connect the Database and return a Datatable. The connection string that has been defined as environment
    /// in the Composer will be used to establish the connection
    /// </summary>
    public class DatabaseExampleActivity : AbstractDatabaseActivity<DataTable>
    {
        [Category("Input")]
        [VariableSelectionInputTextPopup]
        public InArgument<string> Query { get; set; }

        [Category("Output")]
        [VariableSelectionOutputPopup]
        public OutArgument<DataTable> ResultTable { get; set; }

        protected override Task<DataTable> ExecuteAsyncWithResult(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            string query = context.GetValue(Query);
            string connectionString = GetConnectionString(context);

            return Task.Factory.StartNew(
                () =>
                {
                    try
                    {
                        // NOT suited for Production. This example is just a rudimentary example to show how to
                        // connect to the defined Database and return a Datable
                        DataTable dataTable = new DataTable();

                        SqlConnection conn = new SqlConnection(connectionString);        
                        SqlCommand cmd = new SqlCommand(query, conn);
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dataTable);
                        conn.Close();
                        da.Dispose();
                        
                        return dataTable;
                    }
                    catch (Exception ex)
                    {
                        LogHelper.Error(ex.ToString());
                        throw;
                    }
                },
                cancellationToken);
        }

        protected override void OutputResult(AsyncCodeActivityContext context, DataTable result)
        {
            ResultTable.Set(context, result);
        }
    }
}