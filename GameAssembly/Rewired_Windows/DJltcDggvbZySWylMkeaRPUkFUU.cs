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

// Image 66: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8066-8357

internal class DJltcDggvbZySWylMkeaRPUkFUU : PlatformInputManager // TypeDefIndex: 8106
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
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override int deviceCount { get; } // 0x0000000180362090-0x0000000180362180 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000180362190-0x00000001803621A0 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IInputSource inputSource { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override InputSource inputSourceType { get; } // 0x0000000180362180-0x0000000180362190 

	// Nested types
	private class mNERgZsNbTklwRPFuHDMJNORfHb : IDisposable, IInputManagerJoystick // TypeDefIndex: 8107
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
		public string PVKaLjOCEVxeuXVCVCLIazqSdPO { get; } // 0x0000000180372030-0x00000001803720E0 
		public string pNNtlXYRfFRfSKbBcBnNXSyYaYdg { get; } // 0x00000001803722D0-0x0000000180372360 
		public bool YxrzUZDshLahFMRJWSqvKyPACYo { get; } // 0x00000001803720E0-0x00000001803721B0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int rewiredId { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int inputManagerId { get; } // 0x0000000180367710-0x0000000180367720 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public string name { get; } // 0x00000001803721B0-0x00000001803722D0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public long? systemId { get; } // 0x0000000180372370-0x00000001803723D0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int unityId { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Controller.Extension extension { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Guid instanceGuid { get; } // 0x000000018036CB40-0x000000018036CB50 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Guid persistentGuid { get; } // 0x000000018036CB40-0x000000018036CB50 

		// Constructors
		public mNERgZsNbTklwRPFuHDMJNORfHb(int systemId, bool isWin8AppStore, VxzKNvoPFxEvzHeyjWXgRZaCnIB sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Action deviceDisconnectedDelegate); // 0x0000000180371BE0-0x0000000180371CC0

		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void SetVibration(float amount, int motorIndex); // 0x0000000180371100-0x00000001803711D0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void StopVibration(); // 0x00000001803711D0-0x0000000180371200
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void Update(); // 0x0000000180371570-0x00000001803718A0
		public void qXdMretsmUtHGUnAyVbWksgeZOe(bool param_00010e81); // 0x00000001803728A0-0x00000001803728B0
		public bool fhlqyHHlVVRCrjQDTBoaYkvayiB(SZonfVpcAmagTECoXnSCrepkmax param_00010e82); // 0x0000000180371FB0-0x0000000180371FD0
		public bool ceNFAWhtmQETjaRxyqXIitRxHkf(SZonfVpcAmagTECoXnSCrepkmax param_00010e83); // 0x0000000180371CC0-0x0000000180371D70
		public void fUTcAzMqjqfGqHdSSTvCccLOwgmN(bool param_00010e84); // 0x0000000180371FA0-0x0000000180371FB0
		public void XIbEGfWXMHCwpmCMxIYlaXAfXJCc(); // 0x0000000180371AE0-0x0000000180371BA0
		public void mdAaJkSUssKBuPczsnYwnZjozqJ(); // 0x0000000180372800-0x00000001803728A0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void FillData(ControllerDataUpdater dataUpdater); // 0x0000000180370540-0x00000001803707A0
		public BridgedControllerHWInfo gbrBUxoFEhBBZhXueJHCQMMzfJU(); // 0x0000000180371FD0-0x0000000180372030
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public BridgedController ToBridgedController(); // 0x0000000180371200-0x0000000180371510
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x0000000180371510-0x0000000180371570
		private void iprGZknTIARCuPKHvBlGSSXnbgi(); // 0x00000001803723D0-0x0000000180372800
		private bool EHKbHsJaBpcbYYZPoGEESqBrHJyo(); // 0x0000000180370420-0x00000001803704D0
		private void wJOWuPFMVrjFcdpIWkrjikYmGha(); // 0x0000000180372C20-0x0000000180372C30
		private void ZOaVIQlCNwjvITKsdbNdMsLEfCA(); // 0x0000000180371BA0-0x0000000180371BE0
		private void vAtlDGAFFZDBSWfVQjpKMYROXUB(bool[] param_00010e86, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00010e87); // 0x00000001803729C0-0x0000000180372C20
		private void WwLhoTbvnRBIbNCDsBjlVXxPMDA(bool[] param_00010e88, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00010e89); // 0x00000001803718A0-0x0000000180371AE0
		private float ddeAaEoPBwfkDXGlLfHOkRXUPnOG(HardwareJoystickMap.Platform_XInput_Base.Axis param_00010e8a, bool[] param_00010e8b, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00010e8c); // 0x0000000180371E70-0x0000000180371EF0
		private float ddeAaEoPBwfkDXGlLfHOkRXUPnOG(XInputAxis param_00010e8d, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00010e8e); // 0x0000000180371EF0-0x0000000180371FA0
		private bool NazkUlYeVVjyDXBchdfNhwTesrFk(HardwareJoystickMap.Platform_XInput_Base.Button param_00010e8f, bool[] param_00010e90, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00010e91); // 0x0000000180370C30-0x0000000180370CD0
		private bool NazkUlYeVVjyDXBchdfNhwTesrFk(XInputButton param_00010e92, bool[] param_00010e93); // 0x0000000180370840-0x0000000180370C30
		private float EqiBwibyZqNRgcBrauXECrZPRDY(int param_00010e94); // 0x00000001803704D0-0x0000000180370540
		private float DDKPoCuwcrssolbpxuhWZMXflay(int param_00010e95); // 0x0000000180370340-0x00000001803703B0
		private void chgLTsLAoRqfgzxaGOxybgGGSFw(); // 0x0000000180371D70-0x0000000180371E70
		private string yozgjbgkVMDipbeGSOfIRgnpyhr(); // 0x0000000180372C30-0x0000000180372F70
		private void PCBbqseklYNTQIOEEAPmbLgGBmJd(BridgedControllerHWInfo param_00010e96); // 0x0000000180370CD0-0x0000000180370E30
		private void PCBbqseklYNTQIOEEAPmbLgGBmJd(BridgedController param_00010e97); // 0x0000000180370E30-0x0000000180371100
		public void Dispose(); // 0x00000001803703B0-0x0000000180370420
		~mNERgZsNbTklwRPFuHDMJNORfHb(); // 0x00000001803707A0-0x0000000180370840
		protected virtual void ukZeJfPzbKmpvxrUBgmIykVNKVO(bool param_00010e98); // 0x00000001803728B0-0x00000001803729C0
	}

	private class mKVKuSqkZCRMxBDOWcYtGkhntTPf // TypeDefIndex: 8108
	{
		// Fields
		private List<ehwYjFTvZcXzFWTzeEbKyfUoHjM> CKRDfIDoRuhjHMZoRoGYskqfniS; // 0x10

		// Nested types
		private class ehwYjFTvZcXzFWTzeEbKyfUoHjM // TypeDefIndex: 8109
		{
			// Fields
			public bool GgoSbebYNGKOUBMowcyObAhgfMlB; // 0x10
			public int bCdxFnoMWYtrCiNLlRQMlgiLhPYa; // 0x14
			public XInputDeviceSubType XjqvgNQWaQKnnfyWsKRrCVDwjSr; // 0x18

			// Constructors
			public ehwYjFTvZcXzFWTzeEbKyfUoHjM(int rewiredId, XInputDeviceSubType deviceSubType); // 0x000000018036E690-0x000000018036E6E0

			// Methods
			public void bDpjnZNTIBcpcFFeCkJZEztApBtU(mNERgZsNbTklwRPFuHDMJNORfHb param_00010ea6, bool param_00010ea7); // 0x000000018036E6E0-0x000000018036E730
		}

		// Constructors
		public mKVKuSqkZCRMxBDOWcYtGkhntTPf(); // 0x000000018036FF90-0x000000018036FFF0

		// Methods
		public void MRyMEXTbctvdQeQggKFhNpKgubz(mNERgZsNbTklwRPFuHDMJNORfHb param_00010e99, bool param_00010e9a); // 0x000000018036FCC0-0x000000018036FE10
		public void bDpjnZNTIBcpcFFeCkJZEztApBtU(int param_00010e9b, mNERgZsNbTklwRPFuHDMJNORfHb param_00010e9c, bool param_00010e9d); // 0x000000018036FFF0-0x00000001803700D0
		public int YSuIEzLqUHABhBltDalKFVyCTNN(XInputDeviceSubType param_00010e9e, bool param_00010e9f); // 0x000000018036FE10-0x000000018036FF90
		public int daFyNXXCvqkrBdbqihawLHSTSUF(int param_00010ea0, XInputDeviceSubType param_00010ea1, bool param_00010ea2); // 0x00000001803700D0-0x0000000180370290
		public int vObAeLkMJPgHQxAcWKIPlyXGNEL(int param_00010ea3); // 0x0000000180370290-0x0000000180370340
		public void KIbPfJcWSFGmGyeBztYAHmQMLul(int param_00010ea4, bool param_00010ea5); // 0x000000018036FC20-0x000000018036FCC0
	}

	private class oDPACVeCFkiLRDUQHNPMAEzGmvH // TypeDefIndex: 8110
	{
		// Fields
		public bool rKWYspzGRntcPPozuzWnbwhpgxs; // 0x10
		private float fRLagRhYZbysBqvKzTDZjYDpfBzI; // 0x14
		public float NiLnpeIiCMbOFMxOgnWuCIJnrWY; // 0x18

		// Constructors
		public oDPACVeCFkiLRDUQHNPMAEzGmvH(float inLength); // 0x0000000180372F70-0x0000000180372FA0

		// Methods
		public void mrZgAcxGDpNHXwBRLYlfZLapcCNA(); // 0x0000000180373020-0x00000001803730A0
		public bool bDpjnZNTIBcpcFFeCkJZEztApBtU(); // 0x0000000180372FA0-0x0000000180373020
	}

	public class VxzKNvoPFxEvzHeyjWXgRZaCnIB : IDisposable // TypeDefIndex: 8111
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
		public bool[] wKOnPbKbGRtJlXJeMiMmKJJWUdx { get; } // 0x000000018036DDB0-0x000000018036DE10 

		// Constructors
		public VxzKNvoPFxEvzHeyjWXgRZaCnIB(int controllerIndex, UpdateLoopSetting updateLoops); // 0x000000018036D840-0x000000018036D9C0

		// Methods
		public void jVhgReScAKXEjvimtGikJhORNWY(); // 0x000000018036DE50-0x000000018036DF30
		public void TvOJSlVHdjCFIAwzRDmMHSuuRMt(); // 0x000000018036D480-0x000000018036D5F0
		public void hxBuCPWjXWEpuKzEmRBqHrRWHeXE(); // 0x000000018036DE10-0x000000018036DE50
		public void CVGHsGZeOSnwBwCnzeEFdNmYVFh(); // 0x000000018036D000-0x000000018036D010
		public bool ceNFAWhtmQETjaRxyqXIitRxHkf(SZonfVpcAmagTECoXnSCrepkmax param_00010ead); // 0x000000018036DA70-0x000000018036DB10
		public void JLEbXnJHtVbsKJYkNVSkMdgwQfl(float param_00010eae, int param_00010eaf); // 0x000000018036D1C0-0x000000018036D280
		public void GNkiLvkRZDdVIwjLTPEVjnxgClfK(); // 0x000000018036D1B0-0x000000018036D1C0
		public void nKgEkSjuMYLnoocqvhdzBIjvcZWq(); // 0x000000018036E1C0-0x000000018036E370
		public void eFJqovjFOFlKNlUAOskMqjWaKxQ(); // 0x000000018036DB10-0x000000018036DC10
		public void ZoAEycRYSsLSBuKWsFcMOpvFWeq(); // 0x000000018036D5F0-0x000000018036D840
		private void KCYOQXbgAhqnanMhxUXWYOspNXH(); // 0x000000018036D280-0x000000018036D390
		private void vkgGGWgIJrRKJnodYqegAssjwiE(); // 0x000000018036D280-0x000000018036D390
		private void PkjJgCiyffTFzgeREnVfEAtRzQc(); // 0x000000018036D3B0-0x000000018036D480
		private static void CyaoxVjruiSsDjkRrWFvfCoMCn(RingBuffer<gbcTfrWUAyyjnYRbyXTemSdghFG> param_00010eb0, ZhvgftZzLTTvmAppvXznBMXxHXw param_00010eb1, ref float param_00010eb2); // 0x000000018036D010-0x000000018036D0A0
		private static void aDHEmiFPJtgOygtWyXzBdWlfRNxe(ZhvgftZzLTTvmAppvXznBMXxHXw param_00010eb3, gbcTfrWUAyyjnYRbyXTemSdghFG param_00010eb4, ref float param_00010eb5); // 0x000000018036D9C0-0x000000018036DA70
		private void lfSloTkDiaIvRcVQzSqDKDsLxO(ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00010eb6); // 0x000000018036E030-0x000000018036E1C0
		private void lBbbcgyclxAtpIRBCAyUEoZbJfCM(byte[] param_00010eb7, ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00010eb8); // 0x000000018036DF30-0x000000018036E030
		private void unalaRKSlKqpWcANALfIpMVINnC(ref VEbVajMVdbsHdwPajvaXXgzBgbU param_00010eb9, float param_00010eba, byte[] param_00010ebb); // 0x000000018036E3B0-0x000000018036E600
		private bool NazkUlYeVVjyDXBchdfNhwTesrFk(int param_00010ebc, int param_00010ebd); // 0x000000018036D390-0x000000018036D3B0
		private void fDgYQYQKaPimAijWAfVtGjstdSLo(); // 0x000000018036DC10-0x000000018036DDB0
		public void Dispose(); // 0x000000018036D0A0-0x000000018036D110
		~VxzKNvoPFxEvzHeyjWXgRZaCnIB(); // 0x000000018036D110-0x000000018036D1B0
		protected virtual void ukZeJfPzbKmpvxrUBgmIykVNKVO(bool param_00010ebe); // 0x000000018036E370-0x000000018036E3B0
	}

	public enum SZonfVpcAmagTECoXnSCrepkmax // TypeDefIndex: 8112
	{
		UwUmRWvwLwaKrSDPbhAIwmDqfnY = 0,
		sHwiOvCfpiZsAQobWHADUOvTUPJ = 1
	}

	// Constructors
	public DJltcDggvbZySWylMkeaRPUkFUU(bool isWin10AUHack, UpdateLoopSetting updateLoop, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId); // 0x0000000180361C20-0x0000000180362020
	static DJltcDggvbZySWylMkeaRPUkFUU(); // 0x0000000180361A10-0x0000000180361C20

	// Methods
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void Initialize(); // 0x000000018035FCD0-0x0000000180360280
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void Update(UpdateLoopType currentUpdateLoop); // 0x0000000180361790-0x0000000180361920
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void OnDestroy(); // 0x0000000180360650-0x0000000180360A60
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x000000018035FCB0-0x000000018035FCC0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data); // 0x0000000180361730-0x0000000180361790
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SystemDeviceConnected(); // 0x0000000180360C90-0x0000000180360CF0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SystemDeviceDisconnected(); // 0x0000000180360CF0-0x0000000180360D70
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001803581E0-0x00000001803581F0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018035FCC0-0x000000018035FCD0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x000000018035FCC0-0x000000018035FCD0
	private bool tUdkReKczrBxWoihLGDjsVjAQcJ(); // 0x0000000180362270-0x0000000180362340
	private void ZIwErSPsRHysykRTleiYxGabUDz(bool param_00010e71); // 0x0000000180361970-0x0000000180361A10
	private void XtWXdnxjiYEMzAMQjjlCxGbKFQGa(); // 0x0000000180361920-0x0000000180361970
	private void UFvNNhUxYeMKmvQvJQFLhKvfFOr(); // 0x0000000180360D70-0x0000000180360DD0
	private void OFhFIbecuvkSjdBkIUeKkNFxQZbY(); // 0x0000000180360280-0x0000000180360650
	private void cmFNiAyLrpVuTovYJgIFGpTKbnZ(); // 0x0000000180362020-0x0000000180362090
	private void rqflAVLdAqKlvGiSSnRFiKajexu(); // 0x00000001803621A0-0x0000000180362270
	private bool RcKmZMJMxkzNaEncnPqmJkCoHRE(); // 0x0000000180360A60-0x0000000180360C90
	private bool[] FvLKFcQMeefcgCXUhcNWOcCLyRn(); // 0x000000018035FB70-0x000000018035FCB0
	private void zAQSqQtWbUvmkjIWmRwVVeefdsA(bool[] param_00010e72); // 0x0000000180362710-0x0000000180362C60
	private bool UbDkLfmxvvmLDkJnYieQDfWbCeJd(mNERgZsNbTklwRPFuHDMJNORfHb param_00010e73, bool param_00010e74); // 0x0000000180360DD0-0x0000000180361730
	public static bool wCpCDDiRQzSpUvOmtYlfkXqTsKN(string param_00010e75, string param_00010e76, string param_00010e77, Guid param_00010e78); // 0x0000000180362340-0x0000000180362710
}

