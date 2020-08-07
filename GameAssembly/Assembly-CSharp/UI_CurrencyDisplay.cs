/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_CurrencyDisplay : MonoBehaviour // TypeDefIndex: 13878
{
	// Fields
	public CurrencyDisplayType currencyDisplayType; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _currencyText; // 0x28
	private int _lastCurrencyValue; // 0x30

	// Nested types
	public enum CurrencyDisplayType // TypeDefIndex: 13879
	{
		LIKES = 0,
		LOCKPICKS = 1,
		STAR_FRAGMENTS = 2
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13880
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x000000018053D9C0-0x000000018053DA20
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__4_0(); // 0x00000001805382B0-0x00000001805382D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 13881
	{
		// Fields
		public int value; // 0x10
		public UI_CurrencyDisplay <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <OnInventoryChanged>b__0(); // 0x0000000180387590-0x0000000180387930
		internal void <OnInventoryChanged>b__1(int x); // 0x00000001803FEB70-0x00000001803FEB80
		internal void <OnInventoryChanged>b__2(); // 0x000000018053CF50-0x000000018053CFA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 13882
	{
		// Fields
		public int value; // 0x10
		public UI_CurrencyDisplay <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <OnInventoryItemsRemoved>b__0(); // 0x0000000180387590-0x0000000180387930
		internal void <OnInventoryItemsRemoved>b__1(int x); // 0x00000001803FEB70-0x00000001803FEB80
		internal void <OnInventoryItemsRemoved>b__2(); // 0x000000018053CF50-0x000000018053CFA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass10_0 // TypeDefIndex: 13883
	{
		// Fields
		public int value; // 0x10
		public UI_CurrencyDisplay <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass10_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <OnCurrencyUpdated>b__0(); // 0x0000000180387590-0x0000000180387930
		internal void <OnCurrencyUpdated>b__1(int x); // 0x00000001803FEB70-0x00000001803FEB80
		internal void <OnCurrencyUpdated>b__2(); // 0x000000018053CF50-0x000000018053CFA0
	}

	// Constructors
	public UI_CurrencyDisplay(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x000000018054D1B0-0x000000018054D3F0
	private void OnSceneLoaded(Scene inScene, LoadSceneMode inLoadSceneMode); // 0x000000018054D100-0x000000018054D170
	private void OnInventoryChanged(InventoryItemChangedEvent inMessage); // 0x000000018054CC90-0x000000018054CEE0
	private void OnDestroy(); // 0x000000018054CB50-0x000000018054CC90
	private static bool ItemIsCurrency(Item i); // 0x000000018054C8E0-0x000000018054C910
	private void OnInventoryItemsRemoved(InventoryItemRemovedEvent inMessage); // 0x000000018054CEE0-0x000000018054D100
	private void OnCurrencyUpdated(InventoryListResponse inMessage); // 0x000000018054C910-0x000000018054CB50
	private void Reset(); // 0x000000018054D170-0x000000018054D1B0
	private int GetCurrentValue(); // 0x000000018054C7D0-0x000000018054C8E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__4_1(); // 0x000000018054D3F0-0x000000018054D510
}

