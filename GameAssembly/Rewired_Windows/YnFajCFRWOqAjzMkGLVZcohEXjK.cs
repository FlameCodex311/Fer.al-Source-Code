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

// Image 67: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8232-8523

internal class YnFajCFRWOqAjzMkGLVZcohEXjK : PlatformInputManager, NhVfibDxHVoKZLYCMpDnGvgCwqbK // TypeDefIndex: 8246
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
	public bool OWGnbOYLKxblRayALCFlSXflpRF { set; } // 0x000000018045A0B0-0x000000018045A0C0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override int deviceCount { get; } // 0x00000001803F8270-0x00000001803F8280 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000180418980-0x0000000180418990 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IInputSource inputSource { get; } // 0x0000000180839CD0-0x0000000180839D30 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override InputSource inputSourceType { get; } // 0x000000018058C710-0x000000018058C720 

	// Nested types
	private class TUmUoEGFyYTOZlLrFyZFIrnQkRS : IInputManagerJoystick // TypeDefIndex: 8247
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
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int rewiredId { get; set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int inputManagerId { get; set; } // 0x00000001803FD2F0-0x00000001803FD300 0x00000001803FD620-0x00000001803FD630
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public string name { get; } // 0x0000000180A831F0-0x0000000180A83290 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public long? systemId { get; } // 0x0000000180A83290-0x0000000180A83340 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public int unityId { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Controller.Extension extension { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Guid instanceGuid { get; } // 0x0000000180A831E0-0x0000000180A831F0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public Guid persistentGuid { get; } // 0x0000000180A831E0-0x0000000180A831F0 

		// Constructors
		public TUmUoEGFyYTOZlLrFyZFIrnQkRS(DbAgWvggFEEJFAvDJzgCQDZsasHT sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager); // 0x0000000180A81910-0x0000000180A81960

		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void SetVibration(float amount, int motorIndex); // 0x00000001803774A0-0x00000001803774B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void StopVibration(); // 0x00000001803774A0-0x00000001803774B0
		public void PzDxfHSrAHYAAhFeMfJRCxnpwqE(); // 0x0000000180A80F60-0x0000000180A812D0
		public void NClxjNcPgUJJGYyiykTiBudFLhN(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010ff6); // 0x0000000180A7FD50-0x0000000180A7FFD0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void Update(); // 0x0000000180A814E0-0x0000000180A815C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public void FillData(ControllerDataUpdater dataUpdater); // 0x0000000180A7F9E0-0x0000000180A7FC90
		public int nhWDuBakmJfkdCgvAWAkhoruXhxA(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010ff8); // 0x0000000180A835F0-0x0000000180A83750
		private BridgedControllerHWInfo gbrBUxoFEhBBZhXueJHCQMMzfJU(); // 0x0000000180A83180-0x0000000180A831E0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public BridgedController ToBridgedController(); // 0x0000000180A81360-0x0000000180A81480
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x0000000180A81480-0x0000000180A814E0
		public bool jpZeCltOITzIqSxAvIApkadPZtr(); // 0x0000000180A834D0-0x0000000180A83540
		public void kmxWiElONBwdCIeFdCJXYxrvdbQH(); // 0x0000000180A83540-0x0000000180A835F0
		private void vAtlDGAFFZDBSWfVQjpKMYROXUB(bool[] param_00010ff9, int[] param_00010ffa); // 0x0000000180A839F0-0x0000000180A83D30
		private void WwLhoTbvnRBIbNCDsBjlVXxPMDA(bool[] param_00010ffb, int[] param_00010ffc); // 0x0000000180A815C0-0x0000000180A81910
		private void sereoiihHgKiMaYtaGZAVtoBEeCU(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_00010ffd, int param_00010ffe, bool[] param_00010fff, int[] param_00011000); // 0x0000000180A83750-0x0000000180A838E0
		private void itoEuTsnAJcLvnlTzCzuBdrlmMCq(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_00011001, int param_00011002, bool[] param_00011003, int[] param_00011004); // 0x0000000180A83340-0x0000000180A834D0
		private float ddeAaEoPBwfkDXGlLfHOkRXUPnOG(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base param_00011005, bool[] param_00011006, int[] param_00011007); // 0x0000000180A82990-0x0000000180A83180
		private float ddeAaEoPBwfkDXGlLfHOkRXUPnOG(DirectInputAxis param_00011008); // 0x0000000180A81D00-0x0000000180A82990
		private bool NazkUlYeVVjyDXBchdfNhwTesrFk(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base param_00011009, bool[] param_0001100a, int[] param_0001100b); // 0x0000000180A7FFD0-0x0000000180A80CD0
		private float EqiBwibyZqNRgcBrauXECrZPRDY(int param_0001100c); // 0x00000001804247F0-0x0000000180424860
		private bool BqobctiMIBLZinzbMgyWaamHNzYQ(int param_0001100d, int param_0001100e, HatType param_0001100f); // 0x0000000180A7F850-0x0000000180A7F990
		private float QjmjTnjsSLwTjgBrFBJfbwfEhbo(int param_00011010, AxisDirection param_00011011); // 0x0000000180A812D0-0x0000000180A81360
		private bool ISmxhqCDNAqoRmCzdbqueoWHZze(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_00011012, bool[] param_00011013, out bool param_00011014); // 0x0000000180A7FC90-0x0000000180A7FD50
		private bool bgrRzpvJmumcVUJLWrkdYQsZfcR(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData param_00011015, out float param_00011016); // 0x0000000180A819B0-0x0000000180A81C10
		private ControlDeviceType EbBtUZBMKDCHAJQbDaYdLWdgahNU(cqoHseelTbGskTpMXNVSRPcBRWg param_00011017); // 0x0000000180A7F990-0x0000000180A7F9E0
		private void chgLTsLAoRqfgzxaGOxybgGGSFw(); // 0x0000000180A81C10-0x0000000180A81D00
		private string yElEPVKJpZjLrUNflNIKGVNmdOEh(); // 0x0000000180A84040-0x0000000180A84690
		private void PCBbqseklYNTQIOEEAPmbLgGBmJd(BridgedControllerHWInfo param_00011018); // 0x0000000180A80DB0-0x0000000180A80F60
		private void PCBbqseklYNTQIOEEAPmbLgGBmJd(BridgedController param_00011019); // 0x0000000180A80CD0-0x0000000180A80DB0
		private UnknownControllerHat[] yAltpHIGiQujNhHcTiKVTQIDWRb(); // 0x0000000180A83D30-0x0000000180A84040
		public void ukZeJfPzbKmpvxrUBgmIykVNKVO(); // 0x0000000180A838E0-0x0000000180A83970
		~TUmUoEGFyYTOZlLrFyZFIrnQkRS(); // 0x0000000180424C60-0x0000000180424D00
		protected virtual void ukZeJfPzbKmpvxrUBgmIykVNKVO(bool param_0001101a); // 0x0000000180A83970-0x0000000180A839F0
		public static int DCEAIrtYNRwoxAlGMuuCDniqleA(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_0001101b, TUmUoEGFyYTOZlLrFyZFIrnQkRS param_0001101c); // 0x0000000180429290-0x00000001804292D0
		public static int aMEMqWZHdasPYBCQFndZcyoSdVC(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_0001101d, TUmUoEGFyYTOZlLrFyZFIrnQkRS param_0001101e); // 0x0000000180A81960-0x0000000180A819B0
	}

	private class DbAgWvggFEEJFAvDJzgCQDZsasHT : IDisposable // TypeDefIndex: 8248
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
		public bool[] wKOnPbKbGRtJlXJeMiMmKJJWUdx { get; } // 0x0000000180821770-0x00000001808217D0 
		public eShRWneHfEMQNulXAssvRrsrPZg VhLgULgHAlJwhBzWNSJVaZDTOFCi { get; } // 0x00000001803765E0-0x00000001803765F0 

		// Constructors
		public DbAgWvggFEEJFAvDJzgCQDZsasHT(SlQJAJyPmnQOiXQNEoKZMinAMhO source, UpdateLoopSetting updateLoops); // 0x00000001808210F0-0x0000000180821310

		// Methods
		public void jVhgReScAKXEjvimtGikJhORNWY(); // 0x00000001808217D0-0x0000000180821920
		public void TvOJSlVHdjCFIAwzRDmMHSuuRMt(); // 0x0000000180820A50-0x0000000180820AB0
		public void hxBuCPWjXWEpuKzEmRBqHrRWHeXE(); // 0x00000001807E2CB0-0x00000001807E2CC0
		public void CVGHsGZeOSnwBwCnzeEFdNmYVFh(); // 0x00000001808204C0-0x00000001808204D0
		public void NClxjNcPgUJJGYyiykTiBudFLhN(DbAgWvggFEEJFAvDJzgCQDZsasHT param_00011021); // 0x0000000180820640-0x0000000180820A50
		public void yefBitbYBFvoVPkbXMmTySLXadR(int param_00011022, int param_00011023, int param_00011024, float param_00011025); // 0x0000000180821A70-0x0000000180821CF0
		private void eahCgkomBjwwNpwOonGeIbrxAUW(); // 0x0000000180821500-0x0000000180821670
		private void eAixrySQUxKTYsBxrvNhlQKiTtS(eShRWneHfEMQNulXAssvRrsrPZg param_00011026); // 0x0000000180821310-0x0000000180821500
		private void WuACSMdXdVKCGPSyMYMygICKKPZc(byte[] param_00011027, eShRWneHfEMQNulXAssvRrsrPZg param_00011028); // 0x0000000180820DE0-0x00000001808210F0
		private void WUgNwLxzgLVFhMHQfppUCruzijl(eShRWneHfEMQNulXAssvRrsrPZg param_00011029, float param_0001102a, byte[] param_0001102b); // 0x0000000180820AB0-0x0000000180820DE0
		private void fDgYQYQKaPimAijWAfVtGjstdSLo(); // 0x0000000180821670-0x0000000180821770
		private void KBJCTXijuFzTsafHXFifDjpwrYU(eShRWneHfEMQNulXAssvRrsrPZg param_0001102c); // 0x0000000180820540-0x0000000180820640
		public void Dispose(); // 0x00000001808204D0-0x0000000180820540
		~DbAgWvggFEEJFAvDJzgCQDZsasHT(); // 0x000000018041BC40-0x000000018041BCE0
		protected virtual void ukZeJfPzbKmpvxrUBgmIykVNKVO(bool param_0001102d); // 0x0000000180821920-0x0000000180821A70
	}

	private class MrRCsQHqqpJAvNotshtKOTrXvzk // TypeDefIndex: 8249
	{
		// Fields
		private eShRWneHfEMQNulXAssvRrsrPZg rlayWhCtBXbMnNIHafUbCwWWdNi; // 0x10
		private TNVjpVQMkschjmjzRsAlTpMcDxL VrRPNaAHjBDKezRqTeTVWsTbibS; // 0x18
		private int dYmFMNjtOosDbfpkRtEjuaTnxHFE; // 0x20
		private int kuxgyVdzXrVbFmbuCpdBcpiHXef; // 0x24
		private int gLiaTCEIfzgfydAXAhNccPFWjEOf; // 0x28
		private float yfPDOWnfGnnNcxwJMtGbWCqtAVNg; // 0x2C

		// Properties
		public eShRWneHfEMQNulXAssvRrsrPZg OpNomNgPgwIrfElpsUSOdjKAaozE { get; } // 0x0000000180372440-0x0000000180372450 

		// Constructors
		public MrRCsQHqqpJAvNotshtKOTrXvzk(eShRWneHfEMQNulXAssvRrsrPZg state, int axisMin, int axisMax, int axisZero, float eventTimeout); // 0x0000000180825650-0x0000000180825730
		private MrRCsQHqqpJAvNotshtKOTrXvzk(MrRCsQHqqpJAvNotshtKOTrXvzk source, eShRWneHfEMQNulXAssvRrsrPZg state); // 0x0000000180825580-0x0000000180825650
		private MrRCsQHqqpJAvNotshtKOTrXvzk(int axisMin, int axisMax, int axisZero, float axisTimeout); // 0x00000001808254F0-0x0000000180825580

		// Methods
		public static MrRCsQHqqpJAvNotshtKOTrXvzk szAOBsGyRiCvsgdIOMaFjixERNI(MrRCsQHqqpJAvNotshtKOTrXvzk param_0001102e, eShRWneHfEMQNulXAssvRrsrPZg param_0001102f); // 0x00000001808266A0-0x00000001808267C0
		public void bDpjnZNTIBcpcFFeCkJZEztApBtU(float param_0001103b); // 0x0000000180825730-0x00000001808265C0
		public void iAKzPRPwmWNxLkOsOgJnjiXjEMBA(MrRCsQHqqpJAvNotshtKOTrXvzk param_0001103c); // 0x00000001808265F0-0x00000001808266A0
		private int ePmXlMjAuWnSVEJAmZOtLYQdrpk(int param_0001103d); // 0x00000001808265C0-0x00000001808265F0
	}

	private class TNVjpVQMkschjmjzRsAlTpMcDxL // TypeDefIndex: 8250
	{
		// Fields
		private float ZTZAISXlgYUjTqCHmGuRRjruGqKE; // 0x10
		private eShRWneHfEMQNulXAssvRrsrPZg cjRbvLSbcTrtkIHRXCTVLNQdwkI; // 0x18
		private eShRWneHfEMQNulXAssvRrsrPZg dORETaOSVkMRDkwHCkxJLAkwyXe; // 0x20
		private eShRWneHfEMQNulXAssvRrsrPZg pHbanrGsJBhJVBjLfvepeHuzPjSb; // 0x28
		private bool GogTPVtTzaegJkqMgPsszjWEaee; // 0x30
		private float QfxIqNPOnHXceyTmNtxfTaMYXnO; // 0x34

		// Properties
		public eShRWneHfEMQNulXAssvRrsrPZg UQqusYQHVNDrXJVttLDifadIWPhS { get; } // 0x0000000180372430-0x0000000180372440 
		public eShRWneHfEMQNulXAssvRrsrPZg ynkAVFDGSRsaruNiMwkcUIzadTZM { get; } // 0x00000001803745B0-0x00000001803745C0 
		public bool HeFFXigqvCOEWuSRNzCvDuBxJERE { get; } // 0x0000000180455B90-0x0000000180455BA0 
		public float jnZUcWfRYCfhEOxcjUvkRnDUNHv { get; } // 0x00000001806CEAE0-0x00000001806CEAF0 

		// Constructors
		public TNVjpVQMkschjmjzRsAlTpMcDxL(eShRWneHfEMQNulXAssvRrsrPZg sourceState); // 0x0000000180A7E170-0x0000000180A7E1F0

		// Methods
		public void bDpjnZNTIBcpcFFeCkJZEztApBtU(float param_0001103f); // 0x0000000180A7E1F0-0x0000000180A7F090
		public void iAKzPRPwmWNxLkOsOgJnjiXjEMBA(TNVjpVQMkschjmjzRsAlTpMcDxL param_00011040); // 0x0000000180A7F090-0x0000000180A7F100
		private bool ovUVbSenWMGAjfZDrNlrGOPEqjyx(); // 0x0000000180A7F100-0x0000000180A7F850
	}

	private class wSxzldZGrFHtZSRKEpEoiCDqSCe // TypeDefIndex: 8251
	{
		// Fields
		private List<RbAgelUstjAcBdMusEIUdLgDpzwc> CKRDfIDoRuhjHMZoRoGYskqfniS; // 0x10

		// Nested types
		public enum naWUOoWxxTKswmqrFKjSsguWZEo // TypeDefIndex: 8252
		{
			ImpEzyLGlsKAwzazZwhULaPPdZG = 0,
			sxcggOawopAcbGcQfGVpqPpRLvF = 1
		}

		public class RbAgelUstjAcBdMusEIUdLgDpzwc // TypeDefIndex: 8253
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
			public RbAgelUstjAcBdMusEIUdLgDpzwc(); // 0x0000000180373240-0x0000000180373250

			// Methods
			public bool nhWDuBakmJfkdCgvAWAkhoruXhxA(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00011047, naWUOoWxxTKswmqrFKjSsguWZEo param_00011048); // 0x0000000180A7DD80-0x0000000180A7DF00
			public override string ToString(); // 0x0000000180A7CF10-0x0000000180A7DD80
		}

		// Constructors
		public wSxzldZGrFHtZSRKEpEoiCDqSCe(); // 0x0000000180A95CA0-0x0000000180A95D00

		// Methods
		public void INkuYqNLYqxjjynmNgciLAHPvf(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00011041); // 0x0000000180A95440-0x0000000180A957F0
		public RbAgelUstjAcBdMusEIUdLgDpzwc hiuKkuXhnUonltTZUtqalpeXgbMJ(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00011042, naWUOoWxxTKswmqrFKjSsguWZEo param_00011043); // 0x0000000180A95D00-0x0000000180A95E30
		private void ufNnmjGAjtaAcrgAvaPRoQQnnXL(int param_00011044, Guid param_00011045, int param_00011046); // 0x0000000180A95E30-0x0000000180A96010
		public override string ToString(); // 0x0000000180A957F0-0x0000000180A95CA0
	}

	private class dksAsEiTyYAzDrbikJflOwuqUIOg // TypeDefIndex: 8254
	{
		// Fields
		public TUmUoEGFyYTOZlLrFyZFIrnQkRS uOngPHAGiEcguaqBrhxOlGdhSTAO; // 0x10
		public AWARuLKFrIKzIKknTkXdungFUra NhmVtTIoXzRgEFujUvNUXMmlfIf; // 0x18

		// Properties
		public bool SzWwKIMkLcEQgWsXWVvwKifnFkEe { get; } // 0x0000000180A8C680-0x0000000180A8C6A0 

		// Constructors
		public dksAsEiTyYAzDrbikJflOwuqUIOg(TUmUoEGFyYTOZlLrFyZFIrnQkRS joystick, AWARuLKFrIKzIKknTkXdungFUra deviceInstance); // 0x0000000180372010-0x00000001803720F0

		// Methods
		public static List<AWARuLKFrIKzIKknTkXdungFUra> zAIcXrFYiXFTXggBJjtJpDdimjeD(List<dksAsEiTyYAzDrbikJflOwuqUIOg> param_0001104b); // 0x0000000180A8C6A0-0x0000000180A8C7C0
	}

	private class wfbccLOvlWADzAsMpbjyklYLfIoR // TypeDefIndex: 8255
	{
		// Fields
		private hStFMHAcESbldemZACBMnMengOyg.VjMyLWLsQWrGsaylCwDxXhovdl HsaHbWZRpyGKaLTLoJEVOKwxaSub; // 0x10
		private hStFMHAcESbldemZACBMnMengOyg.vJIhoPNWbVvCLIBIGgjaaOXJAqc VLJdgGJQrHweLwSTMjpydeTfgDxX; // 0x28
		private NativeBuffer vnOQOiVIXQbypMEcOZUhZBcLxTg; // 0x68
		private int sgRlsOWNZpAvMCPaWAQvdXYdNHPU; // 0x70

		// Constructors
		public wfbccLOvlWADzAsMpbjyklYLfIoR(); // 0x0000000180A962B0-0x0000000180A96470

		// Methods
		public bool jhkrRAXurgGnTFXgpFHvjDedktr(); // 0x0000000180A96500-0x0000000180A96530
		public void FisIvbMmRviGFTRvizkDghpDPnE(int param_0001104c); // 0x00000001804B47E0-0x00000001804B47F0
		private int bIkzrQmzwGUOPFzizsqjEjtiFYYh(); // 0x0000000180A96470-0x0000000180A96500
	}

	private enum cqoHseelTbGskTpMXNVSRPcBRWg // TypeDefIndex: 8256
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
	public YnFajCFRWOqAjzMkGLVZcohEXjK(UpdateLoopSetting updateLoopSetting, bool useXInput, IntPtr windowHandle, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId); // 0x00000001808392F0-0x00000001808395C0

	// Methods
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void Initialize(); // 0x0000000180837050-0x0000000180837100
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void Update(UpdateLoopType updateLoop); // 0x0000000180837E20-0x0000000180837FB0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void OnDestroy(); // 0x00000001808374F0-0x0000000180837760
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x00000001803765E0-0x00000001803765F0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data); // 0x0000000180837C20-0x0000000180837E20
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SystemDeviceConnected(); // 0x0000000180837A10-0x0000000180837A90
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SystemDeviceDisconnected(); // 0x0000000180837A90-0x0000000180837AD0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001803774A0-0x00000001803774B0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018037DDC0-0x000000018037DDD0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x000000018037DDC0-0x000000018037DDD0
	private void fGAmMkTYcGjWtfWZQcUMryllmqy(); // 0x0000000180839AB0-0x0000000180839CD0
	private List<dksAsEiTyYAzDrbikJflOwuqUIOg> ZllZLEOQNHZMjGQcMQWNyotJOix(); // 0x00000001808382B0-0x00000001808392F0
	private void TFEBLvFrODBsMywWtNmXNqkOMmL(); // 0x0000000180837AD0-0x0000000180837B00
	private void mwtgQyIsRtRqizzkjvRisCKvuqR(List<dksAsEiTyYAzDrbikJflOwuqUIOg> param_00010fcf); // 0x0000000180839DB0-0x000000018083A3E0
	private void ZKQgWvGXskYymffFkSywbJKJyml(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010fd0, lfjcFPfbIFTczjaHKtxRqTqXxevU param_00010fd1, out string param_00010fd2); // 0x0000000180838070-0x00000001808382B0
	private void GLEloJWTNMjIBZBAeEvnudkuMjT(); // 0x0000000180836DF0-0x0000000180836F60
	private IList<AWARuLKFrIKzIKknTkXdungFUra> YYCQXQmLDyPPPSbXmOgsaAEtImO(); // 0x0000000180837FB0-0x0000000180838070
	private void UFvNNhUxYeMKmvQvJQFLhKvfFOr(); // 0x0000000180837B10-0x0000000180837B40
	private void xAacbIhNZZVVuthsDXXvuMTYwiwa(int param_00010fd3, int param_00010fd4, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fd5, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fd6); // 0x000000018083A990-0x000000018083B320
	private bool GhmoFJGGjYjqKvAvUvGmgqowbZih(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fd7, int param_00010fd8); // 0x0000000180836F60-0x0000000180837050
	private int CsMtbGLFNauQHbzEXHOiPwRxNRm(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fd9); // 0x0000000180836C60-0x0000000180836DF0
	private bool CExdBbFFbfyARFJWBASwNihsMSDp(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fda, int param_00010fdb); // 0x0000000180836B80-0x0000000180836C60
	private void dIyMcHagtTthCWrEWvAFfJyKtSE(int param_00010fdc, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fdd, int param_00010fde, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fdf, wSxzldZGrFHtZSRKEpEoiCDqSCe.naWUOoWxxTKswmqrFKjSsguWZEo param_00010fe0); // 0x00000001808397B0-0x0000000180839AB0
	private void xSaiyuMBXkxzPurLvoaVHycLoeF(int param_00010fe1, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fe2, wSxzldZGrFHtZSRKEpEoiCDqSCe.naWUOoWxxTKswmqrFKjSsguWZEo param_00010fe3); // 0x000000018083B320-0x000000018083B7C0
	private void OFhFIbecuvkSjdBkIUeKkNFxQZbY(); // 0x0000000180837100-0x0000000180837280
	private void cmFNiAyLrpVuTovYJgIFGpTKbnZ(); // 0x00000001808395C0-0x0000000180839640
	private void rqflAVLdAqKlvGiSSnRFiKajexu(List<dksAsEiTyYAzDrbikJflOwuqUIOg> param_00010fe4); // 0x000000018083A3E0-0x000000018083A430
	private bool OUozVyxFVusVueJzYDiYOOjwiLL(IList<AWARuLKFrIKzIKknTkXdungFUra> param_00010fe5); // 0x0000000180837280-0x00000001808374F0
	private bool PHHJGfXQQAEHIJiAXuxGAOVHUumM(Guid param_00010fe6); // 0x0000000180837760-0x0000000180837A10
	private bool wTBhJQHlemSSaIPbwLBgWxlpyBF(IList<AWARuLKFrIKzIKknTkXdungFUra> param_00010fe7, Guid param_00010fe8); // 0x000000018083A430-0x000000018083A540
	private void wplMrDyaHhFNOBgCtJXZZfEADVJ(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fe9, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fea, bool param_00010feb); // 0x000000018083A540-0x000000018083A990
	private void UbDkLfmxvvmLDkJnYieQDfWbCeJd(TUmUoEGFyYTOZlLrFyZFIrnQkRS param_00010fec, bool param_00010fed); // 0x0000000180837B40-0x0000000180837C20
	private bool kFOgTKTdWqJvgidTuVbEgpbmcDcc(); // 0x0000000180839D30-0x0000000180839DB0
	private void cwiduzhJUIkvrEkrbXKyemiiFKUo(List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fee, List<TUmUoEGFyYTOZlLrFyZFIrnQkRS> param_00010fef); // 0x0000000180839640-0x00000001808397B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<dksAsEiTyYAzDrbikJflOwuqUIOg> UEKrTqIOwuMPaGBXMNhxvVXyctH(); // 0x0000000180837B00-0x0000000180837B10
}

