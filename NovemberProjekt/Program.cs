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

            //referens till Map.cs
            Map map = new Map();

            //referens till Player.cs
            Player player = new Player(300, 750, KeyboardKey.KEY_W, KeyboardKey.KEY_S, KeyboardKey.KEY_A, KeyboardKey.KEY_D);


            //referens till Car.cs
            // x  y  speed
            Car car = new Car(700, 450, 5);
            Car car2 = new Car(700, 550, 3);
            Car car3 = new Car(800, 650, 4);

            //variabler
            bool gameState = true;
            bool car1Overlap;
            bool car2Overlap;
            bool car3Overlap;
            int scene = 0;


            //gamestate loop
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

                        //Ritar ut kartan
                        map.Draw();

                        //spelaren blir ritad
                        player.Draw();
                        player.Update();


                        //Här ritas de olika Car.cs instanserna ut.
                        car.Draw();
                        car.Update();
                        car2.Draw();
                        car2.Update();
                        car3.Draw();
                        car3.Update();

                        
                        //Kollar om Spelaren rör bilen, tar rectangeln från Player.cs och Bilarna från Car.cs 
                        //och använder raylibs CheckCollisionRecs för att kolla om de kolliderar, gör det de blir boolen true och
                        //spelet går vidare till scen 2, vilket är gameover. 
                        //flytta till separat klass/metod --> mindre stökigt
                        car1Overlap = Raylib.CheckCollisionRecs(player.playerModel, car.carEntity);
                        car2Overlap = Raylib.CheckCollisionRecs(player.playerModel, car2.carEntity);
                        car3Overlap = Raylib.CheckCollisionRecs(player.playerModel, car3.carEntity);

                        if(car1Overlap == true || car2Overlap == true|| car3Overlap == true)
                        {
                            scene = 2;
                        }
                        Raylib.EndDrawing();

                    }

                    else if (scene == 2)
                    {
                        Raylib.BeginDrawing();
                        Raylib.ClearBackground(Color.WHITE);
                        Raylib.DrawText("Game over", 50 , 250, 80, Color.BLACK);
                        Raylib.EndDrawing();
                    }

                }
        }
    }
}