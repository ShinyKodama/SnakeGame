namespace GameComponents.Characters;
public static class User {
    public static string GetUserName() {
            Console.WriteLine("Digite seu nome");   
            Console.WriteLine();

            int x = 6;
            int y = Console.CursorTop;

            Console.SetCursorPosition(x, y);

            string? nomeUsuario = Console.ReadLine();
            
            return (!string.IsNullOrWhiteSpace(nomeUsuario)) 
                ? nomeUsuario 
                : "Snake";

            
    }
}