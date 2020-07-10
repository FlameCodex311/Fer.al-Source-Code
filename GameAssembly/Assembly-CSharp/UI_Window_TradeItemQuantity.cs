/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_TradeItemQuantity : UI_Window // TypeDefIndex: 12619
{
	// Fields
	[Header] // 0x00000001800F5540-0x00000001800F5590
	[SerializeField] // 0x00000001800F5540-0x00000001800F5590
	private RawImage _iconImage; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x110
	[Header] // 0x00000001800D9D80-0x00000001800D9DD0
	[SerializeField] // 0x00000001800D9D80-0x00000001800D9DD0
	private GameObject _memberGroup; // 0x118
	[Header] // 0x00000001800D9B70-0x00000001800D9BC0
	[SerializeField] // 0x00000001800D9B70-0x00000001800D9BC0
	private UI_RarityBadge _rarityBadge; // 0x120
	[Header] // 0x00000001800DB280-0x00000001800DB2D0
	[SerializeField] // 0x00000001800DB280-0x00000001800DB2D0
	private GameObject _ownedCountBadge; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _ownedCount; // 0x130
	[Header] // 0x00000001800F6370-0x00000001800F63C0
	[SerializeField] // 0x00000001800F6370-0x00000001800F63C0
	private TMP_InputField _inputField; // 0x138
	private Item _item; // 0x140
	private int _itemQuantity; // 0x148
	private int _chosenQuantity; // 0x14C
	private Action<int> OnResult; // 0x150

	// Properties
	private int ChosenQuantity { get; set; } // 0x0000000180F83870-0x0000000180F83880 0x0000000180F83880-0x0000000180F83960

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12620
	{
		// Fields
		public Item inItem; // 0x10
		public Action<int> inOnResult; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TradeItemQuantity window); // 0x0000000180F7A330-0x0000000180F7A360
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12621
	{
		// Fields
		public Item inItem; // 0x10
		public Action<int> inOnResult; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F7ADA0-0x0000000180F7AE70
	}

	// Constructors
	public UI_Window_TradeItemQuantity(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(Item inItem, Action<int> inOnResult = null); // 0x0000000180F832D0-0x0000000180F833A0
	public static void QueueWindow(Item inItem, Action<int> inOnResult = null); // 0x0000000180F833A0-0x0000000180F83470
	public static void CloseWindow(); // 0x0000000180F83240-0x0000000180F83290
	private void Setup(Item inItem, Action<int> inOnResult); // 0x0000000180F835B0-0x0000000180F83870
	public void BtnClicked_OK(); // 0x0000000180F831E0-0x0000000180F83240
	public void BtnClicked_Increase(); // 0x0000000180F831B0-0x0000000180F831E0
	public void BtnClicked_Decrease(); // 0x0000000180F83190-0x0000000180F831B0
	public void InputEnded_ChosenQuantity(string inValue); // 0x0000000180F83290-0x0000000180F832D0
	protected override void OnOpen(); // 0x0000000180E9F6A0-0x0000000180E9F6B0
	protected override void OnClose(bool inAnimate); // 0x0000000180E9F690-0x0000000180E9F6A0
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	private void RefreshQuantity(); // 0x0000000180F83470-0x0000000180F835B0
}

