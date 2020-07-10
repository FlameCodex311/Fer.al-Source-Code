/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMODUnity
{
	public class Settings : ScriptableObject // TypeDefIndex: 9851
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public ExtraPlatformFlags ExtraPlatforms; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool SwitchSettingsMigration; // 0x1C
		private const string SettingsAssetName = "FMODStudioSettings"; // Metadata: 0x00745FBB
		private static Settings instance; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public bool HasSourceProject; // 0x1D
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public bool HasPlatforms; // 0x1E
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string sourceProjectPath; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public string SourceProjectPathUnformatted; // 0x28
		private string sourceBankPath; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public string SourceBankPathUnformatted; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public bool AutomaticEventLoading; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public BankLoadType BankLoadType; // 0x44
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public bool AutomaticSampleLoading; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public string EncryptionKey; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public ImportType ImportType; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public string TargetAssetPath; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public DEBUG_FLAGS LoggingLevel; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<PlatformIntSetting> SpeakerModeSettings; // 0x70
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<PlatformIntSetting> SampleRateSettings; // 0x78
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<PlatformBoolSetting> LiveUpdateSettings; // 0x80
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<PlatformBoolSetting> OverlaySettings; // 0x88
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<PlatformBoolSetting> LoggingSettings; // 0x90
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<PlatformStringSetting> BankDirectorySettings; // 0x98
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<PlatformIntSetting> VirtualChannelSettings; // 0xA0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<PlatformIntSetting> RealChannelSettings; // 0xA8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> Plugins; // 0xB0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> MasterBanks; // 0xB8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> Banks; // 0xC0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public List<string> BanksToLoad; // 0xC8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public ushort LiveUpdatePort; // 0xD0
	
		// Properties
		public static Settings Instance { get; } // 0x0000000181B2DA80-0x0000000181B2DCA0 
		public string SourceProjectPath { get; set; } // 0x0000000181B2DD90-0x0000000181B2DE80 0x0000000181B2DF40-0x0000000181B2E000
		public string SourceBankPath { get; set; } // 0x0000000181B2DCA0-0x0000000181B2DD90 0x0000000181B2DE80-0x0000000181B2DF40
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass39_0<T> // TypeDefIndex: 9852
			where T : PlatformSettingBase
		{
			// Fields
			public FMODPlatform platform;
	
			// Constructors
			public <>c__DisplayClass39_0();
	
			// Methods
			internal bool <HasSetting>b__0(T x);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass40_0<T, U> // TypeDefIndex: 9853
			where T : PlatformSetting<U>
		{
			// Fields
			public FMODPlatform platform;
	
			// Constructors
			public <>c__DisplayClass40_0();
	
			// Methods
			internal bool <GetSetting>b__0(T x);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass41_0<T, U> // TypeDefIndex: 9854
			where T : PlatformSetting<U>, new()
		{
			// Fields
			public FMODPlatform platform;
	
			// Constructors
			public <>c__DisplayClass41_0();
	
			// Methods
			internal bool <SetSetting>b__0(T x);
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass42_0<T> // TypeDefIndex: 9855
			where T : PlatformSettingBase
		{
			// Fields
			public FMODPlatform platform;
	
			// Constructors
			public <>c__DisplayClass42_0();
	
			// Methods
			internal bool <RemoveSetting>b__0(T x);
		}
	
		// Constructors
		private Settings(); // 0x0000000181B2D700-0x0000000181B2DA80
		static Settings(); // 0x00000001803581E0-0x00000001803581F0
	
		// Methods
		public static FMODPlatform GetParent(FMODPlatform platform); // 0x0000000181B2D120-0x0000000181B2D1B0
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform)
			where T : PlatformSettingBase;
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def)
			where T : PlatformSetting<U>;
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value)
			where T : PlatformSetting<U>, new();
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform)
			where T : PlatformSettingBase;
		public bool IsLiveUpdateEnabled(FMODPlatform platform); // 0x0000000181B2D430-0x0000000181B2D4B0
		public bool IsOverlayEnabled(FMODPlatform platform); // 0x0000000181B2D4B0-0x0000000181B2D530
		public int GetRealChannels(FMODPlatform platform); // 0x0000000181B2D270-0x0000000181B2D2E0
		public int GetVirtualChannels(FMODPlatform platform); // 0x0000000181B2D3C0-0x0000000181B2D430
		public int GetSpeakerMode(FMODPlatform platform); // 0x0000000181B2D350-0x0000000181B2D3C0
		public int GetSampleRate(FMODPlatform platform); // 0x0000000181B2D2E0-0x0000000181B2D350
		public string GetBankPlatform(FMODPlatform platform); // 0x0000000181B2D090-0x0000000181B2D120
		private void OnEnable(); // 0x0000000181B2D530-0x0000000181B2D700
		private string GetPlatformSpecificPath(string path); // 0x0000000181B2D1B0-0x0000000181B2D270
	}
}
