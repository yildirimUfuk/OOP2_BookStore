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
	public partial class BookAddForm : Form
	{
		string filePath;

		public BookAddForm()
		{
			InitializeComponent();
		}
		/// <summary>
		/// kitap nesnesi oluşturarak admin sınıfı üzerinden kayıt yapan metot
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnSave_Click(object sender, EventArgs e)
		{
			Program.NotifyObserver(this.Name, ((Button)sender).Name);
			Book book = new Book();
			book.Name = tbName.Text;
			book.Price = Convert.ToInt32(tbPrice.Text);
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
			admin.addNewItem(book, filePath);
			this.Close();
		}
		/// <summary>
		/// ürün için resim seçerek ilgili resmi exe konumuna kopyalayan metot
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void LblSelectImage_Click(object sender, EventArgs e)
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
				saveFile.FileName = @"ProductPhotos\book_" + maxId + ".png";
				bitmap.Save(saveFile.FileName);
				pbProductImage.ImageLocation = saveFile.FileName;
				pbProductImage.Visible = true;
				filePath = saveFile.FileName;
			}
		}
		/// <summary>
		/// label üzerine geldiğinde yazı rengi tipi ve mouse imlecini değiştiren metot
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
		/// mouse yazı üzerinden gidince yazının eski haline dönmesini sağlayan metot
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LblSelectImage_MouseLeave(object sender, EventArgs e)
		{
			((Label)sender).Font = new Font(((Label)sender).Font, FontStyle.Regular);
			((Label)sender).ForeColor = Color.Black;
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
