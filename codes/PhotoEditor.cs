using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DesktopEntertainmentApp
{
    public partial class PhotoEditor : Form
    {
        public PhotoEditor()
        {
            InitializeComponent();
        }

        void filter1()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
            new float[]{.769f, .686f+0.5f, .534f, 0, 0},
            new float[]{.189f+2.3f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;

            }
        }

        void filter2()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
                    new float[]{.769f+0.3f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;

            }
        }

        void filter3()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f+0.3f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f+0.2f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.9f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;

            }
        }

        void hue()
        {
            float changered = redbar.Value * 0.1f;
            float changegreen = greenbar.Value * 0.1f;
            float changeblue = bluebar.Value * 0.1f;

            // redvalue.Text = changered.ToString();
            // greenvalue.Text = changeblue.ToString();
            // bluevalue.Text = changegreen.ToString();

            reload();
            if (!opened)
            {
            }
            else
            {



                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1+changered, 0, 0, 0, 0},
                    new float[]{0, 1+changegreen, 0, 0, 0},
                    new float[]{0, 0, 1+changeblue, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;


            }
        }

        void Winter()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;

            }
        }

        void redscale()
        {
            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {

                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;

            }
        }


        void Frozen()
        {

            if (!opened)
            {
                MessageBox.Show("Open an Image then apply changes");
            }
            else
            {


                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
            new float[]{0, 1+0f, 0, 0, 0},
            new float[]{0, 0, 1+5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;

            }

        }


        //it simply reload the image so all previous effects removed..





        void saveImage()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images (*.JPG; *.PNG; *.GIF)| *.png; *.jpg; *.gif";
            ImageFormat format = ImageFormat.Png;

            if(sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = Path.GetExtension(sfd.FileName);

                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        format = ImageFormat.Png;
                        break;
                    case ".gif":
                        format = ImageFormat.Gif;
                        break;
                }
                pictureBox1.Image.Save(sfd.FileName, format);
            }
        }

        void reload()
        {
            if (!opened)
            {
                // MessageBox.Show("Open an Image then apply changes");
            }
            else
            {
                if (opened)
                {
                    // file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    opened = true;
                }
            }
        }

        Image file;
        Boolean opened = false;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image (*.JPG; *.PNG; *.GIF) | *.gif; *.png; *.jpg";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                file = Image.FromFile(opf.FileName);
                opened = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            reload();
            filter2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            greenbar.Value = 0;
            redbar.Value = 0;
            bluebar.Value = 0;
            // greenvalue.Text = "0";
            reload();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            reload();
            filter1();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            reload();
            filter3();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void greenbar_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void bluebar_ValueChanged(object sender, EventArgs e)
        {
            hue();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            reload();
            Frozen();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            reload();
            Winter();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            reload();
            redscale();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            mf.Show();
            this.Hide();
        }
    }
}
