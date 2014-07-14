using System.Collections.Generic;
using System.Linq;

namespace Zoltu.Wrapper.System.Diagnostics
{
	public class ProcessStatic : IProcessStatic
	{
		public IEnumerable<IProcess> GetProcesses()
		{
			return global::System.Diagnostics.Process.GetProcesses()
				.Where(systemProcess => systemProcess != null)
				.Select(systemProcess => new Process(systemProcess));
		}
	}
}
