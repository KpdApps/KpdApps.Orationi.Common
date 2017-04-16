using System;
using System.Runtime.Serialization;
using KpdApps.Orationi.Common.Enums;

namespace KpdApps.Orationi.Common.Contracts
{
	[DataContract]
	public class SlaveInfo
	{
		public Guid Id { get; private set; }

		public int Order { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public SlaveState State { get; set; }

		public DateTime LastActivity { get; set; }
	}
}
