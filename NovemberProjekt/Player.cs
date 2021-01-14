using System;
using Raylib_cs;

namespace NovemberProjekt
{
    public class Player 
    {
        //skapar en rektangel
        public Rectangle playerModel = new Rectangle();
        
        //tangentbordskontroller 
        public KeyboardKey upKey;
        public KeyboardKey downKey;
        public KeyboardKey leftKey;
        public KeyboardKey rightKey;

        //Skapar rektangeln med plats och kontroller
        public Player(float x, float y, KeyboardKey upKey, KeyboardKey downKey, KeyboardKey leftKey, KeyboardKey rightKey)
        {
            //Kordinaterna som instansen skapas på
            this.playerModel.x = x;
            this.playerModel.y = y;

            //höjd och bredd av instansen
            this.playerModel.height = 50;
            this.playerModel.width = 50;

            //väljer tangenter som styr
            this.upKey = upKey;
            this.downKey = downKey;
            this.rightKey = rightKey;
            this.leftKey = leftKey;
        }

        //ritar ut spelaren
        public void Draw()
        {
            Raylib.DrawRectangleRec(this.playerModel, Color.BLACK);
        }

        //GÖR EN METOD FÖR DE TVÅ
        public void Update()
        {
            //De 4 if-satserna kollar om man klickar på en tangent
            //och beroende på vilken "hoppar" spelaren, spelaren rör på sig
            if (Raylib.IsKeyPressed(upKey))
            {
                this.playerModel.y -= 50f;
            }
            else if (Raylib.IsKeyPressed(downKey))
            {
                this.playerModel.y += 50f;
            }
            else if (Raylib.IsKeyPressed(leftKey))
            {
                this.playerModel.x -= 50f;
            }
            else if (Raylib.IsKeyPressed(rightKey))
            {
                this.playerModel.x += 50f;
            }

            //Kollar att spelaen inte går utanför banan
            //Om spelaren gör det teleporteras den in i banan igen
            if (playerModel.y > 800 - playerModel.height)
            {
                this.playerModel.y = 800 - playerModel.height;
            }

            if (playerModel.y < 0)
            {
                this.playerModel.y = 0f;
            }

            if (playerModel.x < 0)
            {
                this.playerModel.x = 0f;
            }

            if (playerModel.x > 650 - playerModel.width)
            {
                this.playerModel.x = 650 - playerModel.width;
            }
        }
    }
}
