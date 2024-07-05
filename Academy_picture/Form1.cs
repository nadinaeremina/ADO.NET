using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;

namespace Academy_picture
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataSet ds = null;
        string fileName = "";
        string str = "";

        public Form1()
        {
            InitializeComponent();
            str = ConfigurationManager.ConnectionStrings["Academy_add"].ConnectionString;
            conn = new SqlConnection(str);
        }

        private void button_load_picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Графические файлы |*.bmp; *.png; *.gif; *.jpg";
            ofd.FileName = "";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                fileName = ofd.FileName;
                LoadPicture();
            }
        }

        private void LoadPicture()
        {
            try
            {
                byte[] bytes = CreateCopy();
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into dbo.Teacher_picture(Name_, Picture," +
                    " TeacherId) values (@name, @picture, @teacherId);", conn);

                if (textBox1.Text == null || textBox1.Text.Length == 0) return;

                int index = -1;
                int.TryParse(textBox1.Text, out index);

                if (index == -1) return;

                cmd.Parameters.Add("@name", SqlDbType.NVarChar, 255).Value = fileName;
                cmd.Parameters.Add("@picture", SqlDbType.Image, bytes.Length).Value = bytes;
                cmd.Parameters.Add("@teacherId", SqlDbType.Int, 255).Value = index;
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private byte[] CreateCopy()
        {
            // это часть для того, чтобы картинки меньше вечили
            Image img = Image.FromFile(fileName);
            int maxWidth = 300, maxHeight = 300;
            double rationX = (double)maxWidth / img.Width;
            double rationY = (double)maxHeight / img.Height;
            double ratio = Math.Min(rationX, rationY);
            int newWidth = (int)(img.Width * ratio);
            int newHeight = (int)(img.Height * ratio);

            // обязательная часть
            Image im = new Bitmap(newWidth, newHeight);
            Graphics g = Graphics.FromImage(im);
            g.DrawImage(img, 0, 0, newWidth, newHeight);
            MemoryStream ms = new MemoryStream();
            im.Save(ms, ImageFormat.Jpeg);
            ms.Flush();
            ms.Seek(0, SeekOrigin.Begin);
            BinaryReader br = new BinaryReader(ms);
            byte[] buf = br.ReadBytes((int)ms.Length);

            return buf;
        }

        private void button_show_one_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == null || textBox1.Text.Length == 0)
                {
                    MessageBox.Show("Укажите id преподавателя");
                    return;
                }
                int index = -1;
                int.TryParse(textBox1.Text, out index);
                if (index == -1)
                {
                    MessageBox.Show("Укажите id преподавателя  в правильном формате");
                    return;
                }
                da = new SqlDataAdapter("select Picture from dbo.Teacher_picture where TeacherId=@id", conn);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                da.SelectCommand.Parameters.Add("@id", SqlDbType.Int).Value = index;
                ds = new DataSet();
                da.Fill(ds);
                byte[] bytes = (byte[])ds.Tables[0].Rows[0]["Picture"];
                MemoryStream ms = new MemoryStream(bytes);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_show_all_Click(object sender, EventArgs e)
        {
            try
            {
                da = new SqlDataAdapter("select * from dbo.Teacher_picture;", conn);
                SqlCommandBuilder cmd = new SqlCommandBuilder(da);
                ds = new DataSet();
                da.Fill(ds, "picture");
                dataGridView1.DataSource = ds.Tables["Picture"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
