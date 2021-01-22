using System;

namespace myDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryModel<string, string[]> myDict = new DictionaryModel<string, string[]>();

            myDict.Add("ege", new string[] {"Kütahya", "İzmir", "Muğla"});
            myDict.Add("marmara", new string[] { "bursa", "istanbul", "Bilecik" });
            myDict.Add("ıcAnadolu", new string[] { "Ankara", "Konya", "Eskişehir" });


            string[] egeArray = myDict.Get("ege");
            string[] marmaraArray = myDict.Get("marmara");
            string[] ıcAnadoluArray = myDict.Get("ıcAnadolu");

            getData(egeArray);
            getData(marmaraArray);
            getData(ıcAnadoluArray);

            Console.Read();
        }

        public static void getData(object[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
