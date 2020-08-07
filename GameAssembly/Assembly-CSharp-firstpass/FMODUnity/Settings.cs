/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMOD;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMODUnity
{
	public class Settings : ScriptableObject // TypeDefIndex: 10305
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public ExtraPlatformFlags ExtraPlatforms; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool SwitchSettingsMigration; // 0x1C
		private const string SettingsAssetName = "FMODStudioSettings"; // Metadata: 0x0077BA6D
		private static Settings instance; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool HasSourceProject; // 0x1D
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool HasPlatforms; // 0x1E
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string sourceProjectPath; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string SourceProjectPathUnformatted; // 0x28
		private string sourceBankPath; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string SourceBankPathUnformatted; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool AutomaticEventLoading; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BankLoadType BankLoadType; // 0x44
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public bool AutomaticSampleLoading; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string EncryptionKey; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public ImportType ImportType; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public string TargetAssetPath; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public DEBUG_FLAGS LoggingLevel; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<PlatformIntSetting> SpeakerModeSettings; // 0x70
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<PlatformIntSetting> SampleRateSettings; // 0x78
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<PlatformBoolSetting> LiveUpdateSettings; // 0x80
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<PlatformBoolSetting> OverlaySettings; // 0x88
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<PlatformBoolSetting> LoggingSettings; // 0x90
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<PlatformStringSetting> BankDirectorySettings; // 0x98
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<PlatformIntSetting> VirtualChannelSettings; // 0xA0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<PlatformIntSetting> RealChannelSettings; // 0xA8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> Plugins; // 0xB0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> MasterBanks; // 0xB8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> Banks; // 0xC0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public List<string> BanksToLoad; // 0xC8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public ushort LiveUpdatePort; // 0xD0
	
		// Properties
		public static Settings Instance { get; } // 0x0000000180D330D0-0x0000000180D332F0 
		public string SourceProjectPath { get; set; } // 0x0000000180D333D0-0x0000000180D334B0 0x0000000180D33570-0x0000000180D33630
		public string SourceBankPath { get; set; } // 0x0000000180D332F0-0x0000000180D333D0 0x0000000180D334B0-0x0000000180D33570
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass39_0<T> // TypeDefIndex: 10306
			where T : PlatformSettingBase
		{
			// Fields
			public FMODPlatform platform;
	
			// Constructors
			public <>c__DisplayClass39_0();
	
			// Methods
			internal bool <HasSetting>b__0(T x);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass40_0<T, U> // TypeDefIndex: 10307
			where T : PlatformSetting<U>
		{
			// Fields
			public FMODPlatform platform;
	
			// Constructors
			public <>c__DisplayClass40_0();
	
			// Methods
			internal bool <GetSetting>b__0(T x);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass41_0<T, U> // TypeDefIndex: 10308
			where T : PlatformSetting<U>, new()
		{
			// Fields
			public FMODPlatform platform;
	
			// Constructors
			public <>c__DisplayClass41_0();
	
			// Methods
			internal bool <SetSetting>b__0(T x);
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass42_0<T> // TypeDefIndex: 10309
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
		private Settings(); // 0x0000000180D32D50-0x0000000180D330D0
		static Settings(); // 0x00000001803774A0-0x00000001803774B0
	
		// Methods
		public static FMODPlatform GetParent(FMODPlatform platform); // 0x0000000180D32770-0x0000000180D32800
		public static bool HasSetting<T>(List<T> list, FMODPlatform platform)
			where T : PlatformSettingBase;
		public static U GetSetting<T, U>(List<T> list, FMODPlatform platform, U def)
			where T : PlatformSetting<U>;
		public static void SetSetting<T, U>(List<T> list, FMODPlatform platform, U value)
			where T : PlatformSetting<U>, new();
		public static void RemoveSetting<T>(List<T> list, FMODPlatform platform)
			where T : PlatformSettingBase;
		public bool IsLiveUpdateEnabled(FMODPlatform platform); // 0x0000000180D32A80-0x0000000180D32B00
		public bool IsOverlayEnabled(FMODPlatform platform); // 0x0000000180D32B00-0x0000000180D32B80
		public int GetRealChannels(FMODPlatform platform); // 0x0000000180D328C0-0x0000000180D32930
		public int GetVirtualChannels(FMODPlatform platform); // 0x0000000180D32A10-0x0000000180D32A80
		public int GetSpeakerMode(FMODPlatform platform); // 0x0000000180D329A0-0x0000000180D32A10
		public int GetSampleRate(FMODPlatform platform); // 0x0000000180D32930-0x0000000180D329A0
		public string GetBankPlatform(FMODPlatform platform); // 0x0000000180D326E0-0x0000000180D32770
		private void OnEnable(); // 0x0000000180D32B80-0x0000000180D32D50
		private string GetPlatformSpecificPath(string path); // 0x0000000180D32800-0x0000000180D328C0
	}
}
