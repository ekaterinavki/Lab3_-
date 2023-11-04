using labr3;

public class Program
{
    public static void Main(string[] args)
    {
        //Controller controller = new Controller();
        //controller.Run();
        DatabaseClass database = new DatabaseClass();
        UserInteractionClass userInteraction = new UserInteractionClass();
        ThirdPartyInteractionClass thirdPartyInteraction = new ThirdPartyInteractionClass();

        Controller controller = new Controller(database, userInteraction, thirdPartyInteraction);
        bool authResult = controller.ProcessUser();

        Console.WriteLine("Authentication result: " + authResult);
    }
}
