using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.DataTypes.ReferenceTypes.Collections.Dictionary
{
    public class DictionaryExample
    {
        public Dictionary<string, (string, DateTime)> exams = new Dictionary<string, (string, DateTime)>
        {
            ["Math Final"] = ("Passed", DateTime.Now),
            ["Science Final"] = ("Passed", DateTime.Now)
        };

        public Dictionary<string, string> employees = new()
        {
            ["John"] = "Finance",
            ["Jim"] = "Legal"
        };
    }
}
