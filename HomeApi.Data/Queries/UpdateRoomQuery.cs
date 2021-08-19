namespace HomeApi.Data.Queries
{
	/// <summary>
	/// Класс для передачи дополнительных параметров при обновлении комнаты
	/// </summary>
	public class UpdateRoomQuery
	{
		public string Name { get; }
		public int? Area { get; }
		public bool? GasConnected { get; }
		public int? Voltage { get; }

		public UpdateRoomQuery(string name = null, int? area = null, bool? gasConnected = null, int? voltage = null)
		{
			Name = name;
			Area = area;
			GasConnected = gasConnected;
			Voltage = voltage;
		}
	}
}
