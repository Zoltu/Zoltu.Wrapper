using System.Reflection;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyDescription(
@"A set of interfaces that thinly wrap a varienty of system classes.

The interfaces include Code Contracts that are valid for at least the underlying .NET 4.5.1 system calls.")]

[assembly: AssemblyTitle("Wrappers for a number of system classes, including Code Contracts.")]
[assembly: AssemblyProduct("Zoltu.Wrapper")]
[assembly: AssemblyCompany("Zoltu")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyCulture("")]