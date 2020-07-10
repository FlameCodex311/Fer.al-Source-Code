/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_AvatarLookImage : MonoBehaviour // TypeDefIndex: 12165
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _emptyLookImage; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useEmptyLookImage; // 0x30
	private Waiter _iconLoadWaiter; // 0x38
	private AvatarLookItemComponent _look; // 0x40
	private BaseDef _def; // 0x48

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12166
	{
		// Fields
		public UI_AvatarLookImage <>4__this; // 0x10
		public AvatarLookItemComponent inLook; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__0(); // 0x0000000180FB2580-0x0000000180FB27B0
	}

	// Constructors
	public UI_AvatarLookImage(); // 0x0000000180EEED90-0x0000000180EEEDA0

	// Methods
	public void Setup(AvatarLookItemComponent inLook); // 0x0000000180FB8F00-0x0000000180FB9080
	private void OnDisable(); // 0x0000000180FB8E40-0x0000000180FB8F00
}

