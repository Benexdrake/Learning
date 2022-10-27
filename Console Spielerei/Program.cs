namespace Console_Spielerei
{
    class Program
    {
        public static async Task Main()
        {
            BereitstellungLogic bl = new();
            await bl.Start("C:\\Users\\Benex\\Desktop\\Demo\\Neu", "C:\\Users\\Benex\\Desktop\\Demo\\vorquartal", "");

        }
    }
}