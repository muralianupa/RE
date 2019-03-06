using System;
using System.Collections.Generic;

namespace RecommendationEngine
{
    public class Profile
    {
        // PROPERTIES
        public string userEmail;
        public string userOrganization;
        public List<Organization> organizations;
        public readonly IDictionary<string, float> topics;

        public Profile()
        {
            //userEmail = profileData["user"];
            //userOrganization = profileData["user_org"];
            //organizations = profileData["organizations"];
            //topics = profileData["topics"];
        }
    }

    public class Organization
    {
        // PROPERTIES
        public string name;
        public string legal_name;
        public string org_id; 
        public float[] priority_ids;
        public float salience; 

    }
}
