/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils.Classes.Utility;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

internal class ePGTCaURqwcphqnKHxpRBdGnTYZ : PlatformInputManager // TypeDefIndex: 6633
{
	// Fields
	private List<IILhtKYdQJUAQYDjlmjnSPmzNsB> YxWCMHbPaQgZcysPKFMIEybVXlg; // 0x38
	private int pCPGQSBvXdijKhpVimfqeELMEtfS; // 0x40
	private mSBBaCgFyvVKevGfajgjjZjtMyd VoNXLwsbUAMaIxrCOafEXDdBDZn; // 0x48
	private bool NPVBwLgCgrnzgKAeMRXkslmDNNe; // 0x50
	private UpdateLoopType bJLiMprynRavojxmnNIzynWbigw; // 0x54
	private UpdateLoopType DdtAyNHlIanXcVoBghiZktlJRTRM; // 0x58
	private TimerAbs rMNMUGEefTtcFrAdeLnsAZfurmk; // 0x60
	private Action<int, ControllerDataUpdater> EJbSxdVddraROjZaiYbZVrUwQoYu; // 0x68
	private PlatformInputManager YPXFTYczxBNwCKQUUwpYRjqDJBr; // 0x70
	private readonly IUnifiedKeyboardSource MbGfqjWviNnSkOvXeESKflAMKnw; // 0x78
	private readonly IUnifiedMouseSource wQKRwJlzHRNNYqSEOhrfWQaRpFg; // 0x80
	private bool ebUGcKHoXpaceyVacdJmRxLEOjl; // 0x88
	private string[] CqqGwJDziuKGreecwrcmJdGmxqlM; // 0x90

	// Properties
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override int deviceCount { get; } // 0x0000000180379F10-0x0000000180379F20 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000180418980-0x0000000180418990 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IInputSource inputSource { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override InputSource inputSourceType { get; } // 0x00000001806C4390-0x00000001806C43A0 

	// Nested types
	private class IILhtKYdQJUAQYDjlmjnSPmzNsB : IInputManagerJoystick // TypeDefIndex: 6634
	{
		// Fields
		private int XOLVDiSWtIqbOpghJCzBEigseKH; // 0x10
		private int IKeuqAccRFFGUGPfkLjliBImiajo; // 0x14
		private int QqpCMJrIsoyyefcScyWUdCeTfPn; // 0x18
		public Guid ZOImCzoQsvFKPDGPJbXrBBLAqoDc; // 0x1C
		public string qJNHNVBcnGCoPZuHIspQhSOYKLb; // 0x30
		public int RqeEfSBOWWEnNatJBPYhAJpbQKkq; // 0x38
		public string DuwcjPfrAlmvtavMgqyuTSXAwVQI; // 0x40
		private int RweyBZyAAIjbTgpvgIOlbybhzioP; // 0x48
		private int QsBvetqPHrzKthaGEErdieSJgIkd; // 0x4C
		private float[] ZNTUylpNRUByYdQSrADdmjAvZRH; // 0x50
		private bool[] vunatIQhxVdxZDEBHEGxdtuFiCZm; // 0x58
		private bool[] VXIlpxHoSpAopqsNsXBVmQQyaHw; // 0x60
		private float[] YdIhbQqjTBlKLpEPSzBgrdbUdOy; // 0x68
		private bool[] fSxqEgGpXybmajNlhthKyOLjTax; // 0x70
		private HardwareJoystickMap_InputManager VnQIptJChOAyXtaioLZfAFotfgY; // 0x78
		private bool TrENyqpiKSBltBAtsfPKDmZKmSP; // 0x80

		// Properties
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int rewiredId { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int inputManagerId { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public string name { get; } // 0x0000000180D5D6D0-0x0000000180D5D720 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public long? systemId { get; } // 0x0000000180D5D750-0x0000000180D5D7C0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int unityId { get; set; } // 0x00000001803F46B0-0x00000001803F46C0 0x00000001803F46C0-0x00000001803F46D0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Guid instanceGuid { get; } // 0x0000000180D5D4E0-0x0000000180D5D6D0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Guid persistentGuid { get; } // 0x0000000180D5D720-0x0000000180D5D750 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Controller.Extension extension { get; } // 0x000000018037DDC0-0x000000018037DDD0 

		// Constructors
		public IILhtKYdQJUAQYDjlmjnSPmzNsB(); // 0x0000000180D5D430-0x0000000180D5D490

		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void SetVibration(float amount, int motorIndex); // 0x00000001803774A0-0x00000001803774B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void StopVibration(); // 0x00000001803774A0-0x00000001803774B0
		public void oNdmArBRsfglpDaVPikdDxDwbcl(); // 0x0000000180D5DB90-0x0000000180D5DC80
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void Update(); // 0x0000000180D5D1C0-0x0000000180D5D3A0
		public int KtuOdxlQvfcWMKWKLpXAppHCedU(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d98a); // 0x0000000180D5C7A0-0x0000000180D5C840
		private void wqlffMjxssnplevpBMMQSUIGWac(BridgedControllerHWInfo param_0000d98b); // 0x0000000180D5EC90-0x0000000180D5ECF0
		private void wqlffMjxssnplevpBMMQSUIGWac(BridgedController param_0000d98c); // 0x0000000180D5EBD0-0x0000000180D5EC90
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void FillData(ControllerDataUpdater dataUpdater); // 0x0000000180D5BD20-0x0000000180D5C150
		public void bRuTarnPjSsMOvlyCPPbCHNCryK(int param_0000d98e); // 0x0000000180D5D490-0x0000000180D5D4A0
		public void QCvxhmnnkSwEVzfQhGvkBcDTyIh(); // 0x0000000180D5CE60-0x0000000180D5CEB0
		public BridgedControllerHWInfo XRVSbFhJTVnjsPfNtQbaBGoeHvx(); // 0x0000000180D5D3A0-0x0000000180D5D430
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public BridgedController ToBridgedController(); // 0x0000000180D5CEB0-0x0000000180D5CFA0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x0000000180D5CFA0-0x0000000180D5D000
		private void oaoJOSoVYewijYauXIwaCZnWeJi(); // 0x0000000180D5DC80-0x0000000180D5DE10
		private void ImXynqJsKrbihkCeHBieZBlZjBkd(); // 0x0000000180D5C330-0x0000000180D5C7A0
		private void nxhcezssRzdcWxCszmkJAETEeBj(); // 0x0000000180D5D8C0-0x0000000180D5DB90
		private bool ozJURFXGWjoSmvRPguejjmdfrxo(HardwareJoystickMap.Platform_Fallback_Base.Button param_0000d98f); // 0x0000000180D5DE10-0x0000000180D5EB20
		private bool LHLdzrNekKQKOLbBvbgFmPfGORN(float param_0000d990, float param_0000d991); // 0x00000001809AB5D0-0x00000001809AB5F0
		private float MrEjHmrhMIAvyvAGWGqoSofBjzv(HardwareJoystickMap.Platform_Fallback_Base.Axis param_0000d992); // 0x0000000180D5C890-0x0000000180D5CE60
		private float MrEjHmrhMIAvyvAGWGqoSofBjzv(UnityAxis param_0000d993); // 0x0000000180D5C840-0x0000000180D5C890
		private bool ozJURFXGWjoSmvRPguejjmdfrxo(UnityButton param_0000d994); // 0x0000000180D5EB20-0x0000000180D5EB90
		private bool hBMAmWZoIsFMeGCGkqvGbnqCDlB(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData param_0000d995, out bool param_0000d996); // 0x0000000180D5D7C0-0x0000000180D5D8C0
		private bool fIAjIljnoMHElOCCESUCCcCoCfI(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData param_0000d997, out bool param_0000d998); // 0x0000000180D5D4A0-0x0000000180D5D4E0
		private bool UMVeaBgkvEwSmLimDxpRGVOGIwyl(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData param_0000d999, out float param_0000d99a); // 0x0000000180D5D000-0x0000000180D5D1C0
		private bool zhnQGuMWCvPXyqFOMFhQJMuJaXga(UnityAxis param_0000d99b); // 0x0000000180D5ED40-0x0000000180D5ED80
		private void BmYcESUSLtTSZTmUBGDGKcYFZYPB(); // 0x0000000180D5B6D0-0x0000000180D5BD20
		private void xYVjwyZhjQqUkUFHjyreFStdrnk(); // 0x0000000180D5ECF0-0x0000000180D5ED40
		private string BDXxuNhkOqICIFSpFjayCRLyExW(); // 0x0000000180D5B140-0x0000000180D5B6D0
		private InputSource HdRlAjGUeRtHPlooquxplAUtYZg(); // 0x0000000180D5C200-0x0000000180D5C330
		public static int yOaTLoqQNpSyLueOFrJKOdZbhdr(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d99c, IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d99d); // 0x0000000180429290-0x00000001804292D0
		public static int qPwaBhHxteevbaxfEAwoyXpkgJci(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d99e, IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d99f); // 0x0000000180D5EB90-0x0000000180D5EBD0
		private static string GZBYVSTALVXFHXGuFcmVAGvsffd(string param_0000d9a0); // 0x0000000180D5C150-0x0000000180D5C200
	}

	private class mSBBaCgFyvVKevGfajgjjZjtMyd // TypeDefIndex: 6635
	{
		// Fields
		private List<NxUScZQzQzJJgzAkMtIilDcAoOW> hnpXymCoCCHPwqlDSIZkffYsKwxu; // 0x10

		// Properties
		public int SHujHYUxHggDGFiBfPBtOLtZhMW { get; } // 0x0000000180D69C30-0x0000000180D69C70 

		// Nested types
		public enum ScwxToYrOlvnuuQoLOgGuIsRbhPd // TypeDefIndex: 6636
		{
			fUCXKJCTVFsJpPqXabTFOEWGhao = 0,
			VvUvsThtRLwEHszViUPhlXdArGo = 1
		}

		public class NxUScZQzQzJJgzAkMtIilDcAoOW // TypeDefIndex: 6637
		{
			// Fields
			public int OVXHKDzaJatXjMbqyxVckuQWdNz; // 0x10
			public int RqeEfSBOWWEnNatJBPYhAJpbQKkq; // 0x14
			public string YvPxdtlAPbSTVkXmeqLwUfQtbBj; // 0x18
			public int OlAgkDKAhOqDAgDjadFVJGPfUNR; // 0x20

			// Constructors
			public NxUScZQzQzJJgzAkMtIilDcAoOW(); // 0x0000000180373240-0x0000000180373250

			// Methods
			public bool KtuOdxlQvfcWMKWKLpXAppHCedU(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d9a9, ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d9aa); // 0x0000000180D5FD20-0x0000000180D5FDF0
		}

		// Constructors
		public mSBBaCgFyvVKevGfajgjjZjtMyd(); // 0x0000000180D69BD0-0x0000000180D69C30

		// Methods
		public void lmldbkvCGcJRSRLClxvEdfwGeFAF(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d9a1); // 0x0000000180D69C70-0x0000000180D69FC0
		public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d9a2, ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d9a3); // 0x0000000180D699B0-0x0000000180D69AC0
		public NxUScZQzQzJJgzAkMtIilDcAoOW SJSWnEKwuoLTQVEoRbtWctEUXhl(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d9a4, ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d9a5); // 0x0000000180D69AC0-0x0000000180D69BD0
		public int ItDzbHMiIYGseDXjmhIUEkIaQew(NxUScZQzQzJJgzAkMtIilDcAoOW param_0000d9a6); // 0x0000000180D698B0-0x0000000180D699B0
		private void BPfbiRRcHBdGVaFlopltypkiKpwF(int param_0000d9a7, int param_0000d9a8); // 0x0000000180D697C0-0x0000000180D698B0
	}

	// Constructors
	public ePGTCaURqwcphqnKHxpRBdGnTYZ(UpdateLoopSetting updateLoopSetting); // 0x0000000180D64350-0x0000000180D64560

	// Methods
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void Initialize(); // 0x0000000180D624B0-0x0000000180D625A0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void Update(UpdateLoopType updateLoop); // 0x0000000180D633B0-0x0000000180D63680
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void OnDestroy(); // 0x0000000180D62D50-0x0000000180D62E10
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x00000001803765E0-0x00000001803765F0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data); // 0x0000000180D63260-0x0000000180D633B0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SystemDeviceConnected(); // 0x0000000180D63190-0x0000000180D631B0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SystemDeviceDisconnected(); // 0x0000000180D631B0-0x0000000180D631D0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x0000000180D62F10-0x0000000180D63190
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018040ED60-0x000000018040ED70
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x0000000180418A40-0x0000000180418A50
	private void YoZyWiOZBJomMtEtoZcHjseDbAj(); // 0x0000000180D63B40-0x0000000180D63B70
	private void YoZyWiOZBJomMtEtoZcHjseDbAj(string[] param_0000d969); // 0x0000000180D63B70-0x0000000180D64350
	private void lacmGlTQoaLmoxrvjoHVdQPxdgv(UpdateLoopType param_0000d96a); // 0x0000000180D647C0-0x0000000180D648D0
	private void CrEFysWJYfMtJVlNOTETVlrRfmH(int param_0000d96b, int param_0000d96c, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d96d, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d96e); // 0x0000000180D61C70-0x0000000180D62240
	private void vldJABpAisLeLtnWmXvbkuWgBVP(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d96f, int param_0000d970, int param_0000d971); // 0x0000000180D64CA0-0x0000000180D64DE0
	private bool pNMfllDFmeSLnPQOJXZWrLWxJvV(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d972, int param_0000d973); // 0x0000000180D648D0-0x0000000180D649B0
	private int bboyWaSBIWfSuDuvAhGSQFlklHB(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d974); // 0x0000000180D64560-0x0000000180D646B0
	private bool pvXOIHQgaXRwmhvpEGPOheJnhQaK(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d975, int param_0000d976); // 0x0000000180D649B0-0x0000000180D64A80
	private void YIYZwrraphZTryuQTiOviKWRzIv(int param_0000d977, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d978, int param_0000d979, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d97a, mSBBaCgFyvVKevGfajgjjZjtMyd.ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d97b); // 0x0000000180D63680-0x0000000180D63B40
	private void MEGxlYFLQIBDskCcuhdtrMUQPsay(int param_0000d97c, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d97d, mSBBaCgFyvVKevGfajgjjZjtMyd.ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d97e); // 0x0000000180D625A0-0x0000000180D62D50
	private void SZwYmZviewQhCXYBZRYpKgLixEo(); // 0x0000000180D62E10-0x0000000180D62F10
	private bool jREgEtiIdWEJuYqeDMqRZmepaiy(string[] param_0000d97f); // 0x0000000180D646B0-0x0000000180D647C0
	private void HDRVotfzQTtozttlcYWzSMkLNGk(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d980, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d981, bool param_0000d982); // 0x0000000180D62240-0x0000000180D624B0
	private void rRbwQLxKmBpfwWwAFobgsEaaBko(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d983, bool param_0000d984); // 0x0000000180D64A80-0x0000000180D64CA0
	private void URXhRKDgyDNdlSGVMSdXbgTHyrg(); // 0x0000000180D631D0-0x0000000180D63260
}

