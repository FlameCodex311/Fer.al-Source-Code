/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class NativeRingBuffer : IDisposable // TypeDefIndex: 6992
	{
		// Fields
		private readonly NativeBuffer BrhnIpAksXpIZLaJirMAeckHzoH; // 0x10
		private readonly int LHcUXOytTkIjlqPoenVhkyCFGKR; // 0x18
		private long iIQOLmrxIqgQeeJJxBEGylnjpIn; // 0x20
		private long jhIWPqGqHLYlEiNUNDFHTHAGxQl; // 0x28
		private int zwpbwCXlbrFscKiFvhUnngSxoZTD; // 0x30
		private bool DSiEclHKneQNlzttRUUgAHdLEvu; // 0x34
		private uint EfoBwbBBneQRbruICOLmvonLpdVg; // 0x38
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x3C
	
		// Properties
		public int Capacity { get; } // 0x00000001803F46B0-0x00000001803F46C0 
		public int BytesInBuffer { get; } // 0x00000001804AA650-0x00000001804AA660 
		public bool BufferOverrun { get; } // 0x0000000180406600-0x0000000180406610 
	
		// Constructors
		public NativeRingBuffer(int capacity); // 0x000000018109AE20-0x000000018109AEF0
	
		// Methods
		public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite, out int startOffset, out uint passId); // 0x000000018109A920-0x000000018109ACA0
		public int Write(byte[] buffer, int numBytesToWrite, out int startOffset, out uint passId); // 0x000000018109A740-0x000000018109A8E0
		public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite); // 0x000000018109A8E0-0x000000018109A920
		public int Write(byte[] buffer, int numBytesToWrite); // 0x000000018109ACA0-0x000000018109AE20
		public int Read(IntPtr buffer, int bufferLength, int numBytesToRead); // 0x000000018109A130-0x000000018109A390
		public int Read(byte[] buffer, int numBytesToRead); // 0x000000018109A390-0x000000018109A6F0
		public int RandomRead(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex); // 0x0000000181099F70-0x000000018109A130
		public int RandomRead(byte[] buffer, int numBytesToRead, int readStartIndex); // 0x0000000181099C40-0x0000000181099F70
		public bool IsValid(int startIndex, uint passId); // 0x0000000181099A90-0x0000000181099AC0
		public void Reset(); // 0x000000018109A6F0-0x000000018109A740
		private void PJeaLDkSvEGgSidNDJuPcdEagVYk(int param_0000ef2a); // 0x0000000181099AC0-0x0000000181099C40
		private void vyefEeRiQmmuqmZyLiHzaxpvULX(int param_0000ef2b); // 0x000000018109AF10-0x000000018109B500
		private void rcOGaiRvvpUuVagAdKqrDEsIdIC(); // 0x000000018109AEF0-0x000000018109AF10
		public void Dispose(); // 0x00000001810997F0-0x00000001810998F0
		~NativeRingBuffer(); // 0x00000001810999C0-0x0000000181099A90
		protected void Dispose(bool disposing); // 0x00000001810998F0-0x00000001810999C0
	}
}
