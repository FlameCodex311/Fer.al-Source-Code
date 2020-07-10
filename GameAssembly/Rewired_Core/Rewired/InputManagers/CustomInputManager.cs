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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.InputManagers
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class CustomInputManager : PlatformInputManager // TypeDefIndex: 6469
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
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override int deviceCount { get; } // 0x000000018047AB20-0x000000018047AB30 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override PlatformInputManager primaryInputManager { get; } // 0x0000000180369B40-0x0000000180369B50 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override IInputSource inputSource { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override InputSource inputSourceType { get; } // 0x00000001804841C0-0x00000001804841E0 
	
		// Nested types
		private class lWCZpNzMmIUsEqLdtWlVGDDPxbB : IInputManagerJoystick // TypeDefIndex: 6470
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
			public int qShluNeysidzzcdCVXhEWimMHJm { get; } // 0x0000000180495280-0x00000001804952A0 
			public int pqWtltkGaUjoTWWhNBdCBqoIWRgw { get; } // 0x0000000180495260-0x0000000180495280 
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public int rewiredId { get; set; } // 0x000000018038E0E0-0x000000018038E0F0 0x000000018036B790-0x000000018036B7A0
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public int inputManagerId { get; set; } // 0x000000018038E0D0-0x000000018038E0E0 0x000000018036B760-0x000000018036B770
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public string name { get; } // 0x0000000180495440-0x0000000180495510 
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public long? systemId { get; } // 0x000000018038E0C0-0x000000018038E0D0 
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public int unityId { get; } // 0x000000018047AB20-0x000000018047AB30 
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public Guid instanceGuid { get; } // 0x00000001804952A0-0x0000000180495440 
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public Guid persistentGuid { get; } // 0x0000000180495510-0x00000001804956A0 
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public Controller.Extension extension { get; } // 0x000000018036AC70-0x000000018036AC80 
	
			// Constructors
			public lWCZpNzMmIUsEqLdtWlVGDDPxbB(CustomInputSource customInputSource, long? systemJoystickId, int unityJoystickId, CustomInputSource.Joystick joystick, InputSource inputSource, Controller.Extension controllerExtension, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager); // 0x0000000180494F20-0x0000000180495260
	
			// Methods
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public void SetVibration(float amount, int motorIndex); // 0x00000001803581E0-0x00000001803581F0
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public void StopVibration(); // 0x00000001803581E0-0x00000001803581F0
			public void LBHnXppSrmtCeLbqzdSyaPaPqpv(); // 0x0000000180494A30-0x0000000180494A60
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public void Update(); // 0x0000000180494E00-0x0000000180494E40
			public int KtuOdxlQvfcWMKWKLpXAppHCedU(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6d5); // 0x0000000180494960-0x0000000180494A30
			private void wqlffMjxssnplevpBMMQSUIGWac(BridgedControllerHWInfo param_0000d6d6); // 0x0000000180495BA0-0x0000000180495C50
			private void wqlffMjxssnplevpBMMQSUIGWac(BridgedController param_0000d6d7); // 0x0000000180495C50-0x0000000180495DB0
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public void FillData(ControllerDataUpdater dataUpdater); // 0x0000000180494140-0x00000001804943B0
			public BridgedControllerHWInfo XRVSbFhJTVnjsPfNtQbaBGoeHvx(); // 0x0000000180494E40-0x0000000180494F20
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public BridgedController ToBridgedController(); // 0x0000000180494C10-0x0000000180494DA0
			[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
			public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs(); // 0x0000000180494DA0-0x0000000180494E00
			private void ImXynqJsKrbihkCeHBieZBlZjBkd(); // 0x0000000180494490-0x0000000180494960
			private void nxhcezssRzdcWxCszmkJAETEeBj(); // 0x00000001804956A0-0x0000000180495A50
			private bool ozJURFXGWjoSmvRPguejjmdfrxo(HardwareJoystickMap.Platform_Custom.Button param_0000d6d9); // 0x0000000180495A50-0x0000000180495B70
			private bool LHLdzrNekKQKOLbBvbgFmPfGORN(float param_0000d6da, float param_0000d6db); // 0x0000000180494A60-0x0000000180494A80
			private float MrEjHmrhMIAvyvAGWGqoSofBjzv(HardwareJoystickMap.Platform_Custom.Axis param_0000d6dc); // 0x0000000180494A80-0x0000000180494BE0
			private float MrEjHmrhMIAvyvAGWGqoSofBjzv(int param_0000d6dd); // 0x0000000180494BE0-0x0000000180494C10
			private bool ozJURFXGWjoSmvRPguejjmdfrxo(int param_0000d6de); // 0x0000000180495B70-0x0000000180495BA0
			private void BmYcESUSLtTSZTmUBGDGKcYFZYPB(); // 0x0000000180493FD0-0x0000000180494140
			private void xYVjwyZhjQqUkUFHjyreFStdrnk(); // 0x0000000180495DB0-0x0000000180495E00
			private string BDXxuNhkOqICIFSpFjayCRLyExW(); // 0x0000000180493B00-0x0000000180493FD0
			public static int yOaTLoqQNpSyLueOFrJKOdZbhdr(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6df, lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6e0); // 0x0000000180495E00-0x0000000180495E40
			public static int HIiawsuXqDvxQRxZFHhRkOKXATJB(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6e1, lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6e2); // 0x00000001804943B0-0x0000000180494490
		}
	
		private class NmJwWlrRRKFJfRBSYoHPIaYgElTg // TypeDefIndex: 6471
		{
			// Fields
			private List<eFjSJQccMtGFWfuDsNyeCWQnPoHw> hnpXymCoCCHPwqlDSIZkffYsKwxu; // 0x10
	
			// Properties
			public int SHujHYUxHggDGFiBfPBtOLtZhMW { get; } // 0x000000018048E1A0-0x000000018048E1E0 
	
			// Nested types
			public enum CRFlivKpxXYVyfkgJBkgeayLvfoj // TypeDefIndex: 6472
			{
				fUCXKJCTVFsJpPqXabTFOEWGhao = 0,
				VvUvsThtRLwEHszViUPhlXdArGo = 1
			}
	
			public class eFjSJQccMtGFWfuDsNyeCWQnPoHw // TypeDefIndex: 6473
			{
				// Fields
				public int OVXHKDzaJatXjMbqyxVckuQWdNz; // 0x10
				public long? aETsTpgQGHeijvpDhoGUBSjNdCc; // 0x18
				public string YvPxdtlAPbSTVkXmeqLwUfQtbBj; // 0x28
				public int OlAgkDKAhOqDAgDjadFVJGPfUNR; // 0x30
				public int QsBvetqPHrzKthaGEErdieSJgIkd; // 0x34
				public int RweyBZyAAIjbTgpvgIOlbybhzioP; // 0x38
	
				// Constructors
				public eFjSJQccMtGFWfuDsNyeCWQnPoHw(int rewiredId, long? systemId, string systemControllerName, int lastInputManagerId, int buttonCount, int axisCount); // 0x0000000180493AA0-0x0000000180493B00
	
				// Methods
				public bool KtuOdxlQvfcWMKWKLpXAppHCedU(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6f1, CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d6f2); // 0x0000000180493910-0x0000000180493AA0
			}
	
			// Constructors
			public NmJwWlrRRKFJfRBSYoHPIaYgElTg(); // 0x000000018048E140-0x000000018048E1A0
	
			// Methods
			public void lmldbkvCGcJRSRLClxvEdfwGeFAF(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6e3); // 0x000000018048E1E0-0x000000018048E730
			public bool QiqTwdMaCeiulPEUZWQFMcDFHZHG(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6e4, CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d6e5); // 0x000000018048DC80-0x000000018048DED0
			public eFjSJQccMtGFWfuDsNyeCWQnPoHw SJSWnEKwuoLTQVEoRbtWctEUXhl(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6e6, CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d6e7); // 0x000000018048DED0-0x000000018048E140
			public int ItDzbHMiIYGseDXjmhIUEkIaQew(eFjSJQccMtGFWfuDsNyeCWQnPoHw param_0000d6e8); // 0x000000018048DB90-0x000000018048DC80
			private void BPfbiRRcHBdGVaFlopltypkiKpwF(int param_0000d6e9, int param_0000d6ea); // 0x000000018048DA90-0x000000018048DB90
		}
	
		// Constructors
		public CustomInputManager(CustomInputSource customInputSource, UpdateLoopSetting updateLoopSetting, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId); // 0x0000000180483F10-0x0000000180484060
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override void Initialize(); // 0x0000000180481B80-0x0000000180481C40
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override void Update(UpdateLoopType updateLoop); // 0x00000001804827C0-0x00000001804829A0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override void OnDestroy(); // 0x0000000180482570-0x0000000180482590
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000180357120-0x0000000180357130
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data); // 0x0000000180482680-0x00000001804827C0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override void SystemDeviceConnected(); // 0x00000001804825F0-0x0000000180482610
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override void SystemDeviceDisconnected(); // 0x0000000180482610-0x0000000180482680
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override void SetUnityJoystickId(int joystickId, int unityJoystickIndex); // 0x00000001803581E0-0x00000001803581F0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x000000018035FCC0-0x000000018035FCD0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x000000018035FCC0-0x000000018035FCD0
		private void YoZyWiOZBJomMtEtoZcHjseDbAj(CustomInputSource.Joystick[] param_0000d6ad); // 0x0000000180483540-0x0000000180483F10
		private void lacmGlTQoaLmoxrvjoHVdQPxdgv(); // 0x00000001804846B0-0x00000001804847D0
		private void CrEFysWJYfMtJVlNOTETVlrRfmH(int param_0000d6ae, int param_0000d6af, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6b0, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6b1); // 0x0000000180480F20-0x0000000180481900
		private void vldJABpAisLeLtnWmXvbkuWgBVP(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6b2, int param_0000d6b3, int param_0000d6b4); // 0x0000000180484A20-0x0000000180484BC0
		private bool pNMfllDFmeSLnPQOJXZWrLWxJvV(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6b5, int param_0000d6b6); // 0x00000001804847D0-0x00000001804848D0
		private int bboyWaSBIWfSuDuvAhGSQFlklHB(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6b7); // 0x0000000180484060-0x00000001804841C0
		private bool pvXOIHQgaXRwmhvpEGPOheJnhQaK(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6b8, int param_0000d6b9); // 0x00000001804848D0-0x00000001804849E0
		private void YIYZwrraphZTryuQTiOviKWRzIv(int param_0000d6ba, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6bb, int param_0000d6bc, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6bd, NmJwWlrRRKFJfRBSYoHPIaYgElTg.CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d6be); // 0x00000001804829A0-0x0000000180483290
		private void MEGxlYFLQIBDskCcuhdtrMUQPsay(int param_0000d6bf, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6c0, NmJwWlrRRKFJfRBSYoHPIaYgElTg.CRFlivKpxXYVyfkgJBkgeayLvfoj param_0000d6c1); // 0x0000000180481C40-0x0000000180482570
		private void SZwYmZviewQhCXYBZRYpKgLixEo(); // 0x0000000180482590-0x00000001804825F0
		private bool jREgEtiIdWEJuYqeDMqRZmepaiy(CustomInputSource.Joystick[] param_0000d6c2); // 0x00000001804841E0-0x00000001804846B0
		private void HDRVotfzQTtozttlcYWzSMkLNGk(List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6c3, List<lWCZpNzMmIUsEqLdtWlVGDDPxbB> param_0000d6c4, bool param_0000d6c5); // 0x0000000180481900-0x0000000180481B80
		private void rRbwQLxKmBpfwWwAFobgsEaaBko(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6c6, bool param_0000d6c7); // 0x00000001804849E0-0x0000000180484A20
		private void YfMnlmBcMMYqbQGgMeLXdIVUDnZF(lWCZpNzMmIUsEqLdtWlVGDDPxbB param_0000d6c8, bool param_0000d6c9); // 0x0000000180483290-0x0000000180483540
	}
}
