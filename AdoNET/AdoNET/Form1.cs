using System.Data.SqlClient;
using System.Xml.Linq;

namespace AdoNET
{
    public partial class Form1 : Form
    {
        const string connectionString = "Server=CA-R214-PC03\\SQLEXPRESS;Database=AB106;Trusted_Connection=True;";
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Surname", "Surname");
            dataGridView1.Columns.Add("Gender", "Gender");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetDatas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ad = nameInput.Text;
            string soyad = surnameInput.Text;
            string cins = radioButton1.Checked ? "Qadın" : "Kişi";
            InsertData(ad, soyad, radioButton1.Checked ? 2 : 1);
            //dataGridView1.Rows.Add(dataGridView1.RowCount + 2, ad, soyad, cins);
            nameInput.Text = "";
            surnameInput.Text = "";
            GetDatas();
        }
        void ResetTable()
        {
            dataGridView1.Rows.Clear();
        }
        void GetDatas()
        {
            ResetTable();
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand("SELECT * FROM People", conn);
            using SqlDataReader datas = command.ExecuteReader();
            while (datas.Read())
            {
                dataGridView1.Rows.Add(datas[0], datas[1], datas[2], (Convert.ToInt32(datas[3]) == 1 ? "Kişi" : "Qadın"));
            }
        }
        bool InsertData(string name, string surname, int genderId)
        {
            if (name.Length < 3 || surname.Length < 3 || genderId < 1 || genderId > 2)
            {
                MessageBox.Show("Daxil olunan dəyərlərdə yalnışlıq var.");
                return false;
            }
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"INSERT INTO People VALUES (N'{name}',N'{surname}',{genderId})", conn);
            int count = command.ExecuteNonQuery();
            if (count > 0)
            {
                return true;
            }
            return false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var data = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            string id = data.Cells[0].Value.ToString();
            Delete(id);
            GetDatas();
        }
        void Delete(string id)
        {
            using SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            using SqlCommand command = new SqlCommand($"DELETE People WHERE Id = {id}", conn);
            var result = command.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Silindi");
            }
            else
            {
                MessageBox.Show("Gözlənilməz xəta baş verdi");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
