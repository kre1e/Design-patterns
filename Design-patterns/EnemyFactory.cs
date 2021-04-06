using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns
{
    internal class EnemyFactory
    {
        private static EnemyFactory instance;

        public static EnemyFactory Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EnemyFactory();
                }

                return instance;
            }
        }

        public GameObject Create(string type)
        {
            GameObject go = new GameObject();
            SpriteRenderer sr = new SpriteRenderer();

            switch (type)
            {
                case "Blue":
                    sr.SetSprite("BlueEnemy");
                    go.AddComponent(new Enemy());
                    break;

                case "Black":
                    sr.SetSprite("BlackEnemy");
                    go.AddComponent(new Enemy());
                    break;

                default:
                    sr.SetSprite("Mr.Unknown");
                    go.AddComponent(new Enemy());
                    break;
            }

            return go;
        }
    }
}