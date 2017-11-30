using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAhorcado
{
    public partial class Main : Form
    {
        List<Palabra> ListPalabras = new List<Palabra>();
        SqlCommand cmd;
        SqlDataReader reader;
        public string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        SqlConnection cnn;

        public Main()
        {
            InitializeComponent();
            cnn = new SqlConnection(ConnectionString);
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        void GetPalabras()
        {
            cnn.Open();
            cmd = new SqlCommand("VerPalabras", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListPalabras.Add(new Palabra(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
            }
            cnn.Close();
        }

        
    }
}
