using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Diagnostics.Contracts;


namespace AgudeloJhonatan
{
    internal class ConexionDB
    {
        OleDbCommand comando;
        OleDbConnection conexion;
        OleDbDataAdapter adaptador;
        public static string cadena;

        public ConexionDB()
        {
            cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;DataSource=C:\Users\Alumno\source\repos\AgudeloJhonatan\AgudeloJhonatan\bin\Debug.accdb";
        }
        public bool VerificarConexion()
        {
            bool result = false;
            conexion = new OleDbConnection();
            try
            {
                conexion.Open();
                result = true;
                MessageBox.Show("Conectado");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            { 
                conexion.Close(); 
            }
            return result;
        }

        public void MostrarTv(TreeView tv)
        {
            try
            {
                tv.Nodes.Clear();
                conexion = new OleDbConnection(cadena);
                comando = new OleDbCommand();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT Administradores, Usuarios regulares, Invitados FROM CategorioUsuarios";
                conexion.Open();
                DataTable tabla = new DataTable();
                adaptador = new OleDbDataAdapter(comando);
                adaptador.Fill(tabla);

                Dictionary<string, List<string>> infoUsuarios = new Dictionary<string, List<string>>();

                foreach (DataRow fila in tabla.Rows)
                {
                    string categoria = fila["Categoria"].ToString();
                    string NombreCate = fila["Nombre_Categoria"].ToString();

                    string Usuarios = $"{categoria} {NombreCate}";

                }

                foreach (var cate in infoUsuarios)
                {
                    TreeNode nodoCate = new TreeNode(cate.Key);

                    foreach (var usuarios in cate.Value)
                    {
                        TreeNode nodoUsuarios = new TreeNode(usuarios);
                        nodoCate.Nodes.Add(nodoUsuarios);
                    }
                    tv.Nodes.Add(nodoCate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }

        }
    }
}
