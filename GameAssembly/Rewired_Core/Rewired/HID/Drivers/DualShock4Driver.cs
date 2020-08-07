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
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class DualShock4Driver : HIDDeviceDriver, IDisposable, IDriver_DualShock4 // TypeDefIndex: 6566
	{
		// Fields
		private const float PiGFndTLnSUCzMhgmEQlDlczrbt = 4f; // Metadata: 0x00764BE9
		private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x00764BED
		private const int gHoDAZBGMoBxErBGngmAckcknKLY = 2; // Metadata: 0x00764BF1
		private const int KrjpCsXuCFdbTORRAOtKvmkGEiZ = 0; // Metadata: 0x00764BF5
		private const int crsGAtILwmOgzyZgZZYBBDBKIlf = 1912; // Metadata: 0x00764BF9
		private const int UQVPSaLpBciqjjmDPdNKlRoDtHn = 0; // Metadata: 0x00764BFD
		private const int vWNiZoybugHSHYUjelQVgDdckgi = 941; // Metadata: 0x00764C01
		private const bool ZVDtcJzDDgDxDZembjqwPTffFjf = false; // Metadata: 0x00764C05
		private const bool FuRpobCCAbNLHZKoqrIkWBGwwip = true; // Metadata: 0x00764C06
		private const float pAzHEvkGapSPqiVeXWsqoATNFEkA = 2.5f; // Metadata: 0x00764C07
		private const int HwnbjuynQFAdgrQaOuGHjwiIJmf = 0; // Metadata: 0x00764C0B
		private const int FFiHvFTyIcyhlboMNrhehMCRXpf = 0; // Metadata: 0x00764C0F
		private const int aNAFjJKdXImWljqNFSTsDWlNDmy = 1; // Metadata: 0x00764C13
		private const int BzaWfjesAqKbjwFbBQsvbhpHzzp = 0; // Metadata: 0x00764C17
		private const int HOQQRyZVdaxICQOrsBulESyrBXl = 0; // Metadata: 0x00764C1B
		private const int DjMQqOGvBLjDwDKiqtyAlSXJCBy = 0; // Metadata: 0x00764C1F
		private const int sUaHiXJXErvDdfBjUarpuXDAJaN = 1; // Metadata: 0x00764C23
		private const int OQyxUCGTioIGdTmOOubEVncKiyE = 17; // Metadata: 0x00764C27
		private const int gRRRzPLeyJGbUaYrhNmHljqrMFcb = 0; // Metadata: 0x00764C2B
		private const int NhjXZtRhzQjtfIgkHsMzAgqssXw = 2; // Metadata: 0x00764C2F
		private const int jcpOukCYTRKBqJGhjenbFCbHJwv = 64; // Metadata: 0x00764C33
		private const int rhUTETHZBMRIDFGktJTyjaNbrdH = 78; // Metadata: 0x00764C37
		private const int KDjywAhqbsQFsLJQaWiOliqnSOO = 1; // Metadata: 0x00764C3B
		private const int lexkYOvSZzEtKjmgvxuGurgBJqc = 2; // Metadata: 0x00764C3F
		private const int elDUOmDgdYymQdwCdhFfmsuksFT = 3; // Metadata: 0x00764C43
		private const int wCeoZZmyIICGSrNTGfkAVRUwtxv = 4; // Metadata: 0x00764C47
		private const int CeHJGHRoAlIjbDigOJkIkaAMOAe = 8; // Metadata: 0x00764C4B
		private const int BopDbbAEswKYMdBMZheGhNkfnjM = 9; // Metadata: 0x00764C4F
		private const int PzZkJKhrEwPBTuUkkrUESmNBVEh = 5; // Metadata: 0x00764C53
		private const int RcAIpcDUFLUOCRXyhCOnHRAYONyH = 19; // Metadata: 0x00764C57
		private const int httUqyHeWurXHRYwzRsOcBrmKEN = 13; // Metadata: 0x00764C5B
		private const int wdSPqgDyCXqZsrFIJHFWznctLSm = 35; // Metadata: 0x00764C5F
		private const int DmMlqCiKPRpvFbdoLIPreDVNegE = 5; // Metadata: 0x00764C63
		private const int crYkNFiIRZUBIyHDWvEsYBhbGQg = 6; // Metadata: 0x00764C67
		private const int GKdQloORUHNPtxcHstdmuWxsDZD = 7; // Metadata: 0x00764C6B
		private const int sSGhsmDgvNuHMhprjkgngffahhVh = 10; // Metadata: 0x00764C6F
		private const int qWtvAigEJdRQGWBoagAVAEaJdDP = 30; // Metadata: 0x00764C73
		private const int JiBBVqAnbWayUBooihgKbWCBJSXU = 27; // Metadata: 0x00764C77
		private const byte gRXEWVINmxbGLwYEoSdoLJhEiGg = 200; // Metadata: 0x00764C7B
		private const byte GLCApaqWSGcbyLoVjtlRJXEBBcy = 53; // Metadata: 0x00764C7C
		private const byte tOItTmDbVFAFgHyWRWWXyneFbRH = 255; // Metadata: 0x00764C7D
		private const byte yfKcIVfWKSDfEjXaQxGIfDsTsqT = 0; // Metadata: 0x00764C7E
		private const bool xNhjYFxzfglQPMdtzYTEeocvcZZE = true; // Metadata: 0x00764C7F
		private const bool DhOEUeGsfjHIOfgDQcyoMSeDCey = true; // Metadata: 0x00764C80
		private const bool flBFIEogoZDBdtppKNNrHcNLhFE = false; // Metadata: 0x00764C81
		private const bool MirerWEMJyzUwTfdVKlpZDWVKxe = true; // Metadata: 0x00764C82
		private const int bOUSQjkQXejIhKqgJKbkRkppkvx = 25; // Metadata: 0x00764C83
		private const bool xroMfgSsMnnUByHlnitLzdIJjTGg = true; // Metadata: 0x00764C87
		private const float EEUiwMoRtjeuafbvipGPTrFgZra = 8192f; // Metadata: 0x00764C88
		private const float NCnDfNFzhLTclwMxzZieFmfjZJZc = 4096f; // Metadata: 0x00764C8C
		private const float kCfQwRNRZWIuUEpmVQXXsmibCVN = 16384f; // Metadata: 0x00764C90
		private const float jrcgeJOUAIgizczzRMkqrrKHFSMK = 16777216f; // Metadata: 0x00764C94
		private const float eHdvNbRiZaRlVOIRPEUIsdqbIdk = 268435460f; // Metadata: 0x00764C98
		private const float WaVHDcAuQkqWNDINuVvuaBDAIxr = 0.01999998f; // Metadata: 0x00764C9C
		private const float TOLOPxQxKwrmoVczTTkxYVKIawu = 8192f; // Metadata: 0x00764CA0
		private const float gFWPqmCdZcpEBaCJqFkqbjJFbxG = 0.0009765625f; // Metadata: 0x00764CA4
		private const float mDyamlbNTVMynlvaIwQUHeiHsDyC = 0.05595291f; // Metadata: 0x00764CA8
		private const float EKyPVWfiUypHVvnCGdahmutRcmCa = 0.98f; // Metadata: 0x00764CAC
		private const float XYBqVsWjhaboihaFojcBMzivgCo = 45f; // Metadata: 0x00764CB0
		private const float medcDWAafCLDeRBKmvTWdjtziOgd = 10f; // Metadata: 0x00764CB4
		private readonly bool IhlGCfAoauXIaGqgprCclpysuVHM; // 0x58
		private readonly int BUMzWXEOFmIRPoWgBNJDLchwuqp; // 0x5C
		private readonly int HDiKNUYtqzrrqCVEXbFtEdEhwHz; // 0x60
		private readonly bool TQskGMETlYDPbDBWtkyupzTgrcM; // 0x64
		private readonly byte UsgaDeDHqjJirMRAUYMYwoQgWpEx; // 0x65
		private readonly int GJMrjKTWgsnGyzToEcayzhDgjUU; // 0x68
		private readonly int ynmbAHmTASdkPGdsGSpsCsQQwjyw; // 0x6C
		private readonly int MkThdjyKzwtBOjbwSolJrEHfyeN; // 0x70
		private readonly int UEEAjdFzqhoZKHeIXpvPeGURzJfv; // 0x74
		private readonly int ZOsAXEbftaZzbKKigjlRAOgidRGC; // 0x78
		private readonly int nzUxZwgnyxlcWHGgGNiyFUGupcQ; // 0x7C
		private readonly NativeBuffer opZNohkiMGYnLwvAgGWTlKZYMKU; // 0x80
		private readonly NativeBuffer bGwmQLshkzsZvTEvekXPlVbBfQZ; // 0x88
		private readonly OutputReport mItRKAnsahRlyYDrIigpMCrvyLj; // 0x90
		private readonly Func<OutputReport, bool> GIMKncRHOXHxWIVrhQZQpLQjIqU; // 0xB0
		private readonly Action<OutputReport> zUUVhqwbAFbCuKMbuxukcRjFlmGe; // 0xB8
		private bool viAyhMbVQPFuhhveSKOFsEUsaoR; // 0xC0
		private bool nyuJgSiiVZdEbZMuzEAmuWNYgCjG; // 0xC1
		private float AsuRMglpfyDkOdSWajJQrdtxHFUC; // 0xC4
		private byte uPFReEAQavKWkqSyKpuuEvIRGER; // 0xC8
		private Quaternion ZUmHOvOaiTkmkqMhBzCQsCgHJrF; // 0xCC
		private ushort sDmIYarUtEZfciQqRxcCaflJYoi; // 0xDC
		private float ZODaNAJNsJTxaCkHcmFGwAHtBDf; // 0xE0
		private float DoJICLJLQXjKHOftTXsCcbFPZQs; // 0xE4
		private float mrzEMvYFSOiJGWyEFpCfjgHSMy; // 0xE8
		private byte QrJOiDMgczZqDRzKBUlTOivjVxn; // 0xEC
		private byte nNyACKkPqVIYWTTmNtKGMvXpbdp; // 0xED
		private Quaternion XrxbgmJGKAHQFnOkAEugkQVeNoC; // 0xF0
		private bool SVSaOlvkKMaBDuqnTwwLPAMrHFKK; // 0x100
		private int VwAgKOJRYcPSKJxMGblUyPdimdC; // 0x104
		private int[] NNcsawzCrIzCbspQCrsAElLdEvg; // 0x108
		private int[] oWBStAVKKGbIDApbnwixaIcdtKhb; // 0x110
	
		// Properties
		private bool isVibrating { get; } // 0x0000000180E57D80-0x0000000180E57E30 
		public float BatteryLevel { get; } // 0x0000000180E58510-0x0000000180E58580 
		public float LeftMotor { get; set; } // 0x0000000180E58F10-0x0000000180E58F80 0x0000000180E5A2C0-0x0000000180E5A370
		public float RightMotor { get; set; } // 0x0000000180E590A0-0x0000000180E59110 0x0000000180E5A650-0x0000000180E5A700
		public float LightColorR { get; set; } // 0x0000000180E59020-0x0000000180E59070 0x0000000180E5A4B0-0x0000000180E5A530
		public float LightColorG { get; set; } // 0x0000000180E58FD0-0x0000000180E59020 0x0000000180E5A400-0x0000000180E5A4B0
		public float LightColorB { get; set; } // 0x0000000180E58F80-0x0000000180E58FD0 0x0000000180E5A370-0x0000000180E5A400
		public float LightFlashOnDuration { get; set; } // 0x0000000180E59080-0x0000000180E59090 0x0000000180E5A5C0-0x0000000180E5A650
		public float LightFlashOffDuration { get; set; } // 0x0000000180E59070-0x0000000180E59080 0x0000000180E5A530-0x0000000180E5A5C0
		public Vector3 AccelerometerValue { get; } // 0x0000000180E58400-0x0000000180E58510 
		public Vector3 AccelerometerValueRaw { get; } // 0x0000000180E58280-0x0000000180E58400 
		public Vector3 GyroscopeValue { get; } // 0x0000000180E58730-0x0000000180E58B10 
		public Vector3 GyroscopeValueRaw { get; } // 0x0000000180E58580-0x0000000180E58730 
		public Vector3 LastGyroscopeValue { get; } // 0x0000000180E58C90-0x0000000180E58F10 
		public Vector3 LastGyroscopeValueRaw { get; } // 0x0000000180E58B10-0x0000000180E58C90 
		public Quaternion Orientation { get; } // 0x0000000180E59090-0x0000000180E590A0 
		public int MaxTouches { get; } // 0x0000000180411150-0x0000000180411160 
	
		// Nested types
		private enum CcxSamzDLVbBjbOUDyZELlwQbwG // TypeDefIndex: 6567
		{
			xAomvonipbmXpporXoNBoOdfStq = 0,
			PVgcydSbNDROAuQJZlzSxFwdtoZ = 1,
			PocWozENsBwPujngorriXlJqKzh = 2
		}
	
		private enum ISEXaYLKrUwSsDCKfYxeYXIyLLD // TypeDefIndex: 6568
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
			jeDCkdtzztZnRAdYJyTaZiqoDkr = 1,
			PVgcydSbNDROAuQJZlzSxFwdtoZ = 2
		}
	
		// Constructors
		public DualShock4Driver(InitArgs initArgs); // 0x0000000180E56760-0x0000000180E57D80
	
		// Methods
		public void ResetOrientation(); // 0x0000000180E56300-0x0000000180E56360
		public int GetTouchCount(); // 0x0000000180E54910-0x0000000180E54A00
		public bool IsTouchingAtIndex(int index); // 0x0000000180E558B0-0x0000000180E55930
		public bool IsTouchingAtTouchId(int touchId); // 0x0000000180E55930-0x0000000180E55980
		public int GetTouchIdAtIndex(int index); // 0x0000000180E54A00-0x0000000180E54AB0
		public bool GetTouchPositionByIndex(int index, out Vector2 position); // 0x0000000180E54DE0-0x0000000180E54F20
		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position); // 0x0000000180E54F20-0x0000000180E550E0
		public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY); // 0x0000000180E54AB0-0x0000000180E54BD0
		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY); // 0x0000000180E54BD0-0x0000000180E54DE0
		public void StopLightFlash(); // 0x0000000180E563D0-0x0000000180E563F0
		public void StopVibration(); // 0x0000000180E563F0-0x0000000180E564B0
		public override void Update(UpdateLoopType updateLoop); // 0x0000000180E564C0-0x0000000180E56600
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp); // 0x0000000180E55D80-0x0000000180E56300
		public override Controller.Extension CreateControllerExtension(); // 0x0000000180E543E0-0x0000000180E54440
		private void whZeXfivRwxFMuTNeZKehdwmBKt(SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d688); // 0x0000000180E5A8E0-0x0000000180E5A910
		private bool STtZZcScRaSedwCGlozUlagaXNr(SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d689); // 0x0000000180E56360-0x0000000180E563D0
		private void xmtaawpaLafFNiSlNPCDoSJEbqh(); // 0x0000000180E5B050-0x0000000180E5BAF0
		private bool WPZGMlGadzWGNkNNYCTxRoUawjbo(SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d68a); // 0x0000000180E56600-0x0000000180E56730
		private void nxhcezssRzdcWxCszmkJAETEeBj(NativeBuffer param_0000d68b, float param_0000d68c); // 0x0000000180E59AE0-0x0000000180E5A210
		private void LMjlrIxnXrEhSIfGklJAMuSHCDA(HIDControllerElement[] param_0000d68d, NativeBuffer param_0000d68e, float param_0000d68f); // 0x0000000180E55A70-0x0000000180E55B30
		private void ltYcfSjOphvSKzdBwCVRphcMgjp(); // 0x0000000180E59820-0x0000000180E59930
		private void eeVOLXnzlBYhUSLorajJKTtosmY(NativeBuffer param_0000d690); // 0x0000000180E58190-0x0000000180E58280
		private void gmAhEJPYfgmRbUAuCfEYRvFLFrm(); // 0x0000000180E59200-0x0000000180E595A0
		private void xAkpQbMntWLqPZjKxclDLtwZcFg(Vector3 param_0000d691, Vector3 param_0000d692); // 0x0000000180E5A910-0x0000000180E5B050
		private static Quaternion OZDtwQwaiZiYzqydBAnVVjFbbKT(Quaternion param_0000d693, Vector3 param_0000d694); // 0x0000000180E55B60-0x0000000180E55D80
		private static Vector3 mXRndyaiwUzFdfksPCGekcnQUaBK(Vector3 param_0000d695, Vector3 param_0000d696); // 0x0000000180E59930-0x0000000180E59AE0
		private Quaternion IgxNsIeoJPvisipGodsnBZescxQO(Quaternion param_0000d697, CcxSamzDLVbBjbOUDyZELlwQbwG param_0000d698); // 0x0000000180E55450-0x0000000180E55680
		public static Quaternion Inverse(Quaternion quaternion); // 0x0000000180E557E0-0x0000000180E558B0
		private float kpiaNkpzJYHVauFjTxFhxHJRUkf(float param_0000d69a, float param_0000d69b); // 0x0000000180E59780-0x0000000180E59820
		private Vector3 glSrmSnNYfrsxScMjcynYaaQkzR(Vector3 param_0000d69c, float param_0000d69d = 0f /* Metadata: 0x00764BDD */); // 0x0000000180E59110-0x0000000180E59200
		private Quaternion vifkLlEduLcOsdUYoOUINnhwtZfI(Vector3 param_0000d69e, float param_0000d69f = 0f /* Metadata: 0x00764BE1 */); // 0x0000000180E5A700-0x0000000180E5A830
		private Quaternion kQUXcFQVCsSQDpBqkNHLzrykcue(Vector3 param_0000d6a0, float param_0000d6a1 = 0f /* Metadata: 0x00764BE5 */); // 0x0000000180E595A0-0x0000000180E59780
		private float GQUpjntVDHedlxMmlUIlMKzSGAm(Vector3 param_0000d6a2); // 0x0000000180E548E0-0x0000000180E54910
		private bool XdvdeeCJakiVRJfPsRyxGRTQJvxF(float param_0000d6a3); // 0x0000000180E56730-0x0000000180E56750
		private bool KDDRRIMPQkxTJjqVLcFejacXyVp(Vector3 param_0000d6a4, out ISEXaYLKrUwSsDCKfYxeYXIyLLD param_0000d6a5); // 0x0000000180E55980-0x0000000180E55A70
		private bool ofCnKygwiaKWGeFzyCeobZwGghT(Vector3 param_0000d6a6); // 0x0000000180E5A210-0x0000000180E5A2C0
		private bool ZGmhRfKIHBGEBOjlxhGEkfAtanL(Vector3 param_0000d6a7); // 0x0000000180380950-0x0000000180380960
		private Vector3 wMNgJRrudGAWubGHyAWxyCZGiRK(float[] param_0000d6a8); // 0x0000000180E5A830-0x0000000180E5A8E0
		private Vector3 cXLjRmmfCEMdyWhIZBaghglIYrM(ExpandableArray_DataContainer<HIDGyroscope.MHFgKytqZWorXhVxTJLZCCoNZhX> param_0000d6a9); // 0x0000000180E57F20-0x0000000180E58190
		private Vector3 cXLjRmmfCEMdyWhIZBaghglIYrM(Vector3 param_0000d6aa, float param_0000d6ab); // 0x0000000180E57E30-0x0000000180E57F20
		private int YPGenAfUkaGjJawPDPPonblNlOE(int param_0000d6ac); // 0x0000000180E56750-0x0000000180E56760
		private void IhqbZzQkTyfKzMUpJdEZQQOYAdS(byte[] param_0000d6ad, float[] param_0000d6ae); // 0x0000000180E55680-0x0000000180E557E0
		private void FWllakxzsKClZIphbcdGNnYyTpn(byte[] param_0000d6af, float[] param_0000d6b0); // 0x0000000180E54740-0x0000000180E54840
		private float AZewDUjOfTFTWHFyIlpdAwDodXq(); // 0x000000018078A9F0-0x000000018078AA00
		private void HegkzGpWZGxDjSJtYtjBVVqnBhj(NativeBuffer param_0000d6b1, HIDTouchpad.TouchData[] param_0000d6b2); // 0x0000000180E550E0-0x0000000180E55450
		private int DFDDkfzkXwkDBObizwgVmiajVLK(int param_0000d6b3, bool param_0000d6b4, int param_0000d6b5); // 0x0000000180E54440-0x0000000180E54610
		private void UZTfLyGQpDDqCwcKMvJouKKXhMbA(); // 0x0000000180E564B0-0x0000000180E564C0
		~DualShock4Driver(); // 0x0000000180E54840-0x0000000180E548E0
		protected override void Dispose(bool disposing); // 0x0000000180E54610-0x0000000180E54740
		public static bool Matches(int vid, int pid); // 0x0000000180E55B30-0x0000000180E55B60
	}
}
