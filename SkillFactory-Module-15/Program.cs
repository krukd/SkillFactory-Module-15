namespace SkillFactory_Module_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {

            /*IEnumerable<string> studentsAll = new List<string>();
            foreach (var eachClass in classes)
            {
                studentsAll = studentsAll.Concat(eachClass.Students);
            }

            var studentsAllFinal = studentsAll.ToArray();
            return studentsAllFinal;*/

            string[] studentsAll = classes.SelectMany(c => c.Students).ToArray();
            return studentsAll;
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}