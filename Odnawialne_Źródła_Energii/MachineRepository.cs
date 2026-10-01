using System.Data;
using System.Data.SqlClient;

namespace Odnawialne_Źródła_Energii;

public class MachineRepository
{
	private readonly SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");

	public DataTable GetDataTable()
	{
		DataTable dt = new DataTable();
		SqlDataAdapter adpt = new SqlDataAdapter("SELECT [Id], [Nazwa], [Moc], [Czas] FROM Machines", connection);
		adpt.Fill(dt);
		return dt;
	}

	public string GetSumOfUsage()
	{
		DataTable dt = new DataTable();
		SqlDataAdapter adpt = new SqlDataAdapter("SELECT SUM([Moc] * [Czas]) AS zużycie FROM Machines;", connection);
		adpt.Fill(dt);
		return dt.Rows[0]["zużycie"].ToString();
	}

	public void Add(Machine machine)
	{
		connection.Open();
		string timeOfMachine = machine.time.ToString().Replace(',', '.');
		SqlCommand command = connection.CreateCommand();
		command.CommandText = $"Insert Into Machines (Nazwa, Moc, Czas) Values ('{machine.name}', '{machine.power}', '{timeOfMachine}');";
		command.ExecuteNonQuery();
		connection.Close();
	}

	public void Update(Machine machine)
	{
		connection.Open();
		SqlCommand command = connection.CreateCommand();
		string timeOfMachine = machine.time.ToString().Replace(',', '.');
		command.CommandText = $"Update Machines Set Nazwa = '{machine.name}', Moc = '{machine.power}', Czas = '{timeOfMachine}' Where Id = {machine.id};";
		command.ExecuteNonQuery();
		connection.Close();
	}

	public void Delete(int id)
	{
		connection.Open();
		SqlCommand command = connection.CreateCommand();
		command.CommandText = $"Delete From Machines Where Id = {id};";
		command.ExecuteNonQuery();
		connection.Close();
	}
}
