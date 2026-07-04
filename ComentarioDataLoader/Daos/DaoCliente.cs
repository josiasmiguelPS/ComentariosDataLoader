using ComentarioDataLoader.Data.Base;
using ComentarioDataLoader.Data.Interfaces;
using ComentarioDataLoader.Data.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace ComentarioDataLoader.Data.Daos
{
    public sealed class DaoCliente : ComentsDataConnection, IDaoCliente
    {
        private readonly string connectionString;
        private SqlDbType sqlDbType;

        public DaoCliente(string connectionString) : base(connectionString)
        {
            this.connectionString = connectionString;
        }

        public async Task<OperactionResult> LoadClienteAsync(LoadClienteModel loadCliente)
        {
            OperactionResult operactionResult = new OperactionResult();
            try
            {
                using (var connection = GetConnection())
                {
                    await connection.OpenAsync();
                   
                    var command = connection.CreateCommand();
                    
                    command.CommandType = CommandType.StoredProcedure;
                    
                    command.CommandText = "[dbo].[usp_LoadCliente]";
                    
                    command.Parameters.AddWithValue("@Nombre", loadCliente.Nombre);
                    
                    command.Parameters.AddWithValue("@Email", loadCliente.Email);


                    SqlParameter p_result = new SqlParameter("P_result", SqlDbType.VarChar, 500)
                    {
                        Direction = ParameterDirection.Output
                    };

                    command.Parameters.Add(p_result);

                    int rowsAffected = await command.ExecuteNonQueryAsync();
                    if (rowsAffected > 0)
                    {
                        p_result.Value = 
                        operactionResult.IsSuccess = true;
                        operactionResult.Message = "Cliente Loaded Successfully.";
                    }
                    else
                    {
                        operactionResult.IsSuccess = false;
                        operactionResult.Message = "Failed to load Cliente.";
                    }
                }
            }
            catch (Exception ex)
            {

                operactionResult.IsSuccess = false;
                operactionResult.Message = $"Error loading Cliente: {ex.Message}";
            }
            return operactionResult;
        }
    }
}
