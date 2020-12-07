using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_BookStore
{
    public partial class UserSettingsForm : Form
    {
        public UserSettingsForm()
        {
            InitializeComponent();
        }
        DataTable kaynakTablo;
        private void UserSettingsForm_Activated(object sender, EventArgs e)
        {
            dataRefresh();
        }
        private void dataRefresh()
        {
            VeritabaniIslemleri dosya = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
            kaynakTablo = dosya.veriCek("*", "MusteriBilgileriTablosu");
            dgvUserInformation.DataSource = kaynakTablo;
        }
        string Id;
        private void SetAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
            database.dataUpdate("userAuthorization", "1", "MusteriBilgileriTablosu", "customerID=" + Id);
            dataRefresh();
        }
        private void DgvUserInformation_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                int satir = dgvUserInformation.HitTest(e.X, e.Y).RowIndex;
                if (satir>-1)
                {
                    dgvUserInformation.Rows[satir].Selected = true;
                    Id = dgvUserInformation.Rows[satir].Cells["customerID"].Value.ToString();
                }
            }
        }
        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
            database.dataUpdate("userAuthorization", "0", "MusteriBilgileriTablosu", "customerID=" + Id);
            dataRefresh();
        }
        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
            database.deleteData("customerID=" + Id, "MusteriBilgileriTablosu");
            dataRefresh();
        }
    }
}
