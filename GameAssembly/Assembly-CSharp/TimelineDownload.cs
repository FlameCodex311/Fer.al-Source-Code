/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x0000000180239FC0-0x0000000180239FF0
public class TimelineDownload : ManagedBehaviour // TypeDefIndex: 13434
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _downloadOnStart; // 0x50
	private bool _downloaded; // 0x51
	public DownloadInfo[] downloadInfos; // 0x58

	// Nested types
	[Serializable]
	public class DownloadInfo // TypeDefIndex: 13435
	{
		// Fields
		[RootSelector] // 0x000000018023AFE0-0x000000018023B040
		public string bundleId; // 0x10
		public Transform parent; // 0x18
		public Vector3 position; // 0x20
		public Vector3 rotation; // 0x2C

		// Constructors
		public DownloadInfo(); // 0x0000000180F7ADE0-0x0000000180F7AE80
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 13436
	{
		// Fields
		public int ii; // 0x10
		public TimelineDownload <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Download>b__0(UnityEngine.Object gLoaded); // 0x0000000180F92A40-0x0000000180F92C90
	}

	// Constructors
	public TimelineDownload(); // 0x0000000180F8E120-0x0000000180F8E180

	// Methods
	public override void MStart(); // 0x0000000180F8E0F0-0x0000000180F8E120
	public void Download(); // 0x0000000180F8DE70-0x0000000180F8E0F0
}

