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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal class DualShock4Driver : HIDDeviceDriver, IDisposable, IDriver_DualShock4 // TypeDefIndex: 6407
	{
		// Fields
		private const float PiGFndTLnSUCzMhgmEQlDlczrbt = 4f; // Metadata: 0x0072FF4C
		private const int yPnzCDCUouValTYijrIjZkOzBoi = 14; // Metadata: 0x0072FF50
		private const int gHoDAZBGMoBxErBGngmAckcknKLY = 2; // Metadata: 0x0072FF54
		private const int KrjpCsXuCFdbTORRAOtKvmkGEiZ = 0; // Metadata: 0x0072FF58
		private const int crsGAtILwmOgzyZgZZYBBDBKIlf = 1912; // Metadata: 0x0072FF5C
		private const int UQVPSaLpBciqjjmDPdNKlRoDtHn = 0; // Metadata: 0x0072FF60
		private const int vWNiZoybugHSHYUjelQVgDdckgi = 941; // Metadata: 0x0072FF64
		private const bool ZVDtcJzDDgDxDZembjqwPTffFjf = false; // Metadata: 0x0072FF68
		private const bool FuRpobCCAbNLHZKoqrIkWBGwwip = true; // Metadata: 0x0072FF69
		private const float pAzHEvkGapSPqiVeXWsqoATNFEkA = 2.5f; // Metadata: 0x0072FF6A
		private const int HwnbjuynQFAdgrQaOuGHjwiIJmf = 0; // Metadata: 0x0072FF6E
		private const int FFiHvFTyIcyhlboMNrhehMCRXpf = 0; // Metadata: 0x0072FF72
		private const int aNAFjJKdXImWljqNFSTsDWlNDmy = 1; // Metadata: 0x0072FF76
		private const int BzaWfjesAqKbjwFbBQsvbhpHzzp = 0; // Metadata: 0x0072FF7A
		private const int HOQQRyZVdaxICQOrsBulESyrBXl = 0; // Metadata: 0x0072FF7E
		private const int DjMQqOGvBLjDwDKiqtyAlSXJCBy = 0; // Metadata: 0x0072FF82
		private const int sUaHiXJXErvDdfBjUarpuXDAJaN = 1; // Metadata: 0x0072FF86
		private const int OQyxUCGTioIGdTmOOubEVncKiyE = 17; // Metadata: 0x0072FF8A
		private const int gRRRzPLeyJGbUaYrhNmHljqrMFcb = 0; // Metadata: 0x0072FF8E
		private const int NhjXZtRhzQjtfIgkHsMzAgqssXw = 2; // Metadata: 0x0072FF92
		private const int jcpOukCYTRKBqJGhjenbFCbHJwv = 64; // Metadata: 0x0072FF96
		private const int rhUTETHZBMRIDFGktJTyjaNbrdH = 78; // Metadata: 0x0072FF9A
		private const int KDjywAhqbsQFsLJQaWiOliqnSOO = 1; // Metadata: 0x0072FF9E
		private const int lexkYOvSZzEtKjmgvxuGurgBJqc = 2; // Metadata: 0x0072FFA2
		private const int elDUOmDgdYymQdwCdhFfmsuksFT = 3; // Metadata: 0x0072FFA6
		private const int wCeoZZmyIICGSrNTGfkAVRUwtxv = 4; // Metadata: 0x0072FFAA
		private const int CeHJGHRoAlIjbDigOJkIkaAMOAe = 8; // Metadata: 0x0072FFAE
		private const int BopDbbAEswKYMdBMZheGhNkfnjM = 9; // Metadata: 0x0072FFB2
		private const int PzZkJKhrEwPBTuUkkrUESmNBVEh = 5; // Metadata: 0x0072FFB6
		private const int RcAIpcDUFLUOCRXyhCOnHRAYONyH = 19; // Metadata: 0x0072FFBA
		private const int httUqyHeWurXHRYwzRsOcBrmKEN = 13; // Metadata: 0x0072FFBE
		private const int wdSPqgDyCXqZsrFIJHFWznctLSm = 35; // Metadata: 0x0072FFC2
		private const int DmMlqCiKPRpvFbdoLIPreDVNegE = 5; // Metadata: 0x0072FFC6
		private const int crYkNFiIRZUBIyHDWvEsYBhbGQg = 6; // Metadata: 0x0072FFCA
		private const int GKdQloORUHNPtxcHstdmuWxsDZD = 7; // Metadata: 0x0072FFCE
		private const int sSGhsmDgvNuHMhprjkgngffahhVh = 10; // Metadata: 0x0072FFD2
		private const int qWtvAigEJdRQGWBoagAVAEaJdDP = 30; // Metadata: 0x0072FFD6
		private const int JiBBVqAnbWayUBooihgKbWCBJSXU = 27; // Metadata: 0x0072FFDA
		private const byte gRXEWVINmxbGLwYEoSdoLJhEiGg = 200; // Metadata: 0x0072FFDE
		private const byte GLCApaqWSGcbyLoVjtlRJXEBBcy = 53; // Metadata: 0x0072FFDF
		private const byte tOItTmDbVFAFgHyWRWWXyneFbRH = 255; // Metadata: 0x0072FFE0
		private const byte yfKcIVfWKSDfEjXaQxGIfDsTsqT = 0; // Metadata: 0x0072FFE1
		private const bool xNhjYFxzfglQPMdtzYTEeocvcZZE = true; // Metadata: 0x0072FFE2
		private const bool DhOEUeGsfjHIOfgDQcyoMSeDCey = true; // Metadata: 0x0072FFE3
		private const bool flBFIEogoZDBdtppKNNrHcNLhFE = false; // Metadata: 0x0072FFE4
		private const bool MirerWEMJyzUwTfdVKlpZDWVKxe = true; // Metadata: 0x0072FFE5
		private const int bOUSQjkQXejIhKqgJKbkRkppkvx = 25; // Metadata: 0x0072FFE6
		private const bool xroMfgSsMnnUByHlnitLzdIJjTGg = true; // Metadata: 0x0072FFEA
		private const float EEUiwMoRtjeuafbvipGPTrFgZra = 8192f; // Metadata: 0x0072FFEB
		private const float NCnDfNFzhLTclwMxzZieFmfjZJZc = 4096f; // Metadata: 0x0072FFEF
		private const float kCfQwRNRZWIuUEpmVQXXsmibCVN = 16384f; // Metadata: 0x0072FFF3
		private const float jrcgeJOUAIgizczzRMkqrrKHFSMK = 16777216f; // Metadata: 0x0072FFF7
		private const float eHdvNbRiZaRlVOIRPEUIsdqbIdk = 268435460f; // Metadata: 0x0072FFFB
		private const float WaVHDcAuQkqWNDINuVvuaBDAIxr = 0.01999998f; // Metadata: 0x0072FFFF
		private const float TOLOPxQxKwrmoVczTTkxYVKIawu = 8192f; // Metadata: 0x00730003
		private const float gFWPqmCdZcpEBaCJqFkqbjJFbxG = 0.0009765625f; // Metadata: 0x00730007
		private const float mDyamlbNTVMynlvaIwQUHeiHsDyC = 0.05595291f; // Metadata: 0x0073000B
		private const float EKyPVWfiUypHVvnCGdahmutRcmCa = 0.98f; // Metadata: 0x0073000F
		private const float XYBqVsWjhaboihaFojcBMzivgCo = 45f; // Metadata: 0x00730013
		private const float medcDWAafCLDeRBKmvTWdjtziOgd = 10f; // Metadata: 0x00730017
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
		private bool isVibrating { get; } // 0x0000000180613C40-0x0000000180613D00 
		public float BatteryLevel { get; } // 0x0000000180614420-0x0000000180614490 
		public float LeftMotor { get; set; } // 0x0000000180614E90-0x0000000180614F00 0x0000000180616320-0x00000001806163D0
		public float RightMotor { get; set; } // 0x0000000180615050-0x00000001806150C0 0x00000001806166C0-0x0000000180616770
		public float LightColorR { get; set; } // 0x0000000180614FC0-0x0000000180615020 0x0000000180616520-0x00000001806165A0
		public float LightColorG { get; set; } // 0x0000000180614F60-0x0000000180614FC0 0x0000000180616470-0x0000000180616520
		public float LightColorB { get; set; } // 0x0000000180614F00-0x0000000180614F60 0x00000001806163D0-0x0000000180616470
		public float LightFlashOnDuration { get; set; } // 0x0000000180615030-0x0000000180615040 0x0000000180616630-0x00000001806166C0
		public float LightFlashOffDuration { get; set; } // 0x0000000180615020-0x0000000180615030 0x00000001806165A0-0x0000000180616630
		public Vector3 AccelerometerValue { get; } // 0x00000001806142F0-0x0000000180614420 
		public Vector3 AccelerometerValueRaw { get; } // 0x0000000180614150-0x00000001806142F0 
		public Vector3 GyroscopeValue { get; } // 0x0000000180614660-0x0000000180614A50 
		public Vector3 GyroscopeValueRaw { get; } // 0x0000000180614490-0x0000000180614660 
		public Vector3 LastGyroscopeValue { get; } // 0x0000000180614BF0-0x0000000180614E90 
		public Vector3 LastGyroscopeValueRaw { get; } // 0x0000000180614A50-0x0000000180614BF0 
		public Quaternion Orientation { get; } // 0x0000000180615040-0x0000000180615050 
		public int MaxTouches { get; } // 0x0000000180362180-0x0000000180362190 
	
		// Nested types
		private enum CcxSamzDLVbBjbOUDyZELlwQbwG // TypeDefIndex: 6408
		{
			xAomvonipbmXpporXoNBoOdfStq = 0,
			PVgcydSbNDROAuQJZlzSxFwdtoZ = 1,
			PocWozENsBwPujngorriXlJqKzh = 2
		}
	
		private enum ISEXaYLKrUwSsDCKfYxeYXIyLLD // TypeDefIndex: 6409
		{
			PoBZZNoYGVGuWkUBxQqhGBhFqWy = 0,
			jeDCkdtzztZnRAdYJyTaZiqoDkr = 1,
			PVgcydSbNDROAuQJZlzSxFwdtoZ = 2
		}
	
		// Constructors
		public DualShock4Driver(InitArgs initArgs); // 0x0000000180612590-0x0000000180613C40
	
		// Methods
		public void ResetOrientation(); // 0x0000000180612120-0x0000000180612180
		public int GetTouchCount(); // 0x0000000180610680-0x0000000180610780
		public bool IsTouchingAtIndex(int index); // 0x00000001806116A0-0x0000000180611730
		public bool IsTouchingAtTouchId(int touchId); // 0x0000000180611730-0x0000000180611780
		public int GetTouchIdAtIndex(int index); // 0x0000000180610780-0x0000000180610830
		public bool GetTouchPositionByIndex(int index, out Vector2 position); // 0x0000000180610B80-0x0000000180610CD0
		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position); // 0x0000000180610CD0-0x0000000180610EA0
		public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY); // 0x0000000180610830-0x0000000180610960
		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY); // 0x0000000180610960-0x0000000180610B80
		public void StopLightFlash(); // 0x00000001806121F0-0x0000000180612210
		public void StopVibration(); // 0x0000000180612210-0x00000001806122E0
		public override void Update(UpdateLoopType updateLoop); // 0x00000001806122F0-0x0000000180612430
		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, float timestamp); // 0x0000000180611B80-0x0000000180612120
		public override Controller.Extension CreateControllerExtension(); // 0x0000000180610130-0x0000000180610190
		private void whZeXfivRwxFMuTNeZKehdwmBKt(SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d418); // 0x0000000180616960-0x0000000180616990
		private bool STtZZcScRaSedwCGlozUlagaXNr(SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d419); // 0x0000000180612180-0x00000001806121F0
		private void xmtaawpaLafFNiSlNPCDoSJEbqh(); // 0x00000001806170D0-0x0000000180617BC0
		private bool WPZGMlGadzWGNkNNYCTxRoUawjbo(SBUIcpSIfZEbnLGolpTEtKWROEd param_0000d41a); // 0x0000000180612430-0x0000000180612560
		private void nxhcezssRzdcWxCszmkJAETEeBj(NativeBuffer param_0000d41b, float param_0000d41c); // 0x0000000180615AE0-0x0000000180616270
		private void LMjlrIxnXrEhSIfGklJAMuSHCDA(HIDControllerElement[] param_0000d41d, NativeBuffer param_0000d41e, float param_0000d41f); // 0x0000000180611870-0x0000000180611930
		private void ltYcfSjOphvSKzdBwCVRphcMgjp(); // 0x0000000180615810-0x0000000180615930
		private void eeVOLXnzlBYhUSLorajJKTtosmY(NativeBuffer param_0000d420); // 0x0000000180614060-0x0000000180614150
		private void gmAhEJPYfgmRbUAuCfEYRvFLFrm(); // 0x00000001806151B0-0x0000000180615590
		private void xAkpQbMntWLqPZjKxclDLtwZcFg(Vector3 param_0000d421, Vector3 param_0000d422); // 0x0000000180616990-0x00000001806170D0
		private static Quaternion OZDtwQwaiZiYzqydBAnVVjFbbKT(Quaternion param_0000d423, Vector3 param_0000d424); // 0x0000000180611960-0x0000000180611B80
		private static Vector3 mXRndyaiwUzFdfksPCGekcnQUaBK(Vector3 param_0000d425, Vector3 param_0000d426); // 0x0000000180615930-0x0000000180615AE0
		private Quaternion IgxNsIeoJPvisipGodsnBZescxQO(Quaternion param_0000d427, CcxSamzDLVbBjbOUDyZELlwQbwG param_0000d428); // 0x0000000180611230-0x0000000180611460
		public static Quaternion Inverse(Quaternion quaternion); // 0x00000001806115D0-0x00000001806116A0
		private float kpiaNkpzJYHVauFjTxFhxHJRUkf(float param_0000d42a, float param_0000d42b); // 0x0000000180615770-0x0000000180615810
		private Vector3 glSrmSnNYfrsxScMjcynYaaQkzR(Vector3 param_0000d42c, float param_0000d42d = 0f /* Metadata: 0x0072FF40 */); // 0x00000001806150C0-0x00000001806151B0
		private Quaternion vifkLlEduLcOsdUYoOUINnhwtZfI(Vector3 param_0000d42e, float param_0000d42f = 0f /* Metadata: 0x0072FF44 */); // 0x0000000180616770-0x00000001806168A0
		private Quaternion kQUXcFQVCsSQDpBqkNHLzrykcue(Vector3 param_0000d430, float param_0000d431 = 0f /* Metadata: 0x0072FF48 */); // 0x0000000180615590-0x0000000180615770
		private float GQUpjntVDHedlxMmlUIlMKzSGAm(Vector3 param_0000d432); // 0x0000000180610650-0x0000000180610680
		private bool XdvdeeCJakiVRJfPsRyxGRTQJvxF(float param_0000d433); // 0x0000000180612560-0x0000000180612580
		private bool KDDRRIMPQkxTJjqVLcFejacXyVp(Vector3 param_0000d434, out ISEXaYLKrUwSsDCKfYxeYXIyLLD param_0000d435); // 0x0000000180611780-0x0000000180611870
		private bool ofCnKygwiaKWGeFzyCeobZwGghT(Vector3 param_0000d436); // 0x0000000180616270-0x0000000180616320
		private bool ZGmhRfKIHBGEBOjlxhGEkfAtanL(Vector3 param_0000d437); // 0x00000001803C28F0-0x00000001803C2900
		private Vector3 wMNgJRrudGAWubGHyAWxyCZGiRK(float[] param_0000d438); // 0x00000001806168A0-0x0000000180616960
		private Vector3 cXLjRmmfCEMdyWhIZBaghglIYrM(ExpandableArray_DataContainer<HIDGyroscope.MHFgKytqZWorXhVxTJLZCCoNZhX> param_0000d439); // 0x0000000180613DF0-0x0000000180614060
		private Vector3 cXLjRmmfCEMdyWhIZBaghglIYrM(Vector3 param_0000d43a, float param_0000d43b); // 0x0000000180613D00-0x0000000180613DF0
		private int YPGenAfUkaGjJawPDPPonblNlOE(int param_0000d43c); // 0x0000000180612580-0x0000000180612590
		private void IhqbZzQkTyfKzMUpJdEZQQOYAdS(byte[] param_0000d43d, float[] param_0000d43e); // 0x0000000180611460-0x00000001806115D0
		private void FWllakxzsKClZIphbcdGNnYyTpn(byte[] param_0000d43f, float[] param_0000d440); // 0x00000001806104B0-0x00000001806105B0
		private float AZewDUjOfTFTWHFyIlpdAwDodXq(); // 0x0000000180610120-0x0000000180610130
		private void HegkzGpWZGxDjSJtYtjBVVqnBhj(NativeBuffer param_0000d441, HIDTouchpad.TouchData[] param_0000d442); // 0x0000000180610EA0-0x0000000180611230
		private int DFDDkfzkXwkDBObizwgVmiajVLK(int param_0000d443, bool param_0000d444, int param_0000d445); // 0x0000000180610190-0x0000000180610380
		private void UZTfLyGQpDDqCwcKMvJouKKXhMbA(); // 0x00000001806122E0-0x00000001806122F0
		~DualShock4Driver(); // 0x00000001806105B0-0x0000000180610650
		protected override void Dispose(bool disposing); // 0x0000000180610380-0x00000001806104B0
		public static bool Matches(int vid, int pid); // 0x0000000180611930-0x0000000180611960
	}
}
