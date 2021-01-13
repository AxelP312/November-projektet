using System;
using Raylib_cs;

namespace NovemberProjekt
{
    public class Player
    {

        public Rectangle rect = new Rectangle();
        public KeyboardKey upKey;
        public KeyboardKey downKey;
        public KeyboardKey leftKey;
        public KeyboardKey rightKey;

        public Player(float x, float y, KeyboardKey upKey, KeyboardKey downKey, KeyboardKey leftKey, KeyboardKey rightKey)
        {
            this.rect.x = x;
            this.rect.y = y;
            this.rect.height = 50;
            this.rect.width = 50;

            this.upKey = upKey;
            this.downKey = downKey;
            this.rightKey = rightKey;
            this.leftKey = leftKey;
        }

        public void Draw()
        {
            Raylib.DrawRectangleRec(this.rect, Color.BLACK);
        }

        public void Update()
        {
            if (Raylib.IsKeyPressed(upKey))
            {
                this.rect.y -= 50f;
            }
            else if (Raylib.IsKeyPressed(downKey))
            {
                this.rect.y += 50f;
            }
            else if (Raylib.IsKeyPressed(leftKey))
            {
                this.rect.x -= 50f;
            }
            else if (Raylib.IsKeyPressed(rightKey))
            {
                this.rect.x += 50f;
            }

            if (rect.y > 800 - rect.height)
            {
                this.rect.y = 800 - rect.height;
            }

            if (rect.y < 0)
            {
                this.rect.y = 0f;
            }

            if (rect.x < 0)
            {
                this.rect.x = 0f;
            }

            if (rect.x > 650 - rect.width)
            {
                this.rect.x = 650 - rect.width;
            }



        }
    }
}
