using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Zoltu.Wrapper.SystemWrapper.Diagnostics
{
	[ContractClass(typeof(IProcessStaticContracts))]
	public interface IProcessStatic
	{
		IEnumerable<IProcess> GetProcesses();
	}

	[ContractClassFor(typeof(IProcessStatic))]
	internal abstract class IProcessStaticContracts : IProcessStatic
	{
		public IEnumerable<IProcess> GetProcesses()
		{
			Contract.Ensures(Contract.Result<IEnumerable<IProcess>>() != null);
			return default(IEnumerable<IProcess>);
		}
	}

}
