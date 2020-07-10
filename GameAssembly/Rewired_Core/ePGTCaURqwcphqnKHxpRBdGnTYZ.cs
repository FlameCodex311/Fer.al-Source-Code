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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

internal class ePGTCaURqwcphqnKHxpRBdGnTYZ : PlatformInputManager // TypeDefIndex: 6474
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
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override int deviceCount { get; } // 0x000000018047AB20-0x000000018047AB30 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000180369B50-0x0000000180369B60 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IInputSource inputSource { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override InputSource inputSourceType { get; } // 0x000000018043D4B0-0x000000018043D4C0 

	// Nested types
	private class IILhtKYdQJUAQYDjlmjnSPmzNsB : IInputManagerJoystick // TypeDefIndex: 6475
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
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int rewiredId { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int inputManagerId { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public string name { get; } // 0x00000001805BD7F0-0x00000001805BD840 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public long? systemId { get; } // 0x00000001805BD870-0x00000001805BD8E0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int unityId { get; set; } // 0x0000000180367710-0x0000000180367720 0x000000018036B1F0-0x000000018036B200
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Guid instanceGuid { get; } // 0x00000001805BD600-0x00000001805BD7F0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Guid persistentGuid { get; } // 0x00000001805BD840-0x00000001805BD870 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Controller.Extension extension { get; } // 0x000000018035FCC0-0x000000018035FCD0 

		// Constructors
		public IILhtKYdQJUAQYDjlmjnSPmzNsB(); // 0x00000001805BD550-0x00000001805BD5B0

		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void SetVibration(float amount, int motorIndex); // 0x00000001803581E0-0x00000001803581F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void StopVibration(); // 0x00000001803581E0-0x00000001803581F0
		public void oNdmArBRsfglpDaVPikdDxDwbcl(); // 0x00000001805BDCC0-0x00000001805BDE00
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void Update(); // 0x00000001805BD460-0x00000001805BD4C0
		public int KtuOdxlQvfcWMKWKLpXAppHCedU(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d71a); // 0x00000001805BCA00-0x00000001805BCAB0
		private void wqlffMjxssnplevpBMMQSUIGWac(BridgedControllerHWInfo param_0000d71b); // 0x00000001805BEE80-0x00000001805BEEE0
		private void wqlffMjxssnplevpBMMQSUIGWac(BridgedController param_0000d71c); // 0x00000001805BEDC0-0x00000001805BEE80
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void FillData(ControllerDataUpdater dataUpdater); // 0x00000001805BBF10-0x00000001805BC380
		public void bRuTarnPjSsMOvlyCPPbCHNCryK(int param_0000d71e); // 0x00000001805BD5B0-0x00000001805BD5C0
		public void QCvxhmnnkSwEVzfQhGvkBcDTyIh(); // 0x00000001805BD0F0-0x00000001805BD140
		public BridgedControllerHWInfo XRVSbFhJTVnjsPfNtQbaBGoeHvx(); // 0x00000001805BD4C0-0x00000001805BD550
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public BridgedController ToBridgedController(); // 0x00000001805BD140-0x00000001805BD240
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x00000001805BD240-0x00000001805BD2A0
		private void oaoJOSoVYewijYauXIwaCZnWeJi(); // 0x00000001805BDE00-0x00000001805BDFA0
		private void ImXynqJsKrbihkCeHBieZBlZjBkd(); // 0x00000001805BC560-0x00000001805BCA00
		private void nxhcezssRzdcWxCszmkJAETEeBj(); // 0x00000001805BD9E0-0x00000001805BDCC0
		private bool ozJURFXGWjoSmvRPguejjmdfrxo(HardwareJoystickMap.Platform_Fallback_Base.Button param_0000d71f); // 0x00000001805BDFA0-0x00000001805BED10
		private bool LHLdzrNekKQKOLbBvbgFmPfGORN(float param_0000d720, float param_0000d721); // 0x0000000180494A60-0x0000000180494A80
		private float MrEjHmrhMIAvyvAGWGqoSofBjzv(HardwareJoystickMap.Platform_Fallback_Base.Axis param_0000d722); // 0x00000001805BCB00-0x00000001805BD0F0
		private float MrEjHmrhMIAvyvAGWGqoSofBjzv(UnityAxis param_0000d723); // 0x00000001805BCAB0-0x00000001805BCB00
		private bool ozJURFXGWjoSmvRPguejjmdfrxo(UnityButton param_0000d724); // 0x00000001805BED10-0x00000001805BED80
		private bool hBMAmWZoIsFMeGCGkqvGbnqCDlB(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData param_0000d725, out bool param_0000d726); // 0x00000001805BD8E0-0x00000001805BD9E0
		private bool fIAjIljnoMHElOCCESUCCcCoCfI(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData param_0000d727, out bool param_0000d728); // 0x00000001805BD5C0-0x00000001805BD600
		private bool UMVeaBgkvEwSmLimDxpRGVOGIwyl(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData param_0000d729, out float param_0000d72a); // 0x00000001805BD2A0-0x00000001805BD460
		private bool zhnQGuMWCvPXyqFOMFhQJMuJaXga(UnityAxis param_0000d72b); // 0x00000001805BEF30-0x00000001805BEF80
		private void BmYcESUSLtTSZTmUBGDGKcYFZYPB(); // 0x00000001805BB8B0-0x00000001805BBF10
		private void xYVjwyZhjQqUkUFHjyreFStdrnk(); // 0x00000001805BEEE0-0x00000001805BEF30
		private string BDXxuNhkOqICIFSpFjayCRLyExW(); // 0x00000001805BB300-0x00000001805BB8B0
		private InputSource HdRlAjGUeRtHPlooquxplAUtYZg(); // 0x00000001805BC430-0x00000001805BC560
		public static int yOaTLoqQNpSyLueOFrJKOdZbhdr(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d72c, IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d72d); // 0x000000018037A600-0x000000018037A640
		public static int qPwaBhHxteevbaxfEAwoyXpkgJci(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d72e, IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d72f); // 0x00000001805BED80-0x00000001805BEDC0
		private static string GZBYVSTALVXFHXGuFcmVAGvsffd(string param_0000d730); // 0x00000001805BC380-0x00000001805BC430
	}

	private class mSBBaCgFyvVKevGfajgjjZjtMyd // TypeDefIndex: 6476
	{
		// Fields
		private List<NxUScZQzQzJJgzAkMtIilDcAoOW> hnpXymCoCCHPwqlDSIZkffYsKwxu; // 0x10

		// Properties
		public int SHujHYUxHggDGFiBfPBtOLtZhMW { get; } // 0x00000001805CA230-0x00000001805CA270 

		// Nested types
		public enum ScwxToYrOlvnuuQoLOgGuIsRbhPd // TypeDefIndex: 6477
		{
			fUCXKJCTVFsJpPqXabTFOEWGhao = 0,
			VvUvsThtRLwEHszViUPhlXdArGo = 1
		}

		public class NxUScZQzQzJJgzAkMtIilDcAoOW // TypeDefIndex: 6478
		{
			// Fields
			public int OVXHKDzaJatXjMbqyxVckuQWdNz; // 0x10
			public int RqeEfSBOWWEnNatJBPYhAJpbQKkq; // 0x14
			public string YvPxdtlAPbSTVkXmeqLwUfQtbBj; // 0x18
			public int OlAgkDKAhOqDAgDjadFVJGPfUNR; // 0x20

			// Constructors
			public NxUScZQzQzJJgzAkMtIilDcAoOW(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			public bool KtuOdxlQvfcWMKWKLpXAppHCedU(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d739, ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d73a); // 0x00000001805BFF90-0x00000001805C0060
		}

		// Constructors
		public mSBBaCgFyvVKevGfajgjjZjtMyd(); // 0x00000001805CA1D0-0x00000001805CA230

		// Methods
		public void lmldbkvCGcJRSRLClxvEdfwGeFAF(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d731); // 0x00000001805CA270-0x00000001805CA5D0
		public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d732, ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d733); // 0x00000001805C9FA0-0x00000001805CA0C0
		public NxUScZQzQzJJgzAkMtIilDcAoOW SJSWnEKwuoLTQVEoRbtWctEUXhl(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d734, ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d735); // 0x00000001805CA0C0-0x00000001805CA1D0
		public int ItDzbHMiIYGseDXjmhIUEkIaQew(NxUScZQzQzJJgzAkMtIilDcAoOW param_0000d736); // 0x00000001805C9EA0-0x00000001805C9FA0
		private void BPfbiRRcHBdGVaFlopltypkiKpwF(int param_0000d737, int param_0000d738); // 0x00000001805C9DB0-0x00000001805C9EA0
	}

	// Constructors
	public ePGTCaURqwcphqnKHxpRBdGnTYZ(UpdateLoopSetting updateLoopSetting); // 0x00000001805C4770-0x00000001805C4980

	// Methods
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void Initialize(); // 0x00000001805C2830-0x00000001805C2920
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void Update(UpdateLoopType updateLoop); // 0x00000001805C3790-0x00000001805C3A70
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void OnDestroy(); // 0x00000001805C3100-0x00000001805C31C0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000180358970-0x0000000180358980
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data); // 0x00000001805C3640-0x00000001805C3790
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SystemDeviceConnected(); // 0x00000001805C3570-0x00000001805C3590
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SystemDeviceDisconnected(); // 0x00000001805C3590-0x00000001805C35B0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001805C32D0-0x00000001805C3570
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018035FCB0-0x000000018035FCC0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x0000000180369C70-0x0000000180369C80
	private void YoZyWiOZBJomMtEtoZcHjseDbAj(); // 0x00000001805C3F40-0x00000001805C3F70
	private void YoZyWiOZBJomMtEtoZcHjseDbAj(string[] param_0000d6f9); // 0x00000001805C3F70-0x00000001805C4770
	private void lacmGlTQoaLmoxrvjoHVdQPxdgv(UpdateLoopType param_0000d6fa); // 0x00000001805C4C00-0x00000001805C4D10
	private void CrEFysWJYfMtJVlNOTETVlrRfmH(int param_0000d6fb, int param_0000d6fc, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d6fd, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d6fe); // 0x00000001805C1FE0-0x00000001805C25C0
	private void vldJABpAisLeLtnWmXvbkuWgBVP(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d6ff, int param_0000d700, int param_0000d701); // 0x00000001805C50F0-0x00000001805C5230
	private bool pNMfllDFmeSLnPQOJXZWrLWxJvV(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d702, int param_0000d703); // 0x00000001805C4D10-0x00000001805C4DF0
	private int bboyWaSBIWfSuDuvAhGSQFlklHB(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d704); // 0x00000001805C4980-0x00000001805C4AE0
	private bool pvXOIHQgaXRwmhvpEGPOheJnhQaK(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d705, int param_0000d706); // 0x00000001805C4DF0-0x00000001805C4ED0
	private void YIYZwrraphZTryuQTiOviKWRzIv(int param_0000d707, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d708, int param_0000d709, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d70a, mSBBaCgFyvVKevGfajgjjZjtMyd.ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d70b); // 0x00000001805C3A70-0x00000001805C3F40
	private void MEGxlYFLQIBDskCcuhdtrMUQPsay(int param_0000d70c, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d70d, mSBBaCgFyvVKevGfajgjjZjtMyd.ScwxToYrOlvnuuQoLOgGuIsRbhPd param_0000d70e); // 0x00000001805C2920-0x00000001805C3100
	private void SZwYmZviewQhCXYBZRYpKgLixEo(); // 0x00000001805C31C0-0x00000001805C32D0
	private bool jREgEtiIdWEJuYqeDMqRZmepaiy(string[] param_0000d70f); // 0x00000001805C4AE0-0x00000001805C4C00
	private void HDRVotfzQTtozttlcYWzSMkLNGk(List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d710, List<IILhtKYdQJUAQYDjlmjnSPmzNsB> param_0000d711, bool param_0000d712); // 0x00000001805C25C0-0x00000001805C2830
	private void rRbwQLxKmBpfwWwAFobgsEaaBko(IILhtKYdQJUAQYDjlmjnSPmzNsB param_0000d713, bool param_0000d714); // 0x00000001805C4ED0-0x00000001805C50F0
	private void URXhRKDgyDNdlSGVMSdXbgTHyrg(); // 0x00000001805C35B0-0x00000001805C3640
}

