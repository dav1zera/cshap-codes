using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroWindowsForms
{
    public partial class CadastrarOferta : Form
    {
        public CadastrarOferta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conex;
            conex = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CadastroDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conex.Open();

            var insertCmd = conex.CreateCommand();
            insertCmd.CommandText = "INSERT INTO Oferta (DataInicial, DataFinal, Curso, SituacaoOferta, Id_Instrutor) Values (@datainicial, @datafinal, @curso, @situacaooferta, @idinstrutor)";
           

            var Param = new SqlParameter();
            var ParamCurso = new SqlParameter("curso", nome_oferta.Text);
            var ParamStatus = new SqlParameter("situacaooferta",status_oferta.Text.ToString());
            var ParamInicial = new SqlParameter("datainicial", Convert.ToDateTime(ini_oferta.Text));
            var ParamFinal = new SqlParameter("datafinal", Convert.ToDateTime(fim_oferta.Text));
            var ParamID = new SqlParameter("idinstrutor", id_instrutor.Text);

         

            insertCmd.Parameters.Add(ParamCurso);
            insertCmd.Parameters.Add(ParamStatus);
            insertCmd.Parameters.Add(ParamInicial);
            insertCmd.Parameters.Add(ParamFinal);
            insertCmd.Parameters.Add(ParamID);
            insertCmd.ExecuteNonQuery();


            var selectCmd = conex.CreateCommand();

            selectCmd.CommandText = "SELECT * FROM OFERTA ";
            selectCmd.ExecuteNonQuery();
            var resultado = selectCmd.ExecuteReader();
            while (resultado.Read())
            {
                ofertas.Items.Add($"{resultado["Curso"]}  - {resultado["SituacaoOferta"]} - {resultado["Id_Instrutor"]}");
            }

            conex.Close();


        }   

           
        // => Funções Geradas pelo windows forms

        private void nome_oferta_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastrarOferta_Load(object sender, EventArgs e)
        {

        }

        private void ofertas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
