/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ManifestChartData : ChartDataObject<ManifestDef, ManifestChartData> // TypeDefIndex: 11021
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
	public override bool PlatformSpecific { get; } // 0x0000000180380B60-0x0000000180380B70 
	public override string DatabaseName { get; } // 0x00000001804F4D60-0x00000001804F4D90 
	public bool UseNewDownloadUrl { get; } // 0x00000001804F4D90-0x00000001804F4F40 
	public static string BundleTarCacheFolderPath { get; } // 0x00000001804F4BF0-0x00000001804F4D60 
	public static string BundleCacheFolderPath { get; } // 0x00000001804F4880-0x00000001804F49F0 
	public static string BundleIncludedFolderPath { get; } // 0x00000001804F49F0-0x00000001804F4BF0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <Init>d__29 : IEnumerator<object> // TypeDefIndex: 11022
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <Init>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180506CF0-0x00000001805070C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805070C0-0x0000000180508370
	}

	// Constructors
	public ManifestChartData(); // 0x00000001804F4820-0x00000001804F4880
	static ManifestChartData(); // 0x00000001804F4120-0x00000001804F4820

	// Methods
	public static string[] GetPostFixesInOrder(AssetQualityLevel inAssetQualityLevel); // 0x00000001804F3A80-0x00000001804F3BB0
	public static ManifestDef GetDefWithPathAndQualityLevel(string inPath, AssetQualityLevel inQualityLevel, bool inShowErrors = true /* Metadata: 0x0077C66B */); // 0x00000001804F33A0-0x00000001804F36C0
	public static string RepairBundleID(string inBundleID); // 0x00000001804F3FF0-0x00000001804F4120
	public static string GetFilePathFromBundleID(string inBundleID, bool inEditorMode = false /* Metadata: 0x0077C66C */); // 0x00000001804F36C0-0x00000001804F3A80
	public static string GetBundleIDFromFilePath(string inBundleFilePath); // 0x00000001804F3070-0x00000001804F33A0
	public bool PruneBundleCache(int inPruneAgeInHours, long inRequiredBytes = -1 /* Metadata: 0x0077C66D */, bool inResetOnRequiredMBFailure = false /* Metadata: 0x0077C675 */); // 0x00000001804F3C00-0x00000001804F3FF0
	public void ClearTarBundleCache(); // 0x00000001804F2F90-0x00000001804F3070
	public void ClearBundleCache(); // 0x00000001804F2EB0-0x00000001804F2F90
	[IteratorStateMachine] // 0x000000018020A0F0-0x000000018020A140
	public IEnumerator Init(); // 0x00000001804F3BB0-0x00000001804F3C00
}

