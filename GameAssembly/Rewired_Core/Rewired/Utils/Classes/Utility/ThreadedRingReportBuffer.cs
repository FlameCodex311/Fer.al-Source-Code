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
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class ThreadedRingReportBuffer : IDisposable // TypeDefIndex: 7066
	{
		// Fields
		private readonly int RSHJxvhMUwNesrprgXLCrLfWnMJ; // 0x10
		private readonly int JzwpMLxqJoCLgCAsMPttddZFBdG; // 0x14
		private readonly int SZzdRYanCdydDxnpBYoxSoLopDw; // 0x18
		private readonly int GqCCenQTbFxsqZsybplDOPJvqBW; // 0x1C
		private readonly int wUnLlcywpCShTdpQqexYzWSCixo; // 0x20
		private readonly bool DCubnnifBIfgImIgPMpGRLhIPLtf; // 0x24
		private ThreadHelper habGSklQHfgBqWkyroQbBEtCUJR; // 0x28
		private NativeRingBuffer YWjdjiBHKMZrCPLasWaTOxmhYSGe; // 0x30
		private NativeRingBuffer tjQESqZBVTUvcjPlFeVOcUtVRGrl; // 0x38
		private Action<byte[]> brTsmqGEkUmYdlESDodgRIsYIOR; // 0x40
		private byte[] bjZkwozEpnlAevCdFAgzamZNAEeJ; // 0x48
		private byte[] glwDofrNHdsRyGheNOFYzQVHuQS; // 0x50
		private bool NUnAFZNgoriwvYnCEOYspThIrYA; // 0x58
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf; // 0x59
		private int NNrqQvfubHScaZqdxCaRhReIAGx; // 0x5C
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x60
	
		// Properties
		public bool IsRunning { get; } // 0x00000001813FEF40-0x00000001813FEF60 
		public int BufferLength { get; } // 0x0000000180387590-0x0000000180387930 
		public int BytesInBuffer { get; } // 0x00000001813FEF00-0x00000001813FEF20 
		public int EntriesInBuffer { get; } // 0x00000001813FEF20-0x00000001813FEF40 
		public byte[] ReadBuffer { get; } // 0x0000000180378320-0x0000000180378330 
		public int LastNumBytesRead { get; } // 0x00000001804D2E40-0x00000001804D2E50 
	
		// Constructors
		public ThreadedRingReportBuffer(int entryByteLength, int entryCapacity, int threadRefreshRateFPS, int threadAutoKillTimeoutMS, bool threadBlockOnStartAndStop, Action<byte[]> threadRetrieveDataDelegate); // 0x00000001813FED00-0x00000001813FEF00
	
		// Methods
		public int Read(); // 0x00000001813FE6D0-0x00000001813FE7B0
		public int Read(byte[] buffer); // 0x00000001813FE7B0-0x00000001813FE8E0
		public int Read(IntPtr buffer, int bufferLength); // 0x00000001813FE8E0-0x00000001813FEA70
		public int StartRead(); // 0x00000001813FEBC0-0x00000001813FEBF0
		public void StartThread(); // 0x00000001813FEBF0-0x00000001813FEC70
		public void StopThread(); // 0x00000001813FEC70-0x00000001813FED00
		private bool DeRyKKaIFeIgBBjcstmktRxedrNm(); // 0x00000001813FE3A0-0x00000001813FE3E0
		private bool DAtaDXybNYHmfIBvCpqNGFfILOkf(); // 0x00000001813FE140-0x00000001813FE3A0
		private void SKLOkQcjSHPMybKTxshPUxHJkoC(); // 0x00000001813FEA70-0x00000001813FEBC0
		private void NLJJNAtrdXKtsPILrseWHDPkKKr(); // 0x00000001813FE5B0-0x00000001813FE6D0
		public void Dispose(); // 0x00000001813FE460-0x00000001813FE520
		~ThreadedRingReportBuffer(); // 0x00000001813FE520-0x00000001813FE5B0
		protected void Dispose(bool disposing); // 0x00000001813FE3E0-0x00000001813FE460
	}
}
