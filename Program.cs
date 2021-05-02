using System;
using System.Runtime.InteropServices.ComTypes;
using Strategy.Strategy;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Strategy!");
            
            var user = new User()
            {
                Name = "guy",
                Surname = "martin",
                Role = UserRole.Student,
                Email = "guy.martin@oldemail.com"
            };

            switch (user.Role)
            {
                case UserRole.Admin: 
                    user.EmailStrategy = new AdminEmailStrategy();
                    break;
                case UserRole.Student: 
                    user.EmailStrategy = new StudentEmailStrategy();
                    break;
                case UserRole.Teacher: 
                    user.EmailStrategy = new TeacherEmailStrategy();
                    break;
                
                default: 
                    throw new InvalidOperationException();
            }       
            
            user.ChangeEmail("guy.martin@email.com");
        }
    }
}