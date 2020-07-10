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
using Rewired.Libraries.SharpDX.DirectInput;
using Rewired.Platforms;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;

// Image 66: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8066-8357

internal class YnFajCFRWOqAjzMkGLVZcohEXjK : PlatformInputManager, NhVfibDxHVoKZLYCMpDnGvgCwqbK // TypeDefIndex: 8080
{
	// Fields
	private IntPtr FHjsOeKWgFyNwsZlZzTZSCoYMUW; // 0x38
	private DirectInput GPmLgdQQlgLidwdHkXEIaVlTCCA; // 0x40
	private List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> vkCJlicxkwEXmIyvHAwORXTSDXy; // 0x48
	private int GqppXomYSVBRlTlodGyMfZjVXjSo; // 0x50
	private wSxzldZGrFHtZSRKEpEoiCDqSCe syfbMIvyiiqvvTcCHIpgYnNUDLY; // 0x58
	private bool wDxUslfEBZiTDyPnLPIExlXEWNP; // 0x60
	private bool RKDZFIYYlgESnVXDJfzHkqxeBPZ; // 0x61
	private UpdateLoopSetting sYTsVPIBIoZTbdiLBrLppyjsAkG; // 0x64
	private Action<int, ControllerDataUpdater> foXIqDIskRyntvUJrVarmOifcqn; // 0x68
	private PlatformInputManager vxvdOmjUaxPdZoojPEpVbAJOQRic; // 0x70
	private TimerRealTime cEsxSKeemeADmVePpHfVxMflGqu; // 0x78
	private qPGcqldiSPYhNvecKMmeQWmBzsAc<bool> eTsnPUJyDifJhMtlrKQVlPlWGtjh; // 0x80
	private int ffeQFoUigxGxtnUJWGKiCSzDCSQs; // 0x88
	private int tXBPFSnYDhfgdjjukAtpAGwIQaOi; // 0x8C
	private qPGcqldiSPYhNvecKMmeQWmBzsAc<List<dksAsEiTyYAzDrbikJflOwuqUIOg>> VCILtlUhYfkfeeJKxejKJbyqIehi; // 0x90
	private wfbccLOvlWADzAsMpbjyklYLfIoR HELdlHBPoruIfOVjPjETxRfsiHj; // 0x98
	private readonly object xQVWyJdIgyRHBquJzbxoxRuijtA; // 0xA0
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> SPPGEprkVSKsolJOZAOXmfAPQau; // 0xA8
	private Func<int> NjwvsULqnevgrqobWcYoUdYGcbI; // 0xB0

	// Properties
	public bool OWGnbOYLKxblRayALCFlSXflpRF { set; } // 0x000000018042EE00-0x000000018042EE10
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override int deviceCount { get; } // 0x0000000180369BA0-0x0000000180369BB0 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000180369B50-0x0000000180369B60 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IInputSource inputSource { get; } // 0x000000018042E680-0x000000018042E6E0 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override InputSource inputSourceType { get; } // 0x000000018042E670-0x000000018042E680 

	// Nested types
	private class TUmUoEGFyYTOZlLrFyZFIrnQkRS : IInputManagerJoystick // TypeDefIndex: 8081
	{
		// Fields
		private int sfnaQCVIFsoKjRqOSiTleJAfZea; // 0x10
		private int tOYJtwxjUzCmljfMnmuNZUudLyAf; // 0x14
		public Guid wDiIVDapdBSywchkAEYXcQxqRiaD; // 0x18
		public string wcmrNAnNnYIsTihDNhRqdAqLidd; // 0x28
		public readonly DbAgWvggFEEJFAvDJzgCQDZsasHT FHrmTAMUixetljGBkWIzbnxEwoS; // 0x30
		public AWARuLKFrIKzIKknTkXdungFUra NhmVtTIoXzRgEFujUvNUXMmlfIf; // 0x38
		public cqoHseelTbGskTpMXNVSRPcBRWg BsQxjBkEtUvcvuoRWcKeGdoTxIxd; // 0x40
		public string PVKaLjOCEVxeuXVCVCLIazqSdPO; // 0x48
		public string pNNtlXYRfFRfSKbBcBnNXSyYaYdg; // 0x50
		public int QygOnjYyisaYSBnluWdqknqZzgb; // 0x58
		public Guid TpDziRSLyFCVcolCVBxAyNBlKGR; // 0x5C
		public Guid JrBDitCUNBKGDllPsPtLaLuFBmZy; // 0x6C
		public Guid rdGanhCiTrROfmNNNaUKzFlVNCiP; // 0x7C
		public int LIdoOugaCYbKvpwirbINuYCzESc; // 0x8C
		public bool snrpjhppIOaNWjjQPhDwPRlNEpFG; // 0x90
		public string ugXDWJYVvUfgGLFNPlVvGayWMsO; // 0x98
		public string HBppcMwMrtTquIjvfrrwylwfHcD; // 0xA0
		public int JgBAtqYdHUKFdrWHdqOfMZKvHqg; // 0xA8
		public int GuWVzKdBwtETsWrUYCvhOPboNNj; // 0xAC
		public int KBkLyHtWnkRWiqBGUUwmrqOHqVH; // 0xB0
		public int JvZculfQbOETGIKGOnGiPJYPLDBI; // 0xB4
		public int osLJBgamzkKrzDYloJPRQAwOBDs; // 0xB8
		public bool fmgfNWvDRXutUQXikljgWMxBHmc; // 0xBC
		private float[] gEvIfPoNUeIWjZEtgeYJbgimKTc; // 0xC0
		private bool[] AALaecJavdNfurAiURsHgWsSGwc; // 0xC8
		private HardwareJoystickMap_InputManager szkLRBAGgmWPuPNDxAzLTpOygLx; // 0xD0
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> SPPGEprkVSKsolJOZAOXmfAPQau; // 0xD8
		private bool VdaLCwxPTzGOIIiGYzXXbfNBefv; // 0xE0
		private bool kVyAEQgTiizdGtANtIomOfhFKQg; // 0xE1
		private bool IwDfiQosJoZcfnCuKPuSDWCkvQz; // 0xE2

		// Properties
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int rewiredId { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int inputManagerId { get; set; } // 0x0000000180372360-0x0000000180372370 0x000000018036C6F0-0x000000018036C700
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public string name { get; } // 0x00000001804C5A10-0x00000001804C5AB0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public long? systemId { get; } // 0x00000001804C5AB0-0x00000001804C5B60 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public int unityId { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Controller.Extension extension { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Guid instanceGuid { get; } // 0x00000001804C5A00-0x00000001804C5A10 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public Guid persistentGuid { get; } // 0x00000001804C5A00-0x00000001804C5A10 

		// Constructors
		public TUmUoEGFyYTOZlLrFyZFIrnQkRS(DbAgWvggFEEJFAvDJzgCQDZsasHT sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager); // 0x00000001804C4070-0x00000001804C40C0

		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void SetVibration(float amount, int motorIndex); // 0x00000001803581E0-0x00000001803581F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void StopVibration(); // 0x00000001803581E0-0x00000001803581F0
		public void PzDxfHSrAHYAAhFeMfJRCxnpwqE(); // 0x00000001804C36A0-0x00000001804C3A10
		public void NClxjNcPgUJJGYyiykTiBudFLhN(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d52); // 0x00000001804C2400-0x00000001804C2690
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void Update(); // 0x00000001804C3C20-0x00000001804C3D00
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public void FillData(ControllerDataUpdater dataUpdater); // 0x00000001804C2070-0x00000001804C2340
		public int nhWDuBakmJfkdCgvAWAkhoruXhxA(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d54); // 0x00000001804C5E10-0x00000001804C5F70
		private BridgedControllerHWInfo gbrBUxoFEhBBZhXueJHCQMMzfJU(); // 0x00000001804C59A0-0x00000001804C5A00
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public BridgedController ToBridgedController(); // 0x00000001804C3AA0-0x00000001804C3BC0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x00000001804C3BC0-0x00000001804C3C20
		public bool jpZeCltOITzIqSxAvIApkadPZtr(); // 0x00000001804C5CF0-0x00000001804C5D60
		public void kmxWiElONBwdCIeFdCJXYxrvdbQH(); // 0x00000001804C5D60-0x00000001804C5E10
		private void vAtlDGAFFZDBSWfVQjpKMYROXUB(bool[] param_00010d55, int[] param_00010d56); // 0x00000001804C6220-0x00000001804C6570
		private void WwLhoTbvnRBIbNCDsBjlVXxPMDA(bool[] param_00010d57, int[] param_00010d58); // 0x00000001804C3D00-0x00000001804C4070
		private void sereoiihHgKiMaYtaGZAVtoBEeCU(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_00010d59, int param_00010d5a, bool[] param_00010d5b, int[] param_00010d5c); // 0x00000001804C5F70-0x00000001804C6110
		private void itoEuTsnAJcLvnlTzCzuBdrlmMCq(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_00010d5d, int param_00010d5e, bool[] param_00010d5f, int[] param_00010d60); // 0x00000001804C5B60-0x00000001804C5CF0
		private float ddeAaEoPBwfkDXGlLfHOkRXUPnOG(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_00010d61, bool[] param_00010d62, int[] param_00010d63); // 0x00000001804C5180-0x00000001804C59A0
		private float ddeAaEoPBwfkDXGlLfHOkRXUPnOG(DirectInputAxis param_00010d64); // 0x00000001804C4470-0x00000001804C5180
		private bool NazkUlYeVVjyDXBchdfNhwTesrFk(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_00010d65, bool[] param_00010d66, int[] param_00010d67); // 0x00000001804C2690-0x00000001804C3410
		private float EqiBwibyZqNRgcBrauXECrZPRDY(int param_00010d68); // 0x0000000180375960-0x00000001803759D0
		private bool BqobctiMIBLZinzbMgyWaamHNzYQ(int param_00010d69, int param_00010d6a, HatType param_00010d6b); // 0x00000001804C1EE0-0x00000001804C2020
		private float QjmjTnjsSLwTjgBrFBJfbwfEhbo(int param_00010d6c, AxisDirection param_00010d6d); // 0x00000001804C3A10-0x00000001804C3AA0
		private bool ISmxhqCDNAqoRmCzdbqueoWHZze(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_00010d6e, bool[] param_00010d6f, out bool param_00010d70); // 0x00000001804C2340-0x00000001804C2400
		private bool bgrRzpvJmumcVUJLWrkdYQsZfcR(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_00010d71, out float param_00010d72); // 0x00000001804C4110-0x00000001804C4380
		private ControlDeviceType EbBtUZBMKDCHAJQbDaYdLWdgahNU(cqoHseelTbGskTpMXNVSRPcBRWg param_00010d73); // 0x00000001804C2020-0x00000001804C2070
		private void chgLTsLAoRqfgzxaGOxybgGGSFw(); // 0x00000001804C4380-0x00000001804C4470
		private string yElEPVKJpZjLrUNflNIKGVNmdOEh(); // 0x00000001804C68B0-0x00000001804C6F40
		private void PCBbqseklYNTQIOEEAPmbLgGBmJd(BridgedControllerHWInfo param_00010d74); // 0x00000001804C34F0-0x00000001804C36A0
		private void PCBbqseklYNTQIOEEAPmbLgGBmJd(BridgedController param_00010d75); // 0x00000001804C3410-0x00000001804C34F0
		private UnknownControllerHat[] yAltpHIGiQujNhHcTiKVTQIDWRb(); // 0x00000001804C6570-0x00000001804C68B0
		public void ukZeJfPzbKmpvxrUBgmIykVNKVO(); // 0x00000001804C6110-0x00000001804C61A0
		~TUmUoEGFyYTOZlLrFyZFIrnQkRS(); // 0x0000000180375E00-0x0000000180375EA0
		protected virtual void ukZeJfPzbKmpvxrUBgmIykVNKVO(bool param_00010d76); // 0x00000001804C61A0-0x00000001804C6220
		public static int DCEAIrtYNRwoxAlGMuuCDniqleA(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d77, TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d78); // 0x000000018037A600-0x000000018037A640
		public static int aMEMqWZHdasPYBCQFndZcyoSdVC(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d79, TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d7a); // 0x00000001804C40C0-0x00000001804C4110
	}

	private class DbAgWvggFEEJFAvDJzgCQDZsasHT : IDisposable // TypeDefIndex: 8082
	{
		// Fields
		private readonly int IVsiltjHrlyHMzzAsnRprcroBGb; // 0x10
		private readonly ButtonLoopSet KmSdXEBjObBEEGgVzPgTlimUVMba; // 0x18
		private readonly DualRingReportBuffer ZGqQXdwjrAfmOStTFVAHpOzGciY; // 0x20
		public readonly SlQJAJyPmnQOiXQNEoKZMinAMhO hWDeJGpknyImCbqJkSnevbUWlsFV; // 0x28
		private readonly eShRWneHfEMQNulXAssvRrsrPZg ZMUanodmUNCuxBPlMIdbqzEIBukb; // 0x30
		private MrRCsQHqqpJAvNotshtKOTrXvzk OGHRiAJrpZtDfoHeEJZxMQSyeFC; // 0x38
		private readonly eShRWneHfEMQNulXAssvRrsrPZg pSdtySmOesiyaswvTrzDBrrjINu; // 0x40
		private readonly object WufDIingVgDpfvpJIUsUrFOPhQi; // 0x48
		private byte[] IakNvUjnhjYspcFJnKjTxzawrOQ; // 0x50
		private byte[] LEcAoiaTQYAINRGoIesOIgwupaGz; // 0x58
		private bool EWhtEIyTwrpqIzgnZPXBXEbtUQs; // 0x60
		private eShRWneHfEMQNulXAssvRrsrPZg FhZreEfhNgsxBeAsULarokPgECG; // 0x68
		private bool IwDfiQosJoZcfnCuKPuSDWCkvQz; // 0x70

		// Properties
		public bool[] wKOnPbKbGRtJlXJeMiMmKJJWUdx { get; } // 0x0000000180415750-0x00000001804157B0 
		public eShRWneHfEMQNulXAssvRrsrPZg VhLgULgHAlJwhBzWNSJVaZDTOFCi { get; } // 0x0000000180358970-0x0000000180358980 

		// Constructors
		public DbAgWvggFEEJFAvDJzgCQDZsasHT(SlQJAJyPmnQOiXQNEoKZMinAMhO source, UpdateLoopSetting updateLoops); // 0x00000001804150C0-0x00000001804152E0

		// Methods
		public void jVhgReScAKXEjvimtGikJhORNWY(); // 0x00000001804157C0-0x0000000180415910
		public void TvOJSlVHdjCFIAwzRDmMHSuuRMt(); // 0x0000000180414A00-0x0000000180414A60
		public void hxBuCPWjXWEpuKzEmRBqHrRWHeXE(); // 0x00000001804157B0-0x00000001804157C0
		public void CVGHsGZeOSnwBwCnzeEFdNmYVFh(); // 0x0000000180414450-0x0000000180414460
		public void NClxjNcPgUJJGYyiykTiBudFLhN(DbAgWvggFEEJFAvDJzgCQDZsasHT param_00010d7d); // 0x00000001804145E0-0x0000000180414A00
		public void yefBitbYBFvoVPkbXMmTySLXadR(int param_00010d7e, int param_00010d7f, int param_00010d80, float param_00010d81); // 0x0000000180415A60-0x0000000180415D10
		private void eahCgkomBjwwNpwOonGeIbrxAUW(); // 0x00000001804154E0-0x0000000180415650
		private void eAixrySQUxKTYsBxrvNhlQKiTtS(eShRWneHfEMQNulXAssvRrsrPZg param_00010d82); // 0x00000001804152E0-0x00000001804154E0
		private void WuACSMdXdVKCGPSyMYMygICKKPZc(byte[] param_00010d83, eShRWneHfEMQNulXAssvRrsrPZg param_00010d84); // 0x0000000180414DA0-0x00000001804150C0
		private void WUgNwLxzgLVFhMHQfppUCruzijl(eShRWneHfEMQNulXAssvRrsrPZg param_00010d85, float param_00010d86, byte[] param_00010d87); // 0x0000000180414A60-0x0000000180414DA0
		private void fDgYQYQKaPimAijWAfVtGjstdSLo(); // 0x0000000180415650-0x0000000180415750
		private void KBJCTXijuFzTsafHXFifDjpwrYU(eShRWneHfEMQNulXAssvRrsrPZg param_00010d88); // 0x00000001804144D0-0x00000001804145E0
		public void Dispose(); // 0x0000000180414460-0x00000001804144D0
		~DbAgWvggFEEJFAvDJzgCQDZsasHT(); // 0x000000018036D110-0x000000018036D1B0
		protected virtual void ukZeJfPzbKmpvxrUBgmIykVNKVO(bool param_00010d89); // 0x0000000180415910-0x0000000180415A60
	}

	private class MrRCsQHqqpJAvNotshtKOTrXvzk // TypeDefIndex: 8083
	{
		// Fields
		private eShRWneHfEMQNulXAssvRrsrPZg rlayWhCtBXbMnNIHafUbCwWWdNi; // 0x10
		private TNVjpVQMkschjmjzRsAlTpMcDxL VrRPNaAHjBDKezRqTeTVWsTbibS; // 0x18
		private int dYmFMNjtOosDbfpkRtEjuaTnxHFE; // 0x20
		private int kuxgyVdzXrVbFmbuCpdBcpiHXef; // 0x24
		private int gLiaTCEIfzgfydAXAhNccPFWjEOf; // 0x28
		private float yfPDOWnfGnnNcxwJMtGbWCqtAVNg; // 0x2C

		// Properties
		public eShRWneHfEMQNulXAssvRrsrPZg OpNomNgPgwIrfElpsUSOdjKAaozE { get; } // 0x000000018036AC80-0x000000018036AC90 

		// Constructors
		public MrRCsQHqqpJAvNotshtKOTrXvzk(eShRWneHfEMQNulXAssvRrsrPZg state, int axisMin, int axisMax, int axisZero, float eventTimeout); // 0x0000000180419880-0x0000000180419960
		private MrRCsQHqqpJAvNotshtKOTrXvzk(MrRCsQHqqpJAvNotshtKOTrXvzk source, eShRWneHfEMQNulXAssvRrsrPZg state); // 0x00000001804197A0-0x0000000180419880
		private MrRCsQHqqpJAvNotshtKOTrXvzk(int axisMin, int axisMax, int axisZero, float axisTimeout); // 0x0000000180419710-0x00000001804197A0

		// Methods
		public static MrRCsQHqqpJAvNotshtKOTrXvzk szAOBsGyRiCvsgdIOMaFjixERNI(MrRCsQHqqpJAvNotshtKOTrXvzk param_00010d8a, eShRWneHfEMQNulXAssvRrsrPZg param_00010d8b); // 0x000000018041A980-0x000000018041AAA0
		public void bDpjnZNTIBcpcFFeCkJZEztApBtU(float param_00010d97); // 0x0000000180419960-0x000000018041A8A0
		public void iAKzPRPwmWNxLkOsOgJnjiXjEMBA(MrRCsQHqqpJAvNotshtKOTrXvzk param_00010d98); // 0x000000018041A8D0-0x000000018041A980
		private int ePmXlMjAuWnSVEJAmZOtLYQdrpk(int param_00010d99); // 0x000000018041A8A0-0x000000018041A8D0
	}

	private class TNVjpVQMkschjmjzRsAlTpMcDxL // TypeDefIndex: 8084
	{
		// Fields
		private float ZTZAISXlgYUjTqCHmGuRRjruGqKE; // 0x10
		private eShRWneHfEMQNulXAssvRrsrPZg cjRbvLSbcTrtkIHRXCTVLNQdwkI; // 0x18
		private eShRWneHfEMQNulXAssvRrsrPZg dORETaOSVkMRDkwHCkxJLAkwyXe; // 0x20
		private eShRWneHfEMQNulXAssvRrsrPZg pHbanrGsJBhJVBjLfvepeHuzPjSb; // 0x28
		private bool GogTPVtTzaegJkqMgPsszjWEaee; // 0x30
		private float QfxIqNPOnHXceyTmNtxfTaMYXnO; // 0x34

		// Properties
		public eShRWneHfEMQNulXAssvRrsrPZg UQqusYQHVNDrXJVttLDifadIWPhS { get; } // 0x000000018038B150-0x000000018038B160 
		public eShRWneHfEMQNulXAssvRrsrPZg ynkAVFDGSRsaruNiMwkcUIzadTZM { get; } // 0x0000000180369B60-0x0000000180369B70 
		public bool HeFFXigqvCOEWuSRNzCvDuBxJERE { get; } // 0x000000018048B840-0x000000018048B850 
		public float jnZUcWfRYCfhEOxcjUvkRnDUNHv { get; } // 0x00000001804C16A0-0x00000001804C16B0 

		// Constructors
		public TNVjpVQMkschjmjzRsAlTpMcDxL(eShRWneHfEMQNulXAssvRrsrPZg sourceState); // 0x00000001804C0690-0x00000001804C0710

		// Methods
		public void bDpjnZNTIBcpcFFeCkJZEztApBtU(float param_00010d9b); // 0x00000001804C0710-0x00000001804C16A0
		public void iAKzPRPwmWNxLkOsOgJnjiXjEMBA(TNVjpVQMkschjmjzRsAlTpMcDxL param_00010d9c); // 0x00000001804C16B0-0x00000001804C1720
		private bool ovUVbSenWMGAjfZDrNlrGOPEqjyx(); // 0x00000001804C1720-0x00000001804C1EE0
	}

	private class wSxzldZGrFHtZSRKEpEoiCDqSCe // TypeDefIndex: 8085
	{
		// Fields
		private List<RbAgelUstjAcBdMusEIUdLgDpzwc> CKRDfIDoRuhjHMZoRoGYskqfniS; // 0x10

		// Nested types
		public enum naWUOoWxxTKswmqrFKjSsguWZEo // TypeDefIndex: 8086
		{
			ImpEzyLGlsKAwzazZwhULaPPdZG = 0,
			sxcggOawopAcbGcQfGVpqPpRLvF = 1
		}

		public class RbAgelUstjAcBdMusEIUdLgDpzwc // TypeDefIndex: 8087
		{
			// Fields
			public int bCdxFnoMWYtrCiNLlRQMlgiLhPYa; // 0x10
			public Guid bMXCQBaILjSLhjhLTWucoJJurha; // 0x14
			public Guid rdGanhCiTrROfmNNNaUKzFlVNCiP; // 0x24
			public int tWVvOSHRBiKQwMbetintESauUpy; // 0x34
			public int KBkLyHtWnkRWiqBGUUwmrqOHqVH; // 0x38
			public int JvZculfQbOETGIKGOnGiPJYPLDBI; // 0x3C
			public int osLJBgamzkKrzDYloJPRQAwOBDs; // 0x40

			// Constructors
			public RbAgelUstjAcBdMusEIUdLgDpzwc(); // 0x000000018036B6C0-0x000000018036B6D0

			// Methods
			public bool nhWDuBakmJfkdCgvAWAkhoruXhxA(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010da3, naWUOoWxxTKswmqrFKjSsguWZEo param_00010da4); // 0x00000001804C0290-0x00000001804C0420
			public override string ToString(); // 0x00000001804BF350-0x00000001804C0290
		}

		// Constructors
		public wSxzldZGrFHtZSRKEpEoiCDqSCe(); // 0x00000001804D8DD0-0x00000001804D8E30

		// Methods
		public void INkuYqNLYqxjjynmNgciLAHPvf(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d9d); // 0x00000001804D8520-0x00000001804D88E0
		public RbAgelUstjAcBdMusEIUdLgDpzwc hiuKkuXhnUonltTZUtqalpeXgbMJ(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d9e, naWUOoWxxTKswmqrFKjSsguWZEo param_00010d9f); // 0x00000001804D8E30-0x00000001804D8F70
		private void ufNnmjGAjtaAcrgAvaPRoQQnnXL(int param_00010da0, Guid param_00010da1, int param_00010da2); // 0x00000001804D8F70-0x00000001804D9150
		public override string ToString(); // 0x00000001804D88E0-0x00000001804D8DD0
	}

	private class dksAsEiTyYAzDrbikJflOwuqUIOg // TypeDefIndex: 8088
	{
		// Fields
		public TUmUoEGFyYTOZlLrFyZFIrnQkRS uOngPHAGiEcguaqBrhxOlGdhSTAO; // 0x10
		public AWARuLKFrIKzIKknTkXdungFUra NhmVtTIoXzRgEFujUvNUXMmlfIf; // 0x18

		// Properties
		public bool SzWwKIMkLcEQgWsXWVvwKifnFkEe { get; } // 0x00000001804CEFD0-0x00000001804CEFF0 

		// Constructors
		public dksAsEiTyYAzDrbikJflOwuqUIOg(TUmUoEGFyYTOZlLrFyZFIrnQkRS joystick, AWARuLKFrIKzIKknTkXdungFUra deviceInstance); // 0x00000001803DA900-0x00000001803DA940

		// Methods
		public static List<AWARuLKFrIKzIKknTkXdungFUra> zAIcXrFYiXFTXggBJjtJpDdimjeD(List<dksAsEiTyYAzDrbikJflOwuqUIOg> param_00010da7); // 0x00000001804CEFF0-0x00000001804CF110
	}

	private class wfbccLOvlWADzAsMpbjyklYLfIoR // TypeDefIndex: 8089
	{
		// Fields
		private hStFMHAcESbldemZACBMnMengOyg.VjMyLWLsQWrGsaylCwDxXhovdl HsaHbWZRpyGKaLTLoJEVOKwxaSub; // 0x10
		private hStFMHAcESbldemZACBMnMengOyg.vJIhoPNWbVvCLIBIGgjaaOXJAqc VLJdgGJQrHweLwSTMjpydeTfgDxX; // 0x28
		private NativeBuffer vnOQOiVIXQbypMEcOZUhZBcLxTg; // 0x68
		private int sgRlsOWNZpAvMCPaWAQvdXYdNHPU; // 0x70

		// Constructors
		public wfbccLOvlWADzAsMpbjyklYLfIoR(); // 0x00000001804D93F0-0x00000001804D95B0

		// Methods
		public bool jhkrRAXurgGnTFXgpFHvjDedktr(); // 0x00000001804D9640-0x00000001804D9670
		public void FisIvbMmRviGFTRvizkDghpDPnE(int param_00010da8); // 0x00000001803DAEA0-0x00000001803DAEB0
		private int bIkzrQmzwGUOPFzizsqjEjtiFYYh(); // 0x00000001804D95B0-0x00000001804D9640
	}

	private enum cqoHseelTbGskTpMXNVSRPcBRWg // TypeDefIndex: 8090
	{
		wFjLyzixaguxMbVJTiBfthGcIqB = 17,
		zupLrDTnHVJHeXDysEETawqpSSQ = 18,
		YJahphtZcfrkqIODTZmVXdZwULM = 19,
		FmzFCDJyykUuRkJqmIffWjgIVIJ = 20,
		OWqOuzYAUHHwzJaKbiYgnfobVSe = 21,
		SOjOBDEYnUVoHssUXCEBqoSUyzR = 22,
		oBiEuIDkOiVemrDZZnaQMIoPtddg = 23,
		CudcWligkZYzfbapHJavAUDyOOa = 24,
		lNPpcRGtRcKaeDWdLdhMrOiTqaf = 25,
		JUmVMGFfSLoxFNcdYBsOBwEOeim = 26,
		oIKVRfMxxhRUwpaqCcKBFCCRtEE = 27,
		JURkHpAkshDXtxPmHZBZCzDCKr = 28
	}

	// Constructors
	public YnFajCFRWOqAjzMkGLVZcohEXjK(UpdateLoopSetting updateLoopSetting, bool useXInput, IntPtr windowHandle, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId); // 0x000000018042DC80-0x000000018042DF50

	// Methods
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void Initialize(); // 0x000000018042B970-0x000000018042BA20
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void Update(UpdateLoopType updateLoop); // 0x000000018042C770-0x000000018042C900
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void OnDestroy(); // 0x000000018042BE20-0x000000018042C0A0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000180358970-0x0000000180358980
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data); // 0x000000018042C570-0x000000018042C770
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SystemDeviceConnected(); // 0x000000018042C350-0x000000018042C3D0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SystemDeviceDisconnected(); // 0x000000018042C3D0-0x000000018042C410
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001803581E0-0x00000001803581F0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018035FCC0-0x000000018035FCD0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x000000018035FCC0-0x000000018035FCD0
	private void fGAmMkTYcGjWtfWZQcUMryllmqy(); // 0x000000018042E450-0x000000018042E670
	private List<dksAsEiTyYAzDrbikJflOwuqUIOg> ZllZLEOQNHZMjGQcMQWNyotJOix(); // 0x000000018042CC00-0x000000018042DC80
	private void TFEBLvFrODBsMywWtNmXNqkOMmL(); // 0x000000018042C410-0x000000018042C440
	private void mwtgQyIsRtRqizzkjvRisCKvuqR(List<dksAsEiTyYAzDrbikJflOwuqUIOg> param_00010d2b); // 0x000000018042E760-0x000000018042EDB0
	private void ZKQgWvGXskYymffFkSywbJKJyml(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d2c, lfjcFPfbIFTczjaHKtxRqTqXxevU param_00010d2d, out string param_00010d2e); // 0x000000018042C9C0-0x000000018042CC00
	private void GLEloJWTNMjIBZBAeEvnudkuMjT(); // 0x000000018042B700-0x000000018042B880
	private IList<AWARuLKFrIKzIKknTkXdungFUra> YYCQXQmLDyPPPSbXmOgsaAEtImO(); // 0x000000018042C900-0x000000018042C9C0
	private void UFvNNhUxYeMKmvQvJQFLhKvfFOr(); // 0x000000018042C450-0x000000018042C480
	private void xAacbIhNZZVVuthsDXXvuMTYwiwa(int param_00010d2f, int param_00010d30, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d31, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d32); // 0x000000018042F380-0x000000018042FD30
	private bool GhmoFJGGjYjqKvAvUvGmgqowbZih(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d33, int param_00010d34); // 0x000000018042B880-0x000000018042B970
	private int CsMtbGLFNauQHbzEXHOiPwRxNRm(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d35); // 0x000000018042B570-0x000000018042B700
	private bool CExdBbFFbfyARFJWBASwNihsMSDp(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d36, int param_00010d37); // 0x000000018042B490-0x000000018042B570
	private void dIyMcHagtTthCWrEWvAFfJyKtSE(int param_00010d38, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d39, int param_00010d3a, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d3b, wSxzldZGrFHtZSRKEpEoiCDqSCe.naWUOoWxxTKswmqrFKjSsguWZEo param_00010d3c); // 0x000000018042E140-0x000000018042E450
	private void xSaiyuMBXkxzPurLvoaVHycLoeF(int param_00010d3d, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d3e, wSxzldZGrFHtZSRKEpEoiCDqSCe.naWUOoWxxTKswmqrFKjSsguWZEo param_00010d3f); // 0x000000018042FD30-0x00000001804301F0
	private void OFhFIbecuvkSjdBkIUeKkNFxQZbY(); // 0x000000018042BA20-0x000000018042BBA0
	private void cmFNiAyLrpVuTovYJgIFGpTKbnZ(); // 0x000000018042DF50-0x000000018042DFD0
	private void rqflAVLdAqKlvGiSSnRFiKajexu(List<dksAsEiTyYAzDrbikJflOwuqUIOg> param_00010d40); // 0x000000018042EDB0-0x000000018042EE00
	private bool OUozVyxFVusVueJzYDiYOOjwiLL(IList<AWARuLKFrIKzIKknTkXdungFUra> param_00010d41); // 0x000000018042BBA0-0x000000018042BE20
	private bool PHHJGfXQQAEHIJiAXuxGAOVHUumM(Guid param_00010d42); // 0x000000018042C0A0-0x000000018042C350
	private bool wTBhJQHlemSSaIPbwLBgWxlpyBF(IList<AWARuLKFrIKzIKknTkXdungFUra> param_00010d43, Guid param_00010d44); // 0x000000018042EE10-0x000000018042EF20
	private void wplMrDyaHhFNOBgCtJXZZfEADVJ(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d45, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d46, bool param_00010d47); // 0x000000018042EF20-0x000000018042F380
	private void UbDkLfmxvvmLDkJnYieQDfWbCeJd(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010d48, bool param_00010d49); // 0x000000018042C480-0x000000018042C570
	private bool kFOgTKTdWqJvgidTuVbEgpbmcDcc(); // 0x000000018042E6E0-0x000000018042E760
	private void cwiduzhJUIkvrEkrbXKyemiiFKUo(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d4a, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010d4b); // 0x000000018042DFD0-0x000000018042E140
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private List<dksAsEiTyYAzDrbikJflOwuqUIOg> UEKrTqIOwuMPaGBXMNhxvVXyctH(); // 0x000000018042C440-0x000000018042C450
}

