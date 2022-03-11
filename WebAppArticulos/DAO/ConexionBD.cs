using Microsoft.Data.SqlClient;

namespace WebAppArticulos.DAO
{
    public static class ConexionBD
    {
        //Cadena de conexion a la BD. El server es mi propia computadora, usando SQLExpress.
        //En caso de requerir usuario y contraseña (no es el caso), se ingresaría al final de esta misma cadena.
        private const string conexionBD = "Server=DESKTOP-NNEPN8G\\SQLEXPRESS;Database=ArticulosDBAccenture_1;Trusted_Connection=True;MultipleActiveResultSets=true";
        public static SqlConnection connection = new SqlConnection(conexionBD);
    }
}
