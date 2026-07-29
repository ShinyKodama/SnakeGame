using GameComponents.Screens;

namespace GameComponents.Screens;

public static class MainMenu {
    static readonly string[] Options = [
        "Iniciar", "Configurações", "Créditos", "Sair"
    ];

    static int selectedOption = 0;

    public static int Show() {
        while (true) {
            Console.Clear();

            Title.ShowTitle();
            Console.WriteLine();

            for (int i = 0; i < Options.Length; i++) {
                Console.WriteLine((i == selectedOption)
                    ? $">> {Options[i]}"
                    : $"{Options[i]}");
            }

            if (HandleInput())
                return selectedOption;
        
            
        }
    }
    static bool HandleInput() {
        ConsoleKey key = Console.ReadKey(true).Key;

        switch (key) {
            case ConsoleKey.UpArrow:
                selectedOption--;
                Title.titleAnimationCounter--;

                if (selectedOption < 0)
                    selectedOption = Options.Length - 1;

                break;

            case ConsoleKey.DownArrow:
                selectedOption++;
                Title.titleAnimationCounter--;

                if (selectedOption >= Options.Length)
                    selectedOption = 0;

                break;

            case ConsoleKey.Enter:
                return true;
        }

        return false;
    }
}