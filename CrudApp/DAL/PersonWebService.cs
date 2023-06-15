using CrudApp.DTOs;
using CrudApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CrudApp.DAL
{
    public class PersonWebService 
    {
        public static readonly string url = @"https://localhost:44395/api/persons/";



        public static async Task<bool> AddPersonAsync(PersonDto personDto)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.PostAsJsonAsync(url,personDto);
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }

            }
        }

        public static async Task<bool> DeletePersonAsync(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                https://localhost:44395
                    HttpResponseMessage response = await client.DeleteAsync(url+ id);
                    if (response.IsSuccessStatusCode)
                    {
                        string res = await response.Content.ReadAsStringAsync();

                        bool obj = JsonConvert.DeserializeObject<bool>(res);

                        return obj;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        public static async Task<List<Person>> GetPersonsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        GetPersonsResponse obj = JsonConvert.DeserializeObject<GetPersonsResponse>(json);

                        return obj.data;
                    }
                    return null;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

        public static async Task<List<Person>> SearchPersonAsync(string searchString)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url + searchString);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();

                        GetPersonsResponse obj = JsonConvert.DeserializeObject<GetPersonsResponse>(json);

                        return obj.data;
                    }
                    return null;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }

    }
}