using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace KpdApps.Orationi.Common.Interfaces
{
	[ServiceContract(Namespace = "tcp://orationi.org/master/v1/", SessionMode = SessionMode.Required, CallbackContract = typeof(IOrationiSlaveService))]
	public interface IOrationiMasterService
	{
		[OperationContract(IsInitiating = true)]
		Guid Connect(string identifier);

		[OperationContract(IsInitiating = false, IsTerminating = true)]
		void Disconnect();

		[OperationContract(IsInitiating = false, IsTerminating = false)]
		void Ping();
	}
}
