using GameComponents.Color;

namespace GameComponents.Screens;

public static class Title {
    public static int titleAnimationCounter = 1;
    public static void ShowTitle() {
        string[] GameTitle = 
        [  
            "    ▄▄▄▄▄▄▄  ▄▄    ▄▄   ▄▄▄▄▄▄▄  ▄▄    ▄▄  ▄▄▄▄▄▄▄     ", 
            "   ██      ▀ ████   ██ ██     ██ ██  ██  █ ██     █    ",
            "   ██▄▄▄▄▄▄▄ ██ ██  ██ ██▄▄▄▄▄██ ████      ██▄▄▄▄▄▄    ",
            "          ██ ██  ██ ██ ██     ██ ██  ██    ██          ",
            "   ▀▄▄▄▄▄▄█▀ ▀█   ▀██▀ ▀█▄   ▄█▀ ██   █▄▄█ ██▄▄▄▄▄▀    ",
            "                                                       ",
            "         ▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄  ▄        ▄ ▄▄▄▄▄▄▄         ",
            "        ██     ██ ██     ██ ██▄▄  ▄▄██ ██     █        ",
            "        ██▄▄▄▄▄▄▄ ██▄▄▄▄▄██ ██ █▄▄█ ██ ██▄▄▄▄▄▄        ",
            "        ██     ██ ██     ██ ██  ▀▀  ██ ██              ",
            "        ▀█▄▄▄▄▄█▀ ▀█▄   ▄█▀ ▀█▄    ▄█▀ ██▄▄▄▄▄▀        "
        ];
        
        for (int i = 0; i < GameTitle.Length; i++) {
            Console.WriteLine(GameTitle[i]);
            Thread.Sleep((titleAnimationCounter == 1) ? 100 : 0);
        }       
    }
}