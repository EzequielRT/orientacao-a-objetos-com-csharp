namespace ConsoleAppEx17.Entities
{
    class Student
    {
        public int Cod { get; private set; }

        public Student(int plate)
        {
            Cod = plate;
        }

        public override int GetHashCode()
        {
            return Cod.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return Cod.Equals(other.Cod);
        }
    }
}
