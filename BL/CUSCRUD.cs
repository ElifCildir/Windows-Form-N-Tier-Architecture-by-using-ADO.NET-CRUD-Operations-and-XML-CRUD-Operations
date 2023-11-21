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
    public class CUSCRUD
    {

        public static DataTable Listele()

        { SqlDataAdapter adp = new SqlDataAdapter("CustomerList", Tools.baglanti);

        adp.SelectCommand.CommandType = System.Data.CommandType.Text;

            DataTable dt = new DataTable();
        adp.Fill(dt);
            return dt;


        }


        public static bool Add(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("CustomerAdd", Tools.baglanti);


            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerNameSurname", customer.CustomerNameSurname);
            cmd.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
            cmd.Parameters.AddWithValue("@CustomerMail", customer.CustomerMail);
            cmd.Parameters.AddWithValue("@CustomerPaymentStatus", customer.CustomerPaymentStatus);

            return Tools.ConnectSet(cmd);




        }

        public static bool Update(Customer customer)


        {
            SqlCommand cmd = new SqlCommand("CustomerUpdate", Tools.baglanti);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerNumber", customer.CustomerNumber);
            cmd.Parameters.AddWithValue("@CustomerNameSurname", customer.CustomerNameSurname);
            cmd.Parameters.AddWithValue("@CustomerAddress", customer.CustomerAddress);
            cmd.Parameters.AddWithValue("@CustomerMail", customer.CustomerMail);
            cmd.Parameters.AddWithValue("@CustomerPaymentStatus", customer.CustomerPaymentStatus);

            return Tools.ConnectSet(cmd);



        }

        public static bool Delete(Customer customer)
        {
            SqlCommand cmd = new SqlCommand("CustomerDelete", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerNumber", customer.CustomerNumber);

            return Tools.ConnectSet(cmd);



        }

        public static DataTable SearchCus(Customer customer)

        {

            SqlCommand cmd = new SqlCommand("CustomerSearch", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CustomerPaymentStatus", customer.CustomerPaymentStatus);
            Tools.ConnectSet(cmd);

            SqlDataAdapter dr = new SqlDataAdapter(cmd);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;



        }




        







    }
}
