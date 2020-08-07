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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class RailDriverDriver : HIDDeviceDriver, IDisposable, IDriver_RailDriver // TypeDefIndex: 6569
	{
		// Fields
		private const int SXCnvSUfzkSiSZZMEBgvGimCHHDc = 1523; // Metadata: 0x00764CD0
		private const int MIPPHacrrActZxEOPbwJPoaHgQX = 210; // Metadata: 0x00764CD4
		private const int yPnzCDCUouValTYijrIjZkOzBoi = 50; // Metadata: 0x00764CD8
		private const int qABrgFEjALgosESANWdsZwvFoEn = 44; // Metadata: 0x00764CDC
		private const int oCnUkxqPzqiTDMRGjHGGsCuheDI = 6; // Metadata: 0x00764CE0
		private const int MgKqEWEhAJJmlWKWdAwWgZQhpSnn = 44; // Metadata: 0x00764CE4
		private const int FLrCYJHbvslPRwEjrTrqsIUiCUWW = 45; // Metadata: 0x00764CE8
		private const int KyPCFAfgfiofaBpJSMCTlpCOZMPS = 46; // Metadata: 0x00764CEC
		private const int LClhQgPHXQKvauRQFlfjZwYBVtk = 47; // Metadata: 0x00764CF0
		private const int eqqbPeVYDynUKiXIsBwMMBPqcvp = 48; // Metadata: 0x00764CF4
		private const int ZEipcodOoJhLqcszhPlKjxovLgMF = 49; // Metadata: 0x00764CF8
		private const int SEnsVgQFSGrpwRoCEnQzySEHRSQ = 0; // Metadata: 0x00764CFC
		private const int BKeETAgVDMDeYExCWBdJCeqZuYne = 15; // Metadata: 0x00764D00
		private const int SfTsyyxPIZkxIuaXoTURnukHgjm = 9; // Metadata: 0x00764D04
		private const int DdTAXzqDnWljgdGYWrdoTfOOGwm = 1; // Metadata: 0x00764D08
		private const int GAOPeoRCMOmyILukEJYDXyubPLK = 2; // Metadata: 0x00764D0C
		private const int kjqNgGUJlHcIcIVyAPgfYEVKkuB = 3; // Metadata: 0x00764D10
		private const int NuCSAqyaxZaFFARhIBrzVvyvUyE = 4; // Metadata: 0x00764D14
		private const int aYLKzFUaZamZdzDNoMqsjJpVYCS = 5; // Metadata: 0x00764D18
		private const int ElcFNrHVUGoGRWwTsPgMpjdVnbS = 6; // Metadata: 0x00764D1C
		private const int rSopJwiJCSwYGjOPaRUOlKJiBUli = 7; // Metadata: 0x00764D20
		private const int BpvGEZkOLhPjIQfQeeHUDIunqVxD = 8; // Metadata: 0x00764D24
		private const int PJlkWuhvsQlHkNIPUOYdvaitYLU = 14; // Metadata: 0x00764D28
		private const int FOYjSJapvofdCiakiFZGEnXnoTu = 3; // Metadata: 0x00764D2C
		private const int CnybBHFvApCxFnaFefnbFbXXpNIj = 7; // Metadata: 0x00764D30
		private readonly NativeBuffer opZNohkiMGYnLwvAgGWTlKZYMKU; // 0x58
		private readonly NativeBuffer bGwmQLshkzsZvTEvekXPlVbBfQZ; // 0x60
		private bool LNlAsuyZsRDRuKKmwIFPJLhgNaXz; // 0x68
		private byte[] utaxvOAPighrKujUifizdiNobRH; // 0x70
		private readonly OutputReport mItRKAnsahRlyYDrIigpMCrvyLj; // 0x78
		private readonly Func<OutputReport, bool> GIMKncRHOXHxWIVrhQZQpLQjIqU; // 0x98
		private readonly Action<OutputReport> zUUVhqwbAFbCuKMbuxukcRjFlmGe; // 0xA0
	
		// Properties
		public bool SpeakerEnabled { get; set; } // 0x000000018037D390-0x000000018037D3A0 0x0000000180E66700-0x0000000180E66770
	
		// Nested types
		private enum AFxHdGfMvNhWIPlpkFLSAWJPfHRg // TypeDefIndex: 6570
		{
			DHOlrMeLFQUrhrciWPVesxlfgtQ = 0,
			HIiniPCUXVlnvbRIUhyVKcQvzjB = 1
		}
	
		// Constructors
		public RailDriverDriver(InitArgs initArgs); // 0x0000000180E65B40-0x0000000180E66220
	
		// Methods
		public void SetLEDDisplay(int digitIndex, byte digitBitValues); // 0x0000000180E65980-0x0000000180E65A50
		public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues); // 0x0000000180E65880-0x0000000180E65980
		public override void Update(UpdateLoopType updateLoop); // 0x00000001803774A0-0x00000001803774B0
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp); // 0x0000000180E655F0-0x0000000180E65780
		public override Controller.Extension CreateControllerExtension(); // 0x0000000180E653D0-0x0000000180E65430
		private bool STtZZcScRaSedwCGlozUlagaXNr(AFxHdGfMvNhWIPlpkFLSAWJPfHRg param_0000d6c4, SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d6c5); // 0x0000000180E65780-0x0000000180E65880
		private void xmtaawpaLafFNiSlNPCDoSJEbqh(AFxHdGfMvNhWIPlpkFLSAWJPfHRg param_0000d6c6); // 0x0000000180E66770-0x0000000180E669F0
		private bool WPZGMlGadzWGNkNNYCTxRoUawjbo(SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d6c7); // 0x0000000180E65A50-0x0000000180E65B40
		private void nxhcezssRzdcWxCszmkJAETEeBj(NativeBuffer param_0000d6c8, float param_0000d6c9); // 0x0000000180E66220-0x0000000180E66700
		private void LMjlrIxnXrEhSIfGklJAMuSHCDA(HIDControllerElement[] param_0000d6ca, NativeBuffer param_0000d6cb, float param_0000d6cc); // 0x0000000180E65510-0x0000000180E655D0
		~RailDriverDriver(); // 0x0000000180E54840-0x0000000180E548E0
		protected override void Dispose(bool disposing); // 0x0000000180E65430-0x0000000180E65510
		public static bool Matches(int vid, int pid); // 0x0000000180E655D0-0x0000000180E655F0
	}
}
