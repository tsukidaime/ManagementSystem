using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemClassLibrary
{
    public class DepartmentManager
    {
        public async Task<List<Department>> GetDepartments()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage jobs = await client.GetAsync("api/DepartmentsController/Departments");
                if (jobs.IsSuccessStatusCode)
                {
                    return await jobs.Content.ReadAsAsync<List<Department>>();
                }
            }
            return new List<Department>();
        }
    }
}
