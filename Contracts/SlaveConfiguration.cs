using System;
using System.Runtime.Serialization;

namespace KpdApps.Orationi.Common.Contracts
{
	[DataContract]
	public class SlaveConfiguration
	{
		[DataMember]
		public Guid SlaveId { get; private set; }

		public SlaveConfiguration(Guid slaveId)
		{
			SlaveId = slaveId;
		}
	}
}
