
using System.Reflection;
namespace Sts.Product.User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> methodsList = new List<string>();
            Console.WriteLine("\n" + "Список команд пользователя User:" + "\n");
            User user = new User();
            methodsList.AddRange(removingUnusedMethods(user.GetType().GetMethods()));
            foreach (string str in methodsList)
            {
                Console.WriteLine(str);
            }
        }

        static List<string> removingUnusedMethods(MethodInfo[] myArrayMethodInfo) 
        {
            List<string> unusedMethods = new List<string>() { "GetType", "ToString", "Equals", "GetHashCode" };
            List<string> newMethodList = new List<string>();

            foreach (MethodInfo m in myArrayMethodInfo)
            {
                newMethodList.Add(m.Name);

            }

            for (int i = 0; i < unusedMethods.Count; i++)
            {
                for (int j = 0; j < newMethodList.Count; j++) 
                {
                    if (newMethodList[j].Equals(unusedMethods[i]))
                    {
                        newMethodList.RemoveAt(j);
                    }
                } 
            }
            return newMethodList;
        }
    }
}