using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace SerializeTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\ca.r214.01\Desktop\AB106\SerializeTask\SerializeTask\Files\Names.json";
            CustomAdd("Rauf",path);
             
        }

        public static bool Search(string path,string name)
        {

            List<string> names=Deserialize(path);
            return names.Exists(n => n.ToLower() == name.ToLower());


            //foreach (var n in names)
            //{
            //    if (n.ToLower() == name.ToLower()) return true;
            //}
            //return false;


            //return names.Any(n => n.ToLower() == name.ToLower());


            //return names.Contains(name.ToLower());


            //string search=names.Find(n => n.ToLower() == name.ToLower());
            //if(search is null)return false;

            //return true;



        }
        public static void CustomAdd(string name, string path)
        {
            
            List<string> names = Deserialize(path);
            names.Add(name);
            Serialize(path,names);
        }


        public static void CustomRemove(string path,int index)
        {
            List<string> names = Deserialize(path);
            names.RemoveAt(index);
            Serialize(path,names);
        }


        public static List<string> Deserialize(string path)
        {
            string result;
            using (StreamReader sr = new StreamReader(path))
            {
                result = sr.ReadToEnd();
            }

            List<string> names = JsonConvert.DeserializeObject<List<string>>(result);
            return names;
        }
        public static void Serialize<T>(string path,T obj)
        {
            string result = JsonConvert.SerializeObject(obj);

            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(result);
            }
        }
    }
}
