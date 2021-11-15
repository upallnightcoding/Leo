using OpenTK.Graphics.OpenGL4;
using System.Drawing;
using System.Drawing.Imaging;
using PixelFormat = OpenTK.Graphics.OpenGL4.PixelFormat;

namespace Textures
{
    public class Texture
    {
        private int Handle;

        // Constructor(s) ...

        public Texture(string path)
        {
            LoadFromFile(path);
        }

        public Texture(Bitmap image)
        {

        }

        // Public Function(s) ...

        public void Use(TextureUnit unit)
        {
            GL.ActiveTexture(unit);
            GL.BindTexture(TextureTarget.Texture2D, Handle);
        }

        // Private Function(s) ...

        private void LoadFromFile(string path)
        {
            // Generate Texture Handle
            Handle = GL.GenTexture();

            // Bind the handle
            //GL.ActiveTexture(TextureUnit.Texture0);
            //GL.BindTexture(TextureTarget.Texture2D, Handle);

            Use(TextureUnit.Texture0);

            Bitmap image = null;

            if (path != null)
            {
                image = new Bitmap(path);
            } else           
            {
                image = new Bitmap(300, 300);
            }

            image.RotateFlip(RotateFlipType.RotateNoneFlipY);

            using (Graphics gr = Graphics.FromImage(image))
            {
                Pen pen = new Pen(Color.DarkOrange, 2);
                Rectangle rectangle = new Rectangle(20, 20, 200, 200);
                gr.DrawRectangle(pen, rectangle);
                //gr.FillRectangle(Brushes.LightGreen, new Rectangle(50, 10, 100, 100));
            }

            var data = image.LockBits(
                new Rectangle(0, 0, image.Width, image.Height),
                ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D,
                0,
                PixelInternalFormat.Rgba,
                image.Width,
                image.Height,
                0,
                PixelFormat.Bgra,
                PixelType.UnsignedByte,
                data.Scan0);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Repeat);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Repeat);

            GL.GenerateMipmap(GenerateMipmapTarget.Texture2D);
        }

       

       
    }
}
