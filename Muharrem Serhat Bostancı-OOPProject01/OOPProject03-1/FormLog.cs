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
    public partial class FormLog : Form
    {
        private Dictionary<string, Ogrenci> logDictionary = new Dictionary<string, Ogrenci>();
        public FormLog(Dictionary<string,Ogrenci>LogDic)
        {
            logDictionary = LogDic;
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            dataGridViewLog.DataSource = null;

            List<Ogrenci> listValues = logDictionary.Values.ToList();
            List<string> listKeys = logDictionary.Keys.ToList();
            int listCount = listKeys.Count;
            //List<string> logList = new List<string>();

            for(int i = 0; i < listCount; i++)
            {

                //logList.Add(s);
                string sKey = listKeys[i];

                if(sKey.Contains("Change") == true|| sKey.Contains("Delete") == true)
                {
                    sKey = sKey.Substring(0, 6);
                }
                else if (sKey.Contains("Add") == true)
                {
                    sKey = sKey.Substring(0, 3);
                }
                string s = sKey + " ==> " + listValues[i].Id + " " + listValues[i].Ad + " " + listValues[i].Soyad + " " + listValues[i].DogumYeri + " " + listValues[i].DogumTarihi + " " + listValues[i].KursBitisTarihi;

                dataGridViewLog.Rows.Add(s);

                if (sKey == "Delete")
                    dataGridViewLog .Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                else if (sKey == "Change")
                    dataGridViewLog.Rows[i].DefaultCellStyle.BackColor = Color.LightSeaGreen;
                else
                    dataGridViewLog.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;

                //dataGridViewLog.Rows.Add(s);
            }
            //this.dataGridViewLog.DataSource = logList.Select(x => new { Value = x }.ToList();

        }
    }
}
