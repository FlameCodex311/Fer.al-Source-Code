/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Drivers.Interfaces;
using Rewired.HID;
using Rewired.Utils.Classes.Data;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class RailDriverDriver : HIDDeviceDriver, IDisposable, IDriver_RailDriver // TypeDefIndex: 6410
	{
		// Fields
		private const int SXCnvSUfzkSiSZZMEBgvGimCHHDc = 1523; // Metadata: 0x00730033
		private const int MIPPHacrrActZxEOPbwJPoaHgQX = 210; // Metadata: 0x00730037
		private const int yPnzCDCUouValTYijrIjZkOzBoi = 50; // Metadata: 0x0073003B
		private const int qABrgFEjALgosESANWdsZwvFoEn = 44; // Metadata: 0x0073003F
		private const int oCnUkxqPzqiTDMRGjHGGsCuheDI = 6; // Metadata: 0x00730043
		private const int MgKqEWEhAJJmlWKWdAwWgZQhpSnn = 44; // Metadata: 0x00730047
		private const int FLrCYJHbvslPRwEjrTrqsIUiCUWW = 45; // Metadata: 0x0073004B
		private const int KyPCFAfgfiofaBpJSMCTlpCOZMPS = 46; // Metadata: 0x0073004F
		private const int LClhQgPHXQKvauRQFlfjZwYBVtk = 47; // Metadata: 0x00730053
		private const int eqqbPeVYDynUKiXIsBwMMBPqcvp = 48; // Metadata: 0x00730057
		private const int ZEipcodOoJhLqcszhPlKjxovLgMF = 49; // Metadata: 0x0073005B
		private const int SEnsVgQFSGrpwRoCEnQzySEHRSQ = 0; // Metadata: 0x0073005F
		private const int BKeETAgVDMDeYExCWBdJCeqZuYne = 15; // Metadata: 0x00730063
		private const int SfTsyyxPIZkxIuaXoTURnukHgjm = 9; // Metadata: 0x00730067
		private const int DdTAXzqDnWljgdGYWrdoTfOOGwm = 1; // Metadata: 0x0073006B
		private const int GAOPeoRCMOmyILukEJYDXyubPLK = 2; // Metadata: 0x0073006F
		private const int kjqNgGUJlHcIcIVyAPgfYEVKkuB = 3; // Metadata: 0x00730073
		private const int NuCSAqyaxZaFFARhIBrzVvyvUyE = 4; // Metadata: 0x00730077
		private const int aYLKzFUaZamZdzDNoMqsjJpVYCS = 5; // Metadata: 0x0073007B
		private const int ElcFNrHVUGoGRWwTsPgMpjdVnbS = 6; // Metadata: 0x0073007F
		private const int rSopJwiJCSwYGjOPaRUOlKJiBUli = 7; // Metadata: 0x00730083
		private const int BpvGEZkOLhPjIQfQeeHUDIunqVxD = 8; // Metadata: 0x00730087
		private const int PJlkWuhvsQlHkNIPUOYdvaitYLU = 14; // Metadata: 0x0073008B
		private const int FOYjSJapvofdCiakiFZGEnXnoTu = 3; // Metadata: 0x0073008F
		private const int CnybBHFvApCxFnaFefnbFbXXpNIj = 7; // Metadata: 0x00730093
		private readonly NativeBuffer opZNohkiMGYnLwvAgGWTlKZYMKU; // 0x58
		private readonly NativeBuffer bGwmQLshkzsZvTEvekXPlVbBfQZ; // 0x60
		private bool LNlAsuyZsRDRuKKmwIFPJLhgNaXz; // 0x68
		private byte[] utaxvOAPighrKujUifizdiNobRH; // 0x70
		private readonly OutputReport mItRKAnsahRlyYDrIigpMCrvyLj; // 0x78
		private readonly Func<OutputReport, bool> GIMKncRHOXHxWIVrhQZQpLQjIqU; // 0x98
		private readonly Action<OutputReport> zUUVhqwbAFbCuKMbuxukcRjFlmGe; // 0xA0
	
		// Properties
		public bool SpeakerEnabled { get; set; } // 0x0000000180622650-0x0000000180622660 0x0000000180622B80-0x0000000180622BF0
	
		// Nested types
		private enum AFxHdGfMvNhWIPlpkFLSAWJPfHRg // TypeDefIndex: 6411
		{
			DHOlrMeLFQUrhrciWPVesxlfgtQ = 0,
			HIiniPCUXVlnvbRIUhyVKcQvzjB = 1
		}
	
		// Constructors
		public RailDriverDriver(InitArgs initArgs); // 0x0000000180621F40-0x0000000180622650
	
		// Methods
		public void SetLEDDisplay(int digitIndex, byte digitBitValues); // 0x0000000180621D70-0x0000000180621E50
		public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues); // 0x0000000180621C60-0x0000000180621D70
		public override void Update(UpdateLoopType updateLoop); // 0x00000001803581E0-0x00000001803581F0
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp); // 0x00000001806219C0-0x0000000180621B60
		public override Controller.Extension CreateControllerExtension(); // 0x0000000180621790-0x00000001806217F0
		private bool STtZZcScRaSedwCGlozUlagaXNr(AFxHdGfMvNhWIPlpkFLSAWJPfHRg param_0000d454, SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d455); // 0x0000000180621B60-0x0000000180621C60
		private void xmtaawpaLafFNiSlNPCDoSJEbqh(AFxHdGfMvNhWIPlpkFLSAWJPfHRg param_0000d456); // 0x0000000180622BF0-0x0000000180622E90
		private bool WPZGMlGadzWGNkNNYCTxRoUawjbo(SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d457); // 0x0000000180621E50-0x0000000180621F40
		private void nxhcezssRzdcWxCszmkJAETEeBj(NativeBuffer param_0000d458, float param_0000d459); // 0x0000000180622660-0x0000000180622B80
		private void LMjlrIxnXrEhSIfGklJAMuSHCDA(HIDControllerElement[] param_0000d45a, NativeBuffer param_0000d45b, float param_0000d45c); // 0x00000001806218D0-0x00000001806219A0
		~RailDriverDriver(); // 0x00000001806105B0-0x0000000180610650
		protected override void Dispose(bool disposing); // 0x00000001806217F0-0x00000001806218D0
		public static bool Matches(int vid, int pid); // 0x00000001806219A0-0x00000001806219C0
	}
}
