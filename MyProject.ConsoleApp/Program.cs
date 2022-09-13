using MyProject.Mock;
using MyProject.Repositories;
using MyProject.Repositories.Repositories;
using System;

namespace MyProject.ConsoleApp
{
    class Program    

    {
        static void Main(string[] args)
        {
            var mockContext = new MockContext();
            var roleRepository = new RoleRepository(mockContext);

            //Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Role r = new Role() { Id = 1, Name = "admin", Description = "administractor" };
            //Console.WriteLine($" role: {r.Id} , {r.Name} , {r.Description}");
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Permission p = new Permission() { Description = "admin", Id = 2, Name = "Yosi" };
            //Console.WriteLine($" Permission: {p.Id} , {p.Name} , {p.Description}");
            //Console.ForegroundColor = ConsoleColor.DarkYellow;
            //Claim c = new Claim()
            //{ Id = 3, PermissionId = 2, ePolicy = Repositories.EPolicys.Allow, RoleId = 1 };
            //Console.WriteLine($" Claim: {c.Id} , {c.PermissionId} , {c.ePolicy} , {c.RoleId}");
            //Console.ForegroundColor = ConsoleColor.Black;
            string choose;
            string obj;
            do
            {
                 obj = Console.ReadLine();
                switch(obj)
                {
                    case "r":
                        Console.WriteLine("");
                        choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "add":
                                roleRepository.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                                   break;
                            case "update":
                                Role r = roleRepository.GetById(int.Parse(Console.ReadLine()));
                               // r.Name =;

                                roleRepository.Update(r);
                                break;
                            case "delete":
                                Console.WriteLine("press id for delete");
                                roleRepository.Delete(int.Parse(Console.ReadLine()));
                                break;
                            case "GetAll":
                                roleRepository.GetAll();
                                    break;
                            case "GetById":
                                Console.WriteLine("press id for get the project");
                                roleRepository.GetById(int.Parse(Console.ReadLine()));
                                break;

                        }
                        break;

                }
            }
            while (obj!="exit");
        }
    }
}
