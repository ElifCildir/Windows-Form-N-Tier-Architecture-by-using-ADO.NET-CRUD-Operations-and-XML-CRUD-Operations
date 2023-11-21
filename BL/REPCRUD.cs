using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BL
{
    public class REPCRUD
    {

        public static DataTable SumofDelivery(Report report)
        {

            SqlCommand command = new SqlCommand("NumofDelivery2", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;
       
            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }

        public static DataTable DeliveryOrder(Report report)
        {

            SqlCommand command = new SqlCommand("DeliveryOrder", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }



        public static DataTable  JoinedCustomer (Report report)
        {

            SqlCommand command = new SqlCommand("JoinedCustomer2", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }



        public static DataTable AvgSalary(Report report)
        {

            SqlCommand command = new SqlCommand("staff5", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }


        public static DataTable JoinVecDelStaff(Report report)
        {

            SqlCommand command = new SqlCommand("Joinvecdelstaff2", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }



        public static DataTable StaffDelCus(Report report)
        {

            SqlCommand command = new SqlCommand("StaffDelCus", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }

        public static DataTable Vec2(Report report)
        {

            SqlCommand command = new SqlCommand("Vec2", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }


        public static DataTable Vec3(Report report)
        {

            SqlCommand command = new SqlCommand("Vec3", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;

            Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }



    }
}
