﻿using System;
using System.Diagnostics.Contracts;
using System.IO;

namespace Zoltu.Wrapper.System.IO
{
	[ContractClass(typeof (IFileStaticContracts))]
	public interface IFileStatic
	{
		String ReadAllText(String filePath);
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
	}

	public class FileStaticWrapper : IFileStatic
	{
		public String ReadAllText(String filePath)
		{
			Contract.Requires<ArgumentNullException>(filePath != null);
			Contract.Requires<ArgumentException>(filePath.Length != 0);
			Contract.Ensures(Contract.Result<String>() != null);

			return File.ReadAllText(filePath);
		}
	}
}
