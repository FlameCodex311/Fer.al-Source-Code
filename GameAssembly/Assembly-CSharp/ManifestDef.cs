/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ManifestDef : BaseDef // TypeDefIndex: 11020
{
	// Fields
	public string hash; // 0x50
	public string fileName; // 0x58
	public int size; // 0x60
	public static string _baseURL; // 0x00
	private string _downloadURL; // 0x68

	// Properties
	private static string BaseDownloadURL { get; } // 0x00000001804F50C0-0x00000001804F51D0 
	public string DownloadURL { get; } // 0x00000001804F5750-0x00000001804F59D0 
	public bool IsIncluded { get; } // 0x00000001804F5B70-0x00000001804F5C30 
	public bool IsDownloaderCached { get; } // 0x00000001804F5A90-0x00000001804F5AB0 
	public bool IsCached { get; } // 0x00000001804F5A70-0x00000001804F5A90 
	public bool IsCachedInAnyWay { get; } // 0x00000001804F5A20-0x00000001804F5A70 
	public bool IsImportant { get; } // 0x00000001804F5AB0-0x00000001804F5B70 
	public string HashedFileName { get; } // 0x00000001804F59D0-0x00000001804F5A20 
	public string TempHashedFileName { get; } // 0x00000001804F5C30-0x00000001804F5CB0 
	public string BundleIncludedFilePath { get; } // 0x00000001804F53E0-0x00000001804F5500 
	public string BundleTarCacheFilePath { get; } // 0x00000001804F5680-0x00000001804F5750 
	public string BundleDownloaderCacheTempFilePath { get; } // 0x00000001804F5340-0x00000001804F53E0 
	public string BundleCacheTempFilePath { get; } // 0x00000001804F52A0-0x00000001804F5340 
	public string BundleCacheFilePath { get; } // 0x00000001804F51D0-0x00000001804F52A0 
	public string BundleLocalFilePath { get; } // 0x00000001804F5500-0x00000001804F5680 

	// Constructors
	public ManifestDef(); // 0x00000001804F5050-0x00000001804F50C0

	// Methods
	public override void LoadEntry(); // 0x00000001804F4FA0-0x00000001804F5050
	public void DeleteFromCache(); // 0x00000001804F4F40-0x00000001804F4FA0
}

