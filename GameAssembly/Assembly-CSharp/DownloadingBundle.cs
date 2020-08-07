/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Networking;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class DownloadingBundle // TypeDefIndex: 10944
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
	public float Progress { get; } // 0x0000000180856530-0x0000000180856550 

	// Constructors
	public DownloadingBundle(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public void StartDownload(); // 0x0000000180856370-0x0000000180856530
	public void OnDownloadSuccess(); // 0x00000001808562F0-0x0000000180856370
	public void OnDownloadError(); // 0x0000000180855DD0-0x00000001808562F0
}

