using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Table
    {
        public Table(int id, string name, string status)
        {
            this.ID = id;
            this.name = name;
            this.status = status;
        } 

        public Table(DataRow row) 
        {
            this.ID = (int)row["id"];
            this.name = row["name"].ToString()!;
            this.Status = row["status"].ToString()!;       
        
        }

        private string status = string.Empty;

        public string Status 
        {
            get { return status; }
            set { status = value; }
        }

        private string name = string.Empty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int iD;

        public int ID 
        {
            get { return iD; }
            set { iD = value; }
        }
    }
}
