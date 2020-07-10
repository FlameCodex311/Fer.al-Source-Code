/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_MultiItemPopup : UI_Window // TypeDefIndex: 12521
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIShiny _shinyEffect; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _titleText; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _itemParent; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_MultiItemPopupListItem _itemPrefab; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _body; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _largeBodyItemCount; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _smallBodyHeight; // 0x134
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _largeBodyHeight; // 0x138

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12522
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		[TupleElementNames] // 0x00000001800D77A0-0x00000001800D7820
		public static Comparison<ValueTuple<BaseDef, int>> <>9__0_0; // 0x08
		[TupleElementNames] // 0x00000001800D7C50-0x00000001800D7CD0
		public static Comparison<ValueTuple<BaseDef, int>> <>9__2_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF510-0x0000000180ECF570
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal int <OpenWindow>b__0_0([TupleElementNames] /* 0x00000001800D80D0-0x00000001800D8150 */ ValueTuple<BaseDef, int> a, [TupleElementNames] /* 0x00000001800D86C0-0x00000001800D8740 */ ValueTuple<BaseDef, int> b); // 0x0000000180ECD8B0-0x0000000180ECD9F0
		internal int <QueueWindow>b__2_0([TupleElementNames] /* 0x00000001800D8C30-0x00000001800D8CB0 */ ValueTuple<BaseDef, int> a, [TupleElementNames] /* 0x00000001800D9090-0x00000001800D9110 */ ValueTuple<BaseDef, int> b); // 0x0000000180ECDF50-0x0000000180ECE0A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12523
	{
		// Fields
		[TupleElementNames] // 0x00000001800D96F0-0x00000001800D9770
		public List<ValueTuple<BaseDef, int>> inItems; // 0x10
		public string inTitle; // 0x18
		public bool inIsPremium; // 0x20

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_MultiItemPopup window); // 0x0000000180ECE620-0x0000000180ECE660
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 12524
	{
		// Fields
		[TupleElementNames] // 0x00000001800D9E80-0x00000001800D9F00
		public List<ValueTuple<BaseDef, int>> inItems; // 0x10
		public string inTitle; // 0x18
		public bool inIsPremium; // 0x20

		// Constructors
		public <>c__DisplayClass3_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECEE80-0x0000000180ECEF60
	}

	// Constructors
	public UI_Window_MultiItemPopup(); // 0x0000000180EDC9B0-0x0000000180EDC9E0

	// Methods
	public static void OpenWindow(BundlePackDefComponent inBundlePack, bool inIsPremium = false /* Metadata: 0x00782F4A */); // 0x0000000180EDBD60-0x0000000180EDC130
	public static void OpenWindow([TupleElementNames] /* 0x00000001800D69E0-0x00000001800D6A60 */ List<ValueTuple<BaseDef, int>> inItems, string inTitle = "" /* Metadata: 0x00782F4B */, bool inIsPremium = false /* Metadata: 0x00782F4F */); // 0x0000000180EDC130-0x0000000180EDC210
	public static void QueueWindow(BundlePackDefComponent inBundlePack, bool inIsPremium = false /* Metadata: 0x00782F50 */); // 0x0000000180EDC210-0x0000000180EDC5E0
	public static void QueueWindow([TupleElementNames] /* 0x00000001800D6E30-0x00000001800D6EB0 */ List<ValueTuple<BaseDef, int>> inItems, string inTitle = "" /* Metadata: 0x00782F51 */, bool inIsPremium = false /* Metadata: 0x00782F55 */); // 0x0000000180EDC5E0-0x0000000180EDC6C0
	public static void CloseWindow(); // 0x0000000180EDBBE0-0x0000000180EDBC30
	private void Setup([TupleElementNames] /* 0x00000001800D72A0-0x00000001800D7320 */ List<ValueTuple<BaseDef, int>> inItems, string inTitle, bool inIsPremium); // 0x0000000180EDC6C0-0x0000000180EDC9B0
	protected override void OnOpen(); // 0x0000000180EDBCD0-0x0000000180EDBD60
	protected override void OnClose(bool inAnimate); // 0x0000000180EDBC30-0x0000000180EDBCD0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

