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
using Rewired.Platforms.Custom;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.InputManagers
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class CustomInputManager : PlatformInputManager // TypeDefIndex: 6628
	{
		// Fields
		private List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> YxWCMHbPaQgZcysPKFMIEybVXlg; // 0x38
		private int pCPGQSBvXdijKhpVimfqeELMEtfS; // 0x40
		private NmJwWlrRRKFJfRBSYoHPIaYgElTg VoNXLwsbUAMaIxrCOafEXDdBDZn; // 0x48
		private UpdateLoopType bJLiMprynRavojxmnNIzynWbigw; // 0x50
		private Action<int, ControllerDataUpdater> EJbSxdVddraROjZaiYbZVrUwQoYu; // 0x58
		private PlatformInputManager YPXFTYczxBNwCKQUUwpYRjqDJBr; // 0x60
		private CustomInputSource JLVDqdhsRDBQYpFLEKvTAACwvYO; // 0x68
		private bool NPVBwLgCgrnzgKAeMRXkslmDNNe; // 0x70
		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> jBvZbJyqnownRPygSHdwnWPOEOD; // 0x78
		private Func<int> yJUjfoACqQcKMcEEPpBEJHiTsbnd; // 0x80
	
		// Properties
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override int deviceCount { get; } // 0x0000000180379F10-0x0000000180379F20 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override PlatformInputManager primaryInputManager { get; } // 0x0000000180418970-0x0000000180418980 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override IInputSource inputSource { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override InputSource inputSourceType { get; } // 0x000000018099B190-0x000000018099B1B0 
	
		// Nested types
		private class lWCZpNzMmIUsEqLdtWlVGDDPxbB : IInputManagerJoystick // TypeDefIndex: 6629
		{
			// Fields
			private readonly InputSource IfWmLaqyRlsuporQiJgqwmXsLqe; // 0x10
			private readonly CustomInputSource JLVDqdhsRDBQYpFLEKvTAACwvYO; // 0x18
			private readonly Controller.Extension ZXidIbsBtOYiKGegrccafjeNbYN; // 0x20
			private int XOLVDiSWtIqbOpghJCzBEigseKH; // 0x28
			private int IKeuqAccRFFGUGPfkLjliBImiajo; // 0x2C
			private long? ZtpFOHCSvVTitFWYQVgBoObqQOKf; // 0x30
			private int QqpCMJrIsoyyefcScyWUdCeTfPn; // 0x40
			public Guid ZOImCzoQsvFKPDGPJbXrBBLAqoDc; // 0x44
			public string PxoGxqnfQxEyStsSNYhOOZsndOh; // 0x58
			public string jtfAnpoVBEPqkLSsTjPlSfeuZnT; // 0x60
			private int RweyBZyAAIjbTgpvgIOlbybhzioP; // 0x68
			private int QsBvetqPHrzKthaGEErdieSJgIkd; // 0x6C
			private float[] ZNTUylpNRUByYdQSrADdmjAvZRH; // 0x70
			private bool[] vunatIQhxVdxZDEBHEGxdtuFiCZm; // 0x78
			private HardwareJoystickMap_InputManager VnQIptJChOAyXtaioLZfAFotfgY; // 0x80
			public CustomInputSource.Joystick ilDchAqijWCBEjokkaYxedeZxvy; // 0x88
			private bool TrENyqpiKSBltBAtsfPKDmZKmSP; // 0x90
			private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> jBvZbJyqnownRPygSHdwnWPOEOD; // 0x98
	
			// Properties
			public int qShluNeysidzzcdCVXhEWimMHJm { get; } // 0x00000001809ABDE0-0x00000001809ABE00 
			public int pqWtltkGaUjoTWWhNBdCBqoIWRgw { get; } // 0x00000001809ABDC0-0x00000001809ABDE0 
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public int rewiredId { get; set; } // 0x000000018043C680-0x000000018043C690 0x000000018041A3A0-0x000000018041A3B0
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public int inputManagerId { get; set; } // 0x000000018043C670-0x000000018043C680 0x000000018041A370-0x000000018041A380
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public string name { get; } // 0x00000001809ABFA0-0x00000001809AC070 
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public long? systemId { get; } // 0x000000018043C660-0x000000018043C670 
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public int unityId { get; } // 0x0000000180379F10-0x0000000180379F20 
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public Guid instanceGuid { get; } // 0x00000001809ABE00-0x00000001809ABFA0 
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public Guid persistentGuid { get; } // 0x00000001809AC070-0x00000001809AC200 
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public Controller.Extension extension { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
			// Constructors
			public lWCZpNzMmIUsEqLdtWlVGDDPxbB(CustomInputSource customInputSource, long? systemJoystickId, int unityJoystickId, CustomInputSource.Joystick joystick, InputSource inputSource, Controller.Extension controllerExtension, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager); // 0x00000001809ABA90-0x00000001809ABDC0
	
			// Methods
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public void SetVibration(float amount, int motorIndex); // 0x00000001803774A0-0x00000001803774B0
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public void StopVibration(); // 0x00000001803774A0-0x00000001803774B0
			public void LBHnXppSrmtCeLbqzdSyaPaPqpv(); // 0x00000001809AB5A0-0x00000001809AB5D0
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public void Update(); // 0x00000001809AB970-0x00000001809AB9B0
			public int KtuOdxlQvfcWMKWKLpXAppHCedU(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d945); // 0x00000001809AB4D0-0x00000001809AB5A0
			private void wqlffMjxssnplevpBMMQSUIGWac(BridgedControllerHWInfo param_0000d946); // 0x00000001809AC6E0-0x00000001809AC790
			private void wqlffMjxssnplevpBMMQSUIGWac(BridgedController param_0000d947); // 0x00000001809AC790-0x00000001809AC8E0
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public void FillData(ControllerDataUpdater dataUpdater); // 0x00000001809AACF0-0x00000001809AAF50
			public BridgedControllerHWInfo XRVSbFhJTVnjsPfNtQbaBGoeHvx(); // 0x00000001809AB9B0-0x00000001809ABA90
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public BridgedController ToBridgedController(); // 0x00000001809AB780-0x00000001809AB910
			[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
			public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x00000001809AB910-0x00000001809AB970
			private void ImXynqJsKrbihkCeHBieZBlZjBkd(); // 0x00000001809AB020-0x00000001809AB4D0
			private void nxhcezssRzdcWxCszmkJAETEeBj(); // 0x00000001809AC200-0x00000001809AC5A0
			private bool ozJURFXGWjoSmvRPguejjmdfrxo(HardwareJoystickMap.Platform_Custom.Button param_0000d949); // 0x00000001809AC5A0-0x00000001809AC6B0
			private bool LHLdzrNekKQKOLbBvbgFmPfGORN(float param_0000d94a, float param_0000d94b); // 0x00000001809AB5D0-0x00000001809AB5F0
			private float MrEjHmrhMIAvyvAGWGqoSofBjzv(HardwareJoystickMap.Platform_Custom.Axis param_0000d94c); // 0x00000001809AB5F0-0x00000001809AB750
			private float MrEjHmrhMIAvyvAGWGqoSofBjzv(int param_0000d94d); // 0x00000001809AB750-0x00000001809AB780
			private bool ozJURFXGWjoSmvRPguejjmdfrxo(int param_0000d94e); // 0x00000001809AC6B0-0x00000001809AC6E0
			private void BmYcESUSLtTSZTmUBGDGKcYFZYPB(); // 0x00000001809AAB90-0x00000001809AACF0
			private void xYVjwyZhjQqUkUFHjyreFStdrnk(); // 0x00000001809AC8E0-0x00000001809AC930
			private string BDXxuNhkOqICIFSpFjayCRLyExW(); // 0x00000001809AA6E0-0x00000001809AAB90
			public static int yOaTLoqQNpSyLueOFrJKOdZbhdr(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d94f, lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d950); // 0x00000001809AC930-0x00000001809AC970
			public static int HIiawsuXqDvxQRxZFHhRkOKXATJB(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d951, lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d952); // 0x00000001809AAF50-0x00000001809AB020
		}
	
		private class NmJwWlrRRKFJfRBSYoHPIaYgElTg // TypeDefIndex: 6630
		{
			// Fields
			private List<eFjSJQccMtGFWfuDsNyeCWQnPoHw> hnpXymCoCCHPwqlDSIZkffYsKwxu; // 0x10
	
			// Properties
			public int SHujHYUxHggDGFiBfPBtOLtZhMW { get; } // 0x00000001809A4EB0-0x00000001809A4EF0 
	
			// Nested types
			public enum CRFlivKpxXYVyfkgJBkgeayLvfoj // TypeDefIndex: 6631
			{
				fUCXKJCTVFsJpPqXabTFOEWGhao = 0,
				VvUvsThtRLwEHszViUPhlXdArGo = 1
			}
	
			public class eFjSJQccMtGFWfuDsNyeCWQnPoHw // TypeDefIndex: 6632
			{
				// Fields
				public int OVXHKDzaJatXjMbqyxVckuQWdNz; // 0x10
				public long? aETsTpgQGHeijvpDhoGUBSjNdCc; // 0x18
				public string YvPxdtlAPbSTVkXmeqLwUfQtbBj; // 0x28
				public int OlAgkDKAhOqDAgDjadFVJGPfUNR; // 0x30
				public int QsBvetqPHrzKthaGEErdieSJgIkd; // 0x34
				public int RweyBZyAAIjbTgpvgIOlbybhzioP; // 0x38
	
				// Constructors
				public eFjSJQccMtGFWfuDsNyeCWQnPoHw(int rewiredId, long? systemId, string systemControllerName, int lastInputManagerId, int buttonCount, int axisCount); // 0x00000001809AA680-0x00000001809AA6E0
	
				// Methods
				public bool KtuOdxlQvfcWMKWKLpXAppHCedU(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d961, CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d962); // 0x00000001809AA4F0-0x00000001809AA680
			}
	
			// Constructors
			public NmJwWlrRRKFJfRBSYoHPIaYgElTg(); // 0x00000001809A4E50-0x00000001809A4EB0
	
			// Methods
			public void lmldbkvCGcJRSRLClxvEdfwGeFAF(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d953); // 0x00000001809A4EF0-0x00000001809A5410
			public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d954, CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d955); // 0x00000001809A49B0-0x00000001809A4BF0
			public eFjSJQccMtGFWfuDsNyeCWQnPoHw SJSWnEKwuoLTQVEoRbtWctEUXhl(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d956, CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d957); // 0x00000001809A4BF0-0x00000001809A4E50
			public int ItDzbHMiIYGseDXjmhIUEkIaQew(eFjSJQccMtGFWfuDsNyeCWQnPoHw param_0000d958); // 0x00000001809A48C0-0x00000001809A49B0
			private void BPfbiRRcHBdGVaFlopltypkiKpwF(int param_0000d959, int param_0000d95a); // 0x00000001809A47C0-0x00000001809A48C0
		}
	
		// Constructors
		public CustomInputManager(CustomInputSource customInputSource, UpdateLoopSetting updateLoopSetting, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId); // 0x000000018099AF00-0x000000018099B040
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override void Initialize(); // 0x0000000180998C30-0x0000000180998CF0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override void Update(UpdateLoopType updateLoop); // 0x0000000180999830-0x0000000180999A00
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override void OnDestroy(); // 0x00000001809995F0-0x0000000180999610
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x00000001803A1580-0x00000001803A1590
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data); // 0x0000000180999700-0x0000000180999830
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override void SystemDeviceConnected(); // 0x0000000180999670-0x0000000180999690
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override void SystemDeviceDisconnected(); // 0x0000000180999690-0x0000000180999700
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override void SetUnityJoystickId(int joystickId, int unityJoystickIndex); // 0x00000001803774A0-0x00000001803774B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018037DDC0-0x000000018037DDD0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x000000018037DDC0-0x000000018037DDD0
		private void YoZyWiOZBJomMtEtoZcHjseDbAj(CustomInputSource.Joystick[] param_0000d91d); // 0x000000018099A560-0x000000018099AF00
		private void lacmGlTQoaLmoxrvjoHVdQPxdgv(); // 0x000000018099B670-0x000000018099B780
		private void CrEFysWJYfMtJVlNOTETVlrRfmH(int param_0000d91e, int param_0000d91f, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d920, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d921); // 0x0000000180998000-0x00000001809989B0
		private void vldJABpAisLeLtnWmXvbkuWgBVP(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d922, int param_0000d923, int param_0000d924); // 0x000000018099B9D0-0x000000018099BB70
		private bool pNMfllDFmeSLnPQOJXZWrLWxJvV(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d925, int param_0000d926); // 0x000000018099B780-0x000000018099B880
		private int bboyWaSBIWfSuDuvAhGSQFlklHB(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d927); // 0x000000018099B040-0x000000018099B190
		private bool pvXOIHQgaXRwmhvpEGPOheJnhQaK(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d928, int param_0000d929); // 0x000000018099B880-0x000000018099B990
		private void YIYZwrraphZTryuQTiOviKWRzIv(int param_0000d92a, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d92b, int param_0000d92c, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d92d, NmJwWlrRRKFJfRBSYoHPIaYgElTg.CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d92e); // 0x0000000180999A00-0x000000018099A2C0
		private void MEGxlYFLQIBDskCcuhdtrMUQPsay(int param_0000d92f, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d930, NmJwWlrRRKFJfRBSYoHPIaYgElTg.CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d931); // 0x0000000180998CF0-0x00000001809995F0
		private void SZwYmZviewQhCXYBZRYpKgLixEo(); // 0x0000000180999610-0x0000000180999670
		private bool jREgEtiIdWEJuYqeDMqRZmepaiy(CustomInputSource.Joystick[] param_0000d932); // 0x000000018099B1B0-0x000000018099B670
		private void HDRVotfzQTtozttlcYWzSMkLNGk(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d933, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d934, bool param_0000d935); // 0x00000001809989B0-0x0000000180998C30
		private void rRbwQLxKmBpfwWwAFobgsEaaBko(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d936, bool param_0000d937); // 0x000000018099B990-0x000000018099B9D0
		private void YfMnlmBcMMYqbQGgMeLXdIVUDnZF(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d938, bool param_0000d939); // 0x000000018099A2C0-0x000000018099A560
	}
}
