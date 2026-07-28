using GameComponents.Color;

namespace GameComponents.Screens;

public static class Title {
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
            Thread.Sleep(100);
        }       
    }
}