namespace UnityLearns.LINQ.Lookup.SelectManyDemo;

/**
 * SelectMany 使用案例
 */
public class SelectManyDemoMgr : Singleton<SelectManyDemoMgr>
{
    public void Run()
    {
        //selectMany 
        /*
         * 专业描述：扁平化
         * 可以理解为： 第一个参数是，传入一个IEnumerable<TSource>。把所有的元素根据形参拆散。在根据第二个形参重新组合
         * 第一个案例，根据宠物的名字重新组合结果，最后得到8条数据，一个主人的名字对应有两个宠物。
         * 后续在通过Where 筛选宠物名字以 S 开头的
         */

        /*
         * 第二个例子
         * 直接传入的是string。在 C# 中，string（字符串）本质上是一个 char（字符）的集合（它实现了 IEnumerable<char> 接口）。
         * 所以会把结果变成单个字符
         *
         */
        PetOwner[] petOwners =
        {
            new PetOwner
            {
                Name = "Higa",
                Pets = new List<string> { "Scruffy", "Sam" }
            },
            new PetOwner
            {
                Name = "Ashkenazi",
                Pets = new List<string> { "Walker", "Sugar" }
            },
            new PetOwner
            {
                Name = "Price",
                Pets = new List<string> { "Scratches", "Diesel" }
            },
            new PetOwner
            {
                Name = "Hines",
                Pets = new List<string> { "Dusty" }
            }
        };

        // Project the pet owner's name and the pet's name.
        var query =
            petOwners
                .SelectMany(petOwner => petOwner.Pets, (petOwner, petName) => new { petOwner, petName })
                .Where(ownerAndPet => ownerAndPet.petName.StartsWith("S"))
                .Select(ownerAndPet =>
                    new
                    {
                        Owner = ownerAndPet.petOwner.Name,
                        Pet = ownerAndPet.petName
                    }
                );


        // Print the results.
        foreach (var obj in query)
        {
            Console.WriteLine(obj);
        }

        /*
         * 结果
         * { Owner = Higa, Pet = Scruffy }
         * { Owner = Higa, Pet = Sam }
         * { Owner = Ashkenazi, Pet = Sugar }
         * { Owner = Price, Pet = Scratches }
         */

        Console.WriteLine("示例2");
        var query2 = petOwners.SelectMany(petOwner => petOwner.Name, (petOwner, petName) => new { petOwner, petName });
        foreach (var obj in query2)
        {
            Console.WriteLine("宠物：" + obj.petName + "主人：" + obj.petOwner.Name);
        }
    }
}

class PetOwner
{
    public string Name { get; set; }
    public List<string> Pets { get; set; }
}