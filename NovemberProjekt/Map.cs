using System;
using Raylib_cs;

namespace NovemberProjekt
{
    public class Map
    {
        public void Draw()
        {
            //-----> Kartan
            //vatten
            Raylib.DrawRectangle(0, 0,  650, 400, Color.BLUE);
            //gräs
            Raylib.DrawRectangle(0, 0,  650, 50, Color.GREEN);  
            Raylib.DrawRectangle(50, 50,  100, 50, Color.GREEN);
            Raylib.DrawRectangle(200, 50,  100, 50, Color.GREEN);
            Raylib.DrawRectangle(350, 50,  100, 50, Color.GREEN);
            Raylib.DrawRectangle(500, 50,  100, 50, Color.GREEN);
            
            Raylib.DrawRectangle(0, 750,  650, 50, Color.GREEN);

            //vägen
            Raylib.DrawRectangle(0, 450,  650, 250, Color.GRAY);
            Raylib.DrawRectangle(0, 400,  650, 50, Color.PURPLE);
            Raylib.DrawRectangle(0, 700,  650, 50, Color.PURPLE);
            //-----> Kartan
        }
    }
}
