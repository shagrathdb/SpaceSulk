using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace SpaceSulk
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class SpaceSulk : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        KeyboardState oldState;
        Color backColor = Color.CornflowerBlue;

        public SpaceSulk()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
            oldState = Keyboard.GetState();
        }

        protected override void LoadContent()
        {
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == 
                ButtonState.Pressed)
                this.Exit();

            UpdateInput();

            base.Update(gameTime);
        }

        private void UpdateInput()
        {
            KeyboardState newState = Keyboard.GetState();

            // Is the SPACE key down?
            if (newState.IsKeyDown(Keys.Space))
            {
                // If not down last update, key has just been pressed.
                if (!oldState.IsKeyDown(Keys.Space))
                {
                    backColor = 
                        new Color(backColor.R, backColor.G, (byte)~backColor.B);
                }
            }
            else if (oldState.IsKeyDown(Keys.Space))
            {
                // Key was down last update, but not down now, so
                // it has just been released.
            }

            // Update saved state.
            oldState = newState;
        }

        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(backColor);
            base.Draw(gameTime);
        }
    }
}
