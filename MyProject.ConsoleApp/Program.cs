using MyProject.Repositories;
using System;

namespace MyProject.ConsoleApp
{
    class Program    

    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Role r = new Role() { Id = 1, Name = "admin", Description = "administractor" };
            Console.WriteLine($" role: {r.Id} , {r.Name} , {r.Description}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Permission p = new Permission() { Description = "admin", Id = 2, Name = "Yosi" };
            Console.WriteLine($" Permission: {p.Id} , {p.Name} , {p.Description}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Claim c = new Claim()
            { Id = 3, PermissionId = 2, ePolicy = Repositories.EPolicys.Allow, RoleId = 1 };
            Console.WriteLine($" Claim: {c.Id} , {c.PermissionId} , {c.ePolicy} , {c.RoleId}");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
