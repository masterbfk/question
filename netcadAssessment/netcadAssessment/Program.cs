using System;

namespace netcadAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = GetDataFromStaticFile.getData();
            foreach (var item in data)
            {
                Solution sl = new Solution();
                Console.WriteLine(sl.solution(item));
            }
            Console.ReadLine();
        }
    }
}
