namespace EF6CodeFirstDemo.School
{
    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public TeachingMode ModeOfTeaching { get; set; }
    }

    public enum TeachingMode
    {
        Online,
        ClassRoom,
        LiveOnline
    }
}