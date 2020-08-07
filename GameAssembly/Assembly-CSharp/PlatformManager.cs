/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PlatformManager : CorePlatformManager // TypeDefIndex: 11821
{
	// Fields
	[SetInstance] // 0x00000001801CEA70-0x00000001801CEA80
	public static PlatformManager instance; // 0x00

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 11822
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__1_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001804ED410-0x00000001804ED470
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Init>b__1_0(); // 0x00000001804ECB90-0x00000001804ECBE0
	}

	// Constructors
	public PlatformManager(); // 0x00000001804E2A90-0x00000001804E2AF0

	// Methods
	public override void Init(); // 0x00000001804E2490-0x00000001804E25B0
	private void CoreLoaded(); // 0x00000001803774A0-0x00000001803774B0
	protected override void SetDeviceQualitySettingsMap(); // 0x00000001804E25B0-0x00000001804E2A90
	public override bool HasFinishCoroutine(); // 0x0000000180380B60-0x0000000180380B70
	public override IEnumerator FinishCoroutine(); // 0x00000001804E2430-0x00000001804E2490
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Init>b__1_1(); // 0x00000001803774A0-0x00000001803774B0
}

