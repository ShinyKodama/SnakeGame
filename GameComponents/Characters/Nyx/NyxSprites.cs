namespace GameComponents.Characters.Sprites;
static class NyxSprites {
    static string[][] sprites =
    [
        [
            "          █████████           ",
            "          █████████           ",
            "          █████████           ",
            "       ███████████████        ",
            "       ▄█▀▀▀▀▀▀▀▀▀▀▀█▄        ",
            "      ██             ██       ",
            "      ██   █     █   ██       ",
            "      ▀█             █▀       ",
            "       █▀▄  ▄   ▄  ▄▀█        ",
            "       █  ▀█▀▀▀▀▀█▀  █        ",
            "       █   ▀     ▀   █        ",
            "       █             █        ",
        ],
        
        [
            "          █████████           ",
            "          █████████           ",
            "          █████████           ",
            "       ███████████████        ",
            "       ▄█▀▀▀▀▀▀▀▀▀▀▀█▄        ",
            "      ██  ▀▄     ▄▀  ██       ",
            "      ██   █     █   ██       ",
            "      ▀█             █▀       ",
            "       █▀▄  ▄   ▄  ▄▀█        ",
            "       █  ▀█▀▀▀▀▀█▀  █        ",
            "       █   ▀     ▀   █        ",
            "       █             █        ",
        ]
    ];

    public static string[] GetSprite(int sprite)  => sprites[sprite];
    public static int GetSpriteWidth(int sprite)  => GetSprite(sprite).Max(line => line.Length);
    public static int GetSpriteHeight(int sprite) => GetSprite(sprite).Length;
}


// ▄ ▀ █