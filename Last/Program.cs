Student student1 = new Student(1,"Akshay",21,"C1");
Student studet2 = new Student(2, "Adarsh", 20, "C2");

Course course1 = new Course("C1","Commerce");
CourseManager courseManager = new CourseManager();

courseManager.AddCourse(course1);
courseManager.listCourse();
StudentManager studentManager = new StudentManager();
studentManager.AddStudent(student1);
studentManager.AddStudent(studet2);

studentManager.UpdateStudent(1,"ANANYA",15,"C1");
studentManager.DeleteStudent(2);
studentManager.ListStudents();
studentManager.FilterStudentsByAge(18);


class Student
{
    public int ID;
    public string Name;
    public int Age;
    public string CourseID;

    public Student( int ID,
    string Name,
    int Age,
    string CourseID){
        this.Name = Name;
        this.ID = ID;
        this.CourseID = CourseID;
        this.Age = Age;
        }
}
class StudentManager
{
    List<Student> students = new List<Student>();
    public void AddStudent(Student student)
    {
        students.Add(student);
    }
    public void ListStudents()
    {
        foreach(var student in students)
        {
            Console.WriteLine("ID:"+student.ID);
            Console.WriteLine("Name:"+student.Name);
            Console.WriteLine("Age:"+student.Age);
            Console.WriteLine("CourseId:"+student.CourseID);
            Console.WriteLine("----------------------------------");
        }
    }
    public void UpdateStudent(int ID,string newName,int newAge,string newCourceID)
    {
        var checkStudent = students.FirstOrDefault(student => student.ID == ID);
        if (checkStudent!=null)
        {
            checkStudent.Name = newName;
            checkStudent.Age = newAge;
            checkStudent.CourseID = newCourceID;
        }
    }
    public void DeleteStudent(int ID)
    {
        var DeleteStudent = students.FirstOrDefault(student => student.ID == ID);
        if (DeleteStudent != null)
        {
            students.Remove(DeleteStudent);
        }
    }
    public void FilterStudentsByAge(int Age)
    {
        var FilteredByAge = students.Where(studnet => studnet.Age > Age);
        foreach(var student in FilteredByAge)
        {
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.CourseID);

        }
    }
    public void GetStudentsByCource(string CourceID)
    {
        var getStudentBYCource = students.Where(student => student.CourseID == CourceID);
        foreach(var student in getStudentBYCource)
        {
            Console.WriteLine(student.ID);
            Console.WriteLine(student.Name);
            Console.WriteLine(student.CourseID);
        }
    }
}

class CourseManager
{
    List<Course> Courses = new List<Course>();
    public void AddCourse(Course course)
    {
        Courses.Add(course);
    }
    public void listCourse()
    {
        foreach(var cource in Courses)
        {
            Console.WriteLine(cource.CourseID);
            Console.WriteLine(cource.CourseName);
        }
    }
    
}
class Course
{
    public string CourseID;
    public string CourseName;
    public Course(string CourseID,string CourseName)
    {
        this.CourseID = CourseID;
        this.CourseName = CourseName;
    }
}