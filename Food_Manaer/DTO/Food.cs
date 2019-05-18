using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Manaer.DTO
{
    class Food
    {
        private string id;
        private string name;
        private int soluong;
        private double price;
        private string type;
        public Food()
        {
            id = name = type = "";
            soluong = 0;
        }
        public Food(string id, string name, int soluong, string type)
        {
            this.id = id;
            this.name = name;
            this.soluong = soluong;
            this.type = type;
        }
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
        public int Amount
        {
            get { return soluong; }
            set { soluong = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
