﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns
{
    public abstract class Component
    {
        public GameObject GameObject { get; set; }

        public virtual void Update(GameTime gameTime)
        {
        }

        public virtual void Awake()
        {
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}