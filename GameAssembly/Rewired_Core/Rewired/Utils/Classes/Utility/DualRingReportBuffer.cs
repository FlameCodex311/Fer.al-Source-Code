/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class DualRingReportBuffer : IDisposable // TypeDefIndex: 7067
	{
		// Fields
		private readonly int RSHJxvhMUwNesrprgXLCrLfWnMJ; // 0x10
		private readonly int JzwpMLxqJoCLgCAsMPttddZFBdG; // 0x14
		private readonly int SZzdRYanCdydDxnpBYoxSoLopDw; // 0x18
		private NativeRingBuffer YWjdjiBHKMZrCPLasWaTOxmhYSGe; // 0x20
		private NativeRingBuffer tjQESqZBVTUvcjPlFeVOcUtVRGrl; // 0x28
		private byte[] bjZkwozEpnlAevCdFAgzamZNAEeJ; // 0x30
		private byte[] glwDofrNHdsRyGheNOFYzQVHuQS; // 0x38
		private int NNrqQvfubHScaZqdxCaRhReIAGx; // 0x40
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x44
	
		// Properties
		public int BufferLength { get; } // 0x0000000180387590-0x0000000180387930 
		public int BytesInBuffer { get; } // 0x00000001813E6130-0x00000001813E6150 
		public int EntriesInBuffer { get; } // 0x00000001813E6150-0x00000001813E6170 
		public byte[] ReadBuffer { get; } // 0x00000001803743D0-0x00000001803743E0 
		public int LastNumBytesRead { get; } // 0x0000000180379F10-0x0000000180379F20 
	
		// Constructors
		public DualRingReportBuffer(int entryByteLength, int entryCapacity); // 0x00000001813E5FF0-0x00000001813E6130
	
		// Methods
		public int StartRead(); // 0x00000001813E5BC0-0x00000001813E5BF0
		public int Read(); // 0x00000001813E55A0-0x00000001813E5680
		public int Read(byte[] buffer, int numBytesToRead); // 0x00000001813E5680-0x00000001813E5840
		public int Read(IntPtr buffer, int bufferLength, int numBytesToRead); // 0x00000001813E5840-0x00000001813E5A70
		public int Write(byte[] buffer, int numBytesToWrite); // 0x00000001813E5E10-0x00000001813E5FF0
		public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite); // 0x00000001813E5BF0-0x00000001813E5E10
		public void Clear(); // 0x00000001813E5310-0x00000001813E5450
		private void SKLOkQcjSHPMybKTxshPUxHJkoC(); // 0x00000001813E5A70-0x00000001813E5BC0
		public void Dispose(); // 0x00000001813E5450-0x00000001813E54D0
		~DualRingReportBuffer(); // 0x00000001813E5510-0x00000001813E55A0
		protected void Dispose(bool disposing); // 0x00000001813E54D0-0x00000001813E5510
	}
}
