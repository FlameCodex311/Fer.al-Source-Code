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
using Rewired.Utils.Classes.Utility;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class HidOutputReportHandler : IDisposable // TypeDefIndex: 6422
	{
		// Fields
		private const bool fWmDoloMFHDDVIbfZVBisbHgLpHP = false; // Metadata: 0x007300C4
		private const int GpkMENyeblGIPtQZcxjoOtAVKtI = 100; // Metadata: 0x007300C5
		private const int kTpxyUYSXgdGUetuYSrNXkITdOE = 10000; // Metadata: 0x007300C9
		private ThreadHelper habGSklQHfgBqWkyroQbBEtCUJR; // 0x10
		private DrHLvjnvTTknYFnktcrVhAQheyGc BrhnIpAksXpIZLaJirMAeckHzoH; // 0x18
		private DrHLvjnvTTknYFnktcrVhAQheyGc jmZtZVHRXuRrZicJYgdjnNeOLtD; // 0x20
		private bool NUnAFZNgoriwvYnCEOYspThIrYA; // 0x28
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf; // 0x29
		private readonly object LDIUDxOFIHmhoGKTvvlJSXkNUPM; // 0x30
		private WriteReportDelegate HEgjuvZijrWXvOAIxbOndYyURkQ; // 0x38
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x40
	
		// Nested types
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public delegate bool WriteReportDelegate(OutputReport report); // TypeDefIndex: 6423; 0x0000000180624690-0x00000001806249F0
	
		private class DrHLvjnvTTknYFnktcrVhAQheyGc : IDisposable // TypeDefIndex: 6424
		{
			// Fields
			private bool UbQmsMhFekjpVDPCvnDnrKeBNzuu; // 0x10
			private OutputReport oZJbgoAOlHYIXutCUylvmnwdvgz; // 0x18
			private NativeBuffer BrhnIpAksXpIZLaJirMAeckHzoH; // 0x38
			private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x40
	
			// Properties
			public bool IhWEnIFVuDyazFmjklrXhcvAmzE { get; } // 0x0000000180375540-0x0000000180375550 
	
			// Constructors
			public DrHLvjnvTTknYFnktcrVhAQheyGc(); // 0x000000018060FE60-0x000000018060FEC0
	
			// Methods
			public void rxAOKBLMTWgMzrijKIidEGrGCWU(ref OutputReport param_0000d49a); // 0x000000018060FF20-0x00000001806100D0
			public OutputReport gHXexNlgacQDAWJhRPJcdPtZjex(); // 0x000000018060FEC0-0x000000018060FEF0
			public OutputReport lgNDoAhxnVQYAPmPcQZvSDmAwIjb(); // 0x000000018060FEF0-0x000000018060FF20
			public void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x00000001806100D0-0x0000000180610120
			public void Dispose(); // 0x000000018060FD90-0x000000018060FE00
			~DrHLvjnvTTknYFnktcrVhAQheyGc(); // 0x000000018036D110-0x000000018036D1B0
			protected virtual void HpvXOLYMqgpVKJfbWRtmjedASDv(bool param_0000d49b); // 0x000000018060FE00-0x000000018060FE60
		}
	
		// Constructors
		public HidOutputReportHandler(WriteReportDelegate writeReportDelegate); // 0x000000018061EA50-0x000000018061EC30
	
		// Methods
		public void WriteReport(OutputReport report); // 0x000000018061E850-0x000000018061EA50
		public void Clear(); // 0x000000018061DF40-0x000000018061E2B0
		private bool DeRyKKaIFeIgBBjcstmktRxedrNm(); // 0x000000018061E4C0-0x000000018061E520
		private bool DAtaDXybNYHmfIBvCpqNGFfILOkf(); // 0x000000018061E2B0-0x000000018061E4C0
		private void gcMjCWTnmpCCVGMaFjVqkmEAlMtg(); // 0x000000018061EC30-0x000000018061ED90
		private void GshAplbZbVrYYVEuAvEkHODFItn(); // 0x00000001803581E0-0x00000001803581F0
		private void AVdWEmsfgXsrMuQhVoSUnjDCafF(); // 0x00000001803581E0-0x00000001803581F0
		private void NLJJNAtrdXKtsPILrseWHDPkKKr(); // 0x000000018061E6A0-0x000000018061E850
		public void Dispose(); // 0x000000018061E520-0x000000018061E590
		~HidOutputReportHandler(); // 0x000000018036D110-0x000000018036D1B0
		protected virtual void Dispose(bool disposing); // 0x000000018061E590-0x000000018061E6A0
	}
}
