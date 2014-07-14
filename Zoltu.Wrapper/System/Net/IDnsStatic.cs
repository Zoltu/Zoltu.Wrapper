using System;
using System.Diagnostics.Contracts;

namespace Zoltu.Wrapper.System.Net
{
	[ContractClass(typeof(IDnsStaticContracts))]
	public interface IDnsStatic
	{
		String GetHostName();
	}

	[ContractClassFor(typeof(IDnsStatic))]
	internal abstract class IDnsStaticContracts : IDnsStatic
	{
		public String GetHostName()
		{
			Contract.Ensures(Contract.Result<String>() != null);
			return default(String);
		}
	}
}
