using System;
using Raylib_cs;

namespace NovemberProjekt
{
    public class Car 
    {
        public Rectangle carEntity = new Rectangle();
        public float carSpeed;

        public Car(float x, float y, float speed)
        {
            //Kordinaterna som instansen skapas på
            this.carEntity.y = y;
            this.carEntity.x = x;

            //höjd och bredd av instansen
            this.carEntity.height = 50;
            this.carEntity.width = 100;

            //"Snabbheten" av bilen
            carSpeed = speed;

        }

        public void Draw() //Ritar ut bilen
        {
            Raylib.DrawRectangleRec(this.carEntity, Color.BROWN);
        }

        public void Update() //Flyttar bilen genom att använda CarSpeed
        {
            this.carEntity.x -= carSpeed;
            RestartPosition();

        }

        //När bilen inte syns helt på skärmen flyttas bilen till höger sida
        public void RestartPosition() 
        {
            if(this.carEntity.x < -100)
            {
                this.carEntity.x = 700;
            }
        }
    }
}
