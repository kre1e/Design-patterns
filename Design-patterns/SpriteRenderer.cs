﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_patterns
{
    internal class SpriteRenderer : Component
    {
        public Texture2D Sprite { get; set; }

        public Vector2 Origin { get; set; }

        public SpriteRenderer()
        {
        }

        public SpriteRenderer(string spriteName)
        {
            SetSprite(spriteName);
        }

        public void SetSprite(string spriteName)
        {
            Sprite = GameWorld.Instance.Content.Load<Texture2D>(spriteName);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, GameObject.Position, null, Color.White, 0, Origin, 1, SpriteEffects.None, 0);
        }

        public override string ToString()
        {
            return "SpriteRenderer";
        }

        public SpriteRenderer Clone()
        {
            return (SpriteRenderer)this.MemberwiseClone();
        }
    }
}