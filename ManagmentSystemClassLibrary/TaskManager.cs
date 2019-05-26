using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystemClassLibrary
{
    public class TaskManager
    {
        public async Task<List<Job>> GetJobs() {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44345");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage jobs = await client.GetAsync("api/JobsController/Jobs");
                if (jobs.IsSuccessStatusCode)
                {
                    return await jobs.Content.ReadAsAsync<List<Job>>();
                }
            }
            return new List<Job>();
        }

        public async Task<bool> DisributeTask(Department department, Job job) {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:5051");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage jobs = await client.PostAsJsonAsync("api/JobsController/DisributeTask/"+department.Id, job);
                if (jobs.IsSuccessStatusCode)
                {
                    return true;
                }
            }
            return false;
        }
    }   
}
