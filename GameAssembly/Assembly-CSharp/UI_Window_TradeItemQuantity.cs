/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_TradeItemQuantity : UI_Window // TypeDefIndex: 14221
{
	// Fields
	[Header] // 0x00000001801DACB0-0x00000001801DAD00
	[SerializeField] // 0x00000001801DACB0-0x00000001801DAD00
	private RawImage _iconImage; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x110
	[Header] // 0x00000001801DAF30-0x00000001801DAF80
	[SerializeField] // 0x00000001801DAF30-0x00000001801DAF80
	private GameObject _memberGroup; // 0x118
	[Header] // 0x00000001801DB2C0-0x00000001801DB310
	[SerializeField] // 0x00000001801DB2C0-0x00000001801DB310
	private UI_RarityBadge _rarityBadge; // 0x120
	[Header] // 0x00000001801DB5C0-0x00000001801DB610
	[SerializeField] // 0x00000001801DB5C0-0x00000001801DB610
	private GameObject _ownedCountBadge; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _ownedCount; // 0x130
	[Header] // 0x00000001801E9C20-0x00000001801E9C70
	[SerializeField] // 0x00000001801E9C20-0x00000001801E9C70
	private TMP_InputField _inputField; // 0x138
	private Item _item; // 0x140
	private int _itemQuantity; // 0x148
	private int _chosenQuantity; // 0x14C
	private Action<int> OnResult; // 0x150

	// Properties
	private int ChosenQuantity { get; set; } // 0x000000018044F710-0x000000018044F720 0x000000018044F720-0x000000018044F800

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14222
	{
		// Fields
		public Item inItem; // 0x10
		public Action<int> inOnResult; // 0x18

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TradeItemQuantity window); // 0x0000000180446BD0-0x0000000180446C00
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14223
	{
		// Fields
		public Item inItem; // 0x10
		public Action<int> inOnResult; // 0x18

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180447A80-0x0000000180447B50
	}

	// Constructors
	public UI_Window_TradeItemQuantity(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(Item inItem, Action<int> inOnResult = null); // 0x000000018044F180-0x000000018044F250
	public static void QueueWindow(Item inItem, Action<int> inOnResult = null); // 0x000000018044F250-0x000000018044F320
	public static void CloseWindow(); // 0x000000018044F0F0-0x000000018044F140
	private void Setup(Item inItem, Action<int> inOnResult); // 0x000000018044F460-0x000000018044F710
	public void BtnClicked_OK(); // 0x000000018044F090-0x000000018044F0F0
	public void BtnClicked_Increase(); // 0x000000018044F060-0x000000018044F090
	public void BtnClicked_Decrease(); // 0x000000018044F040-0x000000018044F060
	public void InputEnded_ChosenQuantity(string inValue); // 0x000000018044F140-0x000000018044F180
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	private void RefreshQuantity(); // 0x000000018044F320-0x000000018044F460
}

