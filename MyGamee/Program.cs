using System;

namespace MyGamee
{
    class Program
    {
        public class MyGamee
        {
            private string name;
            private float shield;
            private float health;

            public Enemy(string name)
            {
                this.name= name; 
                health= 100;
                shield= 0;
            }
        }
    }
}
