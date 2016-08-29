using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanfolyam1
{
    static class PersonHelper
    {
        //this kulcsszoval a list sajat fv-enek fogja tekinteni a mi fv-unket! magic
        internal static IEnumerable<Person> Filter(this List<Person> list, string filter)
        {
            //List<Person> result = new List<Person>();

            foreach (var person in list)
            {
                if (person.Name.Contains(filter))
                    yield return person; //results.Add(person);
                //yield break;
            }


            //return result;
        }

        internal static string Dump(this object o)
        {
            string result = "";
            foreach (var prop in o.GetType().GetProperties())
            {
                result += prop.Name + "=" + prop.GetValue(o) + ", ";
            }

            result += ")";
            return result;
            {

            }
        }

    }
    }

