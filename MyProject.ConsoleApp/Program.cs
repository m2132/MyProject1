using MyProject.Mock;
using MyProject.Repositories;
using MyProject.Repositories.Interfaces;
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
            var permissionRepository = new PermissionRepository(mockContext);
            var claimRepository = new ClaimRepository(mockContext);
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
                Console.WriteLine("enter object permission  || role  ||  claim for exit press 'exit'  ");
                obj = Console.ReadLine();
                switch (obj)
                {
                    case "role":
                        Console.WriteLine("enter to choose || update || add || delete ||getAll ||getById ");
                        choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "add":
                                Console.WriteLine("You have to enter id,name and description");
                                roleRepository.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                                break;
                            case "update":
                                Console.WriteLine("You have to enter id");

                                Role r = roleRepository.GetById(int.Parse(Console.ReadLine()));
                                // r.Name =;

                                roleRepository.Update(r);
                                break;
                            case "delete":
                                Console.WriteLine("press id for delete");
                                roleRepository.Delete(int.Parse(Console.ReadLine()));
                                break;
                            case "getAll":
                                roleRepository.GetAll();
                                break;
                            case "getById":
                                Console.WriteLine("press id for get the project");
                                roleRepository.GetById(int.Parse(Console.ReadLine()));
                                break;


                        }
                        break;
                    case "permission":
                        Console.WriteLine("enter to choose || update || add || delete ||getAll ||getById ");
                        choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "add":
                                Console.WriteLine("You have to enter id,name and description");

                                permissionRepository.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());
                                break;
                            case "update":
                                Console.WriteLine("You have to enter id");

                                Permission permission = permissionRepository.GetById(int.Parse(Console.ReadLine()));


                                permissionRepository.Update(permission);
                                break;
                            case "delete":
                                Console.WriteLine("press id for delete");
                                permissionRepository.Delete(int.Parse(Console.ReadLine()));
                                break;
                            case "getAll":
                                permissionRepository.GetAll();
                                break;
                            case "getById":
                                Console.WriteLine("press id for get the project");
                                permissionRepository.GetById(int.Parse(Console.ReadLine()));
                                break;


                        }
                        break;
                    case "claim":
                        Console.WriteLine("enter to choose || update || add || delete ||getAll ||getById ");
                        choose = Console.ReadLine();
                        switch (choose)
                        {
                            case "add":
                                Console.WriteLine("You have to enter id,name and description");

                                claimRepository.Add(int.Parse(Console.ReadLine()), Console.ReadLine(), Console.ReadLine());//I need put year Epolicy and I dont know how
                                break;
                            case "update":
                                Console.WriteLine("You have to enter id");

                                Claim claim = claimRepository.GetById(int.Parse(Console.ReadLine()));


                                claimRepository.Update(claim);
                                break;
                            case "delete":
                                Console.WriteLine("press id for delete");
                                claimRepository.Delete(int.Parse(Console.ReadLine()));
                                break;
                            case "getAll":
                                claimRepository.GetAll();
                                break;
                            case "getById":
                                Console.WriteLine("press id for get the project");
                                claimRepository.GetById(int.Parse(Console.ReadLine()));
                                break;


                        }
                        break;

                }
            }
            while (obj != "exit");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
