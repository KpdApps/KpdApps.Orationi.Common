using System.ServiceModel;
using KpdApps.Orationi.Common.Contracts;

namespace KpdApps.Orationi.Common.Interfaces
{
	public interface IOrationiSlaveService
	{
		[OperationContract]
		void Configure(SlaveConfiguration configuration);
	}
}
