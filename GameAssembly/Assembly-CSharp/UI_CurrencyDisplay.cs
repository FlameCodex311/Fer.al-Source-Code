/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_CurrencyDisplay : MonoBehaviour // TypeDefIndex: 12294
{
	// Fields
	public CurrencyDisplayType currencyDisplayType; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _currencyText; // 0x28
	private int _lastCurrencyValue; // 0x30

	// Nested types
	public enum CurrencyDisplayType // TypeDefIndex: 12295
	{
		LIKES = 0,
		LOCKPICKS = 1,
		STAR_FRAGMENTS = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12296
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180F1FA80-0x0000000180F1FAE0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__4_0(); // 0x0000000180F1EFD0-0x0000000180F1EFF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12297
	{
		// Fields
		public int value; // 0x10
		public UI_CurrencyDisplay <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <OnInventoryChanged>b__0(); // 0x000000018036CFF0-0x000000018036D000
		internal void <OnInventoryChanged>b__1(int x); // 0x000000018037AA40-0x000000018037AA50
		internal void <OnInventoryChanged>b__2(); // 0x0000000180F1EFF0-0x0000000180F1F040
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 12298
	{
		// Fields
		public int value; // 0x10
		public UI_CurrencyDisplay <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <OnInventoryItemsRemoved>b__0(); // 0x000000018036CFF0-0x000000018036D000
		internal void <OnInventoryItemsRemoved>b__1(int x); // 0x000000018037AA40-0x000000018037AA50
		internal void <OnInventoryItemsRemoved>b__2(); // 0x0000000180F1EFF0-0x0000000180F1F040
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 12299
	{
		// Fields
		public int value; // 0x10
		public UI_CurrencyDisplay <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass10_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <OnCurrencyUpdated>b__0(); // 0x000000018036CFF0-0x000000018036D000
		internal void <OnCurrencyUpdated>b__1(int x); // 0x000000018037AA40-0x000000018037AA50
		internal void <OnCurrencyUpdated>b__2(); // 0x0000000180F1EFF0-0x0000000180F1F040
	}

	// Constructors
	public UI_CurrencyDisplay(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180F2FA40-0x0000000180F2FC80
	private void OnSceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode); // 0x0000000180F2F990-0x0000000180F2FA00
	private void OnInventoryChanged(InventoryItemChangedEvent inMessage); // 0x0000000180F2F520-0x0000000180F2F770
	private void OnDestroy(); // 0x0000000180F2F3E0-0x0000000180F2F520
	private static bool ItemIsCurrency(Item i); // 0x0000000180F2F170-0x0000000180F2F1A0
	private void OnInventoryItemsRemoved(InventoryItemRemovedEvent inMessage); // 0x0000000180F2F770-0x0000000180F2F990
	private void OnCurrencyUpdated(InventoryListResponse inMessage); // 0x0000000180F2F1A0-0x0000000180F2F3E0
	private void Reset(); // 0x0000000180F2FA00-0x0000000180F2FA40
	private int GetCurrentValue(); // 0x0000000180F2F060-0x0000000180F2F170
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__4_1(); // 0x0000000180F2FC80-0x0000000180F2FDB0
}

