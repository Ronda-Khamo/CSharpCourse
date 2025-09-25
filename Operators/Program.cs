using System;

namespace EmployeeEqualityApp
{
    class Emp
    {
        public int Id { get; set; }
        public string First { get; set; }

        public static bool operator ==(Emp a, Emp b)
        {
            if (object.ReferenceEquals(a, b)) return true;
            if ((object)a == null || (object)b == null) return false;
            return a.Id == b.Id;
        }

        public static bool operator !=(Emp a, Emp b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Emp other = obj as Emp;
            return other != null && this.Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program5
    {
        static void Main()
        {
            Emp emp1 = new Emp { Id = 101, First = "Ronda" };
            Emp emp2 = new Emp { Id = 101, First = "Rondo" };

            Console.WriteLine("Do they match? " + (emp1 == emp2));
            Console.ReadLine();
        }
    }
}
