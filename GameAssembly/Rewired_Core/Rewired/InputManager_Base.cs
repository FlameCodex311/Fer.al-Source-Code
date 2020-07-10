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

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[AddComponentMenu] // 0x0000000180154930-0x00000001801549A0
	[Browsable] // 0x0000000180154930-0x00000001801549A0
	[EditorBrowsable] // 0x0000000180154930-0x00000001801549A0
	[ExecuteInEditMode] // 0x0000000180154930-0x00000001801549A0
	public abstract class InputManager_Base : UnityEngine.MonoBehaviour // TypeDefIndex: 6433
	{
		// Fields
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
		private bool _dontDestroyOnLoad; // 0x18
		[CustomObfuscation] // 0x00000001800C5270-0x00000001800C52B0
		[SerializeField] // 0x00000001800C5270-0x00000001800C52B0
		private UserData _userData; // 0x20
		[CustomObfuscation] // 0x00000001800C3DD0-0x00000001800C3E10
		[SerializeField] // 0x00000001800C3DD0-0x00000001800C3E10
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
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		protected ScriptingBackend scriptingBackend; // 0x44
		[NonSerialized]
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		protected ScriptingAPILevel scriptingAPILevel; // 0x48
		[NonSerialized]
		private bool _duplicateRIMError; // 0x4C
		private bool _isAwake; // 0x4D
	
		// Properties
		public UserData userData { get; internal set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
		public ControllerDataFiles dataFiles { get; } // 0x0000000180369B60-0x0000000180369B70 
		public bool runInEditMode { get; set; } // 0x000000018048B5C0-0x000000018048B5F0 0x000000018048B5F0-0x000000018048B6E0
		internal bool isRunningInEditMode { get; } // 0x000000018048B470-0x000000018048B5C0 
	
		// Nested types
		private enum ExceptionPoint // TypeDefIndex: 6434
		{
			Initialization = 0,
			Update = 1,
			Destroy = 2
		}
	
		// Constructors
		protected InputManager_Base(); // 0x000000018048B400-0x000000018048B470
	
		// Methods
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void Awake(); // 0x0000000180488920-0x0000000180488990
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnEnable(); // 0x000000018048A730-0x000000018048A850
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnDisable(); // 0x000000018048A6D0-0x000000018048A730
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnDestroy(); // 0x000000018048A570-0x000000018048A6D0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void OnApplicationFocus(bool isFocused); // 0x000000018048A4D0-0x000000018048A570
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void Start(); // 0x000000018048AC50-0x000000018048AD30
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void Update(); // 0x000000018048B380-0x000000018048B400
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void FixedUpdate(); // 0x0000000180488B60-0x0000000180488C10
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		private void LateUpdate(); // 0x000000018048A350-0x000000018048A450
		internal void OnGUIUpdate(); // 0x000000018048A850-0x000000018048A8E0
		internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit); // 0x00000001804889C0-0x0000000180488B60
		internal void TryStartRunInEditMode(); // 0x000000018048AD30-0x000000018048B290
		internal void TryStopRunInEditMode(); // 0x000000018048B290-0x000000018048B310
		private bool ManualInitialize(); // 0x000000018048A450-0x000000018048A4D0
		private void Initialize(); // 0x00000001804898F0-0x000000018048A070
		private object InitializePlatform(ConfigVars configVars); // 0x00000001804897C0-0x00000001804898F0
		private List<Assembly> GetNativeAssembliesFromResources(); // 0x0000000180488EE0-0x00000001804892D0
		private List<Assembly> GetNativeAssembliesByReflection(); // 0x0000000180488C70-0x0000000180488EE0
		private byte[] GetNativeDLLBytesByReflection(); // 0x00000001804892D0-0x0000000180489490
		private void AddTextAssetInResourcesToList(List<TextAsset> list, List<string> dllPaths); // 0x0000000180488700-0x0000000180488920
		private string SetPlatformToEditorPlatform(); // 0x000000018048AAC0-0x000000018048AC50
		private bool CheckEditorPlatformMatches(); // 0x0000000180488990-0x00000001804889C0
		private string GetPlatformSpecificAssemblyName(); // 0x0000000180489490-0x00000001804895E0
		private bool IsOnlyManagerInScene(); // 0x000000018048A1D0-0x000000018048A350
		protected void RecompileStart(); // 0x000000018048A9E0-0x000000018048AA30
		protected void RecompileEnd(); // 0x000000018048A9A0-0x000000018048A9E0
		protected void OnSceneLoaded(); // 0x000000018048A8E0-0x000000018048A9A0
		private void HandleException(ExceptionPoint location, string message, Exception exception); // 0x00000001804896B0-0x00000001804897C0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal void ResetAll(); // 0x000000018048AA30-0x000000018048AAC0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal EditorPlatform GetEditorPlatform(); // 0x0000000180488C10-0x0000000180488C70
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported); // 0x00000001804895E0-0x00000001804896B0
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		internal bool IsEditModeSupported(); // 0x000000018048A070-0x000000018048A1D0
		protected abstract void OnInitialized();
		protected abstract void OnDeinitialized();
		protected abstract void DetectPlatform();
		protected abstract void CheckRecompile();
		protected abstract IExternalTools GetExternalTools();
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <GetNativeAssembliesByReflection>b__1(Assembly x); // 0x000000018048B310-0x000000018048B380
	}
}
