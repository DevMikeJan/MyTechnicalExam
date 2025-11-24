using APIEmployeeInfo.App.Models;
using APIEmployeeInfo.Public;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static APIEmployeeInfo.Public.CustomEnums;

namespace APIEmployeeInfo.App.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly HttpClient http;
        public EmployeeRepository()
        {
            http = new HttpClient { BaseAddress = new Uri("https://localhost:7191") };
        }

        public async Task<DataTable> LoadList()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("empID", typeof(string));
            dt.Columns.Add("empFName", typeof(string));
            dt.Columns.Add("empMName", typeof(string));
            dt.Columns.Add("empLName", typeof(string));
            dt.Columns.Add("empAdd", typeof(string));
            dt.Columns.Add("empAge", typeof(int));
            dt.Columns.Add("empGender", typeof(string));

            try
            {
                var apiResponsed = await http.GetAsync("api/emp/EmpList");
                var jsonData = await apiResponsed.Content.ReadAsStringAsync();
                var empInfo = JsonConvert.DeserializeObject<List<EmployeeModel>>(jsonData);

                foreach (var emp in empInfo)
                    dt.Rows.Add(emp.empID, emp.empFName, emp.empMName, emp.empLName, emp.empAdd, emp.empAge, emp.empGender);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }

            return dt;
        }


        public async Task<String> GetEmpID()
        {
            string empID = string.Empty;

            try
            {
                var apiResponsed = await http.GetAsync("api/emp/GenerateID");
                var jsonData = await apiResponsed.Content.ReadAsStringAsync();

                empID = jsonData.NullAlphaM();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                empID = "";
            }

            return empID;
        }

        public async Task<Boolean> SaveInfo(EmployeeModel ListInput, Trans trans)
        {
            HttpResponseMessage apiResponsed = null;
            try
            {
                var input = new StringContent(JsonConvert.SerializeObject(ListInput), Encoding.UTF8, "application/json");

                if (trans == Trans.New)
                    apiResponsed = await http.PostAsync("api/emp/SaveEmp", input);
                else if (trans == Trans.Edit)
                    apiResponsed = await http.PostAsync("api/emp/SaveEmpEdit", input);

                apiResponsed.EnsureSuccessStatusCode();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


            return true;
        }

        public async Task<Boolean> DelEmp(string empID)
        {
            HttpResponseMessage apiResponsed = null;
            try
            {
                apiResponsed = await http.DeleteAsync("api/emp/DeleteEmp/" + empID + "");

                apiResponsed.EnsureSuccessStatusCode();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return true;
        }
    }
}
