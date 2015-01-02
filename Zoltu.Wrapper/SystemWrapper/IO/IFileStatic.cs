using System;
using System.Diagnostics.Contracts;
using System.IO;
using System.Text;

namespace Zoltu.Wrapper.SystemWrapper.IO
{
	[ContractClass(typeof (IFileStaticContracts))]
	public interface IFileStatic
	{
		String ReadAllText(String filePath);
		String ReadAllText(String filePath, Encoding encoding);
	}

	[ContractClassFor(typeof(IFileStatic))]
	internal abstract class IFileStaticContracts : IFileStatic
	{
		public String ReadAllText(String filePath)
		{
			Contract.Requires<ArgumentNullException>(filePath != null);
			Contract.Requires<ArgumentException>(filePath.Length != 0);
			Contract.Ensures(Contract.Result<String>() != null);

			return default (String);
		}

		public String ReadAllText(String filePath, Encoding encoding)
		{
			Contract.Requires<ArgumentNullException>(filePath != null);
			Contract.Requires<ArgumentException>(filePath.Length != 0);
			Contract.Requires<ArgumentNullException>(encoding != null);
			Contract.Ensures(Contract.Result<String>() != null);

			return default (String);
		}
	}

	public class FileStaticWrapper : IFileStatic
	{
		public String ReadAllText(String filePath)
		{
			return File.ReadAllText(filePath);
		}

		public String ReadAllText(String filePath, Encoding encoding)
		{
			return File.ReadAllText(filePath, encoding);
		}
	}
}
