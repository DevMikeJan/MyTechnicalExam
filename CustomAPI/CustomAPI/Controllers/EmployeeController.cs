using CustomAPI.Models;
using CustomAPI.Public;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace CustomAPI.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        private readonly string conString = @"Server=YourServer;Database=YourDB;User Id=YourID;Password=YourPassword;
                                              Trusted_Connection=True;
                                              Encrypt=True;
                                              TrustServerCertificate=True;                    
                                              MultipleActiveResultSets=True;";

        [HttpGet("EmpList")]
        public IActionResult GetAll()
        {
            var list = new List<EmployeeModel>();
            SqlConnection con = new SqlConnection(conString);
            string qry = @"SELECT * FROM EMPLOYEE";

            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    list.Add(new EmployeeModel
                    {
                        empID = rd["empID"].ToString(),
                        empFName = rd["empFName"].ToString(),
                        empMName = rd["empMName"].ToString(),
                        empLName = rd["empLName"].ToString(),
                        empAdd = rd["empAdd"].ToString(),
                        empAge = Convert.ToInt32(rd["empAge"]),
                        empGender = rd["empGender"].ToString(),
                    });
                }

                return Ok(list);
            }
        }

        [HttpGet("GenerateID")]
        public IActionResult GenerateEmpID()
        {
            SqlConnection con = new SqlConnection(conString);
            int zeros = 6;
            string empID = string.Empty;
            string qry = @"SELECT TOP(1)empID FROM EMPLOYEE ORDER BY EMPID DESC";


            empID = CustomFunctions.RemoveSpecificZero(zeros, "1") + "1";

            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                con.Open();

                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string tempID = rd["empID"].ToString();
                    tempID = tempID.Substring(3, zeros);
                    int empTempID = Convert.ToInt32(tempID);
                    int totLen = empTempID.ToString().Length;
                    int zeroCount = 0;
                    string zero = string.Empty;
                    empTempID += 1;
                    zeroCount = zeros - totLen;

                    if (zeros > totLen.ToString().Length)
                        for (int i = 1; i <= zeroCount; i++)
                            zero += "0";

                    empID = zero + empTempID;
                }
            }


            return Ok("EMP" + empID);
        }

        [HttpPost("SaveEmp")]
        public IActionResult SaveEntry(EmployeeModel input)
        {
            var list = new List<EmployeeModel>();
            SqlConnection con = new SqlConnection(conString);
            string qry = @"INSERT INTO EMPLOYEE (empID,empFName,empMName,empLName,empAdd,empAge,empGender) 
                                         VALUES (@empID,@empFName,@empMName,@empLName,@empAdd,@empAge,@empGender)";

            con.Open();
            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@empID", input.empID);
                cmd.Parameters.AddWithValue("@empFName", input.empFName);
                cmd.Parameters.AddWithValue("@empMName", input.empMName);
                cmd.Parameters.AddWithValue("@empLName", input.empLName);
                cmd.Parameters.AddWithValue("@empAdd", input.empAdd);
                cmd.Parameters.AddWithValue("@empAge", input.empAge);
                cmd.Parameters.AddWithValue("@empGender", input.empGender);
                cmd.ExecuteNonQuery();
            }

            con.Close();

            return Ok();

        }

        [HttpPost("SaveEmpEdit")]
        public IActionResult SaveEdit(EmployeeModel input)
        {
            var list = new List<EmployeeModel>();
            SqlConnection con = new SqlConnection(conString);
            string qry = @"UPDATE EMPLOYEE SET empFName = @empFName, empMName = @empMName, 
                                               empLName = @empLName, empAdd = @empAdd, 
                                               empAge = @empAge, empGender = @empGender
                                        WHERE empID = @empID";

            con.Open();
            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@empID", input.empID);
                cmd.Parameters.AddWithValue("@empFName", input.empFName);
                cmd.Parameters.AddWithValue("@empMName", input.empMName);
                cmd.Parameters.AddWithValue("@empLName", input.empLName);
                cmd.Parameters.AddWithValue("@empAdd", input.empAdd);
                cmd.Parameters.AddWithValue("@empAge", input.empAge);
                cmd.Parameters.AddWithValue("@empGender", input.empGender);
                cmd.ExecuteNonQuery();
            }

            con.Close();

            return Ok();

        }

        [HttpDelete("DeleteEmp/{empID}")]
        public IActionResult DeleteEmpt(string empID)
        {
            var list = new List<EmployeeModel>();
            SqlConnection con = new SqlConnection(conString);
            string qry = @"DELETE EMPLOYEE WHERE empID = @empID";

            con.Open();
            using (SqlCommand cmd = new SqlCommand(qry, con))
            {
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.ExecuteNonQuery();
            }

            con.Close();

            return Ok();

        }
    }
}
