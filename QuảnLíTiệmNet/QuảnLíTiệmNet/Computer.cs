using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QuảnLíTiệmNet
{
    [Serializable]
    public class Computer
    {
        public string idComputer;
        public string status;
        public string kind;
        public string room;
        public double price;
        public Computer()
        {
            this.idComputer = null;
            this.status = null;
            this.kind = null;
            this.room = null;
            this.price = 0;
        }
        public Computer(string idComputer, string status, string kind, string room, double price)
        {
            this.idComputer = idComputer;
            this.status = status;
            this.kind = kind;
            this.room = room;
            this.price = price;
        }
        public string IDComputer
        {
            get { return this.idComputer; }
            set { this.idComputer = value; }
        }
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }
        public string Kind
        {
            get { return this.kind; }
            set { this.kind = value; }
        }
        public string Room
        {
            get { return this.room; }
            set { this.room = value; }
        }
        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
