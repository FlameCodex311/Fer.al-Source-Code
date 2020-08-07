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

// Image 67: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8232-8523

internal class AencFeKOrVDwLiaYYvSPCUBnyQR : PlatformInputManager, INativePlatformHelper // TypeDefIndex: 8265
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
	bool EqNCsHnThXNYPmKqMTCKNSGUTPS { get; } // 0x0000000180407150-0x00000001804071F0 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override int deviceCount { get; } // 0x0000000180407E00-0x0000000180407E50 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override PlatformInputManager primaryInputManager { get; } // 0x00000001803765E0-0x00000001803765F0 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IInputSource inputSource { get; } // 0x0000000180407E70-0x0000000180407EA0 
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override InputSource inputSourceType { get; } // 0x0000000180407E50-0x0000000180407E70 

	// Nested types
	private class iEeYcsSnMNDBtUXEPEUGiCTxLrcE // TypeDefIndex: 8266
	{
		// Fields
		private List<MfklltoMHqIRLgRVaRGlCBeTopfN> lKmUXPDVzddeQFnSCIhnMWRqJKR; // 0x10
		private List<MfklltoMHqIRLgRVaRGlCBeTopfN> ZSSbVlFXIeeWlHfnMgJUZsyZVBov; // 0x18

		// Properties
		public int bdffqpeEhWHfiCfGAiADIQPAjoP { get; } // 0x000000018041DFC0-0x000000018041E000 

		// Nested types
		private class MfklltoMHqIRLgRVaRGlCBeTopfN // TypeDefIndex: 8267
		{
			// Fields
			public int pEDcwpmUGWaCBeFfGgLGUFNuPvn; // 0x10
			public int TMAbbsgEGJyYLJbZUinsGyJDzfrr; // 0x14
			public int WjUeSSqMcKwalSfYxtJXUaOcpFR; // 0x18
			public InputSource hWDeJGpknyImCbqJkSnevbUWlsFV; // 0x1C

			// Constructors
			public MfklltoMHqIRLgRVaRGlCBeTopfN(int mapperId, int managerId, int id, InputSource source); // 0x000000018041B210-0x000000018041B260

			// Methods
			public void bDpjnZNTIBcpcFFeCkJZEztApBtU(int param_00011102); // 0x00000001803FD620-0x00000001803FD630
			public LvRtGrAbSGUIQWczhOCUDgaeLKv tCiFeqeOnmXzZvCDknvaffhpPQZ(); // 0x000000018041B260-0x000000018041B280
			public static int DCTdFRfBDKaerapFUDmsUaGXfkO(MfklltoMHqIRLgRVaRGlCBeTopfN param_00011103, MfklltoMHqIRLgRVaRGlCBeTopfN param_00011104); // 0x000000018041B1B0-0x000000018041B210
		}

		public struct LvRtGrAbSGUIQWczhOCUDgaeLKv // TypeDefIndex: 8268
		{
			// Fields
			public int pEDcwpmUGWaCBeFfGgLGUFNuPvn; // 0x00
			public int TMAbbsgEGJyYLJbZUinsGyJDzfrr; // 0x04
			public InputSource hWDeJGpknyImCbqJkSnevbUWlsFV; // 0x08

			// Constructors
			public LvRtGrAbSGUIQWczhOCUDgaeLKv(int mapperId, int managerId, InputSource source); // 0x00000001800035B0-0x0000000180003830
		}

		public enum lBXWckRJjvMTTglfQYcEgBfMEej // TypeDefIndex: 8269
		{
			hxBuCPWjXWEpuKzEmRBqHrRWHeXE = 0,
			CVGHsGZeOSnwBwCnzeEFdNmYVFh = 1
		}

		// Constructors
		public iEeYcsSnMNDBtUXEPEUGiCTxLrcE(); // 0x000000018041D400-0x000000018041D490

		// Methods
		public void czJfNpWlLRIuVIlmRarULntsPJh(BridgedController param_000110ef); // 0x000000018041D490-0x000000018041DB30
		public void BIAKqCiPjcexYgWkFTrsKtithaqk(ControllerDisconnectedEventArgs param_000110f0); // 0x000000018041D200-0x000000018041D310
		public void lVhkLlPjRCqgbnOfNcvgGpgAezfB(int param_000110f1, int param_000110f2); // 0x000000018041E000-0x000000018041E120
		public int daFyNXXCvqkrBdbqihawLHSTSUF(int param_000110f3, lBXWckRJjvMTTglfQYcEgBfMEej param_000110f4); // 0x000000018041DDB0-0x000000018041DFC0
		public int daFyNXXCvqkrBdbqihawLHSTSUF(int param_000110f5, InputSource param_000110f6, lBXWckRJjvMTTglfQYcEgBfMEej param_000110f7); // 0x000000018041DB30-0x000000018041DDB0
		public LvRtGrAbSGUIQWczhOCUDgaeLKv tCiFeqeOnmXzZvCDknvaffhpPQZ(int param_000110f8, lBXWckRJjvMTTglfQYcEgBfMEej param_000110f9); // 0x000000018041E120-0x000000018041E300
		public int MMUCCxeitikgDjcjgHCrxuDlmBOk(int param_000110fa, InputSource param_000110fb, lBXWckRJjvMTTglfQYcEgBfMEej param_000110fc); // 0x000000018041D310-0x000000018041D400
		private int ygYAplBkUyHheekxTbaAbgmeVgka(int param_000110fd); // 0x000000018041E300-0x000000018041E420
		private int ygYAplBkUyHheekxTbaAbgmeVgka(); // 0x000000018041E420-0x000000018041E590
	}

	private class IPlgRheNIlFXOBfrEyCPvUiuWWB : IInputManagerJoystickPublic // TypeDefIndex: 8270
	{
		// Fields
		private IInputManagerJoystickPublic FHrmTAMUixetljGBkWIzbnxEwoS; // 0x10
		private int LjdqEeltlMcuRXPZqFjwAAshjTLy; // 0x18

		// Properties
		public int bCdxFnoMWYtrCiNLlRQMlgiLhPYa { get; } // 0x0000000180416760-0x00000001804167B0 
		public int rOswLqEgOAUdfDDijgplETcyGsj { get; } // 0x00000001803F46B0-0x00000001803F46C0 
		public string jOGaaqLeMxUeGlAHgGomExnvoPks { get; } // 0x00000001804166A0-0x0000000180416760 
		public long? NqbaEJahRxeWAYFmqUTcGYZIrKTk { get; } // 0x00000001804167B0-0x0000000180416880 
		public int qqCUErPxWEsKgPeLTrVvGVDVshx { get; } // 0x0000000180416880-0x00000001804168D0 
		public Guid bMXCQBaILjSLhjhLTWucoJJurha { get; } // 0x00000001804165D0-0x00000001804166A0 
		public Guid LmbhqyhADUZyVAHUuyuwxUiUCRp { get; } // 0x00000001804165D0-0x00000001804166A0 
		public Controller.Extension jYEFyiCuBDWDkjltLhxjBCtAToeE { get; } // 0x0000000180416510-0x00000001804165D0 

		// Constructors
		public IPlgRheNIlFXOBfrEyCPvUiuWWB(IInputManagerJoystickPublic sourceJoystick, int bridgeJoystickId); // 0x00000001804164D0-0x0000000180416510

		// Methods
		public void SetVibration(float amount, int motorIndex); // 0x00000001804163B0-0x0000000180416480
		public void StopVibration(); // 0x0000000180416480-0x00000001804164D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class jzacRxCYNcUguYTfyaTXnEFWGeW // TypeDefIndex: 8271
	{
		// Fields
		public int ngqDUMuDAInmkCVzhBrDxYDYBx; // 0x10

		// Constructors
		public jzacRxCYNcUguYTfyaTXnEFWGeW(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public int KsLIdHUTjVPNwRkLhpaqAGNrepHg(); // 0x000000018041E590-0x000000018041E6B0
	}

	// Constructors
	public AencFeKOrVDwLiaYYvSPCUBnyQR(ConfigVars configVars, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId); // 0x0000000180407960-0x0000000180407E00

	// Methods
	private bool MexDitdLJRgsJVVUHoyaQprgLKe(ConfigVars param_000110dd, RFXBGuaLilDRmxUmxillviMcHxZq param_000110de); // 0x0000000180406A30-0x0000000180406DB0
	private bool ggWLElqpgITLCAXULBtmuSwWEaC(ConfigVars param_000110df, RFXBGuaLilDRmxUmxillviMcHxZq param_000110e0); // 0x0000000180407EA0-0x0000000180408070
	private bool pEDhINPNHjxbRThwXXNttIVrRsS(ConfigVars param_000110e1, RFXBGuaLilDRmxUmxillviMcHxZq param_000110e2); // 0x0000000180408870-0x0000000180408AD0
	private bool oIJyLDRbWHYQLmAuyrcUGCCbYqf(ConfigVars param_000110e3, bool param_000110e4); // 0x0000000180408070-0x0000000180408690
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void Initialize(); // 0x00000001804068A0-0x0000000180406A30
	public override void Update(UpdateLoopType currentUpdateLoop); // 0x0000000180407870-0x0000000180407960
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void OnDestroy(); // 0x0000000180406DB0-0x0000000180406F80
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate(); // 0x00000001803A1580-0x00000001803A1590
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void UpdateControllerData(int controllerId, ControllerDataUpdater data); // 0x0000000180407730-0x0000000180407870
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SystemDeviceConnected(); // 0x00000001803774A0-0x00000001803774B0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SystemDeviceDisconnected(); // 0x00000001803774A0-0x00000001803774B0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId); // 0x00000001803774A0-0x00000001803774B0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IUnifiedMouseSource GetUnifiedMouseSource(); // 0x0000000180406790-0x00000001804068A0
	[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource(); // 0x00000001804066B0-0x0000000180406790
	private void yChVacnOcsCgebJCKmcNvuuaXOL(BridgedController param_000110ea); // 0x0000000180408AD0-0x0000000180408B70
	private void PjaIBuqxmeqWsLJUUmWUZRHNnWj(ControllerDisconnectedEventArgs param_000110eb); // 0x0000000180406F80-0x0000000180407150
	private void odqIgZjKcYVvmGQfsYJjYGLSHTfe(EventArgs param_000110ec); // 0x0000000180408750-0x0000000180408870
	private void oXBNntKocVtcWoqREXKDZbcwYCc(EventArgs param_000110ed); // 0x0000000180408690-0x0000000180408750
	private void RjqAngxudnPnDHWrIbmwYwemjv(UpdateControllerInfoEventArgs param_000110ee); // 0x00000001804071F0-0x0000000180407730
}

