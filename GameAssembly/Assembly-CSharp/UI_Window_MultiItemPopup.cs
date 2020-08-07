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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_MultiItemPopup : UI_Window // TypeDefIndex: 14123
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIShiny _shinyEffect; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _itemParent; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_MultiItemPopupListItem _itemPrefab; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _body; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _largeBodyItemCount; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _smallBodyHeight; // 0x134
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _largeBodyHeight; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _btnBotRight; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _btnBotRightText; // 0x148
	private Action _buttonBotRightCallback; // 0x150

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14124
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		[TupleElementNames] // 0x000000018028EF90-0x000000018028F010
		public static Comparison<ValueTuple<BaseDef, int>> <>9__0_0; // 0x08
		[TupleElementNames] // 0x000000018028F210-0x000000018028F290
		public static Comparison<ValueTuple<BaseDef, int>> <>9__2_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E27F0-0x00000001803E2850
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal int <OpenWindow>b__0_0([TupleElementNames] /* 0x000000018028F5F0-0x000000018028F670 */ ValueTuple<BaseDef, int> a, [TupleElementNames] /* 0x000000018028F8A0-0x000000018028F920 */ ValueTuple<BaseDef, int> b); // 0x00000001803E0DF0-0x00000001803E0F30
		internal int <QueueWindow>b__2_0([TupleElementNames] /* 0x000000018028FB20-0x000000018028FBA0 */ ValueTuple<BaseDef, int> a, [TupleElementNames] /* 0x000000018028FEE0-0x000000018028FF60 */ ValueTuple<BaseDef, int> b); // 0x00000001803E1550-0x00000001803E16A0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14125
	{
		// Fields
		[TupleElementNames] // 0x0000000180290280-0x0000000180290300
		public List<ValueTuple<BaseDef, int>> inItems; // 0x10
		public string inTitle; // 0x18
		public bool inIsPremium; // 0x20

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_MultiItemPopup window); // 0x00000001803E1B90-0x00000001803E1BD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass3_0 // TypeDefIndex: 14126
	{
		// Fields
		[TupleElementNames] // 0x00000001802905C0-0x0000000180290640
		public List<ValueTuple<BaseDef, int>> inItems; // 0x10
		public string inTitle; // 0x18
		public bool inIsPremium; // 0x20

		// Constructors
		public <>c__DisplayClass3_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803E2170-0x00000001803E2240
	}

	// Constructors
	public UI_Window_MultiItemPopup(); // 0x00000001803F0190-0x00000001803F01C0

	// Methods
	public static void OpenWindow(BundlePackDefComponent inBundlePack, bool inIsPremium = false /* Metadata: 0x007BA662 */); // 0x00000001803EF4D0-0x00000001803EF890
	public static void OpenWindow([TupleElementNames] /* 0x000000018028E360-0x000000018028E3E0 */ List<ValueTuple<BaseDef, int>> inItems, string inTitle = "" /* Metadata: 0x007BA663 */, bool inIsPremium = false /* Metadata: 0x007BA667 */); // 0x00000001803EF890-0x00000001803EF970
	public static void QueueWindow(BundlePackDefComponent inBundlePack, bool inIsPremium = false /* Metadata: 0x007BA668 */); // 0x00000001803EF970-0x00000001803EFD30
	public static void QueueWindow([TupleElementNames] /* 0x000000018028E850-0x000000018028E8D0 */ List<ValueTuple<BaseDef, int>> inItems, string inTitle = "" /* Metadata: 0x007BA669 */, bool inIsPremium = false /* Metadata: 0x007BA66D */); // 0x00000001803EFD30-0x00000001803EFE10
	public static void CloseWindow(); // 0x00000001803EF350-0x00000001803EF3A0
	public void Setup([TupleElementNames] /* 0x000000018028EBC0-0x000000018028EC40 */ List<ValueTuple<BaseDef, int>> inItems, string inTitle, bool inIsPremium); // 0x00000001803EFE80-0x00000001803F0190
	public void SetupBotRightBtn(Action inCallback, string inText); // 0x00000001803EFE10-0x00000001803EFE80
	public void BtnClicked_BotRight(); // 0x00000001803EF320-0x00000001803EF350
	protected override void OnOpen(); // 0x00000001803EF440-0x00000001803EF4D0
	protected override void OnClose(bool inAnimate); // 0x00000001803EF3A0-0x00000001803EF440
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

