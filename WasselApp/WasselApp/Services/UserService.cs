using Newtonsoft.Json;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WasselApp.NewFolder;

namespace WasselApp.Services
{
  public  class UserService
    {
        public async Task<string> InsertUser(User user)
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                using (var client = new HttpClient())
                {
                    Dictionary<string, string> values = new Dictionary<string, string>();
                    values.Add("name", user.name);
                    values.Add("email", user.email);
                    values.Add("carnumber", user.carnumber.ToString());
                    values.Add("cartype", user.cartype.ToString());
                    values.Add("carmodal", user.carmodal.ToString());
                    values.Add("country", user.country);
                    values.Add("city", user.city);
                    values.Add("phone", user.phone);
                    values.Add("age", user.age.ToString());
                    values.Add("national", user.national.ToString());
                    values.Add("image", user.image);
                    values.Add("idnumber", user.idnumber.ToString());
                    values.Add("denominationnumber", user.denominationnumber.ToString());
                    values.Add("passportnumber", user.passportnumber.ToString());
                    values.Add("nationality", user.nationality);
                    values.Add("type", user.type.ToString());
                    values.Add("password", user.password);
                    values.Add("confirmpass", user.confirmpass);
                    values.Add("firebase_token", user.firebase_token);
                    values.Add("device_id", user.device_id);
                    values.Add("lat", user.lat.ToString());
                    values.Add("lng", user.lng.ToString());
                    
                    string content = JsonConvert.SerializeObject(values);
                    try
                    {
                        var response = await client.PostAsync("https://waselksa.alsalil.net/api/register", new StringContent(content, Encoding.UTF8, "text/json"));
                        var serverResponse = response.Content.ReadAsStringAsync().Result.ToString();
                        return serverResponse;
                    }
                    catch (Exception)
                    {
                        return "false";
                    }
                }
            }
            else return "false";
        }
    }
}
