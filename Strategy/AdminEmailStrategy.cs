using System;
using System.Data;

namespace DesignPatterns.Strategy
{
    public class AdminEmailStrategy : IEmailStrategy
    {
        public void ChangeEmail(User user, string email)
        {
            if (user.Email.Contains("@admin.com"))
                Console.WriteLine("Changed email for admin");
            else
                throw new DataException();
        }
    }
}