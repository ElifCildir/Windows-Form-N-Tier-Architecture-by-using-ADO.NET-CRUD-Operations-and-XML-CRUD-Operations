using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using System.Data;
namespace BL
{
    public class DELCRUD
    {

        public static DataTable Listele()
        {

            SqlDataAdapter sql =   new SqlDataAdapter("DeliverList", Tools.baglanti);
            sql.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            sql.Fill(dt);
            return dt;



        }

        public static bool Add(Delivery delivery)
        {
            SqlCommand command = new SqlCommand("DeliveryAdd", Tools.baglanti);
            command.CommandType =System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DeliveryName", delivery.DeliveryName);
            command.Parameters.AddWithValue("@DeliveryPickupPoint", delivery.DeliveryPickupPoint);
            command.Parameters.AddWithValue("@DeliveryPoint", delivery.DeliveryPoint);
            command.Parameters.AddWithValue("@DeliveryDistance", delivery.DeliveryDistance);
            command.Parameters.AddWithValue("@DeliveryPrice", delivery.DeliveryPrice);
            command.Parameters.AddWithValue("@CustomerNumber", delivery.CustomerNumber);
            command.Parameters.AddWithValue("@VehicleNo", delivery.VehicleNo);
            command.Parameters.AddWithValue("@StaffNumber", delivery.StaffNumber);

            return Tools.ConnectSet(command);



        }

        public static bool Update(Delivery delivery) 
        
        
       {

            SqlCommand command = new SqlCommand("DeliveryUpdate", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DeliveryNumber", delivery.DeliveryNumber);
            command.Parameters.AddWithValue("@DeliveryName", delivery.DeliveryName);
            command.Parameters.AddWithValue("@DeliveryPickupPoint", delivery.DeliveryPickupPoint);
            command.Parameters.AddWithValue("@DeliveryPoint", delivery.DeliveryPoint);
            command.Parameters.AddWithValue("@DeliveryDistance", delivery.DeliveryDistance);
            command.Parameters.AddWithValue("@DeliveryPrice", delivery.DeliveryPrice);
            command.Parameters.AddWithValue("@CustomerNumber", delivery.CustomerNumber);
            command.Parameters.AddWithValue("@VehicleNo", delivery.VehicleNo);
            command.Parameters.AddWithValue("@StaffNumber", delivery.StaffNumber);
            
            return Tools.ConnectSet(command);



        }

        public static bool Delete(Delivery delivery)


        {
            SqlCommand command = new SqlCommand("DeliveryDelete", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DeliveryNumber", delivery.DeliveryNumber);

            return Tools.ConnectSet(command);


        }


        public static DataTable Search (Delivery delivery)
        {

            SqlCommand command = new SqlCommand("DeliverySearch", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@DeliveryPoint", delivery.DeliveryPoint);
            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;
          


        }




    }
}
