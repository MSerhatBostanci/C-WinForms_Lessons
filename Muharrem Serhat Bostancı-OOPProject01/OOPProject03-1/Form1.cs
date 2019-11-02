using OOPProject03;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject03_1
{
    public partial class Form1 : Form
    {
        //Projemizin bu katmanına UI katmanı diyebiliriz.
        //OOPProject03'te olturuğumuz ClassLibrary bu projede
        //Yani OOPProject03-1 Projesinde kullanılacaktır.
        //OOPProject03 - ClassLibrary (Veri Üretmek için hazırladığımız bir kütüphanedir)
        //OOPProject03-1 UI (User Interface) katmanı 
        //OOPProject03-1 UI katmanının, OOPProject03 ClassLibrary'sini kullanabilmesi için
        //bu Library'nin OOPProject03-1 projesine dahil edilmesi gerekir.
        //Dahil etmek için, OOPProject03 önce referance kısmına eklenir,
        //sonra using satırı eklenir.
        //Bir class tanınmıyorsa kütüphaneye eklenmedi demektir.

        public Ogrenci seciliOgrBilgileri = new Ogrenci();
        //public List<Ogrenci> sonSilmeListesi = new List<Ogrenci>();
        public Dictionary<string, Ogrenci> sonIslemDictionary = new Dictionary<string, Ogrenci>();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnUretveDoldur_Click(object sender, EventArgs e)
        {
            List<Ogrenci> olist = new List<Ogrenci>();

            for (int i = 1; i <= 100; i++)
            {
                Ogrenci ogr = new Ogrenci(); //Sabit

                BAU sourceOfData = new BAU(); //BAU FakeData çekmek için kullandık.

                ogr.Id = i;
                ogr.Ad = sourceOfData.GetName();
                ogr.Soyad = sourceOfData.GetSurName();
                ogr.DogumYeri = sourceOfData.GetCity();
                ogr.DogumTarihi = sourceOfData.GetBackDate(30);
                ogr.KursBitisTarihi = sourceOfData.GetForwardDate(5);

                // Object Initializer yöntemi ile class'ın oluşturulması ve 
                // değerlerinin doldurulması
                //TutorialsTeacher c# objectInıtializer Sntax bak.

                //1. Gösterim
                //Ogrenci ogr = new Ogrenci() { Ad = "Gizem" ,Soyad = "Sürer" , DogumYeri = "Hatay" ,
                //                                DogumTarihi = Convert.ToDateTime("07/05/1992") ,
                //                                Id = i, KursBitisTarihi = Convert.ToDateTime("31/10/2019")}; 

                //2. Gösterim
                //Ogrenci ogr = new Ogrenci()
                //{
                //    Ad = "Gizem",
                //    Soyad = "Sürer",
                //    DogumYeri = "Hatay",
                //    DogumTarihi = Convert.ToDateTime("07/05/1992"),
                //    Id = i,
                //    KursBitisTarihi = Convert.ToDateTime("31/10/2019")
                //};

                olist.Add(ogr);
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = olist;

        }
        private void btnVeriDetay_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seçili satırın detayını görmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Cancel || dr == DialogResult.No)
            {
                return;
            }
            else
            {
                FormDetay frmDetay = new FormDetay();
                frmDetay.seciliOgrBilgileri = this.seciliOgrBilgileri;
                frmDetay.ShowDialog();
            }
        }
        private int EnBüyükIDNumarasınıVer()
        {
            int enBuyukID = 0;
            int tmpID = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                tmpID = (int)row.Cells[0].Value;

                if (tmpID > enBuyukID)
                    enBuyukID = tmpID;
            }
            int enBuyukIDLst = 0;
            List<int> idList = new List<int>();
            foreach (KeyValuePair<string,Ogrenci> item in sonIslemDictionary)
            {
                string sKey = item.Key;
                string sId = "";
                if (sKey.Contains("Add"))
                {
                    sId = sKey.Substring(3, sKey.Length - 3);
                }
                else if (item.Key.Contains("Change") || item.Key.Contains("Delete"))
                {
                    sId = sKey.Substring(6, sKey.Length - 6);
                }
                idList.Add(Convert.ToInt32(sId));

                if (Convert.ToInt32(sId) > enBuyukIDLst)
                    enBuyukIDLst = Convert.ToInt32(sId);
            }
            if (enBuyukID > enBuyukIDLst)
                return enBuyukID;
            else
                return enBuyukIDLst;
        }
        private void btnVeriEkle_Click(object sender, EventArgs e)
        {
            int n = EnBüyükIDNumarasınıVer();
            OgrenciEkleme frmYeniOgrenci = new OgrenciEkleme(n);
            frmYeniOgrenci.ShowDialog();

            //YENİ BİLGİ KONTROLÜ 
            //string str = frmYeniOgrenci.YeniOgrBilgileri.Id + "\n" +
            //    frmYeniOgrenci.YeniOgrBilgileri.Ad + "\n" +
            //    frmYeniOgrenci.YeniOgrBilgileri.Soyad + "\n" +
            //    frmYeniOgrenci.YeniOgrBilgileri.DogumYeri + "\n" +
            //    frmYeniOgrenci.YeniOgrBilgileri.DogumTarihi + "\n" +
            //    frmYeniOgrenci.YeniOgrBilgileri.KursBitisTarihi + "\n";

            //MessageBox.Show(str);

            List<Ogrenci> ogrList = new List<Ogrenci>();

            if (dataGridView1.RowCount > 0)
                ogrList = (List<Ogrenci>)dataGridView1.DataSource;

            sonIslemDictionary.Add("Add"+frmYeniOgrenci.YeniOgrBilgileri.Id, frmYeniOgrenci.YeniOgrBilgileri);

            ogrList.Add(frmYeniOgrenci.YeniOgrBilgileri);

            //ÇOK ÖNEMLİ   
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ogrList;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //seciliOgrBilgileri.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            //seciliOgrBilgileri.Ad = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
            //seciliOgrBilgileri.Soyad = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
            //seciliOgrBilgileri.DogumYeri = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);
            //seciliOgrBilgileri.DogumTarihi = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            //seciliOgrBilgileri.KursBitisTarihi = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);

            //İkinci YOL
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                seciliOgrBilgileri.Id = Convert.ToInt32(row.Cells[0].Value);
                seciliOgrBilgileri.Ad = Convert.ToString(row.Cells[1].Value);
                seciliOgrBilgileri.Soyad = Convert.ToString(row.Cells[2].Value);
                seciliOgrBilgileri.DogumYeri = Convert.ToString(row.Cells[3].Value);
                seciliOgrBilgileri.DogumTarihi = Convert.ToDateTime(row.Cells[4].Value);
                seciliOgrBilgileri.KursBitisTarihi = Convert.ToDateTime(row.Cells[5].Value);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Cancel || dr == DialogResult.No)
            {
                return;
            }
            else
            {
                List<Ogrenci> ogrList = new List<Ogrenci>();
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    ogrList = (List<Ogrenci>)dataGridView1.DataSource;

                    Ogrenci ogrTmp = ogrList[dataGridView1.CurrentRow.Index];
                    //sonSilmeListesi.Add(ogrTmp);
                    sonIslemDictionary.Add("Delete" + ogrTmp.Id, ogrTmp);

                    ogrList.RemoveAt(dataGridView1.CurrentRow.Index);
                    //ÇOK ÖNEMLİ   
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = ogrList;
                }
            }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            frmOgrenciDegistir ogrOgrenciDegistir = new frmOgrenciDegistir();
            ogrOgrenciDegistir.DegisecekOgrBilgileri = this.seciliOgrBilgileri;

            string s = "Change" + seciliOgrBilgileri.Id;

            if (sonIslemDictionary.Keys.Contains(s)==false)
                sonIslemDictionary.Add("Change" + seciliOgrBilgileri.Id, this.seciliOgrBilgileri);

            ogrOgrenciDegistir.ShowDialog();

            this.seciliOgrBilgileri = ogrOgrenciDegistir.DegisecekOgrBilgileri;
            dataGridView1.CurrentRow.Cells[0].Value = seciliOgrBilgileri.Id;
            dataGridView1.CurrentRow.Cells[1].Value = seciliOgrBilgileri.Ad;
            dataGridView1.CurrentRow.Cells[2].Value = seciliOgrBilgileri.Soyad;
            dataGridView1.CurrentRow.Cells[3].Value = seciliOgrBilgileri.DogumYeri;
            dataGridView1.CurrentRow.Cells[4].Value = seciliOgrBilgileri.DogumTarihi;
            dataGridView1.CurrentRow.Cells[5].Value = seciliOgrBilgileri.KursBitisTarihi;
        }

        private void btnCokluSil_Click(object sender, EventArgs e)
        {
            List<Ogrenci> ogrList = new List<Ogrenci>();
            ogrList = (List<Ogrenci>)dataGridView1.DataSource;

            DialogResult dr = MessageBox.Show("Seçili satırı silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Cancel || dr == DialogResult.No)
            {
                return;
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    Ogrenci ogrTmp = ogrList[row.Index];
                    sonIslemDictionary.Add("Delete"+ ogrTmp.Id, ogrTmp);
                    ogrList.RemoveAt(row.Index);
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ogrList;
                //btnGeriAl.Enabled = true;
            }
        }
        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            //if(sonSilmeListesi.Count > 0)
            if (sonIslemDictionary.Count > 0)
            {
                List<Ogrenci> ogrList = new List<Ogrenci>();
                //foreach (Ogrenci item in sonSilmeListesi)
                foreach (KeyValuePair<string, Ogrenci> item in sonIslemDictionary)
                {
                    if (dataGridView1.RowCount > 0)
                        ogrList = (List<Ogrenci>)dataGridView1.DataSource;

                    //ogrList.Add(item);
                    string sKey = item.Key;
                    if (sKey.Contains("Add"))
                    {
                        //ogrList.Remove(item.Value);
                        string sId = "";
                        sId = sKey.Substring(3, sKey.Length - 3);
                        foreach (Ogrenci item2 in ogrList)
                        {
                            if(item2.Id == Convert.ToInt32(sId))
                            {

                                int ogrIndex = ogrList.IndexOf(item2);
                                ogrList.RemoveAt(ogrIndex);
                                break;
                            }
                        }
                    }
                    else if (item.Key.Contains("Delete"))
                    {
                        ogrList.Add(item.Value);
                    }
                    else if (item.Key.Contains("Change")) 
                    {
                        string sId = "";
                        sId = sKey.Substring(6, sKey.Length - 6);
                        foreach (Ogrenci item2 in ogrList)
                        {
                            if (item2.Id == Convert.ToInt32(sId))
                            {

                                int ogrIndex = ogrList.IndexOf(item2);
                                ogrList.RemoveAt(ogrIndex);
                                break;
                            }
                        }
                        ogrList.Add(item.Value);
                    }
                }
                //ÇOK ÖNEMLİ   
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = ogrList;
                //btnGeriAl.Enabled = false;
                //sonSilmeListesi.Clear();
                sonIslemDictionary.Clear();
            }
        }
        private void btnLogListele_Click(object sender, EventArgs e)
        {
            FormLog frmLog = new FormLog(sonIslemDictionary);
            frmLog.ShowDialog();
        }
    }
}