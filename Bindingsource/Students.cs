using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindingsource
{
    public class Students
    {
        public string studentid { get; set; }

        public string studentname { get; set; }

        public string studentgroup { get; set; }

        public string studentkurs { get; set; }

        public int studentdate { get; set; }

        public int yearsold { get; set; }

        public int studentmidmark { get; set; } = 0;

        public string Номер { get; set; } = "8914267-44-35";

        public Image studentphoto { get; set; }

        public string studentgender { get; set; }

        public Факультет studentfacult { get; set; }

        public string studentfacultName { get; private set; }

        public Students()
        {
            studentid = string.Empty;
            studentname = string.Empty;
            studentdate = 0;
            studentkurs = string.Empty;
            studentgroup = string.Empty;
            studentphoto = null;
            studentgender = string.Empty;
            studentmidmark = 0;
            studentfacultName = string.Empty;
        }

        public Students(string id, string name, string group, int date, string kurs, Image photo, string gender, int midmark, Факультет facul)
        {
            studentid = id;
            studentname = name;
            studentgroup = group;
            studentdate = date;
            studentkurs = kurs;
            var codeBitmap = new Bitmap(photo, new Size(50, 50));
            Image image = codeBitmap;
            studentphoto = image;
            studentgender = gender;
            studentmidmark = midmark;
            studentfacult = facul;
            studentfacultName = studentfacult.Name;
            Years();
        }
        public void Years() 
        {
            yearsold = 2023 - studentdate;
        }

    }
}
