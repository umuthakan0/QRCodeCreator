using MessagingToolkit.QRCode.Codec;
namespace QR_Code_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureBox1.Image = encoder.Encode(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string date=DateTime.Now.ToString("G");
                while (date.Contains("."))
                {
                    date = date.Replace(".", "");
                }
                while(date.Contains(" "))
                {
                    date = date.Replace(" ", "");
                }
                while (date.Contains(":"))
                {
                    date = date.Replace(":", "");
                }
                pictureBox1.Image.Save(Application.StartupPath + "\\QRCodes\\QRCode"+date+ ".png");
                MessageBox.Show("Created a new QRCode..");
                textBox1.Text = "";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
         
        }
    }
}