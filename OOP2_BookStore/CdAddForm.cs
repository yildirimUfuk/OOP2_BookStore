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
    public partial class CdAddForm : Form
    {
        string filePath;
        public CdAddForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// resmin fontunu ve mouse imlecini değiştiren metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblSelectImage_MouseMove(object sender, MouseEventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Bold);
            ((Label)sender).ForeColor = Color.Maroon;
            Cursor.Current = Cursors.Hand;
        }
        /// <summary>
        /// yazının rengini ve fontunu eski haline getiren metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblSelectImage_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
            ((Label)sender).ForeColor = Color.Black;
        }
        /// <summary>
        /// cd için resim seçen metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "resim dosyası | *.png|resim dosyası | *.jpeg";
            file.FilterIndex = 1;
            //file.Multiselect = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                Bitmap bitmap = new Bitmap(filePath);
                SaveFileDialog saveFile = new SaveFileDialog();
                VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
                string maxId = null;
                try
                {
                    DataTable maxIdtTable = database.veriCek("SELECT Max(productId) FROM UrunlerTablosu");
                    maxId = (Convert.ToInt32(maxIdtTable.Rows[0][0]) + 1).ToString();
                }
                catch (Exception)
                {
                    if (maxId == null)
                        maxId = 1.ToString();
                }
                saveFile.FileName = @"ProductPhotos\CD_" + maxId + ".png";
                bitmap.Save(saveFile.FileName);
                pbProductImage.ImageLocation = saveFile.FileName;
                pbProductImage.Visible = true;
                filePath = saveFile.FileName;
            }
        }
        /// <summary>
        /// admin sinifini kullanarak cd ekleyen metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
            MusicCD cd = new MusicCD();
            cd.Name = tbName.Text;
            cd.Price = Convert.ToDouble(tbPrice.Text);
            cd.Photo1 = pbProductImage.Image;
            cd.Description = tbDescription.Text;
            cd.Sale = Convert.ToInt32(tbSale.Text);
            cd.Singer = tbSinger.Text;
            cd.Mcdtype = (MusicCD.MusicCDType)cmbCdType.SelectedIndex;
            Admin admin = Admin.createAdmin();
            admin.addNewItem(cd,filePath);
            this.Close();
        }

		private void Decimal_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (((TextBox)sender) == tbPrice)
			{
				int comma = ((TextBox)sender).Text.Count(k => k == ',');
				if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || (e.KeyChar == ',' && comma == 0)))
				{
					e.Handled = true;
				}
			}
			else if (((TextBox)sender) == tbSale)
			{
				if (!((Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))))
				{

					e.Handled = true;

				}
				else
				{
					try
					{
						int comma = Convert.ToInt32(((TextBox)sender).Text + e.KeyChar);
						if (!(comma <= 100 || Char.IsControl(e.KeyChar)))
						{
							e.Handled = true;
						}
					}
					catch
					{

					}
				}
			}
			else
			{
				if (!(Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar)))
				{
					e.Handled = true;
				}
			}
		}
	}
}
