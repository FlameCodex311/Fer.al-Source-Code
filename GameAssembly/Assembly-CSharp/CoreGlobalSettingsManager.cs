/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class CoreGlobalSettingsManager : CoreManagerBase<CoreGlobalSettingsManager> // TypeDefIndex: 11121
{
	// Fields
	[Header] // 0x000000018023E8A0-0x000000018023E8D0
	public string version; // 0x60
	[Header] // 0x000000018023E9F0-0x000000018023EA20
	public string currentBuild; // 0x68
	public string currentBuildNumber; // 0x70
	[Header] // 0x000000018023EC10-0x000000018023EC40
	public DeviceQualityLevel quality; // 0x78
	public bool qualityAutoSetOnDevice; // 0x7C
	[Header] // 0x000000018023EF10-0x000000018023EF40
	public bool platformEmulatePhoneInEditor; // 0x7D
	[Header] // 0x000000018023EFE0-0x000000018023F010
	public AudioQualityLevel audioQuality; // 0x80
	[Header] // 0x000000018023F150-0x000000018023F180
	public bool useEditorTestPlatform; // 0x84
	public EEditorPlatform editorTestPlatform; // 0x88
	[Header] // 0x000000018023F2E0-0x000000018023F310
	public SystemLanguage editorLanguage; // 0x8C
	private static SystemLanguage? _language; // 0x00
	public bool showUnlocalizedLabels; // 0x90
	public List<SystemLanguage> supportedLanguages; // 0x98
	[Header] // 0x00000001801D1FE0-0x00000001801D2010
	public bool showUnityVersionPopup; // 0xA0
	[Header] // 0x000000018023F560-0x000000018023F590
	public bool chartForceOfflineMode; // 0xA1
	public List<string> chartForceOfflineChartNames; // 0xA8
	public bool chartAllowOfflineMode; // 0xB0
	public bool chartTestOfflineMode; // 0xB1
	[Header] // 0x000000018023F7C0-0x000000018023F7F0
	public BundleManagerMode bundleMode; // 0xB4
	public SimplePlatform bundlePlatform; // 0xB8
	public bool bundleEmulateSlowBundlesInEditor; // 0xBC
	public bool bundleUseDevBundlesInEditor; // 0xBD
	public bool bundleUseDownloaderInEditor; // 0xBE
	public bool bundleUseEditorAssetBundleServer; // 0xBF
	public string bundleEditorAssetBundleServerURL; // 0xC0
	[Header] // 0x000000018023F9C0-0x000000018023F9F0
	public bool airplaneMode; // 0xC8
	public bool forceKeepAlive; // 0xC9
	public ServerTier serverTier; // 0xCC
	public static ServerTier ServerTier; // 0x08
	[FormerlySerializedAs] // 0x000000018023FC50-0x000000018023FC80
	public ServerEnvironment currentServerEnvironment; // 0xD0
	public ServerEnvironment[] serverEnvironments; // 0xD8
	private static bool _useAlternateCDNURL; // 0x0C
	private static string _clientID; // 0x10
	private string _networkChartURL; // 0xE0
	private string _networkAssetBundleURL; // 0xE8
	private string _networkHashedAssetBundleURL; // 0xF0

	// Properties
	public SystemLanguage language { get; set; } // 0x0000000180A6BF80-0x0000000180A6C1C0 0x0000000180A6C2A0-0x0000000180A6C3B0
	public bool IsLanguageReversed { get; } // 0x0000000180A6BC10-0x0000000180A6BC60 
	public static bool UseAlternateCDNURL { get; set; } // 0x0000000180A6BEC0-0x0000000180A6BF80 0x0000000180A6C1C0-0x0000000180A6C2A0
	public static string ClientID { get; } // 0x0000000180A6B9F0-0x0000000180A6BB20 
	public virtual string PostSplashScene { get; } // 0x0000000180A6BC70-0x0000000180A6BCA0 
	public virtual string DataServerProject { get; } // 0x0000000180A6BB20-0x0000000180A6BB50 
	public virtual string ProjectSVNURL { get; } // 0x0000000180A6BD80-0x0000000180A6BDC0 
	protected virtual string DevBaseURL { get; } // 0x0000000180A6BB50-0x0000000180A6BB90 
	protected virtual string ProdBaseURL { get; } // 0x0000000180A6BCE0-0x0000000180A6BD20 
	protected virtual string StageBaseURL { get; } // 0x0000000180A6BE40-0x0000000180A6BE80 
	protected virtual string ProdAlternateBaseURL { get; } // 0x0000000180A6BCA0-0x0000000180A6BCE0 
	protected virtual string StageAlternateBaseURL { get; } // 0x0000000180A6BE00-0x0000000180A6BE40 
	protected virtual string DevSharedBaseURL { get; } // 0x0000000180A6BB90-0x0000000180A6BBD0 
	protected virtual string StageSharedBaseURL { get; } // 0x0000000180A6BE80-0x0000000180A6BEC0 
	protected virtual string SharedBaseURL { get; } // 0x0000000180A6BDC0-0x0000000180A6BE00 
	public bool IsProdMode { get; } // 0x0000000180A6BC60-0x0000000180A6BC70 
	public bool IsStageMode { get; } // 0x0000000180647A30-0x0000000180647A40 
	public bool IsDevMode { get; } // 0x0000000180A6BBD0-0x0000000180A6BC10 
	public bool ChartsAndBundlesHashed { get; } // 0x0000000180A6B9D0-0x0000000180A6B9F0 
	public virtual string ProjectDefine { get; } // 0x0000000180A6BD20-0x0000000180A6BD80 

	// Constructors
	protected CoreGlobalSettingsManager(); // 0x0000000180A6B8C0-0x0000000180A6B9D0
	static CoreGlobalSettingsManager(); // 0x00000001803774A0-0x00000001803774B0

	// Methods
	public string GetDevCDNBaseURL(); // 0x0000000180A6A9E0-0x0000000180A6AA00
	public string GetStageCDNBaseURL(); // 0x0000000180A6B060-0x0000000180A6B130
	public string GetProdCDNBaseURL(); // 0x0000000180A6AE30-0x0000000180A6AF00
	public string GetCDNBaseURL(); // 0x0000000180A6A890-0x0000000180A6A9E0
	public string GetSharedBaseURL(); // 0x0000000180A6AFE0-0x0000000180A6B060
	public string GetNetworkChartURL(); // 0x0000000180A6ACC0-0x0000000180A6AD20
	public string GetNetworkAssetBundleURL(); // 0x0000000180A6AA00-0x0000000180A6ACC0
	public string GetNetworkHashedAssetBundleURL(); // 0x0000000180A6AD20-0x0000000180A6AE30
	public override void Init(); // 0x0000000180A6B130-0x0000000180A6B630
	public virtual void SetReleaseSettings(); // 0x00000001803774A0-0x00000001803774B0
	private void SetSafeSettingsForCurrentPlatform(); // 0x0000000180A6B6D0-0x0000000180A6B750
	private void OnApplicationQuit(); // 0x0000000180A6B630-0x0000000180A6B6D0
	public ServerEnvironment GetServerEnvironmentByName(string name); // 0x0000000180A6AF00-0x0000000180A6AFE0
	public void SetServerEnvironmentByName(string name); // 0x0000000180A6B750-0x0000000180A6B8C0
}

