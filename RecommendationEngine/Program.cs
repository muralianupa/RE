using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Collections;

namespace RecommendationEngine
{
    class RecommendationEngine
    {
        static void Main(string[] args)
        {
            // TODO 1. Regex filtering out any mention of Refinitiv where Refinitiv is just a source

            // TODO 2. Get matches for user profile

            // // TODO a. import profile
            Profile profileData;
            using (StreamReader r = new StreamReader("Sample Data/Sample Profiles/financeprofile.json"))
            {
                string json = r.ReadToEnd();
                profileData = JsonConvert.DeserializeObject<Profile>(json);
            }
            foreach (Organization organization in profileData.organizations) {
                Console.WriteLine(organization.name);

            }
            // // TODO b. fetch profile
            // // TODO c. fetch news for profile
            // // TODO d. filter valid news
            // // TODO e. rank news for user profile
            // // TODO f. 
        }
    }

}
