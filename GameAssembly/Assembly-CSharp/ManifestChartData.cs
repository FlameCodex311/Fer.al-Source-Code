/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class ManifestChartData : ChartDataObject<ManifestDef, ManifestChartData> // TypeDefIndex: 13350
{
	// Fields
	private static string[] _nonePostfixes; // 0x00
	private static string[] _lqPostfixes; // 0x08
	private static string[] _mqPostfixes; // 0x10
	private static string[] _hqPostfixes; // 0x18
	private bool? _useNewDownloadUrl; // 0x78
	private static Dictionary<string, string> _getFilePathFromBundleIDCache; // 0x20
	private static string _bundleTarCacheFolderPath; // 0x28
	private static string _bundleCacheFolderPath; // 0x30
	private static string _bundleIncludedFolderPath; // 0x38

	// Properties
	public override bool PlatformSpecific { get; } // 0x00000001803C29F0-0x00000001803C2A00 
	public override string DatabaseName { get; } // 0x00000001811EE260-0x00000001811EE290 
	public bool UseNewDownloadUrl { get; } // 0x00000001811EE290-0x00000001811EE440 
	public static string BundleTarCacheFolderPath { get; } // 0x00000001811EE0F0-0x00000001811EE260 
	public static string BundleCacheFolderPath { get; } // 0x00000001811EDD80-0x00000001811EDEF0 
	public static string BundleIncludedFolderPath { get; } // 0x00000001811EDEF0-0x00000001811EE0F0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <Init>d__29 : IEnumerator<object> // TypeDefIndex: 13351
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <Init>d__29(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811F16C0-0x00000001811F1AC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001811F1AC0-0x00000001811F1B10
	}

	// Constructors
	public ManifestChartData(); // 0x00000001811EDD20-0x00000001811EDD80
	static ManifestChartData(); // 0x00000001811ED5C0-0x00000001811EDD20

	// Methods
	public static string[] GetPostFixesInOrder(AssetQualityLevel inAssetQualityLevel); // 0x00000001811ECF00-0x00000001811ED030
	public static ManifestDef GetDefWithPathAndQualityLevel(string inPath, AssetQualityLevel inQualityLevel, bool inShowErrors = true /* Metadata: 0x00783BA2 */); // 0x00000001811EC7F0-0x00000001811ECB20
	public static string RepairBundleID(string inBundleID); // 0x00000001811ED480-0x00000001811ED5C0
	public static string GetFilePathFromBundleID(string inBundleID, bool inEditorMode = false /* Metadata: 0x00783BA3 */); // 0x00000001811ECB20-0x00000001811ECF00
	public static string GetBundleIDFromFilePath(string inBundleFilePath); // 0x00000001811EC4A0-0x00000001811EC7F0
	public bool PruneBundleCache(int inPruneAgeInHours, long inRequiredBytes = -1 /* Metadata: 0x00783BA4 */, bool inResetOnRequiredMBFailure = false /* Metadata: 0x00783BAC */); // 0x00000001811ED080-0x00000001811ED480
	public void ClearTarBundleCache(); // 0x00000001811EC3B0-0x00000001811EC4A0
	public void ClearBundleCache(); // 0x00000001811EC2C0-0x00000001811EC3B0
	[IteratorStateMachine] // 0x000000018012DD10-0x000000018012DD60
	public IEnumerator Init(); // 0x00000001811ED030-0x00000001811ED080
}

