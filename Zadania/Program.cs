namespace Zadanie
{
    // polimorfizm, interfejsy, klasy abstrakcyjne
    abstract class AbstractMessege
    {
        public string Content { get; init; }
        public abstract bool Send();
    }
    public interface IFly
    {
        void Fly();
    }
    public interface ISwim
    {
        void Swim();
    }
    public class Duck : IFly, ISwim
    {

    }

    class EmailMessage : AbstractMessege
    {
        public string To { get; init; }
        public string From { get; init; }
        public string Subject { get; init; }
        public override bool Send()
        {
            Console.WriteLine($"Sending email from {From} to {To} with content {Content}");
            return true;
        }
    }
    class MessengerMessege : AbstractMessege
    {
        public string To { get; init; }
        public string From { get; init; }
        public string Subject { get; init; }
        public override bool Send()
        {
            Console.WriteLine($"Sending messenger messege with content {Content}");
            return true;
        }
    }
    class SmsMessege : AbstractMessege
    {
        public string ToPhone { get; init; }
        public string FromPhone { get; init; }
    }
    class User
    {
        public string Name { get; init; }
        public AbstractMessege LastMessege { get; init; }
    }
    public void Main(string[] args)
    {
        int EmailCounter = 0;
        foreach (var user in users)
        {
            user.LastMessege.Send();
            if( user.LastMessege is EmailMessage)
            {
                EmailCounter++;
            }
            if (user.LastMessege is SmsMessege)
            {

            }
        }
    }
}

