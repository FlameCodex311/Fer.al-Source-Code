/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180153E00-0x0000000180153E30
public class TimelineDownload : ManagedBehaviour // TypeDefIndex: 11898
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _downloadOnStart; // 0x50
	private bool _downloaded; // 0x51
	public DownloadInfo[] downloadInfos; // 0x58

	// Nested types
	[Serializable]
	public class DownloadInfo // TypeDefIndex: 11899
	{
		// Fields
		[RootSelector] // 0x0000000180154E10-0x0000000180154E70
		public string bundleId; // 0x10
		public Transform parent; // 0x18
		public Vector3 position; // 0x20
		public Vector3 rotation; // 0x2C

		// Constructors
		public DownloadInfo(); // 0x00000001819F3F30-0x00000001819F3FD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 11900
	{
		// Fields
		public int ii; // 0x10
		public TimelineDownload <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Download>b__0(UnityEngine.Object gLoaded); // 0x0000000181A0E830-0x0000000181A0EAA0
	}

	// Constructors
	public TimelineDownload(); // 0x0000000181A0CCB0-0x0000000181A0CD10

	// Methods
	public override void MStart(); // 0x0000000181A0CC80-0x0000000181A0CCB0
	public void Download(); // 0x0000000181A0C9F0-0x0000000181A0CC80
}

