using System.Data;
using System.Data.SqlClient;

namespace Odnawialne_Źródła_Energii;

public class SourcesRepository
{
	private readonly SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True");

	public DataTable GetDataTable()
	{
		DataTable dt = new DataTable();
		SqlDataAdapter adpt = new SqlDataAdapter("SELECT [Id], [Nazwa], [Moc], [Sprawność], [Powiechrznia], [Czas] FROM SourcesEnergy", connection);
		adpt.Fill(dt);
		return dt;
	}

	public string GetSumOfUsage()
	{
		DataTable dt = new DataTable();
		SqlDataAdapter adpt = new SqlDataAdapter("SELECT SUM([Moc] * [Czas] * [Sprawność] * [Powiechrznia]) AS wyprodukowane FROM SourcesEnergy;", connection);
		adpt.Fill(dt);
		return dt.Rows[0]["wyprodukowane"].ToString();
	}

	public void Add(Sources sources)
	{
		connection.Open();
		SqlCommand command = connection.CreateCommand();
		string fieldOfSources = sources.field.ToString().Replace(',', '.');
		string timeOfSources = sources.time.ToString().Replace(',', '.');
		command.CommandText = $"Insert Into SourcesEnergy (Nazwa, Moc, Sprawność, Powiechrznia, Czas) Values ('{sources.name}', '{sources.power}', '{sources.efficiency}', {fieldOfSources}, '{timeOfSources}');";
		command.ExecuteNonQuery();
		connection.Close();
	}

	public void Update(Sources sources)
	{
		connection.Open();
		SqlCommand command = connection.CreateCommand();
		string fieldOfSources = sources.field.ToString().Replace(',', '.');
		string timeOfSources = sources.time.ToString().Replace(',', '.');
		command.CommandText = $"Update SourcesEnergy Set Nazwa = '{sources.name}', Moc = '{sources.power}', Sprawność = '{sources.efficiency}', Powiechrznia = '{fieldOfSources}', Czas = '{timeOfSources}' Where Id = {sources.id};";
		command.ExecuteNonQuery();
		connection.Close();
	}

	public void Delete(int id)
	{
		connection.Open();
		SqlCommand command = connection.CreateCommand();
		command.CommandText = $"Delete From SourcesEnergy Where Id = {id};";
		command.ExecuteNonQuery();
		connection.Close();
	}
}
