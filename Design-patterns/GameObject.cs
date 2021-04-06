using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace Design_patterns
{
    internal class GameObject
    {
        private List<string> Enemyes = new List<string>();
        public static Vector2 Position { get; set; }
        public Texture2D Sprite { get; set; }
        public Vector2 Origin { get; set; }

        public void AddComponent(GameObject gameObject)
        {
            Enemyes.Add(gameObject.ToString());
        }

        public virtual void Update(GameTime gameTime)
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}