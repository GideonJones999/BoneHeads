using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace boneHeads
{
    
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D back;
        Rectangle backRec;

        Skeleton bones;
        Zombie student;
        Demon teacher;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1300;
            graphics.PreferredBackBufferHeight = 950;

            this.IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            

            bones = new Skeleton();
            bones.Cage = 2;
            bones.setPic();

            student = new Zombie();
            student.Cage = 4;
            student.setPic("Zombie");
            student.setWalk();

            teacher = new Demon();
            teacher.Cage = 7;
            teacher.setPic("Demon");
            teacher.setWalk();
            teacher.setFly();

            base.Initialize();
        }

        
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            backRec = new Rectangle(0, 0, 1300, 950);
            back = Content.Load<Texture2D>("Back2");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Gray);

            spriteBatch.Begin();

            bones.Move();
            bones.Draw(spriteBatch);

            student.Move();
            student.Walk();
            student.Draw(spriteBatch);

            teacher.Move();
            teacher.Walk();
            teacher.Fly();
            teacher.Draw(spriteBatch);

            spriteBatch.Draw(back, backRec, Color.Orange);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
