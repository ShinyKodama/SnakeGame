namespace GameComponents.Characters {
    public class Snake {
        // int snakePosX = 0;
        // int snakePosY = 0;
        
        static int snakeSize = 1;
        static bool snakeIsAlive = true;

        // static void UpdateSnake() {
                
        // }

        static void DrawSnake() {
            while (true) {
                if (snakeIsAlive) {
                    for (int i = 0; i < snakeSize; i++) {
                        Console.Write("▄");
                    }
                }        
            }
        }
    }
}