using GameComponents.Characters.Sprites;

namespace GameComponents.Characters;

public static class Nyx {
    public static void Show() {
        string[] NyxStandartSprite = NyxSprites.GetSprite(0);
        for (int i = 0; i < NyxStandartSprite.Length; i++) {
            Console.WriteLine(NyxStandartSprite[i]);
        }

        Talk();
    }   
    static void Talk() {
        string[] NyxFirstText = [
            "Olá! Meu Nome é Nyx!",
            "Qual o seu? "    
        ];

        for (int i = 0; i < NyxFirstText.Length; i++) {
            Console.SetCursorPosition(
                NyxSprites.GetSpriteWidth(0), NyxSprites.GetSpriteHeight(0) + i + 5
            );

            for (int j = 0; j < NyxFirstText[i].Length; j++) {
                Console.Write(NyxFirstText[i][j]);
                Thread.Sleep(TimeSpan.FromMilliseconds(50));
            }
            Console.WriteLine();
        }
    }

}