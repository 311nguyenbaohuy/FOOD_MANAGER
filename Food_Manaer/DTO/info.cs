using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Manaer.DTO
{
    class info
    {
        private string name;
        private string id;
        private string gender;
        private string email;
        private string telephone;
        private string country;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public info(string name, string id, string email, string country, string gender, string telephone)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.country = country;
            this.gender = gender;
            this.telephone = telephone;
        }
    }
}
