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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class HidOutputReportHandler : IDisposable // TypeDefIndex: 6581
	{
		// Fields
		private const bool fWmDoloMFHDDVIbfZVBisbHgLpHP = false; // Metadata: 0x00764D61
		private const int GpkMENyeblGIPtQZcxjoOtAVKtI = 100; // Metadata: 0x00764D62
		private const int kTpxyUYSXgdGUetuYSrNXkITdOE = 10000; // Metadata: 0x00764D66
		private ThreadHelper habGSklQHfgBqWkyroQbBEtCUJR; // 0x10
		private DrHLvjnvTTknYFnktcrVhAQheyGc BrhnIpAksXpIZLaJirMAeckHzoH; // 0x18
		private DrHLvjnvTTknYFnktcrVhAQheyGc jmZtZVHRXuRrZicJYgdjnNeOLtD; // 0x20
		private bool NUnAFZNgoriwvYnCEOYspThIrYA; // 0x28
		private bool ZjOOLblNcYQwrXXNEEJgJyiCsWf; // 0x29
		private readonly object LDIUDxOFIHmhoGKTvvlJSXkNUPM; // 0x30
		private WriteReportDelegate HEgjuvZijrWXvOAIxbOndYyURkQ; // 0x38
		private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x40
	
		// Nested types
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public delegate bool WriteReportDelegate(OutputReport report); // TypeDefIndex: 6582; 0x00000001804D68D0-0x00000001804D6C90
	
		private class DrHLvjnvTTknYFnktcrVhAQheyGc : IDisposable // TypeDefIndex: 6583
		{
			// Fields
			private bool UbQmsMhFekjpVDPCvnDnrKeBNzuu; // 0x10
			private OutputReport oZJbgoAOlHYIXutCUylvmnwdvgz; // 0x18
			private NativeBuffer BrhnIpAksXpIZLaJirMAeckHzoH; // 0x38
			private bool vEblpmllYIOuQHCXVghuIpihdSG; // 0x40
	
			// Properties
			public bool IhWEnIFVuDyazFmjklrXhcvAmzE { get; } // 0x00000001803FD450-0x00000001803FD460 
	
			// Constructors
			public DrHLvjnvTTknYFnktcrVhAQheyGc(); // 0x0000000180E54120-0x0000000180E54180
	
			// Methods
			public void rxAOKBLMTWgMzrijKIidEGrGCWU(ref OutputReport param_0000d70a); // 0x0000000180E541E0-0x0000000180E54390
			public OutputReport gHXexNlgacQDAWJhRPJcdPtZjex(); // 0x0000000180E54180-0x0000000180E541B0
			public OutputReport lgNDoAhxnVQYAPmPcQZvSDmAwIjb(); // 0x0000000180E541B0-0x0000000180E541E0
			public void vMfAexzdpfzhXKkyGdAHmJVnQEr(); // 0x0000000180E54390-0x0000000180E543E0
			public void Dispose(); // 0x0000000180E54050-0x0000000180E540C0
			~DrHLvjnvTTknYFnktcrVhAQheyGc(); // 0x000000018041BC40-0x000000018041BCE0
			protected virtual void HpvXOLYMqgpVKJfbWRtmjedASDv(bool param_0000d70b); // 0x0000000180E540C0-0x0000000180E54120
		}
	
		// Constructors
		public HidOutputReportHandler(WriteReportDelegate writeReportDelegate); // 0x0000000180E62740-0x0000000180E62920
	
		// Methods
		public void WriteReport(OutputReport report); // 0x0000000180E62540-0x0000000180E62740
		public void Clear(); // 0x0000000180E61C60-0x0000000180E61FB0
		private bool DeRyKKaIFeIgBBjcstmktRxedrNm(); // 0x0000000180E621C0-0x0000000180E62220
		private bool DAtaDXybNYHmfIBvCpqNGFfILOkf(); // 0x0000000180E61FB0-0x0000000180E621C0
		private void gcMjCWTnmpCCVGMaFjVqkmEAlMtg(); // 0x0000000180E62920-0x0000000180E62A70
		private void GshAplbZbVrYYVEuAvEkHODFItn(); // 0x00000001803774A0-0x00000001803774B0
		private void AVdWEmsfgXsrMuQhVoSUnjDCafF(); // 0x00000001803774A0-0x00000001803774B0
		private void NLJJNAtrdXKtsPILrseWHDPkKKr(); // 0x0000000180E62390-0x0000000180E62540
		public void Dispose(); // 0x0000000180E62220-0x0000000180E62290
		~HidOutputReportHandler(); // 0x000000018041BC40-0x000000018041BCE0
		protected virtual void Dispose(bool disposing); // 0x0000000180E62290-0x0000000180E62390
	}
}
