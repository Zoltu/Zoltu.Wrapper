using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Zoltu.Wrapper.System.Diagnostics
{
	[ContractClass(typeof(IProcessContracts))]
	public interface IProcess
	{
		String ProcessName { get; }
		IProcessModule MainModule { get; }
		IEnumerable<IProcessModule> Modules { get; }
	}

	[ContractClassFor(typeof(IProcess))]
	internal abstract class IProcessContracts : IProcess
	{
		public abstract String ProcessName { get; }
		public abstract IProcessModule MainModule { get; }
		public IEnumerable<IProcessModule> Modules
		{
			get
			{
				Contract.Ensures(Contract.Result<IEnumerable<IProcessModule>>() != null);
				return default(IEnumerable<IProcessModule>);
			}
		}
	}
}
