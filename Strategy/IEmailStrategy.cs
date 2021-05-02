namespace Strategy.Strategy
{
    public interface IEmailStrategy
    {
        void ChangeEmail(User user, string email);
    }
}