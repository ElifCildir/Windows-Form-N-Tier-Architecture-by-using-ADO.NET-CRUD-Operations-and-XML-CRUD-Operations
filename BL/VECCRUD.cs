using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;
using System.Security.Policy;

namespace BL
{
    public class VECCRUD
    {

        public static DataTable Listele()
        {
           SqlDataAdapter cmd= new SqlDataAdapter("VecList",Tools.baglanti);

            cmd.SelectCommand.CommandType= CommandType.Text;
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;

        }

        public static bool Add(Vehicle vehicle)
        {
            SqlCommand cmd = new SqlCommand("VehicleAdd", Tools.baglanti);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VehicleType", vehicle.VehicleType);
            cmd.Parameters.AddWithValue("@VehicleCapacity", vehicle.VehicleCapacity);
            cmd.Parameters.AddWithValue("@VehicleDriver", vehicle.VehicleDriver);
            cmd.Parameters.AddWithValue("@VehicleExpense", vehicle.VehicleExpense);

            return Tools.ConnectSet(cmd);

        }

        public static bool Update(Vehicle vehicle)
        {
            SqlCommand cmd = new SqlCommand("VehicleUpdate", Tools.baglanti);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VehicleNo", vehicle.VehicleNo);
            cmd.Parameters.AddWithValue("@VehicleType", vehicle.VehicleType);
            cmd.Parameters.AddWithValue("@VehicleCapacity", vehicle.VehicleCapacity);
            cmd.Parameters.AddWithValue("@VehicleDriver", vehicle.VehicleDriver);
            cmd.Parameters.AddWithValue("@VehicleExpense", vehicle.VehicleExpense);

            return Tools.ConnectSet(cmd);



        }

        public static bool Delete(Vehicle vehicle) 
        
        {
            SqlCommand cmd = new SqlCommand("VehicleDelete", Tools.baglanti);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VehicleNo", vehicle.VehicleNo);

            return Tools.ConnectSet(cmd);
        
        
        
        }


       public static DataTable Search(Vehicle vehicle)
        {
            SqlCommand cmd = new SqlCommand("VehicleSearch", Tools.baglanti);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@VehicleType", vehicle.VehicleType);
            Tools.ConnectSet(cmd);

            SqlDataAdapter dr= new SqlDataAdapter(cmd);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);

            return filldata;



        }







    }
}
