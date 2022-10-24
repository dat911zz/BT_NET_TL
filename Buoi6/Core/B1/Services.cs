using Buoi6.Modal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6.Core.B1
{
    public class Services
    {
        public List<Student> List { get; set; }
        public Services()
        {
            List = new List<Student>();
        }
        public bool CheckItemExistInList(Student x)
        {
            return List.FindIndex(std => std.Id == x.Id) != -1;
        }
        public bool CheckItemExistInList(string id)
        {
            return List.FindIndex(std => std.Id == id) != -1;
        }
        public string ConvertString(Panel p)
        {
            int flag = 0;
            string listF = "";
            p.Controls.OfType<CheckBox>().ToList().ForEach(x =>
            {
                if (x.Checked)
                {
                    listF += x.Text + ", ";
                    flag++;
                }
            });
            if (flag == 0)
            {
                return "";
            }
            listF = listF.Substring(0, listF.Trim().Length - 1);
            return listF;
        }
        public string[] ConvertStudentToStringArr(Student std)
        {
            return new string[] {std.Name, std.Id, std.Gender == true ? "Nam" : "Nữ", std.ForeignLanguages, std.Ethnic};
        }
    }
}
