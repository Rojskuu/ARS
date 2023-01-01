﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomatedRoomScheduling
{
    internal class SubjectCRUD : ICRUD
    {
        SqlCommand cmd;
        SqlConnection con;
        String server = @"Data Source=DESKTOP-3LSCP0F\SQLEXPRESS;Initial Catalog = ARS; Integrated Security = True";
        SqlDataAdapter adapter;
        DataSet ds;
        DataTable dt;
        SqlDataReader reader;
        String query;

        public static String SubjectCode { get; set; }
        public static String SubjectDesc { get; set; }
        public static String SubjectType { get; set; }
        public static int  SubjectUnit { get; set; }
        public static int SubjectHrsndd { get; set; }

        public static String SubDisplay = "Select SubCode AS 'Subject Code', SubDescript AS 'Subject Description'," +
            "SubType AS 'Subject Type', unit AS 'Subject Unit' , Hrs AS 'Hours Required' From Subj Where Archive = 0"; 
       
        public void Create()
        {
           
            try
            {
                
                con = new SqlConnection(server);
                con.Open();

                query = $"insert into Subj " +
                    "(SubCode, SubDescript, SubType, unit, Hrs, Archive,Username)" +
                    "values('" + SubjectCode + "', '" + SubjectDesc + "', '" + SubjectType + "', " +
                    "'" + SubjectUnit + "', '" + SubjectHrsndd + "', '" +0+ "', '"+AdminChecker.Admin+"')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();


            }
            catch (Exception) { }

        }

        public void Delete()
        {
            
        }

        public void Retrieve()
        {

            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "Select SubDescript, SubType, unit, Hrs " +
                        "from Subj where SubCode = '" + SubjectCode + "'";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr = cmd.ExecuteReader();
                
                while (rdr.Read())
                {
                    //MessageBox.Show(rdr.GetString(0) + " " + rdr.GetString(1) + " " + rdr.GetString(2));

                    SubjectDesc = rdr.GetString(0)+"";
                    SubjectType = rdr.GetString(1) + "";
                    SubjectUnit = Convert.ToInt32(rdr.GetValue(2));
                    SubjectHrsndd = Convert.ToInt32(rdr.GetValue(3));

                }

                con.Close();

            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }

        public void Update()
        {
            try
            {
                con = new SqlConnection(server);
                con.Open();

                query = "UPDATE Subj set " +
                         "SubDescript = '" + SubjectDesc + "', "
                       + "SubType = '" + SubjectType + "', "
                       + "unit = '" + SubjectUnit + "', "
                       + "Hrs = '"+SubjectHrsndd+"' " +
                       "WHERE SubCode = '"+SubjectCode+"'";


                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();

                cmd.Dispose();
                con.Close();



            }
            catch (Exception ex) { MessageBox.Show(ex + ""); }
        }
    }
}
