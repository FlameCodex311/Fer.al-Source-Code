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
using Rewired.Data;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils.Classes.Data;

// Image 66: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8066-8357

internal class AencFeKOrVDwLiaYYvSPCUBnyQR : PlatformInputManager, INativePlatformHelper // TypeDefIndex: 8099
{
	// Fields
	private bool zIMjkflcMpNJWsSweDCVucrSvMT; // 0x38
	private object tEWeesDkzCTZLiCbehRdivtycqB; // 0x40
	private IndexedDictionary<int, PlatformInputManager> TrasUKNqBhxcuamzTJuqxHgrQuY; // 0x48
	private iEeYcsSnMNDBtUXEPEUGiCTxLrcE zWBATVQuwnIrUjNzAhxcFkfrRfsF; // 0x50
	private Action<int, ControllerDataUpdater> foXIqDIskRyntvUJrVarmOifcqn; // 0x58
	private WindowsStandalonePrimaryInputSource cMHgbfdWKJAprdwQbEWusiGqhIiR; // 0x60
	private bool OWGnbOYLKxblRayALCFlSXflpRF; // 0x64
	private PlatformInputManager vxvdOmjUaxPdZoojPEpVbAJOQRic; // 0x68
	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> SPPGEprkVSKsolJOZAOXmfAPQau; // 0x70
	private Func<int> NjwvsULqnevgrqobWcYoUdYGcbI; // 0x78

	// Properties
	bool EqNCsHnThXNYPmKqMTCKNSGUTPS { get; } // 0x0000000180357BE0-0x0000000180357C80 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override int deviceCount { get; } // 0x00000001803588D0-0x0000000180358920 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override PlatformInputManager primaryInputManager { get; } // 0x0000000180358970-0x0000000180358980 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IInputSource inputSource { get; } // 0x0000000180358940-0x0000000180358970 
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override InputSource inputSourceType { get; } // 0x0000000180358920-0x0000000180358940 

	// Nested types
	private class iEeYcsSnMNDBtUXEPEUGiCTxLrcE // TypeDefIndex: 8100
	{
		// Fields
		private List<MfklltoMHqIRLgRVaRGlCBeTopfN> lKmUXPDVzddeQFnSCIhnMWRqJKR; // 0x10
		private List<MfklltoMHqIRLgRVaRGlCBeTopfN> ZSSbVlFXIeeWlHfnMgJUZsyZVBov; // 0x18

		// Properties
		public int bdffqpeEhWHfiCfGAiADIQPAjoP { get; } // 0x000000018036F530-0x000000018036F570 

		// Nested types
		private class MfklltoMHqIRLgRVaRGlCBeTopfN // TypeDefIndex: 8101
		{
			// Fields
			public int pEDcwpmUGWaCBeFfGgLGUFNuPvn; // 0x10
			public int TMAbbsgEGJyYLJbZUinsGyJDzfrr; // 0x14
			public int WjUeSSqMcKwalSfYxtJXUaOcpFR; // 0x18
			public InputSource hWDeJGpknyImCbqJkSnevbUWlsFV; // 0x1C

			// Constructors
			public MfklltoMHqIRLgRVaRGlCBeTopfN(int mapperId, int managerId, int id, InputSource source); // 0x000000018036C6A0-0x000000018036C6F0

			// Methods
			public void bDpjnZNTIBcpcFFeCkJZEztApBtU(int param_00010e5e); // 0x000000018036C6F0-0x000000018036C700
			public LvRtGrAbSGUIQWczhOCUDgaeLKv tCiFeqeOnmXzZvCDknvaffhpPQZ(); // 0x000000018036C700-0x000000018036C720
			public static int DCTdFRfBDKaerapFUDmsUaGXfkO(MfklltoMHqIRLgRVaRGlCBeTopfN param_00010e5f, MfklltoMHqIRLgRVaRGlCBeTopfN param_00010e60); // 0x000000018036C640-0x000000018036C6A0
		}

		public struct LvRtGrAbSGUIQWczhOCUDgaeLKv // TypeDefIndex: 8102
		{
			// Fields
			public int pEDcwpmUGWaCBeFfGgLGUFNuPvn; // 0x00
			public int TMAbbsgEGJyYLJbZUinsGyJDzfrr; // 0x04
			public InputSource hWDeJGpknyImCbqJkSnevbUWlsFV; // 0x08

			// Constructors
			public LvRtGrAbSGUIQWczhOCUDgaeLKv(int mapperId, int managerId, InputSource source); // 0x00000001800027E0-0x0000000180002A70
		}

		public enum lBXWckRJjvMTTglfQYcEgBfMEej // TypeDefIndex: 8103
		{
			hxBuCPWjXWEpuKzEmRBqHrRWHeXE = 0,
			CVGHsGZeOSnwBwCnzeEFdNmYVFh = 1
		}

		// Constructors
		public iEeYcsSnMNDBtUXEPEUGiCTxLrcE(); // 0x000000018036E930-0x000000018036E9C0

		// Methods
		public void czJfNpWlLRIuVIlmRarULntsPJh(BridgedController param_00010e4b); // 0x000000018036E9C0-0x000000018036F080
		public void BIAKqCiPjcexYgWkFTrsKtithaqk(ControllerDisconnectedEventArgs param_00010e4c); // 0x000000018036E730-0x000000018036E840
		public void lVhkLlPjRCqgbnOfNcvgGpgAezfB(int param_00010e4d, int param_00010e4e); // 0x000000018036F570-0x000000018036F690
		public int daFyNXXCvqkrBdbqihawLHSTSUF(int param_00010e4f, lBXWckRJjvMTTglfQYcEgBfMEej param_00010e50); // 0x000000018036F310-0x000000018036F530
		public int daFyNXXCvqkrBdbqihawLHSTSUF(int param_00010e51, InputSource param_00010e52, lBXWckRJjvMTTglfQYcEgBfMEej param_00010e53); // 0x000000018036F080-0x000000018036F310
		public LvRtGrAbSGUIQWczhOCUDgaeLKv tCiFeqeOnmXzZvCDknvaffhpPQZ(int param_00010e54, lBXWckRJjvMTTglfQYcEgBfMEej param_00010e55); // 0x000000018036F690-0x000000018036F870
		public int MMUCCxeitikgDjcjgHCrxuDlmBOk(int param_00010e56, InputSource param_00010e57, lBXWckRJjvMTTglfQYcEgBfMEej param_00010e58); // 0x000000018036E840-0x000000018036E930
		private int ygYAplBkUyHheekxTbaAbgmeVgka(int param_00010e59); // 0x000000018036F870-0x000000018036F990
		private int ygYAplBkUyHheekxTbaAbgmeVgka(); // 0x000000018036F990-0x000000018036FB00
	}

	private class IPlgRheNIlFXOBfrEyCPvUiuWWB : IInputManagerJoystickPublic // TypeDefIndex: 8104
	{
		// Fields
		private IInputManagerJoystickPublic FHrmTAMUixetljGBkWIzbnxEwoS; // 0x10
		private int LjdqEeltlMcuRXPZqFjwAAshjTLy; // 0x18

		// Properties
		public int bCdxFnoMWYtrCiNLlRQMlgiLhPYa { get; } // 0x00000001803678B0-0x0000000180367900 
		public int rOswLqEgOAUdfDDijgplETcyGsj { get; } // 0x0000000180367710-0x0000000180367720 
		public string jOGaaqLeMxUeGlAHgGomExnvoPks { get; } // 0x00000001803677F0-0x00000001803678B0 
		public long? NqbaEJahRxeWAYFmqUTcGYZIrKTk { get; } // 0x0000000180367900-0x00000001803679D0 
		public int qqCUErPxWEsKgPeLTrVvGVDVshx { get; } // 0x00000001803679D0-0x0000000180367A20 
		public Guid bMXCQBaILjSLhjhLTWucoJJurha { get; } // 0x0000000180367720-0x00000001803677F0 
		public Guid LmbhqyhADUZyVAHUuyuwxUiUCRp { get; } // 0x0000000180367720-0x00000001803677F0 
		public Controller.Extension jYEFyiCuBDWDkjltLhxjBCtAToeE { get; } // 0x0000000180367650-0x0000000180367710 

		// Constructors
		public IPlgRheNIlFXOBfrEyCPvUiuWWB(IInputManagerJoystickPublic sourceJoystick, int bridgeJoystickId); // 0x0000000180367610-0x0000000180367650

		// Methods
		public void SetVibration(float amount, int motorIndex); // 0x00000001803674F0-0x00000001803675C0
		public void StopVibration(); // 0x00000001803675C0-0x0000000180367610
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class jzacRxCYNcUguYTfyaTXnEFWGeW // TypeDefIndex: 8105
	{
		// Fields
		public int ngqDUMuDAInmkCVzhBrDxYDYBx; // 0x10

		// Constructors
		public jzacRxCYNcUguYTfyaTXnEFWGeW(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public int KsLIdHUTjVPNwRkLhpaqAGNrepHg(); // 0x000000018036FB00-0x000000018036FC20
	}

	// Constructors
	public AencFeKOrVDwLiaYYvSPCUBnyQR(ConfigVars configVars, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId); // 0x0000000180358420-0x00000001803588D0

	// Methods
	private bool MexDitdLJRgsJVVUHoyaQprgLKe(ConfigVars param_00010e39, RFXBGuaLilDRmxUmxillviMcHxZq param_00010e3a); // 0x00000001803574B0-0x0000000180357840
	private bool ggWLElqpgITLCAXULBtmuSwWEaC(ConfigVars param_00010e3b, RFXBGuaLilDRmxUmxillviMcHxZq param_00010e3c); // 0x0000000180358980-0x0000000180358B50
	private bool pEDhINPNHjxbRThwXXNttIVrRsS(ConfigVars param_00010e3d, RFXBGuaLilDRmxUmxillviMcHxZq param_00010e3e); // 0x0000000180359360-0x00000001803595C0
	private bool oIJyLDRbWHYQLmAuyrcUGCCbYqf(ConfigVars param_00010e3f, bool param_00010e40); // 0x0000000180358B50-0x0000000180359180
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void Initialize(); // 0x0000000180357320-0x00000001803574B0
	public override void Update(UpdateLoopType currentUpdateLoop); // 0x0000000180358330-0x0000000180358420
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void OnDestroy(); // 0x0000000180357840-0x0000000180357A10
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x0000000180357120-0x0000000180357130
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void UpdateControllerData(int controllerId, ControllerDataUpdater data); // 0x00000001803581F0-0x0000000180358330
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SystemDeviceConnected(); // 0x00000001803581E0-0x00000001803581F0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SystemDeviceDisconnected(); // 0x00000001803581E0-0x00000001803581F0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001803581E0-0x00000001803581F0
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x0000000180357210-0x0000000180357320
	[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x0000000180357130-0x0000000180357210
	private void yChVacnOcsCgebJCKmcNvuuaXOL(BridgedController param_00010e46); // 0x00000001803595C0-0x0000000180359670
	private void PjaIBuqxmeqWsLJUUmWUZRHNnWj(ControllerDisconnectedEventArgs param_00010e47); // 0x0000000180357A10-0x0000000180357BE0
	private void odqIgZjKcYVvmGQfsYJjYGLSHTfe(EventArgs param_00010e48); // 0x0000000180359240-0x0000000180359360
	private void oXBNntKocVtcWoqREXKDZbcwYCc(EventArgs param_00010e49); // 0x0000000180359180-0x0000000180359240
	private void RjqAngxudnPnDHWrIbmwYwemjv(UpdateControllerInfoEventArgs param_00010e4a); // 0x0000000180357C80-0x00000001803581E0
}

