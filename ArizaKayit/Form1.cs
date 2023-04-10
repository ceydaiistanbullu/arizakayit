using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace deneme
{
	public partial class frmservis : Form
	{

		public frmservis()
		{
			InitializeComponent();
		}
		private SqlConnection baglanti = new SqlConnection("Data Source=HP\\SQLEXPRESS;Initial Catalog=DbAssetManagementt;Integrated Security=True");
		public frmservis(SqlConnection baglanti)
		{
			this.baglanti = baglanti;
		}


		public void temizle()
		{
			txtAd.Text = "";
			txtSeriNo.Text = "";
			txtMarka.Text = "";
			txtModel.Text = "";
			//dtTarih.Value. = "";
			cmbDepartman.Text = "";
			cmbYonetici.Text = "";
			txtTel.Text = "";
			txtDurum.Text = "";
		}
		private void btnkayit_Click(object sender, EventArgs e)
		{

			baglanti.Open();

			SqlCommand cmd = new SqlCommand("SELECT count(*) FROM TeknikServis WHERE seriNo=@seriNo and marka=@marka and model=@model", baglanti);
			cmd.Parameters.AddWithValue("@seriNo", txtSeriNo.Text);
			cmd.Parameters.AddWithValue("@marka", txtMarka.Text);
			cmd.Parameters.AddWithValue("@model", txtModel.Text);
			cmd.Connection = baglanti;
			int sayac = Convert.ToInt32(cmd.ExecuteScalar());

			if (sayac > 0) //Güncelleme burada yapılıyor
			{
				if (!string.IsNullOrWhiteSpace(cmbDepartman.Text) &&
					!string.IsNullOrWhiteSpace(txtAd.Text) &&
					!string.IsNullOrWhiteSpace(txtSeriNo.Text) &&
					!string.IsNullOrWhiteSpace(txtMarka.Text) &&  //boşluk kontrolü yapıyoruz
					!string.IsNullOrWhiteSpace(txtModel.Text) &&
					!string.IsNullOrWhiteSpace(dtTarih.Text) &&
					!string.IsNullOrWhiteSpace(txtDurum.Text) &&
					!string.IsNullOrWhiteSpace(txtTel.Text) &&
					!string.IsNullOrWhiteSpace(cmbYonetici.Text))
					
				{
					string sqlCommand = "update TeknikServis set urunIsmi = @urunIsmi, seriNo = @seriNo," +
					"marka = @marka, model = @model, gidisTarih = @gidisTarih, departmanAd = departmanAd," +
					"yoneticiAd = @yoneticiAd, telefon = @telefon, durum = @durum where seriNo=@seriNo and marka=@marka and model=@model";

					SqlCommand komut = new SqlCommand(sqlCommand, baglanti);
					komut.Parameters.AddWithValue("@urunIsmi", txtAd.Text);
					komut.Parameters.AddWithValue("@seriNo", txtSeriNo.Text);
					komut.Parameters.AddWithValue("@marka", txtMarka.Text);
					komut.Parameters.AddWithValue("@model", txtModel.Text);
					komut.Parameters.AddWithValue("@gidisTarih", dtTarih.Value.Date);
					komut.Parameters.AddWithValue("@departmanAd", cmbDepartman.Text);
					komut.Parameters.AddWithValue("@yoneticiAd", cmbYonetici.Text);
					komut.Parameters.AddWithValue("@telefon", txtTel.Text);
					komut.Parameters.AddWithValue("@durum", txtDurum.Text);

					komut.ExecuteNonQuery();
					baglanti.Close();
					MessageBox.Show("Kayıt Güncellendi");
					datagrid_ariza.DataSource = yenile();
					temizle();
				}
				else 
				{
					MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
					baglanti.Close();
				}
			}
			else //Yeni Kayıt Ekleniyor
			{
				if (!string.IsNullOrWhiteSpace(cmbDepartman.Text) &&
					!string.IsNullOrWhiteSpace(txtAd.Text) &&
					!string.IsNullOrWhiteSpace(txtSeriNo.Text) &&
					!string.IsNullOrWhiteSpace(txtMarka.Text) &&
					!string.IsNullOrWhiteSpace(txtModel.Text) &&
					!string.IsNullOrWhiteSpace(dtTarih.Text) &&
					!string.IsNullOrWhiteSpace(txtDurum.Text) &&
					!string.IsNullOrWhiteSpace(txtTel.Text) &&
					!string.IsNullOrWhiteSpace(cmbYonetici.Text))
				{
					SqlCommand komut = new SqlCommand("insert into TeknikServis(urunIsmi,seriNo,marka,model," +
					"gidisTarih,departmanAd,yoneticiAd,telefon,durum) values(@urunIsmi,@seriNo,@marka,@model," +
					"@gidisTarih,@departmanAd,@yoneticiAd,@telefon,@durum)", baglanti);

					komut.Parameters.AddWithValue("@urunIsmi", txtAd.Text);
					komut.Parameters.AddWithValue("@seriNo", txtSeriNo.Text);
					komut.Parameters.AddWithValue("@marka", txtMarka.Text);
					komut.Parameters.AddWithValue("@model", txtModel.Text);
					komut.Parameters.AddWithValue("@gidisTarih", dtTarih.Value.Date);
					komut.Parameters.AddWithValue("@departmanAd", cmbDepartman.Text);
					komut.Parameters.AddWithValue("@yoneticiAd", cmbYonetici.Text);
					komut.Parameters.AddWithValue("@telefon", txtTel.Text);
					komut.Parameters.AddWithValue("@durum", txtDurum.Text);
					komut.ExecuteNonQuery();
					baglanti.Close();
					MessageBox.Show("Kayıt Eklendi");
					datagrid_ariza.DataSource = yenile();
					temizle();
				}
				else
				{
					MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
					baglanti.Close();
				}
			}
		}

		private void frmservis_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dbAssetManagementtDataSet1.TeknikServis' table. You can move, or remove it, as needed.
			this.teknikServisTableAdapter.Fill(this.dbAssetManagementtDataSet1.TeknikServis);

			datagrid_ariza.DataSource = yenile();

			SqlDataReader dr;
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Select departmanAd from TeknikServis", baglanti);
			dr = komut.ExecuteReader();
			while (dr.Read())
			{
				cmbDepartman.Items.Add(dr["departmanAd"]);
			}
			baglanti.Close();


		}

		DataTable yenile()
		{
			baglanti.Open();
			SqlDataAdapter adtr = new SqlDataAdapter("Select * from TeknikServis", baglanti);
			DataTable tablo = new DataTable();
			adtr.Fill(tablo);
			baglanti.Close();
			return tablo;
		}
		private void cmbDepartman_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbYonetici.Items.Clear();
			SqlDataReader dr;
			baglanti.Close();
			baglanti.Open();
			SqlCommand komut2 = new SqlCommand("Select yoneticiAd from TeknikServis WHERE departmanAd=@p1", baglanti);
			komut2.Parameters.AddWithValue("@p1", cmbDepartman.SelectedItem.ToString());
			dr = komut2.ExecuteReader();
			while (dr.Read())
			{
				cmbYonetici.Items.Add(dr[0]);
			}
			baglanti.Close();
		}

		private void btnsil_Click(object sender, EventArgs e)
		{
			var itemToDelete = (DataRowView)datagrid_ariza.SelectedRows[0].DataBoundItem;
			MessageBox.Show(itemToDelete.Row.ItemArray[1].ToString());
			baglanti.Open();
			SqlCommand komut = new SqlCommand("Delete from TeknikServis Where urunId=@urunId", baglanti);
			komut.Parameters.AddWithValue("@urunId", itemToDelete.Row.ItemArray[1].ToString());
			komut.ExecuteNonQuery();
			baglanti.Close();

			MessageBox.Show("Kayıtlar Silindi");
			datagrid_ariza.DataSource = yenile();
			temizle();
		}

		private void datagrid_ariza_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			baglanti.Open();
			if (e.RowIndex >= 0)
			{
				//DataGridViewRow row = this.datagrid_ariza.Rows[e.RowIndex];
				txtAd.Text = datagrid_ariza.CurrentRow.Cells[0].Value.ToString();
				txtSeriNo.Text = datagrid_ariza.CurrentRow.Cells[1].Value.ToString();
				txtMarka.Text = datagrid_ariza.CurrentRow.Cells[2].Value.ToString();
				txtModel.Text = datagrid_ariza.CurrentRow.Cells[3].Value.ToString();
				dtTarih.Value = Convert.ToDateTime(datagrid_ariza.CurrentRow.Cells[4].Value);
				cmbDepartman.Text = datagrid_ariza.CurrentRow.Cells[5].Value.ToString();
				cmbYonetici.Text = datagrid_ariza.CurrentRow.Cells[6].Value.ToString();
				txtTel.Text = datagrid_ariza.CurrentRow.Cells[7].Value.ToString();
				txtDurum.Text = datagrid_ariza.CurrentRow.Cells[8].Value.ToString();


			}
			baglanti.Close();
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{

		}
	}
}
