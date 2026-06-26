namespace UnityLearns.LINQ;

public class StudentMgr
{
    public static List<StudentInfo> students = new List<StudentInfo>
    {
        new StudentInfo
        {
            StudentID = 3,
            StudentName = "大姚",
            Birthday = Convert.ToDateTime("1999-10-25"),
            ClassID = 101,
            Courses = new List<Course>
            {
                new Course { CourseID = 101, CourseName = "语文" },
                new Course { CourseID = 102, CourseName = "数学" }
            },
            Age = 20,
        },
        new StudentInfo
        {
            StudentID = 2,
            StudentName = "李四",
            Birthday = Convert.ToDateTime("1998-10-25"),
            ClassID = 101,
            Courses = new List<Course>
            {
                new Course { CourseID = 101, CourseName = "语文" },
                new Course { CourseID = 102, CourseName = "数学" }
            },
            Age = 20,
        },
        new StudentInfo
        {
            StudentID = 1,
            StudentName = "王五",
            Birthday = Convert.ToDateTime("1999-10-25"),
            ClassID = 102,
            Address = "广州",
            Courses = new List<Course>
            {
                new Course { CourseID = 101, CourseName = "语文" },
                new Course { CourseID = 102, CourseName = "数学" }
            },
            Age = 21,
        },
        new StudentInfo
        {
            StudentID = 4,
            StudentName = "时光者",
            Birthday = Convert.ToDateTime("1999-11-25"),
            ClassID = 102,
            Address = "深圳",
            Courses = new List<Course>
            {
                new Course { CourseID = 104, CourseName = "历史" },
                new Course { CourseID = 103, CourseName = "地理" }
            },
            Age = 21,
        }
    };

    public static List<Course> Courses = new List<Course>()
    {
        new Course { CourseID = 101, CourseName = "语文" },
        new Course { CourseID = 102, CourseName = "数学" },
        new Course { CourseID = 103, CourseName = "英语" }
    };
}

public class StudentInfo
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public DateTime Birthday { get; set; }
    public int ClassID { get; set; }
    public string Address { get; set; }
    public List<Course> Courses { get; set; } = new List<Course>();

    public int Age { get; set; }


    public IEnumerable<string> GetTages()
    {
        yield return ClassID.ToString();
        yield return Age.ToString();
    }
}

public class Course
{
    public int CourseID { get; set; }
    public string CourseName { get; set; }
}