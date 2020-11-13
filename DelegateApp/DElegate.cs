using System.Collections.Generic;
namespace DelegateApp
{
    public class TestDelegate
    {
        public string Space(string str)
        {
            string spaceInsert = "";
            foreach (var item in str)
            {
                spaceInsert += item + " ";
            }
            return spaceInsert;
        }

        public string Reverse( string str )
        {
            string result = "";
            Stack<char> reverser = new Stack<char>();
            foreach (var item in str)
            {
                reverser.Push(item);
            }
            foreach (var item in reverser)
            {
                result += item;
            }
            return result;
        }
    }
}
