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
    public partial class BookUpdateForm : Form
    {
        string filePath;
        string productId;
        public BookUpdateForm()
        {
            InitializeComponent();
        }
        public BookUpdateForm(string productId)
        {
            InitializeComponent();
            this.productId = productId;
        }
        /// <summary>
        /// ürün için resim seçen metot
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
                string uniq = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() +DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                saveFile.FileName = @"ProductPhotos\book_" + uniq+ ".png";
                bitmap.Save(saveFile.FileName);
                pbProductImage.ImageLocation = saveFile.FileName;
                pbProductImage.Visible = true;
                filePath = saveFile.FileName;
            }
        }
        /// <summary>
        /// yazının üzerine gelince yazı rengi stili ve mouse seklini değiştiren metot
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
        /// yazı üzerinden gidince yazıyı eski haline döndüren metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblSelectImage_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
            ((Label)sender).ForeColor = Color.Black;
        }
        /// <summary>
        /// kitap güncellemeyi admin sınıfı üzerinden kaydeden metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Id = Convert.ToInt32(tbId.Text);
            book.Name = tbName.Text;
            book.Price = Convert.ToDouble(tbPrice.Text);
            book.Photo1 = pbProductImage.Image;
            book.Description = tbDescription.Text;
            book.Sale = Convert.ToInt32(tbSale.Text);
            book.Author = tbAuthor.Text;
            book.Isbn = Convert.ToInt64(tbIsbn.Text);
            book.Publisher = tbPublisher.Text;
            book.Page = Convert.ToInt32(tbPage.Text);
            book.size = tbSize.Text;
            book.type = ((Book.BookType)cmbBookType.SelectedIndex);
            book.l_anguage = ((Book.Language)cmbBoxLanguage.SelectedIndex);
            Admin admin = Admin.createAdmin();
            admin.updateItem(book, pbProductImage.ImageLocation);
            this.Close();
        }

        /// <summary>
        /// kitap güncelleme ekranını açan ve açarken de ilgili ürünün bilgilerini yazan metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BookUpdateForm_Load(object sender, EventArgs e)
        {
           
            VeritabaniIslemleri database = VeritabaniIslemleri.bagOlustur("SatisVeritabani");
            dgvBookUpdate.DataSource = database.veriCek("SELECT * FROM UrunlerTablosu WHERE productId=" + productId);
            tbId.Text = dgvBookUpdate.Rows[0].Cells["productId"].Value.ToString();
            tbName.Text = dgvBookUpdate.Rows[0].Cells["productName"].Value.ToString();
            tbPrice.Text = dgvBookUpdate.Rows[0].Cells["productPrice"].Value.ToString();
            tbDescription.Text = dgvBookUpdate.Rows[0].Cells["productDescription"].Value.ToString();
            tbSale.Text = dgvBookUpdate.Rows[0].Cells["productSale"].Value.ToString();
            pbProductImage.ImageLocation= dgvBookUpdate.Rows[0].Cells["productImage"].Value.ToString();
            filePath = dgvBookUpdate.Rows[0].Cells["productImage"].Value.ToString();
            pbProductImage.Visible = true;
            dgvBookUpdate.DataSource = database.veriCek("SELECT * FROM KitapBilgileriTablosu WHERE productId=" + productId);
            tbAuthor.Text = dgvBookUpdate.Rows[0].Cells["productAuthor"].Value.ToString();
            tbIsbn.Text = dgvBookUpdate.Rows[0].Cells["isbn"].Value.ToString();
            tbPublisher.Text = dgvBookUpdate.Rows[0].Cells["publisher"].Value.ToString();
            tbPage.Text = dgvBookUpdate.Rows[0].Cells["page"].Value.ToString();
            tbSize.Text = dgvBookUpdate.Rows[0].Cells["size"].Value.ToString();
            cmbBookType.SelectedIndex = Convert.ToInt32(dgvBookUpdate.Rows[0].Cells["type"].Value);
            cmbBoxLanguage.SelectedIndex = Convert.ToInt32(dgvBookUpdate.Rows[0].Cells["language"].Value);
        }
        /// <summary>
        /// resim seçen metot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblSelectImage_Click_1(object sender, EventArgs e)
        {
            lblSelectImage.Visible = false;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "resim dosyası | *.png|resim dosyası | *.jpeg";
            file.FilterIndex = 1;
            //file.Multiselect = true;
            if (file.ShowDialog() == DialogResult.OK)
            {
                filePath = file.FileName;
                pbProductImage.ImageLocation = filePath;
                pbProductImage.Visible = true;
            }
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
