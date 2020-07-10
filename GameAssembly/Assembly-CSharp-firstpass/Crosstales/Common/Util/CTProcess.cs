/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.Common.Util
{
	public class CTProcess : IDisposable // TypeDefIndex: 9948
	{
		// Fields
		private uint exitCode; // 0x10
		private CTProcessStartInfo startInfo; // 0x18
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private IntPtr <Handle>k__BackingField; // 0x20
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private int <Id>k__BackingField; // 0x28
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <HasExited>k__BackingField; // 0x2C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private DateTime <StartTime>k__BackingField; // 0x30
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private DateTime <ExitTime>k__BackingField; // 0x38
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private StreamReader <StandardOutput>k__BackingField; // 0x40
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private StreamReader <StandardError>k__BackingField; // 0x48
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <isBusy>k__BackingField; // 0x50
		private EventHandler _onExited; // 0x58
		private DataReceivedEventHandler _onOutputDataReceived; // 0x60
		private DataReceivedEventHandler _onErrorDataReceived; // 0x68
		private IntPtr threadHandle; // 0x70
		private static readonly FieldInfo[] eventFields; // 0x00
		private const uint Infinite = 4294967295; // Metadata: 0x00746768
		private const uint CREATE_NO_WINDOW = 134217728; // Metadata: 0x0074676C
	
		// Properties
		public IntPtr Handle { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public int Id { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0
		public CTProcessStartInfo StartInfo { get; set; } // 0x000000018038B150-0x000000018038B160 0x00000001815CFF60-0x00000001815CFF70
		public bool HasExited { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180488600-0x0000000180488610 0x0000000180488610-0x0000000180488620
		public uint ExitCode { get; } // 0x000000018036CFF0-0x000000018036D000 
		public DateTime StartTime { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
		public DateTime ExitTime { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
		public StreamReader StandardOutput { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369B30-0x0000000180369B40 0x00000001803A2810-0x00000001803A2820
		public StreamReader StandardError { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C40-0x0000000180369C50 0x00000001803A27F0-0x00000001803A2800
		public bool isBusy { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180619B50-0x0000000180619B60 0x0000000180639DF0-0x0000000180639E00
	
		// Events
		public event EventHandler Exited {
			add; // 0x00000001815CE400-0x00000001815CE480
			remove; // 0x00000001815CFE60-0x00000001815CFEE0
		}
		public event DataReceivedEventHandler OutputDataReceived {
			add; // 0x00000001815CE480-0x00000001815CE500
			remove; // 0x00000001815CFEE0-0x00000001815CFF60
		}
		public event DataReceivedEventHandler ErrorDataReceived {
			add; // 0x00000001815CE380-0x00000001815CE400
			remove; // 0x00000001815CFDE0-0x00000001815CFE60
		}
	
		// Constructors
		public CTProcess(); // 0x00000001815CE300-0x00000001815CE380
		static CTProcess(); // 0x00000001815CE270-0x00000001815CE300
	
		// Methods
		private void onExited(); // 0x00000001815CFCD0-0x00000001815CFDE0
		public void Start(); // 0x00000001815CE050-0x00000001815CE210
		public void Start(CTProcessStartInfo info); // 0x00000001815CE210-0x00000001815CE220
		public void Kill(); // 0x00000001815CDF50-0x00000001815CE050
		public void WaitForExit(int milliseconds = 0 /* Metadata: 0x00746764 */); // 0x00000001815CE250-0x00000001815CE270
		public void BeginOutputReadLine(); // 0x00000001815CDDC0-0x00000001815CDE50
		public void BeginErrorReadLine(); // 0x00000001815CDD30-0x00000001815CDDC0
		public void Dispose(); // 0x00000001815CDE50-0x00000001815CDF50
		private void createProcess(); // 0x00000001815CE830-0x00000001815CFCD0
		private void cleanup(); // 0x00000001815CE500-0x00000001815CE610
		private void watchStdOut(); // 0x00000001815D0140-0x00000001815D0310
		private void watchStdErr(); // 0x00000001815CFF70-0x00000001815D0140
		private static DataReceivedEventArgs createMockDataReceivedEventArgs(string data); // 0x00000001815CE610-0x00000001815CE830
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Start>b__56_0(); // 0x00000001815CE240-0x00000001815CE250
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <BeginOutputReadLine>b__60_0(); // 0x00000001815CE230-0x00000001815CE240
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <BeginErrorReadLine>b__61_0(); // 0x00000001815CE220-0x00000001815CE230
	}
}
