/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Config;
using Rewired.Data;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[AddComponentMenu] // 0x00000001801EFC50-0x00000001801EFCC0
	[Browsable] // 0x00000001801EFC50-0x00000001801EFCC0
	[EditorBrowsable] // 0x00000001801EFC50-0x00000001801EFCC0
	[ExecuteInEditMode] // 0x00000001801EFC50-0x00000001801EFCC0
	public abstract class InputManager_Base : UnityEngine.MonoBehaviour // TypeDefIndex: 6592
	{
		// Fields
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private bool _dontDestroyOnLoad; // 0x18
		[CustomObfuscation] // 0x00000001801D1070-0x00000001801D10B0
		[SerializeField] // 0x00000001801D1070-0x00000001801D10B0
		private UserData _userData; // 0x20
		[CustomObfuscation] // 0x00000001801D00E0-0x00000001801D0120
		[SerializeField] // 0x00000001801D00E0-0x00000001801D0120
		private ControllerDataFiles _controllerDataFiles; // 0x28
		protected bool isCompiling; // 0x30
		[NonSerialized]
		private bool initialized; // 0x31
		[NonSerialized]
		private bool criticalError; // 0x32
		[NonSerialized]
		protected EditorPlatform editorPlatform; // 0x34
		[NonSerialized]
		protected Rewired.Platforms.Platform platform; // 0x38
		[NonSerialized]
		protected WebplayerPlatform webplayerPlatform; // 0x3C
		[NonSerialized]
		protected bool isEditor; // 0x40
		[NonSerialized]
		protected bool _detectedPlatformInEditor; // 0x41
		[NonSerialized]
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		protected ScriptingBackend scriptingBackend; // 0x44
		[NonSerialized]
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		protected ScriptingAPILevel scriptingAPILevel; // 0x48
		[NonSerialized]
		private bool _duplicateRIMError; // 0x4C
		private bool _isAwake; // 0x4D
	
		// Properties
		public UserData userData { get; internal set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
		public ControllerDataFiles dataFiles { get; } // 0x00000001803745B0-0x00000001803745C0 
		public bool runInEditMode { get; set; } // 0x00000001809A2340-0x00000001809A2370 0x00000001809A2370-0x00000001809A2460
		internal bool isRunningInEditMode { get; } // 0x00000001809A21F0-0x00000001809A2340 
	
		// Nested types
		private enum ExceptionPoint // TypeDefIndex: 6593
		{
			Initialization = 0,
			Update = 1,
			Destroy = 2
		}
	
		// Constructors
		protected InputManager_Base(); // 0x00000001809A2180-0x00000001809A21F0
	
		// Methods
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Awake(); // 0x000000018099F6E0-0x000000018099F740
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnEnable(); // 0x00000001809A14B0-0x00000001809A15D0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnDisable(); // 0x00000001809A1460-0x00000001809A14B0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnDestroy(); // 0x00000001809A1300-0x00000001809A1460
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void OnApplicationFocus(bool isFocused); // 0x00000001809A1260-0x00000001809A1300
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Start(); // 0x00000001809A19D0-0x00000001809A1AB0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void Update(); // 0x00000001809A2100-0x00000001809A2180
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void FixedUpdate(); // 0x000000018099F910-0x000000018099F9C0
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		private void LateUpdate(); // 0x00000001809A10E0-0x00000001809A11E0
		internal void OnGUIUpdate(); // 0x00000001809A15D0-0x00000001809A1660
		internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit); // 0x000000018099F770-0x000000018099F910
		internal void TryStartRunInEditMode(); // 0x00000001809A1AB0-0x00000001809A2010
		internal void TryStopRunInEditMode(); // 0x00000001809A2010-0x00000001809A2090
		private bool ManualInitialize(); // 0x00000001809A11E0-0x00000001809A1260
		private void Initialize(); // 0x00000001809A0690-0x00000001809A0E00
		private object InitializePlatform(ConfigVars configVars); // 0x00000001809A0560-0x00000001809A0690
		private List<Assembly> GetNativeAssembliesFromResources(); // 0x000000018099FC90-0x00000001809A0070
		private List<Assembly> GetNativeAssembliesByReflection(); // 0x000000018099FA20-0x000000018099FC90
		private byte[] GetNativeDLLBytesByReflection(); // 0x00000001809A0070-0x00000001809A0230
		private void AddTextAssetInResourcesToList(List<TextAsset> list, List<string> dllPaths); // 0x000000018099F4C0-0x000000018099F6E0
		private string SetPlatformToEditorPlatform(); // 0x00000001809A1840-0x00000001809A19D0
		private bool CheckEditorPlatformMatches(); // 0x000000018099F740-0x000000018099F770
		private string GetPlatformSpecificAssemblyName(); // 0x00000001809A0230-0x00000001809A0380
		private bool IsOnlyManagerInScene(); // 0x00000001809A0F60-0x00000001809A10E0
		protected void RecompileStart(); // 0x00000001809A1760-0x00000001809A17B0
		protected void RecompileEnd(); // 0x00000001809A1720-0x00000001809A1760
		protected void OnSceneLoaded(); // 0x00000001809A1660-0x00000001809A1720
		private void HandleException(ExceptionPoint location, string message, Exception exception); // 0x00000001809A0450-0x00000001809A0560
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal void ResetAll(); // 0x00000001809A17B0-0x00000001809A1840
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal EditorPlatform GetEditorPlatform(); // 0x000000018099F9C0-0x000000018099FA20
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported); // 0x00000001809A0380-0x00000001809A0450
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		internal bool IsEditModeSupported(); // 0x00000001809A0E00-0x00000001809A0F60
		protected abstract void OnInitialized();
		protected abstract void OnDeinitialized();
		protected abstract void DetectPlatform();
		protected abstract void CheckRecompile();
		protected abstract IExternalTools GetExternalTools();
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <GetNativeAssembliesByReflection>b__1(Assembly x); // 0x00000001809A2090-0x00000001809A2100
	}
}
