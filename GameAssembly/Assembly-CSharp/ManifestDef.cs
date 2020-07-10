/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ManifestDef : BaseDef // TypeDefIndex: 13349
{
	// Fields
	public string hash; // 0x50
	public string fileName; // 0x58
	public int size; // 0x60
	public static string _baseURL; // 0x00
	private string _downloadURL; // 0x68

	// Properties
	private static string BaseDownloadURL { get; } // 0x00000001811EE5C0-0x00000001811EE6E0 
	public string DownloadURL { get; } // 0x00000001811EEC60-0x00000001811EEF00 
	public bool IsIncluded { get; } // 0x00000001811EF0A0-0x00000001811EF170 
	public bool IsDownloaderCached { get; } // 0x00000001811EEFC0-0x00000001811EEFE0 
	public bool IsCached { get; } // 0x00000001811EEFA0-0x00000001811EEFC0 
	public bool IsCachedInAnyWay { get; } // 0x00000001811EEF50-0x00000001811EEFA0 
	public bool IsImportant { get; } // 0x00000001811EEFE0-0x00000001811EF0A0 
	public string HashedFileName { get; } // 0x00000001811EEF00-0x00000001811EEF50 
	public string TempHashedFileName { get; } // 0x00000001811EF170-0x00000001811EF1F0 
	public string BundleIncludedFilePath { get; } // 0x00000001811EE8F0-0x00000001811EEA10 
	public string BundleTarCacheFilePath { get; } // 0x00000001811EEB90-0x00000001811EEC60 
	public string BundleDownloaderCacheTempFilePath { get; } // 0x00000001811EE850-0x00000001811EE8F0 
	public string BundleCacheTempFilePath { get; } // 0x00000001811EE7B0-0x00000001811EE850 
	public string BundleCacheFilePath { get; } // 0x00000001811EE6E0-0x00000001811EE7B0 
	public string BundleLocalFilePath { get; } // 0x00000001811EEA10-0x00000001811EEB90 

	// Constructors
	public ManifestDef(); // 0x00000001811EE550-0x00000001811EE5C0

	// Methods
	public override void LoadEntry(); // 0x00000001811EE4A0-0x00000001811EE550
	public void DeleteFromCache(); // 0x00000001811EE440-0x00000001811EE4A0
}

