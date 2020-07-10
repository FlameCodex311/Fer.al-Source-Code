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

public class UI_SanctuaryLookImage : MonoBehaviour // TypeDefIndex: 12058
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _emptyLookImage; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _useEmptyLookImage; // 0x30
	private Waiter _iconLoadWaiter; // 0x38
	private SanctuaryLookItemComponent _look; // 0x40
	private BaseDef _def; // 0x48

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12059
	{
		// Fields
		public UI_SanctuaryLookImage <>4__this; // 0x10
		public SanctuaryLookItemComponent inLook; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__0(); // 0x0000000180EE19F0-0x0000000180EE1C30
	}

	// Constructors
	public UI_SanctuaryLookImage(); // 0x0000000180EEED90-0x0000000180EEEDA0

	// Methods
	public void Setup(SanctuaryLookItemComponent inLook); // 0x0000000180EEEC10-0x0000000180EEED90
	private void OnDisable(); // 0x0000000180EEEB50-0x0000000180EEEC10
}

