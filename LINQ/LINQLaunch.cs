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
        Console.WriteLine("学习链接：https://www.yuque.com/ysgstudyhard/lg56l0/ggt1v0z1g37wsv02#3cec23eb");
    }

    public void Run()
    {
        var femaleStudents = StudentMgr.students.Where(s => s.StudentName == "时光者");
        var studentNames = StudentMgr.students.Select(s => s.StudentName);

        // 使用SelectMany展平所有学生的课程列表
        var allCourses = StudentMgr.students.SelectMany(student => student.Courses).ToList();

        // 输出所有课程的名称
        foreach (var course in allCourses)
        {
            Console.WriteLine(course.CourseName);
        }

        var studentList = StudentMgr.students.ToList();
        var studentArray = StudentMgr.students.ToArray();
        var studentDictionary = StudentMgr.students.ToDictionary(s => s.StudentID, s => s.StudentName);

        //用例：1.背包系统中的数据分页查询功能中。2.任务日志（按状态分类任务）3.商城（按类别分类商品）4.成就系统
        //背包系统用例：  https://gemini.google.com/share/dfae737415bc
        Console.WriteLine("Lookup数据类型");
        var studentLookup = StudentMgr.students.ToLookup(s => s.ClassID);

        foreach (var studentInfo in studentLookup[101])
        {
            Console.WriteLine(studentInfo.StudentName);
        }

        Console.WriteLine("---------------------------------");
        // SelectManyDemoMgr.Instance.Run();

        var firstStudent = StudentMgr.students.First();
        var firstAdult = StudentMgr.students.FirstOrDefault(s => s.Birthday <= DateTime.Now.AddYears(-18));
        var onlyWangWu = StudentMgr.students.Single(s => s.StudentName == "王五");
        var wangWuOrDefault = StudentMgr.students.SingleOrDefault(s => s.StudentName == "王六");
        var lastStudent = StudentMgr.students.Last();
        var lastAdult = StudentMgr.students.LastOrDefault(s => s.Birthday <= DateTime.Now.AddYears(-18));
        var secondStudent = StudentMgr.students.ElementAt(1);
        var tenthStudentOrDefault = StudentMgr.students.ElementAtOrDefault(9);
        var nonEmptyStudents = StudentMgr.students.DefaultIfEmpty(new StudentInfo
            { StudentID = 0, StudentName = "默认Student", Address = "默认" });

        Console.WriteLine(firstStudent.StudentID);
        Console.WriteLine("年龄大于18的人的学生ID " + firstAdult.StudentID + "生日：" + firstAdult.Birthday);
        Console.WriteLine(onlyWangWu.StudentID);
        Console.WriteLine(wangWuOrDefault);
        Console.WriteLine(lastStudent.StudentID);
        Console.WriteLine(lastAdult);
        Console.WriteLine("Where-*------------");
        StudentMgr.students.Where(item => item.Birthday <= DateTime.Now.AddYears(-18)).ToList()
            .ForEach(item => Console.WriteLine(item.StudentName));

        var sortedByNameThenClassID = StudentMgr.students.OrderBy(s => s.Birthday).ThenBy(s => s.StudentID);
        Console.WriteLine("根据生日、StudentID 排序");
        foreach (var VARIABLE in sortedByNameThenClassID)
        {
            Console.WriteLine(VARIABLE.StudentName);
        }

        Console.WriteLine("聚合方法");
        string concatenatedNames =
            StudentMgr.students.Aggregate("", (acc, s) => acc == "" ? s.StudentName : acc + ", " + s.StudentName);
        /*
         StudentMgr.students.Aggregate(
    "",                            // 1. 初始值 (Seed)
    (acc, s) =>                    // 2. 累加逻辑
        acc == ""
            ? s.StudentName        // 3. 如果是第一个，直接放名字
            : acc + ", " + s.StudentName // 4. 如果不是第一个，加逗号再加名字
);

acc 已经拼接好的字符串
         */
        Console.WriteLine(concatenatedNames);

        string[] fruits = { "apple", "banana", "cherry" };
        string longestFruit = fruits.Aggregate("",
            (longest, next) => next.Length > longest.Length ? next : longest,
            fruit => fruit.ToUpper());
        Console.WriteLine(longestFruit); // 输出 "BANANA"
    }
}