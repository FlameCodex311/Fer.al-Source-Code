/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_AvatarLookImage : MonoBehaviour // TypeDefIndex: 13712
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _emptyLookImage; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useEmptyLookImage; // 0x30
	private Waiter _iconLoadWaiter; // 0x38
	private AvatarLookItemComponent _look; // 0x40
	private BaseDef _def; // 0x48

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 13713
	{
		// Fields
		public UI_AvatarLookImage <>4__this; // 0x10
		public AvatarLookItemComponent inLook; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Setup>b__0(); // 0x0000000180517560-0x0000000180517770
	}

	// Constructors
	public UI_AvatarLookImage(); // 0x00000001804C3790-0x00000001804C37A0

	// Methods
	public void Setup(AvatarLookItemComponent inLook); // 0x000000018051DDB0-0x000000018051DF20
	private void OnDisable(); // 0x000000018051DCF0-0x000000018051DDB0
}

