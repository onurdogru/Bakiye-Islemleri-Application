using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakiyeIslemleri
{
    public partial class Form1 : Form
    {
        //Form2 frm2 = new Form2();  //Öncelikle bir değişken tanımlıyoruz...

        //NOT: Hani form'u açmak istiyorsak, Program.cs'den o form'un adınız yazmalıyız !!!

        

        public Form1()
        {
            InitializeComponent();
        }
        //1- Uygulama açıldığında bakiye 500 TL şeklinde gösterilecek. (OK)
        //2- Kullanıcı para çek butonuna tıkladığında, belirtilen miktar kadar bakiyeden azalacak. (OK)
        //3- Kullanıcı para yatır butonuna tıkladığında, belirtilen miktar kadar bakiyeye eklenecek. (OK)
        //4- Bakiye 0 ise, para çekme işlemi gerçekleşmiyecek, kullanıcıya mesaj gönderilecek. Para çek butonu tıklanmayacak (OK)
        //5- Para yatır bölümünde en az 1 TL olması durumunda bakiyeye eklenecek. (OK)
        //6- Her işlemde bakiye değeri güncellenecek. (OK)
        //7- Yapılan her işlem listbox'a eklenecektir. (Format: Para Çekme : Miktar Güncel Bakiye) (OK)
        //8- 

        decimal Bakiye = 500m;
        decimal ekmekFiyat = 10m;

        private void Form1_Load(object sender, EventArgs e)
        {
            labelBAKIYE.Text = Bakiye.ToString() + " TL";
        }

        private void numericUpDownPARACEK_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonParaCek_Click(object sender, EventArgs e)
        {
            decimal cekilecekPara = numericUpDownPARACEK.Value;

            try
            {
                if(cekilecekPara > Bakiye)
                {
                    MessageBox.Show("Bakiye Yetersiz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Bakiye = Bakiye - cekilecekPara;
                    labelBAKIYE.Text = Bakiye.ToString() + " TL";
                    listBoxTABLO.Items.Add("Çekilecek Para :" +  cekilecekPara + "Kalan Para :" + Bakiye.ToString());
                }

                if(Bakiye == 0)
                {
                    MessageBox.Show("Bakiyeniz Bitmiştir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonParaCek.Enabled = false;
                    listBoxTABLO.Items.Add("Çekilecek Para :" + cekilecekPara + "Kalan Para :" + Bakiye.ToString());
                }
            }
            catch(Exception ex)
            {

            }
        }

        private void buttonPARAYATIR_Click(object sender, EventArgs e)
        {
            decimal yatirilacakPara = numericUpDownPARAYATIR.Value;
            
            try
            {
                if(yatirilacakPara < 1)
                {
                    MessageBox.Show("Parayı arttırınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Bakiye = Bakiye + yatirilacakPara;
                    labelBAKIYE.Text = Bakiye.ToString() + " TL";
                    listBoxTABLO.Items.Add("Yatırılacak Para :" + yatirilacakPara + "Kalan Para :" + Bakiye.ToString());
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ekmek = checkBox1.Checked;
            bool seker = checkBox2.Checked;
            bool cikolata = checkBox3.Checked;
            bool peynir = checkBox4.Checked;

            if (ekmek)
            {
                Bakiye = Bakiye - ekmekFiyat;
                listBoxTABLO.Items.Add("Ekmek" + ekmekFiyat.ToString() + "TL");
                labelBAKIYE.Text = (Bakiye - ekmekFiyat).ToString();
                
            }

        }
    }
}
