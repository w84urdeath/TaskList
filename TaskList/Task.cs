using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList
{
    public class Task
    {
        
        public string nameTask;//{get; set;}
        public string textTask; //{ get; set; }
        public string dateTask;//{get;set;}
        public Task(string name) {
            nameTask = name;
            textTask = "";
            DateTime timeObj = new DateTime();
            dateTask = Convert.ToString(timeObj.Date);
        }
    }
}
