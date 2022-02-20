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
using CadastroWindowsForms;
using System.Data.SqlClient;

namespace WindowsFormsCadastro
{
    public partial class CadastrarInstrutor : Form
    {

       
        public CadastrarInstrutor()
        {
           
            InitializeComponent();
            

            }


        

       
         private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
          {

          }
       

      
        private void Form1_Load(object sender, EventArgs e)
            {

            }
       

      

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            
            SqlConnection conex;
            conex = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CadastroDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            conex.Open();

            var insertCmd = conex.CreateCommand();
            insertCmd.CommandText = "INSERT INTO Instrutor (Nome, Celular, CPF, Endereco) Values (@nome, @celular, @cpf, @endereco)";
           

           
            var ParamNome = new SqlParameter("nome", nome_instrutor.Text);
            var ParamTelefone = new SqlParameter("celular", int.Parse(telefone_instrutor.Text));
            var ParamEndereco = new SqlParameter("endereco", endereco_instrutor.Text);
            var ParamCPF = new SqlParameter("cpf", endereco_instrutor.Text);
            

            insertCmd.Parameters.Add(ParamNome);
            insertCmd.Parameters.Add(ParamTelefone);
            insertCmd.Parameters.Add(ParamEndereco);
            insertCmd.Parameters.Add(ParamCPF);
            insertCmd.ExecuteNonQuery();


                 var selectCmd = conex.CreateCommand();

                selectCmd.CommandText = "SELECT * FROM INSTRUTOR";
                selectCmd.ExecuteNonQuery();
                var resultado = selectCmd.ExecuteReader();
                while (resultado.Read())
                {
                    instrutor.Items.Add($"{resultado["Nome"]} - {resultado["Celular"]} - {resultado["CPF"]}");
                }

                 conex.Close();
                
         }          
                       
                
                   
            
        

           

           



        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboEC_SelectedIndexChanged(object sender, EventArgs e)
        {


         }

        private void txtTel_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

       

        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void instrutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }






      
       
}
