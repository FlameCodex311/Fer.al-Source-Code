/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.Common.Util
{
	public class CTProcess : IDisposable // TypeDefIndex: 9734
	{
		// Fields
		private uint exitCode; // 0x10
		private CTProcessStartInfo startInfo; // 0x18
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IntPtr <Handle>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int <Id>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <HasExited>k__BackingField; // 0x2C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DateTime <StartTime>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DateTime <ExitTime>k__BackingField; // 0x38
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private StreamReader <StandardOutput>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private StreamReader <StandardError>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isBusy>k__BackingField; // 0x50
		private EventHandler _onExited; // 0x58
		private DataReceivedEventHandler _onOutputDataReceived; // 0x60
		private DataReceivedEventHandler _onErrorDataReceived; // 0x68
		private IntPtr threadHandle; // 0x70
		private static readonly FieldInfo[] eventFields; // 0x00
		private const uint Infinite = 4294967295; // Metadata: 0x0077AA33
		private const uint CREATE_NO_WINDOW = 134217728; // Metadata: 0x0077AA37
	
		// Properties
		public IntPtr Handle { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public int Id { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0
		public CTProcessStartInfo StartInfo { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000181079D40-0x0000000181079D50
		public bool HasExited { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180626230-0x0000000180626240 0x0000000180626250-0x0000000180626260
		public uint ExitCode { get; } // 0x0000000180387590-0x0000000180387930 
		public DateTime StartTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
		public DateTime ExitTime { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743D0-0x00000001803743E0 0x00000001803FEB60-0x00000001803FEB70
		public StreamReader StandardOutput { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803C7290-0x00000001803C72A0 0x00000001804CD6C0-0x00000001804CD6D0
		public StreamReader StandardError { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803743E0-0x00000001803743F0 0x00000001804ADAE0-0x00000001804ADAF0
		public bool isBusy { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180379EC0-0x0000000180379ED0 0x000000018047A1C0-0x000000018047A1D0
	
		// Events
		public event EventHandler Exited {
			add; // 0x0000000181078300-0x0000000181078380
			remove; // 0x0000000181079C40-0x0000000181079CC0
		}
		public event DataReceivedEventHandler OutputDataReceived {
			add; // 0x0000000181078380-0x0000000181078400
			remove; // 0x0000000181079CC0-0x0000000181079D40
		}
		public event DataReceivedEventHandler ErrorDataReceived {
			add; // 0x0000000181078280-0x0000000181078300
			remove; // 0x0000000181079BC0-0x0000000181079C40
		}
	
		// Constructors
		public CTProcess(); // 0x0000000181078200-0x0000000181078280
		static CTProcess(); // 0x0000000181078170-0x0000000181078200
	
		// Methods
		private void onExited(); // 0x0000000181079AB0-0x0000000181079BC0
		public void Start(); // 0x0000000181077F70-0x0000000181078110
		public void Start(CTProcessStartInfo info); // 0x0000000181078110-0x0000000181078120
		public void Kill(); // 0x0000000181077E90-0x0000000181077F70
		public void WaitForExit(int milliseconds = 0 /* Metadata: 0x0077AA2F */); // 0x0000000181078150-0x0000000181078170
		public void BeginOutputReadLine(); // 0x0000000181077D00-0x0000000181077D90
		public void BeginErrorReadLine(); // 0x0000000181077C70-0x0000000181077D00
		public void Dispose(); // 0x0000000181077D90-0x0000000181077E90
		private void createProcess(); // 0x0000000181078710-0x0000000181079AB0
		private void cleanup(); // 0x0000000181078400-0x00000001810784F0
		private void watchStdOut(); // 0x0000000181079F20-0x000000018107A0F0
		private void watchStdErr(); // 0x0000000181079D50-0x0000000181079F20
		private static DataReceivedEventArgs createMockDataReceivedEventArgs(string data); // 0x00000001810784F0-0x0000000181078710
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Start>b__56_0(); // 0x0000000181078140-0x0000000181078150
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <BeginOutputReadLine>b__60_0(); // 0x0000000181078130-0x0000000181078140
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <BeginErrorReadLine>b__61_0(); // 0x0000000181078120-0x0000000181078130
	}
}
