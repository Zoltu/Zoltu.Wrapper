using System;
using System.Diagnostics.Contracts;

namespace Zoltu.Wrapper.System.Diagnostics
{
	[ContractClass(typeof(IProcessModuleContracts))]
	public interface IProcessModule
	{
		String ModuleName { get; }
		String FileName { get; }
		IFileVersionInfo FileVersionInfo { get; }
	}

	[ContractClassFor(typeof(IProcessModule))]
	internal abstract class IProcessModuleContracts : IProcessModule
	{
		public abstract String ModuleName { get; }
		public abstract String FileName { get; }
		public IFileVersionInfo FileVersionInfo
		{
			get
			{
				Contract.Ensures(Contract.Result<IFileVersionInfo>() != null);
				return default(IFileVersionInfo);
			}
		}
	}
}
