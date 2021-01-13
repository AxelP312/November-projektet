using System;
using Raylib_cs;

namespace NovemberProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(650, 800, "Spelrutan");
            Raylib.SetTargetFPS(60);
            Map map = new Map(); //referens till Map.cs
            Player player = new Player(250, 250, KeyboardKey.KEY_W, KeyboardKey.KEY_S, KeyboardKey.KEY_A, KeyboardKey.KEY_D);

            bool gameState = true;
            int scene = 0;

            while (gameState == true)
                {
                    if (scene == 0) //Start skärmen, klickar man enter går man vidare
                    {
                        Raylib.BeginDrawing();
                        Raylib.ClearBackground(Color.WHITE);
                        Raylib.DrawText("Press Enter", 50 , 250, 80, Color.BLACK);
                        if(Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                        {
                            scene = 1;
                        }
                        Raylib.EndDrawing();
                        
                    }
                    else if (scene == 1) //spelet
                    {
                        Raylib.BeginDrawing();
                        Raylib.ClearBackground(Color.ORANGE); // oklart vad den gör hmm
                        map.Draw(); //Ritar ut kartan
                        player.Draw();//ritar ut spelaren
                        player.Update();
                        Raylib.EndDrawing();
                    }

                }
        }
    }
}