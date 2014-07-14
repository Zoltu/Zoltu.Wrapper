﻿using System;
using System.Diagnostics.Contracts;

namespace Zoltu.Wrapper.System.Diagnostics
{
	public class FileVersionInfo : IFileVersionInfo
	{
		private readonly global::System.Diagnostics.FileVersionInfo _systemFileVersionInfo;

		[ContractInvariantMethod]
		private void ContractInvariants()
		{
			Contract.Invariant(_systemFileVersionInfo != null);
		}

		public FileVersionInfo(global::System.Diagnostics.FileVersionInfo systemFileVersionInfo)
		{
			_systemFileVersionInfo = systemFileVersionInfo;
		}

		public String FileVersion
		{
			get
			{
				return _systemFileVersionInfo.FileVersion;
			}
		}
	}
}