namespace Zoltu.Wrapper.System.Net
{
	public class DnsStatic : IDnsStatic
	{
		public string GetHostName()
		{
			return global::System.Net.Dns.GetHostName();
		}
	}
}
