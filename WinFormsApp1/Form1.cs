namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = double.TryParse(s1.Text, out sayi1) ? sayi1 : 0; // s1.Text'i double türüne dönüþtürmeye çalýþýr. Baþarýlý olursa sayi1'e atar, baþarýsýz olursa sayi1'e 0 atar.

            sayi2 = double.TryParse(s2.Text, out sayi2) ? sayi2 : 0; // s2.Text'i double türüne dönüþtürmeye çalýþýr. Baþarýlý olursa sayi2'ye atar, baþarýsýz olursa sayi2'ye 0 atar. 
            sonuc = sayi1 + sayi2;
            MessageBox.Show(sonuc.ToString());

        }

        private void s2_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(s2.Text, out double sayi2) ? true : false) // s2.Text'i double türüne dönüþtürmeye çalýþýr. Baþarýlý olursa sayi2'ye atar, baþarýsýz olursa sayi2'ye 0 atar. 
            {
                MessageBox.Show($"s2'ye geçerli bir sayý giriniz : {sayi2}");
                s2.Text = s2.Text.Substring(0, (s2.Text.Length - 1)); // Formun baþlýðýný, s2.Text'in son karakteri çýkarýlmýþ hali yapar. Bu, kullanýcý geçersiz bir karakter girdiðinde formun baþlýðýný günceller.
            }

        }


 



        private void cikar_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null) // listBox1'de herhangi bir öðe seçilmemiþse
            {

                if (listBox2.SelectedItem.ToString().Contains("Pizza"))
                    spt.Text = (Convert.ToInt32(spt.Text) - 100).ToString();
                else if (listBox2.SelectedItem.ToString().Contains("Hamburger"))
                    spt.Text = (Convert.ToInt32(spt.Text) - 75).ToString();
                else if (listBox2.SelectedItem.ToString().Contains("Patates Kýzartmasý"))
                    spt.Text = (Convert.ToInt32(spt.Text) - 40).ToString();
                else if (listBox2.SelectedItem.ToString().Contains("Ýçecek"))
                    spt.Text = (Convert.ToInt32(spt.Text) - 20).ToString();

                listBox2.Items.Remove(listBox2.SelectedItem); // listBox2'de seçilen öðeyi listBox2'den kaldýrýr.

            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null) // listBox1'de herhangi bir öðe seçilmemiþse
            {

                listBox2.Items.Add(listBox1.SelectedItem); // listBox1'de seçilen öðeyi listBox2'ye ekler.
                if (listBox1.SelectedItem.ToString().Contains("Pizza"))
                    spt.Text = (Convert.ToInt32(spt.Text) + 100).ToString();
                else if (listBox1.SelectedItem.ToString().Contains("Hamburger"))
                    spt.Text = (Convert.ToInt32(spt.Text) + 75).ToString();
                else if (listBox1.SelectedItem.ToString().Contains("Patates Kýzartmasý"))
                    spt.Text = (Convert.ToInt32(spt.Text) + 40).ToString();
                else if (listBox1.SelectedItem.ToString().Contains("Ýçecek"))
                    spt.Text = (Convert.ToInt32(spt.Text) + 20).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.");
            }
        }
    }
}
