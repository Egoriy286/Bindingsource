using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bindingsource
{
    public class Факультет
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public string Decan { get; private set; }
        public Факультет(string name, int value, string decan)
        {
            Name = name;
            Value = value;
            Decan = decan;
        }
        public static readonly List<Факультет> possibleChoices = new List<Факультет>
            {
            { new Факультет("ИМИ", 1,"Пинигина") },
            { new Факультет("ФТИ", 2,"Николаев") },
            { new Факультет("ИЕН", 3,"Колодезников") },
            { new Факультет("ИТИ", 4,"Архангельская") },
            { new Факультет("ГИ",  5,"Овчинников") }
            };
        public static List<Факультет> GetChoices()
        {
            return possibleChoices;
        }
    }
}
