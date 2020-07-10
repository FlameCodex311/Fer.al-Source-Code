/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class CoreGlobalSettingsManager : CoreManagerBase<CoreGlobalSettingsManager> // TypeDefIndex: 13450
{
	// Fields
	[Header] // 0x000000018015D0A0-0x000000018015D0D0
	public string version; // 0x60
	[Header] // 0x000000018015D1C0-0x000000018015D1F0
	public string currentBuild; // 0x68
	public string currentBuildNumber; // 0x70
	[Header] // 0x000000018015D450-0x000000018015D480
	public DeviceQualityLevel quality; // 0x78
	public bool qualityAutoSetOnDevice; // 0x7C
	[Header] // 0x000000018015D610-0x000000018015D640
	public bool platformEmulatePhoneInEditor; // 0x7D
	[Header] // 0x0000000180127080-0x00000001801270B0
	public AudioQualityLevel audioQuality; // 0x80
	[Header] // 0x000000018015D980-0x000000018015D9B0
	public bool useEditorTestPlatform; // 0x84
	public EEditorPlatform editorTestPlatform; // 0x88
	[Header] // 0x000000018015DC00-0x000000018015DC30
	public SystemLanguage editorLanguage; // 0x8C
	private static SystemLanguage? _language; // 0x00
	public bool showUnlocalizedLabels; // 0x90
	public List<SystemLanguage> supportedLanguages; // 0x98
	[Header] // 0x00000001800FF680-0x00000001800FF6B0
	public bool showUnityVersionPopup; // 0xA0
	[Header] // 0x000000018015E000-0x000000018015E030
	public bool chartForceOfflineMode; // 0xA1
	public List<string> chartForceOfflineChartNames; // 0xA8
	public bool chartAllowOfflineMode; // 0xB0
	public bool chartTestOfflineMode; // 0xB1
	[Header] // 0x000000018015E3E0-0x000000018015E410
	public BundleManagerMode bundleMode; // 0xB4
	public SimplePlatform bundlePlatform; // 0xB8
	public bool bundleEmulateSlowBundlesInEditor; // 0xBC
	public bool bundleUseDevBundlesInEditor; // 0xBD
	public bool bundleUseDownloaderInEditor; // 0xBE
	public bool bundleUseEditorAssetBundleServer; // 0xBF
	public string bundleEditorAssetBundleServerURL; // 0xC0
	[Header] // 0x000000018015E530-0x000000018015E560
	public bool airplaneMode; // 0xC8
	public bool forceKeepAlive; // 0xC9
	public ServerTier serverTier; // 0xCC
	public static ServerTier ServerTier; // 0x08
	[FormerlySerializedAs] // 0x000000018015E7F0-0x000000018015E820
	public ServerEnvironment currentServerEnvironment; // 0xD0
	public ServerEnvironment[] serverEnvironments; // 0xD8
	private static bool _useAlternateCDNURL; // 0x0C
	private static string _clientID; // 0x10
	private string _networkChartURL; // 0xE0
	private string _networkAssetBundleURL; // 0xE8
	private string _networkHashedAssetBundleURL; // 0xF0

	// Properties
	public SystemLanguage language { get; set; } // 0x00000001813119C0-0x0000000181311C10 0x0000000181311CF0-0x0000000181311E00
	public bool IsLanguageReversed { get; } // 0x0000000181311650-0x00000001813116A0 
	public static bool UseAlternateCDNURL { get; set; } // 0x0000000181311900-0x00000001813119C0 0x0000000181311C10-0x0000000181311CF0
	public static string ClientID { get; } // 0x0000000181311430-0x0000000181311560 
	public virtual string PostSplashScene { get; } // 0x00000001813116B0-0x00000001813116E0 
	public virtual string DataServerProject { get; } // 0x0000000181311560-0x0000000181311590 
	public virtual string ProjectSVNURL { get; } // 0x00000001813117C0-0x0000000181311800 
	protected virtual string DevBaseURL { get; } // 0x0000000181311590-0x00000001813115D0 
	protected virtual string ProdBaseURL { get; } // 0x0000000181311720-0x0000000181311760 
	protected virtual string StageBaseURL { get; } // 0x0000000181311880-0x00000001813118C0 
	protected virtual string ProdAlternateBaseURL { get; } // 0x00000001813116E0-0x0000000181311720 
	protected virtual string StageAlternateBaseURL { get; } // 0x0000000181311840-0x0000000181311880 
	protected virtual string DevSharedBaseURL { get; } // 0x00000001813115D0-0x0000000181311610 
	protected virtual string StageSharedBaseURL { get; } // 0x00000001813118C0-0x0000000181311900 
	protected virtual string SharedBaseURL { get; } // 0x0000000181311800-0x0000000181311840 
	public bool IsProdMode { get; } // 0x00000001813116A0-0x00000001813116B0 
	public bool IsStageMode { get; } // 0x0000000180FA19D0-0x0000000180FA19E0 
	public bool IsDevMode { get; } // 0x0000000181311610-0x0000000181311650 
	public bool ChartsAndBundlesHashed { get; } // 0x0000000181311410-0x0000000181311430 
	public virtual string ProjectDefine { get; } // 0x0000000181311760-0x00000001813117C0 

	// Constructors
	protected CoreGlobalSettingsManager(); // 0x00000001813112F0-0x0000000181311410
	static CoreGlobalSettingsManager(); // 0x00000001803581E0-0x00000001803581F0

	// Methods
	public string GetDevCDNBaseURL(); // 0x00000001813103A0-0x00000001813103C0
	public string GetStageCDNBaseURL(); // 0x0000000181310A50-0x0000000181310B20
	public string GetProdCDNBaseURL(); // 0x0000000181310810-0x00000001813108E0
	public string GetCDNBaseURL(); // 0x0000000181310250-0x00000001813103A0
	public string GetSharedBaseURL(); // 0x00000001813109D0-0x0000000181310A50
	public string GetNetworkChartURL(); // 0x00000001813106A0-0x0000000181310700
	public string GetNetworkAssetBundleURL(); // 0x00000001813103C0-0x00000001813106A0
	public string GetNetworkHashedAssetBundleURL(); // 0x0000000181310700-0x0000000181310810
	public override void Init(); // 0x0000000181310B20-0x0000000181311050
	public virtual void SetReleaseSettings(); // 0x00000001803581E0-0x00000001803581F0
	private void SetSafeSettingsForCurrentPlatform(); // 0x00000001813110F0-0x0000000181311170
	private void OnApplicationQuit(); // 0x0000000181311050-0x00000001813110F0
	public ServerEnvironment GetServerEnvironmentByName(string name); // 0x00000001813108E0-0x00000001813109D0
	public void SetServerEnvironmentByName(string name); // 0x0000000181311170-0x00000001813112F0
}

