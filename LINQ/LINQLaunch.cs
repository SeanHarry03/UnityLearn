using System.Runtime.CompilerServices;
using UnityLearns.LINQ.Lookup.SelectManyDemo;

namespace UnityLearns.LINQ;

/// <summary>
/// LINQ 学习 启动脚本
/// </summary>
public class LINQLaunch : Singleton<LINQLaunch>
{
    public LINQLaunch()
    {
        Console.WriteLine("LINQ语言集成查询");
        Console.WriteLine("学习链接：https://www.yuque.com/ysgstudyhard/lg56l0/ggt1v0z1g37wsv02#3cec23e");
    }

    public void Run()
    {
        // var femaleStudents = StudentMgr.students.Where(s => s.StudentName == "时光者");
        // var studentNames = StudentMgr.students.Select(s => s.StudentName);
        //
        // // 使用SelectMany展平所有学生的课程列表
        // var allCourses = StudentMgr.students.SelectMany(student => student.Courses).ToList();
        //
        // // 输出所有课程的名称
        // foreach (var course in allCourses)
        // {
        //     Console.WriteLine(course.CourseName);
        // }
        //
        // var studentList = StudentMgr.students.ToList();
        // var studentArray = StudentMgr.students.ToArray();
        // var studentDictionary = StudentMgr.students.ToDictionary(s => s.StudentID, s => s.StudentName);
        //
        // foreach (var studentDicItem in studentDictionary)
        // {
        //     Console.WriteLine(studentDicItem.Key);
        //     Console.WriteLine(studentDicItem.Value);
        // }
        //
        // //用例：1.背包系统中的数据分页查询功能中。2.任务日志（按状态分类任务）3.商城（按类别分类商品）4.成就系统
        // Console.WriteLine("Lookup数据类型");
        // var studentLookup = StudentMgr.students.ToLookup(s => s.ClassID);
        //
        // foreach (var studentInfo in studentLookup[101])
        // {
        //     Console.WriteLine(studentInfo.StudentName);
        // }
        //
        // Console.WriteLine("---------------------------------");
        // SelectManyDemoMgr.Instance.Run();

//         var firstStudent = StudentMgr.students.First();
//         var firstAdult = StudentMgr.students.FirstOrDefault(s => s.Birthday <= DateTime.Now.AddYears(-18));
//         var onlyWangWu = StudentMgr.students.Single(s => s.StudentName == "王五");
//         var wangWuOrDefault = StudentMgr.students.SingleOrDefault(s => s.StudentName == "王六");
//         var lastStudent = StudentMgr.students.Last();
//         var lastAdult = StudentMgr.students.LastOrDefault(s => s.Birthday <= DateTime.Now.AddYears(-18));
//         var secondStudent = StudentMgr.students.ElementAt(1);
//         var tenthStudentOrDefault = StudentMgr.students.ElementAtOrDefault(9);
//         var nonEmptyStudents = StudentMgr.students.DefaultIfEmpty(new StudentInfo
//             { StudentID = 0, StudentName = "默认Student", Address = "默认" });
//
//         Console.WriteLine(firstStudent.StudentID);
//         Console.WriteLine("年龄大于18的人的学生ID " + firstAdult.StudentID + "生日：" + firstAdult.Birthday);
//         Console.WriteLine(onlyWangWu.StudentID);
//         Console.WriteLine(wangWuOrDefault);
//         Console.WriteLine(lastStudent.StudentID);
//         Console.WriteLine(lastAdult);
//         Console.WriteLine("Where-*------------");
//         StudentMgr.students.Where(item => item.Birthday <= DateTime.Now.AddYears(-18))
//             .ToList()
//             .ForEach(item => Console.WriteLine(item.StudentName));
//
//         var sortedByNameThenClassID = StudentMgr.students.OrderBy(s => s.Birthday).ThenBy(s => s.StudentID);
//         Console.WriteLine("根据生日、StudentID 排序");
//         foreach (var VARIABLE in sortedByNameThenClassID)
//         {
//             Console.WriteLine(VARIABLE.StudentName);
//         }
//
//         Console.WriteLine("聚合方法");
//         string concatenatedNames =
//             StudentMgr.students.Aggregate("", (acc, s) => acc == "" ? s.StudentName : acc + ", " + s.StudentName);
//         /*
//          StudentMgr.students.Aggregate(
//         "",                            // 1. 初始值 (Seed)
//         (acc, s) =>                    // 2. 累加逻辑
//             acc == ""
//             ? s.StudentName        // 3. 如果是第一个，直接放名字
//             : acc + ", " + s.StudentName // 4. 如果不是第一个，加逗号再加名字
//         );
//
//             acc 已经拼接好的字符串
//          */
//         Console.WriteLine(concatenatedNames);
//
//         string[] fruits = { "apple", "banana", "cherry" };
//         string longestFruit = fruits.Aggregate("",
//             (longest, next) => next.Length > longest.Length ? next : longest,
//             fruit => fruit.ToUpper());
//         Console.WriteLine(longestFruit); // 输出 "BANANA"

        // Console.WriteLine("集合操作方法-----------------");

        /*
         *  ● Distinct：返回集合中的唯一元素（去除重复项）。
            ● Union：返回两个集合的并集（合并后去重）。
            ● Intersect：返回两个集合的交集（共有的唯一元素）。
            ● Except：返回在第一个集合中存在但不在第二个集合中存在的元素（取集合的差集）。
            ● Concat：连接两个集合，返回一个新的序列（保留所有元素，包括重复项）。
         */
        // var uniqueClassIDs = StudentMgr.students.Select(s => s.ClassID).Distinct(); //101 102
        // var unionClassIDs = uniqueClassIDs.Union(new[] { 103, 104 }); //101 102 103 104
        // var intersectClassIDs = uniqueClassIDs.Intersect(new[] { 101, 103 }); //101
        // var exceptClassIDs = uniqueClassIDs.Except(new[] { 101 }); //120
        // var concatClassIDs = uniqueClassIDs.Concat(new[] { 103, 104, 101 });
        //
        // foreach (var VARIABLE in concatClassIDs)
        // {
        //     Console.WriteLine(VARIABLE);
        // }
        //
        // Console.WriteLine("----------分组与连接方法--------------");

        /*
         *  ● GroupBy：对集合中的元素进行分组。
            ● Join：基于匹配键对两个集合的元素进行关联。
            ● GroupJoin：基于键值等同性将两个集合的元素进行关联，并对结果进行分组。
            对于 LINQ Join，通常在内存中（如 List<T>）由于性能考虑，如果数据量极大，建议先转换成 Dictionary 再查询；
            但在 EF Core (Entity Framework) 中，LINQ Join 会被完美翻译成高效的 SQL 语句在数据库端执行，可以放心使用。
         */

        // var groupedByClassID = StudentMgr.students.GroupBy(s => s.ClassID);
        //
        // foreach (var group in groupedByClassID)
        // {
        //     Console.WriteLine($"班级ID: {group.Key}");
        //     foreach (var student in group)
        //     {
        //         Console.WriteLine($"  学生姓名: {student.StudentName}");
        //     }
        // }
        // 连接两个集合（内连接查询）
        var otherStudent = new List<StudentInfo>
        {
            new StudentInfo
            {
                StudentID = 3,
                StudentName = "摇一摇",
                Birthday = Convert.ToDateTime("1997-10-25"),
                ClassID = 101,
                Courses = new List<Course>
                {
                    new Course { CourseID = 101, CourseName = "语文" },
                    new Course { CourseID = 102, CourseName = "数学" }
                }
            },
            new StudentInfo
            {
                StudentID = 4,
                StudentName = "爻一爻",
                Birthday = Convert.ToDateTime("1997-10-25"),
                ClassID = 101,
                Courses = new List<Course>
                {
                    new Course { CourseID = 101, CourseName = "语文" },
                    new Course { CourseID = 102, CourseName = "数学" }
                }
            }
        };

        var listJoin = StudentMgr.students.Join(
            otherStudent, // 要连接的第二个集合 内表
            s1 => s1.StudentID, // 从第一个集合中提取键 外表键(StudentMgr.students)
            s2 => s2.StudentID, // 从第二个集合中提取键 内表(otherStudent)
            (s1, s2) => new // 结果选择器，指定如何从两个匹配元素创建结果
            {
                StudentID = s1.StudentID,
                StudentName = s1.StudentName,
                Birthday = s1.Birthday,
                ClassID = s1.ClassID,
                Address = s1.Address,
                Courses = s1.Courses,
                OtherStudentName = s2.StudentName
            });

        foreach (var listJoinitem in listJoin)
        {
            Console.WriteLine(
                $"StudentID:{listJoinitem.StudentID}学生ID相同的人  名字:{listJoinitem.StudentName} 名字2:{listJoinitem.OtherStudentName}");
        }
        
        //使用 GroupJoin 方法实现两个集合的左连接（Left Join）
        //目标：获取所有课程及选修学生（即使无人选修也要显示课程）
        var courseStudentGroups = StudentMgr.Courses.GroupJoin(
            StudentMgr.students.SelectMany(
                student => student.Courses,
                (student, course) => new { Student = student, Course = course }
            ),
            course => course.CourseID,
            studentCoursePairs => studentCoursePairs.Course.CourseID,
            // 结果投影：生成课程名称及对应的学生列表
            (course, matchedStudents) => new
            {
                CourseName = course.CourseName,
                jihe = matchedStudents,
                Students = matchedStudents
                    .Select(pair => pair.Student.StudentName)
                    .DefaultIfEmpty("（无学生）")
                    .ToList()
            }
        ).ToList();

        // 输出结果
        foreach (var group in courseStudentGroups)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"课程：{group.CourseName}");
            Console.WriteLine($"选修学生：{string.Join(", ", group.Students)}");

            // foreach (var VARIABLE in group.jihe)
            // {
            //     Console.WriteLine($"{VARIABLE.Student.StudentName} {VARIABLE.Course.CourseName}");
            // }
            Console.WriteLine("-------------------");
        }
    }
}