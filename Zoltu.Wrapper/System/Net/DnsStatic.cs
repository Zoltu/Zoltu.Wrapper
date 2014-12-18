namespace Zoltu.Wrapper.SystemWrapper.Net
{
	public class DnsStatic : IDnsStatic
	{
		public string GetHostName()
		{
			return global::System.Net.Dns.GetHostName();
		}
	}
}
