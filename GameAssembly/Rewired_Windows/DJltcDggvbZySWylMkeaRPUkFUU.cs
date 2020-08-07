/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Libraries.SharpDX.XInput;
using Rewired.Platforms;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;

// Image 67: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8232-8523

internal class DJltcDggvbZySWylMkeaRPUkFUU : PlatformInputManager // TypeDefIndex: 8272
{
	// Fields
	private mNERgZsNbTklwRPFuHDMJNORfHb[] QGmtJjtlPHcXDLmuPJpcBhWHeSt; // 0x38
	private bool rBSVeVWbkkZVPFTAWxxNqGIvQcu; // 0x40
	private oDPACVeCFkiLRDUQHNPMAEzGmvH TVcehgHJzQazmwYbRsqajNenNkz; // 0x48
	private mKVKuSqkZCRMxBDOWcYtGkhntTPf DsEtcuriNprststCvdRDwAQbKrY; // 0x50
	private qPGcqldiSPYhNvecKMmeQWmBzsAc<bool> VCILtlUhYfkfeeJKxejKJbyqIehi; // 0x58
	private bool[] RqmntkWXjvHwoBjmKmGQBRCjDMK; // 0x60
	private bool[] mbELpcNoGUeZvbDicBwTCPCUmWR; // 0x68
	private bool FXoahTghgCWdNxNVoTqaBfanWW; // 0x70
	private readonly bool vvBiwyQcTQuVQiEPHwLwzRseSYb; // 0x71
	private readonly UpdateLoopSetting bwgBPRcKuQavlBLAcISJrrygHzyp; // 0x74
	private UpdateLoopType YifzZDqyircPJRMDkxXJzzemqqN; // 0x78
	private UpdateLoopType qoXenbwLTEyfRxfmbPxpcJTWbHa; // 0x7C
	private Action<int, ControllerDataUpdater> foXIqDIskRyntvUJrVarmOifcqn; // 0x80
	private bool yFRKNNwybZzSOnyRWCRPOwnQpcx; // 0x88
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> SPPGEprkVSKsolJOZAOXmfAPQau; // 0x90
	private Func<int> NjwvsULqnevgrqobWcYoUdYGcbI; // 0x98
	private static Guid[] FPwEEPfkHTQQsgfqIIvEJbysyIy; // 0x00
	private static string[] pTsaRKDsgDYclPxnzpHxhWvuexM; // 0x08
	private static string[] jWoGWhAdrOGRwEBaZzIRWBbEyToP; // 0x10

	// Properties
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override int deviceCount { get; } // 0x0000000180411060-0x0000000180411150 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000180411160-0x0000000180411170 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IInputSource inputSource { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override InputSource inputSourceType { get; } // 0x0000000180411150-0x0000000180411160 

	// Nested types
	private class mNERgZsNbTklwRPFuHDMJNORfHb : IDisposable, IInputManagerJoystick // TypeDefIndex: 8273
	{
		// Fields
		private bool FXoahTghgCWdNxNVoTqaBfanWW; // 0x10
		private int sfnaQCVIFsoKjRqOSiTleJAfZea; // 0x14
		private readonly int yGRLVnJBqxnQSqcfVHtffVHfAKdo; // 0x18
		public Guid wDiIVDapdBSywchkAEYXcQxqRiaD; // 0x1C
		public string wcmrNAnNnYIsTihDNhRqdAqLidd; // 0x30
		public Guid TpDziRSLyFCVcolCVBxAyNBlKGR; // 0x38
		public DeviceType lxnExoEuUmWZrwtoBNaQZAdaJbx; // 0x48
		public XInputDeviceSubType XjqvgNQWaQKnnfyWsKRrCVDwjSr; // 0x4C
		public bool TuHsdkDvhPAtDWpHyvJzvlJYKqh; // 0x50
		public bool UsPKTFhzGrmPjOtXNPqBZscrdjv; // 0x51
		public readonly VxzKNvoPFxEvzHeyjWXgRZaCnIB FHrmTAMUixetljGBkWIzbnxEwoS; // 0x58
		public bool ZvgiIzGItcVoxnvqTllzoqQEhFl; // 0x60
		public bool zIMjkflcMpNJWsSweDCVucrSvMT; // 0x61
		private int owMEWzlmNesJiVGKrhLLhhJkfcNn; // 0x64
		private int zFfGjPrPWXBoOkJpRUiXllcODEHl; // 0x68
		private int KBkLyHtWnkRWiqBGUUwmrqOHqVH; // 0x6C
		private int JvZculfQbOETGIKGOnGiPJYPLDBI; // 0x70
		private readonly float[] gEvIfPoNUeIWjZEtgeYJbgimKTc; // 0x78
		private readonly bool[] AALaecJavdNfurAiURsHgWsSGwc; // 0x80
		private HardwareJoystickMap_InputManager szkLRBAGgmWPuPNDxAzLTpOygLx; // 0x88
		private readonly VxzKNvoPFxEvzHeyjWXgRZaCnIB BobOiXXQIFeMDrJfIXDUwoflICf; // 0x90
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> SPPGEprkVSKsolJOZAOXmfAPQau; // 0x98
		private Action CjYdNdGDaNAieMGXkMJIXybuwQp; // 0xA0
		private bool EWhtEIyTwrpqIzgnZPXBXEbtUQs; // 0xA8
		private bool kVyAEQgTiizdGtANtIomOfhFKQg; // 0xA9
		private bool IwDfiQosJoZcfnCuKPuSDWCkvQz; // 0xAA

		// Properties
		public string PVKaLjOCEVxeuXVCVCLIazqSdPO { get; } // 0x00000001804210E0-0x0000000180421190 
		public string pNNtlXYRfFRfSKbBcBnNXSyYaYdg { get; } // 0x0000000180421380-0x0000000180421410 
		public bool YxrzUZDshLahFMRJWSqvKyPACYo { get; } // 0x0000000180421190-0x0000000180421260 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int rewiredId { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int inputManagerId { get; } // 0x00000001803F46B0-0x00000001803F46C0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public string name { get; } // 0x0000000180421260-0x0000000180421380 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public long? systemId { get; } // 0x0000000180421410-0x0000000180421470 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int unityId { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Controller.Extension extension { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Guid instanceGuid { get; } // 0x000000018041B670-0x000000018041B680 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Guid persistentGuid { get; } // 0x000000018041B670-0x000000018041B680 

		// Constructors
		public mNERgZsNbTklwRPFuHDMJNORfHb(int systemId, bool isWin8AppStore, VxzKNvoPFxEvzHeyjWXgRZaCnIB sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Action deviceDisconnectedDelegate); // 0x0000000180420930-0x0000000180420A10

		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void SetVibration(float amount, int motorIndex); // 0x000000018041FE80-0x000000018041FF50
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void StopVibration(); // 0x000000018041FF50-0x000000018041FF80
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void Update(); // 0x00000001804202E0-0x0000000180420600
		public void qXdMretsmUtHGUnAyVbWksgeZOe(bool param_00011125); // 0x0000000180421930-0x0000000180421940
		public bool fhlqyHHlVVRCrjQDTBoaYkvayiB(SZonfVpcAmagTECoXnSCrepkmax param_00011126); // 0x0000000180421060-0x0000000180421080
		public bool ceNFAWhtmQETjaRxyqXIitRxHkf(SZonfVpcAmagTECoXnSCrepkmax param_00011127); // 0x0000000180420A10-0x0000000180420AC0
		public void fUTcAzMqjqfGqHdSSTvCccLOwgmN(bool param_00011128); // 0x0000000180421050-0x0000000180421060
		public void XIbEGfWXMHCwpmCMxIYlaXAfXJCc(); // 0x0000000180420830-0x00000001804208F0
		public void mdAaJkSUssKBuPczsnYwnZjozqJ(); // 0x0000000180421890-0x0000000180421930
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void FillData(ControllerDataUpdater dataUpdater); // 0x000000018041EF80-0x000000018041F1C0
		public BridgedControllerHWInfo gbrBUxoFEhBBZhXueJHCQMMzfJU(); // 0x0000000180421080-0x00000001804210E0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public BridgedController ToBridgedController(); // 0x000000018041FF80-0x0000000180420280
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x0000000180420280-0x00000001804202E0
		private void iprGZknTIARCuPKHvBlGSSXnbgi(); // 0x0000000180421470-0x0000000180421890
		private bool EHKbHsJaBpcbYYZPoGEESqBrHJyo(); // 0x000000018041EE70-0x000000018041EF10
		private void wJOWuPFMVrjFcdpIWkrjikYmGha(); // 0x0000000180421CA0-0x0000000180421CB0
		private void ZOaVIQlCNwjvITKsdbNdMsLEfCA(); // 0x00000001804208F0-0x0000000180420930
		private void vAtlDGAFFZDBSWfVQjpKMYROXUB(bool[] param_0001112a, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_0001112b); // 0x0000000180421A50-0x0000000180421CA0
		private void WwLhoTbvnRBIbNCDsBjlVXxPMDA(bool[] param_0001112c, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_0001112d); // 0x0000000180420600-0x0000000180420830
		private float ddeAaEoPBwfkDXGlLfHOkRXUPnOG(HardwareJoystickMap.Platform_XInput_Base.Axis param_0001112e, bool[] param_0001112f, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00011130); // 0x0000000180420BC0-0x0000000180420FA0
		private float ddeAaEoPBwfkDXGlLfHOkRXUPnOG(XInputAxis param_00011131, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00011132); // 0x0000000180420FA0-0x0000000180421050
		private bool NazkUlYeVVjyDXBchdfNhwTesrFk(HardwareJoystickMap.Platform_XInput_Base.Button param_00011133, bool[] param_00011134, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00011135); // 0x000000018041F610-0x000000018041FA60
		private bool NazkUlYeVVjyDXBchdfNhwTesrFk(XInputButton param_00011136, bool[] param_00011137); // 0x000000018041F260-0x000000018041F610
		private float EqiBwibyZqNRgcBrauXECrZPRDY(int param_00011138); // 0x000000018041EF10-0x000000018041EF80
		private float DDKPoCuwcrssolbpxuhWZMXflay(int param_00011139); // 0x000000018041ED90-0x000000018041EE00
		private void chgLTsLAoRqfgzxaGOxybgGGSFw(); // 0x0000000180420AC0-0x0000000180420BC0
		private string yozgjbgkVMDipbeGSOfIRgnpyhr(); // 0x0000000180421CB0-0x0000000180421FD0
		private void PCBbqseklYNTQIOEEAPmbLgGBmJd(BridgedControllerHWInfo param_0001113a); // 0x000000018041FA60-0x000000018041FBB0
		private void PCBbqseklYNTQIOEEAPmbLgGBmJd(BridgedController param_0001113b); // 0x000000018041FBB0-0x000000018041FE80
		public void Dispose(); // 0x000000018041EE00-0x000000018041EE70
		~mNERgZsNbTklwRPFuHDMJNORfHb(); // 0x000000018041F1C0-0x000000018041F260
		protected virtual void ukZeJfPzbKmpvxrUBgmIykVNKVO(bool param_0001113c); // 0x0000000180421940-0x0000000180421A50
	}

	private class mKVKuSqkZCRMxBDOWcYtGkhntTPf // TypeDefIndex: 8274
	{
		// Fields
		private List<ehwYjFTvZcXzFWTzeEbKyfUoHjM> CKRDfIDoRuhjHMZoRoGYskqfniS; // 0x10

		// Nested types
		private class ehwYjFTvZcXzFWTzeEbKyfUoHjM // TypeDefIndex: 8275
		{
			// Fields
			public bool GgoSbebYNGKOUBMowcyObAhgfMlB; // 0x10
			public int bCdxFnoMWYtrCiNLlRQMlgiLhPYa; // 0x14
			public XInputDeviceSubType XjqvgNQWaQKnnfyWsKRrCVDwjSr; // 0x18

			// Constructors
			public ehwYjFTvZcXzFWTzeEbKyfUoHjM(int rewiredId, XInputDeviceSubType deviceSubType); // 0x000000018041D160-0x000000018041D1B0

			// Methods
			public void bDpjnZNTIBcpcFFeCkJZEztApBtU(mNERgZsNbTklwRPFuHDMJNORfHb param_0001114a, bool param_0001114b); // 0x000000018041D1B0-0x000000018041D200
		}

		// Constructors
		public mKVKuSqkZCRMxBDOWcYtGkhntTPf(); // 0x000000018041EA00-0x000000018041EA60

		// Methods
		public void MRyMEXTbctvdQeQggKFhNpKgubz(mNERgZsNbTklwRPFuHDMJNORfHb param_0001113d, bool param_0001113e); // 0x000000018041E740-0x000000018041E880
		public void bDpjnZNTIBcpcFFeCkJZEztApBtU(int param_0001113f, mNERgZsNbTklwRPFuHDMJNORfHb param_00011140, bool param_00011141); // 0x000000018041EA60-0x000000018041EB30
		public int YSuIEzLqUHABhBltDalKFVyCTNN(XInputDeviceSubType param_00011142, bool param_00011143); // 0x000000018041E880-0x000000018041EA00
		public int daFyNXXCvqkrBdbqihawLHSTSUF(int param_00011144, XInputDeviceSubType param_00011145, bool param_00011146); // 0x000000018041EB30-0x000000018041ECE0
		public int vObAeLkMJPgHQxAcWKIPlyXGNEL(int param_00011147); // 0x000000018041ECE0-0x000000018041ED90
		public void KIbPfJcWSFGmGyeBztYAHmQMLul(int param_00011148, bool param_00011149); // 0x000000018041E6B0-0x000000018041E740
	}

	private class oDPACVeCFkiLRDUQHNPMAEzGmvH // TypeDefIndex: 8276
	{
		// Fields
		public bool rKWYspzGRntcPPozuzWnbwhpgxs; // 0x10
		private float fRLagRhYZbysBqvKzTDZjYDpfBzI; // 0x14
		public float NiLnpeIiCMbOFMxOgnWuCIJnrWY; // 0x18

		// Constructors
		public oDPACVeCFkiLRDUQHNPMAEzGmvH(float inLength); // 0x0000000180421FD0-0x0000000180422000

		// Methods
		public void mrZgAcxGDpNHXwBRLYlfZLapcCNA(); // 0x0000000180422080-0x0000000180422100
		public bool bDpjnZNTIBcpcFFeCkJZEztApBtU(); // 0x0000000180422000-0x0000000180422080
	}

	public class VxzKNvoPFxEvzHeyjWXgRZaCnIB : IDisposable // TypeDefIndex: 8277
	{
		// Fields
		private readonly ButtonLoopSet KmSdXEBjObBEEGgVzPgTlimUVMba; // 0x10
		private readonly DualRingReportBuffer ZGqQXdwjrAfmOStTFVAHpOzGciY; // 0x18
		public readonly ZhvgftZzLTTvmAppvXznBMXxHXw PzkBSMhKCDKLlSIUPgKJJknoYGJ; // 0x20
		public VEbVajMVdbsHdwPajvaXXgzBgbU pIGTilJTlzHgQcQsoaAbaWTnfjBS; // 0x28
		private int dIhaoWWkozCIAgOfasQAVueTuYoN; // 0x34
		private bool EWhtEIyTwrpqIzgnZPXBXEbtUQs; // 0x38
		private bool kWVxPKnJdeVFuaHJgtWsJFIUmXW; // 0x39
		private byte[] IakNvUjnhjYspcFJnKjTxzawrOQ; // 0x40
		private byte[] LEcAoiaTQYAINRGoIesOIgwupaGz; // 0x48
		private RingBuffer<gbcTfrWUAyyjnYRbyXTemSdghFG> zrnRaKYqjAWLNQcTcfVPGlbaRIg; // 0x50
		private RingBuffer<gbcTfrWUAyyjnYRbyXTemSdghFG> lumiKCpUQEQcKUnWLEqRaETxCTWg; // 0x58
		private readonly object ZYuqcOmSrLqHLqMZAnPPRIViICF; // 0x60
		private readonly object AvHfHnxOwUGyYtJfXeOfRnjzKtc; // 0x68
		private gbcTfrWUAyyjnYRbyXTemSdghFG wMGQlFNzeKJwIuDyKIRIvbXjgPr; // 0x70
		private float ERyzcuvFoiHazzSBhPWtkwaqluu; // 0x74
		private bool IwDfiQosJoZcfnCuKPuSDWCkvQz; // 0x78

		// Properties
		public bool[] wKOnPbKbGRtJlXJeMiMmKJJWUdx { get; } // 0x000000018041C8D0-0x000000018041C930 

		// Constructors
		public VxzKNvoPFxEvzHeyjWXgRZaCnIB(int controllerIndex, UpdateLoopSetting updateLoops); // 0x000000018041C370-0x000000018041C4F0

		// Methods
		public void jVhgReScAKXEjvimtGikJhORNWY(); // 0x000000018041C970-0x000000018041CA50
		public void TvOJSlVHdjCFIAwzRDmMHSuuRMt(); // 0x000000018041BFB0-0x000000018041C120
		public void hxBuCPWjXWEpuKzEmRBqHrRWHeXE(); // 0x000000018041C930-0x000000018041C970
		public void CVGHsGZeOSnwBwCnzeEFdNmYVFh(); // 0x000000018041BB30-0x000000018041BB40
		public bool ceNFAWhtmQETjaRxyqXIitRxHkf(SZonfVpcAmagTECoXnSCrepkmax param_00011151); // 0x000000018041C5A0-0x000000018041C630
		public void JLEbXnJHtVbsKJYkNVSkMdgwQfl(float param_00011152, int param_00011153); // 0x000000018041BCF0-0x000000018041BDB0
		public void GNkiLvkRZDdVIwjLTPEVjnxgClfK(); // 0x000000018041BCE0-0x000000018041BCF0
		public void nKgEkSjuMYLnoocqvhdzBIjvcZWq(); // 0x000000018041CCD0-0x000000018041CE70
		public void eFJqovjFOFlKNlUAOskMqjWaKxQ(); // 0x000000018041C630-0x000000018041C730
		public void ZoAEycRYSsLSBuKWsFcMOpvFWeq(); // 0x000000018041C120-0x000000018041C370
		private void KCYOQXbgAhqnanMhxUXWYOspNXH(); // 0x000000018041BDB0-0x000000018041BEC0
		private void vkgGGWgIJrRKJnodYqegAssjwiE(); // 0x000000018041BDB0-0x000000018041BEC0
		private void PkjJgCiyffTFzgeREnVfEAtRzQc(); // 0x000000018041BEE0-0x000000018041BFB0
		private static void CyaoxVjruiSsDjkRrWFvfCoMCn(RingBuffer<gbcTfrWUAyyjnYRbyXTemSdghFG> param_00011154, ZhvgftZzLTTvmAppvXznBMXxHXw param_00011155, ref float param_00011156); // 0x000000018041BB40-0x000000018041BBD0
		private static void aDHEmiFPJtgOygtWyXzBdWlfRNxe(ZhvgftZzLTTvmAppvXznBMXxHXw param_00011157, gbcTfrWUAyyjnYRbyXTemSdghFG param_00011158, ref float param_00011159); // 0x000000018041C4F0-0x000000018041C5A0
		private void lfSloTkDiaIvRcVQzSqDKDsLxO(ref VEbVajMVdbsHdwPajvaXXgzBgbU param_0001115a); // 0x000000018041CB50-0x000000018041CCD0
		private void lBbbcgyclxAtpIRBCAyUEoZbJfCM(byte[] param_0001115b, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_0001115c); // 0x000000018041CA50-0x000000018041CB50
		private void unalaRKSlKqpWcANALfIpMVINnC(ref VEbVajMVdbsHdwPajvaXXgzBgbU param_0001115d, float param_0001115e, byte[] param_0001115f); // 0x000000018041CEB0-0x000000018041D0D0
		private bool NazkUlYeVVjyDXBchdfNhwTesrFk(int param_00011160, int param_00011161); // 0x000000018041BEC0-0x000000018041BEE0
		private void fDgYQYQKaPimAijWAfVtGjstdSLo(); // 0x000000018041C730-0x000000018041C8D0
		public void Dispose(); // 0x000000018041BBD0-0x000000018041BC40
		~VxzKNvoPFxEvzHeyjWXgRZaCnIB(); // 0x000000018041BC40-0x000000018041BCE0
		protected virtual void ukZeJfPzbKmpvxrUBgmIykVNKVO(bool param_00011162); // 0x000000018041CE70-0x000000018041CEB0
	}

	public enum SZonfVpcAmagTECoXnSCrepkmax // TypeDefIndex: 8278
	{
		UwUmRWvwLwaKrSDPbhAIwmDqfnY = 0,
		sHwiOvCfpiZsAQobWHADUOvTUPJ = 1
	}

	// Constructors
	public DJltcDggvbZySWylMkeaRPUkFUU(bool isWin10AUHack, UpdateLoopSetting updateLoop, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId); // 0x0000000180410C00-0x0000000180410FF0
	static DJltcDggvbZySWylMkeaRPUkFUU(); // 0x0000000180410A10-0x0000000180410C00

	// Methods
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void Initialize(); // 0x000000018040ED70-0x000000018040F310
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void Update(UpdateLoopType currentUpdateLoop); // 0x00000001804107A0-0x0000000180410920
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void OnDestroy(); // 0x000000018040F6D0-0x000000018040FAD0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x000000018040ED60-0x000000018040ED70
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data); // 0x0000000180410750-0x00000001804107A0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SystemDeviceConnected(); // 0x000000018040FCF0-0x000000018040FD50
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SystemDeviceDisconnected(); // 0x000000018040FD50-0x000000018040FDD0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001803774A0-0x00000001803774B0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018037DDC0-0x000000018037DDD0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x000000018037DDC0-0x000000018037DDD0
	private bool tUdkReKczrBxWoihLGDjsVjAQcJ(); // 0x0000000180411240-0x0000000180411310
	private void ZIwErSPsRHysykRTleiYxGabUDz(bool param_00011115); // 0x0000000180410970-0x0000000180410A10
	private void XtWXdnxjiYEMzAMQjjlCxGbKFQGa(); // 0x0000000180410920-0x0000000180410970
	private void UFvNNhUxYeMKmvQvJQFLhKvfFOr(); // 0x000000018040FDD0-0x000000018040FE30
	private void OFhFIbecuvkSjdBkIUeKkNFxQZbY(); // 0x000000018040F310-0x000000018040F6D0
	private void cmFNiAyLrpVuTovYJgIFGpTKbnZ(); // 0x0000000180410FF0-0x0000000180411060
	private void rqflAVLdAqKlvGiSSnRFiKajexu(); // 0x0000000180411170-0x0000000180411240
	private bool RcKmZMJMxkzNaEncnPqmJkCoHRE(); // 0x000000018040FAD0-0x000000018040FCF0
	private bool[] FvLKFcQMeefcgCXUhcNWOcCLyRn(); // 0x000000018040EC30-0x000000018040ED60
	private void zAQSqQtWbUvmkjIWmRwVVeefdsA(bool[] param_00011116); // 0x00000001804116D0-0x0000000180411BD0
	private bool UbDkLfmxvvmLDkJnYieQDfWbCeJd(mNERgZsNbTklwRPFuHDMJNORfHb param_00011117, bool param_00011118); // 0x000000018040FE30-0x0000000180410750
	public static bool wCpCDDiRQzSpUvOmtYlfkXqTsKN(string param_00011119, string param_0001111a, string param_0001111b, Guid param_0001111c); // 0x0000000180411310-0x00000001804116D0
}

