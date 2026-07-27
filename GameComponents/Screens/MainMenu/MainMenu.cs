using GameComponents.Characters;

namespace GameComponents.Screens;
public static class MainMenu {
    public static void Show() {

        while (true) {
            Console.Clear();
            Title.ShowTitle();
            // Console.WriteLine($"█{new string('▀', NexFirstText.Length + 2)}█");

            for (int i = 0; i < 5; i++) 
                Console.Write('\n');

            Nyx.Show();
            Console.ReadKey(true);
            break;
        }
    }
} // ▄ ▀ █
    
