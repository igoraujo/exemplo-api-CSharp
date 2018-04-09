using System;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;



namespace API.FW
{
    public class Connection
    {
        public class Conexao
        {

            #region Variaveis Globais

            private bool _Status;
            private string _ErrorMessage;
            private int _ErrorNumber;
            private bool _SuccesCommand;
            private SqlDataReader _SqlRsData;
            private String ConnectionString;
            private SqlConnection Connection;
            private int _primaryKey;
            #endregion

            #region Metodos

            public int getID
            {
                get { return _primaryKey; }
            }

            public void getSql(string myQueryString)
            {

                try
                {
                    _ErrorMessage = string.Empty;
                    _Status = false;

                    if (myQueryString.Length > 0)
                    {

                        SqlCommand myCommand = new SqlCommand(myQueryString, this.Connection);

                        _SqlRsData = myCommand.ExecuteReader();
                        _Status = true;
                        _SuccesCommand = true;
                    }
                }
                catch (Exception ex)
                {
                    _ErrorMessage = ex.Message.ToString();
                    _Status = false;
                    _ErrorNumber = ex.GetHashCode();
                    throw;
                }
            }
            public void getSqlID(string myQueryString)
            {

                try
                {

                    _ErrorMessage = string.Empty;
                    _Status = false;

                    if (myQueryString.Length > 0)
                    {

                        SqlCommand myCommand = new SqlCommand(myQueryString, this.Connection);

                        _primaryKey = Convert.ToInt32(myCommand.ExecuteScalar());
                        _Status = true;
                        _SuccesCommand = true;
                    }
                }
                catch (Exception ex)
                {
                    _ErrorMessage = ex.Message.ToString();
                    _Status = false;
                    _ErrorNumber = ex.GetHashCode();
                    throw;
                }
            }

            public DataTable getDataTable(string myQueryString)
            {

                SqlCommand myCommand = new SqlCommand(myQueryString, this.Connection);

                SqlDataAdapter da = new SqlDataAdapter(myCommand);

                DataTable tab = new DataTable();

                da.Fill(tab);

                myCommand.Dispose();
                myCommand = null;
                da.Dispose();
                da = null;

                return tab;
            }


            private DataSet _ds;

            public void getDs(string myQueryString)
            {

                SqlCommand myCommand = new SqlCommand(myQueryString, this.Connection);
                SqlDataAdapter da = new SqlDataAdapter(myCommand);
                _ds = new DataSet();
                da.Fill(_ds);
            }

            public DataSet Ds
            {
                get
                {
                    return _ds;
                }
            }

            public SqlConnection sqlConn
            {
                get
                {
                    return Connection;
                }
            }

            public void Open()
            {

                String conString;

                conString = ConfigurationManager.ConnectionStrings["InvestBrothersConnection"].ConnectionString;

                this.ConnectionString = conString;
                this.Connection = new SqlConnection(this.ConnectionString);

                this.Connection.Open();

            }

            public void Close()
            {
                if (this.Connection.Equals(null) == false)
                {

                    this.Connection.Close();

                }
            }

            public SqlDataReader RecordSet
            {
                get { return _SqlRsData; }
            }

            #endregion
        }


    }
}
