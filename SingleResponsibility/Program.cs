namespace SingleResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationService appService = new ApplicationService();
            appService.Run();
        }
    }
}
