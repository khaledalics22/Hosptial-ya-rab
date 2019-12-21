﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Hospital_ISA
{
    public class DBManager
    {
        static string DB_Connection_String= @"Data Source=desktop-eajqu63\sqlexpress;Initial Catalog=Hospital;Integrated Security=True";
        SqlConnection myConnection;

    public DBManager()
        {
            myConnection = new SqlConnection(DB_Connection_String);
            try
            {
                myConnection.Open();
                Console.WriteLine("The DB connection is opened successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("The DB connection is failed");
                Console.WriteLine(e.ToString());
            }
        }

        public int ExecuteNonQuery(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
#pragma warning disable IDE0017 // Simplify object initialization
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);
#pragma warning restore IDE0017 // Simplify object initialization

                myCommand.CommandType = CommandType.StoredProcedure;

                foreach (KeyValuePair<string, object> Param in parameters)
                {
                    myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                }

                return myCommand.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public DataTable ExecuteReader(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
#pragma warning disable IDE0017 // Simplify object initialization
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);
#pragma warning restore IDE0017 // Simplify object initialization

                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                SqlDataReader reader = myCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    reader.Close();
                    return dt;
                }
                else
                {
                    reader.Close();
                    return null;
                }
               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public object ExecuteScalar(string storedProcedureName, Dictionary<string, object> parameters)
        {
            try
            {
#pragma warning disable IDE0017 // Simplify object initialization
                SqlCommand myCommand = new SqlCommand(storedProcedureName, myConnection);
#pragma warning restore IDE0017 // Simplify object initialization

                myCommand.CommandType = CommandType.StoredProcedure;

                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> Param in parameters)
                    {
                        myCommand.Parameters.Add(new SqlParameter(Param.Key, Param.Value));
                    }
                }

                return myCommand.ExecuteScalar();            

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void CloseConnection()
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    }

