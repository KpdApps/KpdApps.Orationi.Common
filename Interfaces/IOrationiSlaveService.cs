using System.ServiceModel;
using KpdApps.Orationi.Common.Contracts;

namespace KpdApps.Orationi.Common.Interfaces
{
	interface IOrationiSlaveService
	{
		[OperationContract]
		void Configure(SlaveConfiguration configuration);
	}
}
