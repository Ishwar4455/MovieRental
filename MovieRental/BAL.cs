using System;
using System.Collections.Generic;

using System.Web;
using System.Data.SqlClient;
using System.Data;
using MovieRental;

/// <summary>
/// Summary description for login
/// </summary>

/// <summary>
/// Summary description for BAL
/// </summary>
public class BAL
{
    DAL FwDal = new DAL();

    public DataSet getExecutSP_DSWithParamter(string SPName, SqlParameter[] SP)
    {
        SqlCommand cmd = new SqlCommand(SPName, FwDal.fwDALConnection());
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dt = new DataSet();

        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = SPName;
        cmd.CommandTimeout = 600;
        foreach (SqlParameter sp in SP)
        {
            cmd.Parameters.Add(sp);
        }



        try
        {
            FwDal.SqlOpen();
            da.SelectCommand = cmd;
            da.Fill(dt);
            FwDal.SqlClose();

        }
        catch (Exception e)
        {
            // Response.Write(" <script>alert('"+e.ToString()+"')</script>");

        }
        finally
        {
            cmd.Dispose();
            FwDal.SqlClose();
        }
        return dt;


    }

    public DataTable getExecutSP_DTWithParamter(string SPName, SqlParameter[] SP)
    {
        SqlCommand cmd = new SqlCommand(SPName, FwDal.fwDALConnection());
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = SPName;
        cmd.CommandTimeout = 600;
        foreach (SqlParameter sp in SP)
        {
            cmd.Parameters.Add(sp);
        }



        try
        {
            FwDal.SqlOpen();
            da.SelectCommand = cmd;
            da.Fill(dt);
            FwDal.SqlClose();

        }
        catch (Exception e)
        {
            // Response.Write(" <script>alert('"+e.ToString()+"')</script>");

        }
        finally
        {
            cmd.Dispose();
            FwDal.SqlClose();
        }
        return dt;


    }

    public DataTable getExecutSP_DTWithoutParamter(string SPName)
    {
        SqlCommand cmd = new SqlCommand(SPName, FwDal.fwDALConnection());
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = SPName;
        cmd.CommandTimeout = 600;
        try
        {
            FwDal.SqlOpen();
            da.SelectCommand = cmd;
            da.Fill(dt);
            FwDal.SqlClose();

        }
        catch { }
        finally
        {
            cmd.Dispose();
            FwDal.SqlClose();
        }
        return dt;


    }

    public DataSet getExecutSP_DSWithoutParamter(string SPName)
    {
        SqlCommand cmd = new SqlCommand(SPName, FwDal.fwDALConnection());
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dt = new DataSet();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = SPName;
        cmd.CommandTimeout = 600;
        try
        {
            FwDal.SqlOpen();
            da.SelectCommand = cmd;
            da.Fill(dt);
            FwDal.SqlClose();

        }
        catch { }
        finally
        {
            cmd.Dispose();
            FwDal.SqlClose();
        }
        return dt;


    }
    public string getExecutSPWithParamter(string SPName, SqlParameter[] SP)
    {
        SqlCommand cmd = new SqlCommand(SPName, FwDal.fwDALConnection());
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = SPName;
        cmd.CommandTimeout = 600;
        foreach (SqlParameter sp in SP)
        {
            cmd.Parameters.Add(sp);
        }



        try
        {
            FwDal.SqlOpen();
            cmd.ExecuteNonQuery();
            FwDal.SqlClose();

        }
        catch { }
        finally
        {
            cmd.Dispose();
            FwDal.SqlClose();
        }
        return "Success";
    }






}