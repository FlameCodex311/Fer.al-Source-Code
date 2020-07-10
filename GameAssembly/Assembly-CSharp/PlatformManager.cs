/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class PlatformManager : CorePlatformManager // TypeDefIndex: 10331
{
	// Fields
	[SetInstance] // 0x00000001800BDB50-0x00000001800BDB60
	public static PlatformManager instance; // 0x00

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 10332
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__1_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000181166E10-0x0000000181166E70
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Init>b__1_0(); // 0x0000000181166C60-0x0000000181166CB0
	}

	// Constructors
	public PlatformManager(); // 0x0000000181159820-0x0000000181159880

	// Methods
	public override void Init(); // 0x0000000181159230-0x0000000181159350
	private void CoreLoaded(); // 0x00000001803581E0-0x00000001803581F0
	protected override void SetDeviceQualitySettingsMap(); // 0x0000000181159350-0x0000000181159820
	public override bool HasFinishCoroutine(); // 0x00000001803C29F0-0x00000001803C2A00
	public override IEnumerator FinishCoroutine(); // 0x00000001811591D0-0x0000000181159230
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Init>b__1_1(); // 0x00000001803581E0-0x00000001803581F0
}

