using System;
using System.Data;
using System.Data.SqlClient;


namespace ADO_Assessment1
{
    class Program
    {
        public static SqlConnection con = null;
        public static SqlCommand cmd;
        public static SqlDataReader dr;

        static void Main(string[] args)
        {
            Employee_DataDetails();
            Display_EmployeeDetails();

            Console.Read();
        }

        public static SqlConnection GetConnection()
        {
            con = new SqlConnection("data source=ICS-LT-3P1Y7G3;initial catalog=EmployeeManagement;" +
                "integrated security=true");
            con.Open();
            return con;
        }

        public static void Employee_DataDetails()
        {
            con = GetConnection();

            try
            {
                Console.WriteLine("Enter Employee Name, Salary, Type (P/C) : ");
                string empname = Console.ReadLine();
                float empsal = Convert.ToSingle(Console.ReadLine());
                string emptype = Console.ReadLine();

                cmd = new SqlCommand("Employee_Data", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpName", empname);
                cmd.Parameters.AddWithValue("@Empsal", empsal);
                cmd.Parameters.AddWithValue("@Emptype", emptype);

                int Emp_no = (int)cmd.ExecuteScalar();
            }
            catch (SqlException se)
            {
                Console.WriteLine("Some SQL error occurred, Try to enter salary above 25000");
            }
        }

        public static void Display_EmployeeDetails()
        {
            con = GetConnection();

            cmd = new SqlCommand("select * from Employee_Details", con);

            dr = cmd.ExecuteReader();

            Console.WriteLine("=====================================================================");
            Console.WriteLine("Empno \t| EmpName \t| Empsal \t| Emptype");
            Console.WriteLine("---------------------------------------------------------------------");

            while (dr.Read())
            {
                Console.WriteLine("{0} \t| {1} \t| {2} \t| {3}",
                    dr["Empno"], dr["EmpName"], dr["Empsal"], dr["Emptype"]);
            }

            Console.WriteLine("=====================================================================");
            dr.Close();
        }
    }
}
