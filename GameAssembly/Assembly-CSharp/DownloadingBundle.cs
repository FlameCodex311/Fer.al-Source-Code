/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class DownloadingBundle // TypeDefIndex: 13278
{
	// Fields
	public string path; // 0x10
	public ManifestDef manifestDef; // 0x18
	public DownloadState state; // 0x20
	[NonSerialized]
	public ulong remoteFileSize; // 0x28
	public float priorProgress; // 0x30
	public int downloadAttemptCount; // 0x34
	public float downloadTimer; // 0x38
	public BundleQueue queue; // 0x3C
	[NonSerialized]
	public UnityWebRequest webRequest; // 0x40
	[NonSerialized]
	public bool waitForResponseCodeFunctionPointerStandalone; // 0x48

	// Properties
	public float Progress { get; } // 0x0000000181189850-0x0000000181189870 

	// Constructors
	public DownloadingBundle(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public void StartDownload(); // 0x0000000181189680-0x0000000181189850
	public void OnDownloadSuccess(); // 0x0000000181189600-0x0000000181189680
	public void OnDownloadError(); // 0x00000001811890C0-0x0000000181189600
}

