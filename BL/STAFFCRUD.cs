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
    public class STAFFCRUD
    {

        public static DataTable Listele()
        {
            SqlDataAdapter cmd = new SqlDataAdapter("StaffList", Tools.baglanti);
            cmd.SelectCommand.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            cmd.Fill(dt);
            return dt;



        }


        public static bool Add(Staff staff)
        {

            SqlCommand cmd = new SqlCommand("StaffAdd", Tools.baglanti);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StaffNameSurname", staff.StaffNameSurname);
            cmd.Parameters.AddWithValue("@StaffRole", staff.StaffRole);
            cmd.Parameters.AddWithValue("@StaffTitle", staff.StaffTitle);
            cmd.Parameters.AddWithValue("@StaffPhone", staff.StaffPhone);
            cmd.Parameters.AddWithValue("@StaffMail", staff.StaffMail);
            cmd.Parameters.AddWithValue("@StaffWage", staff.StaffWage);

            return Tools.ConnectSet(cmd);



        }


        public static bool Update(Staff staff)
        {

            SqlCommand cmd = new SqlCommand("StaffUpdate", Tools.baglanti);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StaffNumber", staff.StaffNumber);
            cmd.Parameters.AddWithValue("@StaffNameSurname", staff.StaffNameSurname);
            cmd.Parameters.AddWithValue("@StaffRole", staff.StaffRole);
            cmd.Parameters.AddWithValue("@StaffTitle", staff.StaffTitle);
            cmd.Parameters.AddWithValue("@StaffPhone", staff.StaffPhone);
            cmd.Parameters.AddWithValue("@StaffMail", staff.StaffMail);
            cmd.Parameters.AddWithValue("@StaffWage", staff.StaffWage);

            return Tools.ConnectSet(cmd);



        }


        public static bool Delete(Staff staff)


        {
            SqlCommand command = new SqlCommand("StaffDelete", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@StaffNumber", staff.StaffNumber);

            return Tools.ConnectSet(command);


        }

        public static DataTable Search(Staff staff)
        {

            SqlCommand command = new SqlCommand("StaffSearch", Tools.baglanti);
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@StaffRole", staff.StaffRole); 
             Tools.ConnectSet(command);

            SqlDataAdapter dr = new SqlDataAdapter(command);
            DataTable filldata = new DataTable();
            dr.Fill(filldata);


            return filldata;






        }
    }
}
