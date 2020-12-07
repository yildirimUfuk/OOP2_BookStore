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
    public partial class AdminForm : Form
    {
        DataTable kaynakTablo;
        public AdminForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// datagridvire üzerine geldiğinde ilgili satırın resmini gösteren metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUrunler_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            Point position = MousePosition;
            position.X -= this.Location.X;
            position.Y -= this.Location.Y;
            if (e.RowIndex >= 0 && e.RowIndex < dgvUrunler.Rows.Count - 1)
            {
                pbUrunResmi.ImageLocation = dgvUrunler.Rows[e.RowIndex].Cells["productImage"].Value.ToString();
                pbUrunResmi.Location = position;
                pbUrunResmi.Visible = true;
            }
        }

        private void LblBook_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Bold);
            ((Label)sender).ForeColor = Color.Maroon;
            Cursor.Current = Cursors.Hand;
        }

        private void LblBook_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
            ((Label)sender).ForeColor = Color.Black;
        }

        private void DgvUrunler_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            pbUrunResmi.Visible = false;
        }
        /// <summary>
        /// butonun üzerine geldiğinde ekleme menusunu açan metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_MouseEnter(object sender, EventArgs e)
        {
            Point position = new Point();
            position = MousePosition;
            position.X -= this.Location.X;
            position.Y -= this.Location.Y+20;
            gbUrun.Location = position;
            gbUrun.Visible = true;

        }

        private void LblBook_Click(object sender, EventArgs e)
        {
            gbUrun.Visible = false;
            BookAddForm frmAddBook = new BookAddForm();
            frmAddBook.ShowDialog();
        }

        private void AdminForm_Activated(object sender, EventArgs e)
        {
            VeritabaniIslemleri dosya = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
            kaynakTablo = dosya.veriCek("*", "UrunlerTablosu");
            dgvUrunler.DataSource = kaynakTablo;
        }

        private void LblCD_Click(object sender, EventArgs e)
        {
            gbUrun.Visible = false;
            CdAddForm frmCdAdd = new CdAddForm();
            frmCdAdd.ShowDialog();
        }

        private void LblMagazine_Click(object sender, EventArgs e)
        {
            gbUrun.Visible = false;
            MagazineAddForm frmMagazineAdd = new MagazineAddForm();
            frmMagazineAdd.ShowDialog();
        }
        /// <summary>
        /// çift tıklama ile veri güncelleme ekranını açan metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUrunler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUrunler.Rows[e.RowIndex].Cells["productType"].Value.ToString() == "1")
            {
                BookUpdateForm frmBookUpdate = new BookUpdateForm(dgvUrunler.Rows[e.RowIndex].Cells["productId"].Value.ToString());
                frmBookUpdate.ShowDialog();
            }
            else if (dgvUrunler.Rows[e.RowIndex].Cells["productType"].Value.ToString()=="3")
            {
                MagazineUpdateForm frmMagazineUpdate = new MagazineUpdateForm(dgvUrunler.Rows[e.RowIndex].Cells["productId"].Value.ToString());
                frmMagazineUpdate.ShowDialog();
            }
            else if (dgvUrunler.Rows[e.RowIndex].Cells["productType"].Value.ToString()=="2")
            {
                CdUpdateForm frmCdUpdate = new CdUpdateForm(dgvUrunler.Rows[e.RowIndex].Cells["productId"].Value.ToString());
                frmCdUpdate.ShowDialog();
            }
            else
            {
                MessageBox.Show("invalid product type");
            }
        }

        private void BtnUserSettings_Click(object sender, EventArgs e)
        {
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			UserSettingsForm frmUserSettings = new UserSettingsForm();
            frmUserSettings.ShowDialog();
        }

        string productId;
        string productType;
        /// <summary>
        /// sag tuş ile işlem yapmak için menustrip menusunu açan metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DgvUrunler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Right)
            {
                int satir = dgvUrunler.HitTest(e.X, e.Y).RowIndex;
                if (satir>-1)
                {
                    dgvUrunler.Rows[satir].Selected = true;
                    if (dgvUrunler.Rows[satir].Cells["productId"].Value!=null)
                    {
                        productId = dgvUrunler.Rows[satir].Cells["productId"].Value.ToString();
                        productType = dgvUrunler.Rows[satir].Cells["productType"].Value.ToString();
                    }
                }
            }
        }

        private void BookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookAddForm frmAddBook = new BookAddForm();
            frmAddBook.ShowDialog();
        }

        private void MusicCdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CdAddForm frmCdAdd = new CdAddForm();
            frmCdAdd.ShowDialog();
        }

        private void MagazineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MagazineAddForm frmMagazineAdd = new MagazineAddForm();
            frmMagazineAdd.ShowDialog();
        }

        /// <summary>
        /// veri silen metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = Admin.createAdmin();
            dgvUrunler.DataSource = admin.deleteData(productType, productId);
        }

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
		}
        /// <summary>
        /// sag tuş ile güncelleme ekranini açan metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productType == "1")
            {
                BookUpdateForm frmUpdateBook = new BookUpdateForm(productId);
                frmUpdateBook.ShowDialog();
            }
            else if (productType == "3")
            {
                MagazineUpdateForm frmMagazineUpdate = new MagazineUpdateForm(productId);
                frmMagazineUpdate.ShowDialog();
            }
            else if (productType == "2")
            {
                CdUpdateForm frmCdUpdate = new CdUpdateForm(productId);
                frmCdUpdate.ShowDialog();
            }
        }

		private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Program.mainform.mainFormPanelWithPicture.upload();
		}
	}
}
