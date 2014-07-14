using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Zoltu.Wrapper.System.Diagnostics
{
	public class Process : IProcess
	{
		private readonly global::System.Diagnostics.Process _systemProcess;

		[ContractInvariantMethod]
		private void ContractInvariants()
		{
			Contract.Invariant(_systemProcess != null);
		}

		public Process(global::System.Diagnostics.Process systemProcess)
		{
			Contract.Requires(systemProcess != null);
			_systemProcess = systemProcess;
		}

		public IProcessModule MainModule
		{
			get
			{
				if (_systemProcess.MainModule != null)
					return new ProcessModule(_systemProcess.MainModule);
				else
					return null;
			}
		}

		public IEnumerable<IProcessModule> Modules
		{
			get
			{
				if (_systemProcess.Modules == null)
					return new List<IProcessModule>();
				return _systemProcess.Modules
					.Cast<global::System.Diagnostics.ProcessModule>()
					.Where(systemProcessModule => systemProcessModule != null)
					.Select(systemProcessModule => new ProcessModule(systemProcessModule));
			}
		}

		public String ProcessName
		{
			get
			{
				return _systemProcess.ProcessName;
			}
		}
	}
}
