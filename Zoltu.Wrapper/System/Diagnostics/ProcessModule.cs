using System;
using System.Diagnostics.Contracts;

namespace Zoltu.Wrapper.System.Diagnostics
{
	public class ProcessModule : IProcessModule
	{
		private readonly global::System.Diagnostics.ProcessModule _systemProcessModule;

		[ContractInvariantMethod]
		private void ContractInvariants()
		{
			Contract.Invariant(_systemProcessModule != null);
		}

		public ProcessModule(global::System.Diagnostics.ProcessModule systemProcessModule)
		{
			Contract.Requires(systemProcessModule != null);
			_systemProcessModule = systemProcessModule;
		}

		public String FileName
		{
			get
			{
				Contract.Assume(_systemProcessModule.FileName != null);
				return _systemProcessModule.FileName;
			}
		}

		public IFileVersionInfo FileVersionInfo
		{
			get
			{
				return new FileVersionInfo(_systemProcessModule.FileVersionInfo);
			}
		}

		public String ModuleName
		{
			get
			{
				return _systemProcessModule.ModuleName;
			}
		}
	}
}
