using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindingsource
{
    public class Факультет : Students
    {
        
        public string Name { get;  set; }
        public int Value { get;  set; }
        public string Decan { get;  set; }
        public Факультет()
        {
            Name = "NULL";
            Value = 0;
            Decan = "Unknown";
        }
        public Факультет(string name)
        {
             List<Факультет> ALL = new List<Факультет>
             {
                { new Факультет("ИМИ", 1,"Пинигина") },
                { new Факультет("ИТИ", 2,"Архангельская") },
                { new Факультет("ГИ",  3,"Овчинников") }
             };
            for (int i = 0;i<ALL.Count;i++)
                if(name == ALL[i].Name)
                {
                    Name = ALL[i].Name;
                    Value = ALL[i].Value;
                    Decan = ALL[i].Decan;
                }
        }
        public Факультет(string name, int value, string decan)
        {
            Name = name;
            Value = value;
            Decan = decan;
        }
        public static readonly List<Факультет> possibleChoices = new List<Факультет>
            {
            { new Факультет("ИМИ", 1,"Пинигина") },
            { new Факультет("ИТИ", 2,"Архангельская") },
            { new Факультет("ГИ",  3,"Овчинников") }
            };
        public static List<Факультет> GetChoices()
        {
            return possibleChoices;
        }
    }
}
