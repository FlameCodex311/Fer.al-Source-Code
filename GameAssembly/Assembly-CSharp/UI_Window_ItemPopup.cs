/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Coffee.UIExtensions;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ItemPopup : UI_Window // TypeDefIndex: 14110
{
	// Fields
	[Header] // 0x00000001802847F0-0x0000000180284840
	[SerializeField] // 0x00000001802847F0-0x0000000180284840
	private Rectangle _bodyRectangle; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _bodyColorNormal; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _bodyColorPremium; // 0x120
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UIShiny _shinyEffect; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _headerText; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageTitleText; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _messageText; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _btnB; // 0x150
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _btnBotRight; // 0x158
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _btnAText; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _btnBText; // 0x168
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _btnBotRightText; // 0x170
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconImage; // 0x178
	private Action _buttonACallback; // 0x180
	private Action _buttonBCallback; // 0x188
	private Action _buttonBotRightCallback; // 0x190

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14111
	{
		// Fields
		public string inHeader; // 0x10
		public string inBtnAText; // 0x18
		public BaseDef inCraftableItem; // 0x20
		public int inQuantity; // 0x28
		public Action inButtonACallback; // 0x30
		public string inBtnBText; // 0x38
		public Action inButtonBCallback; // 0x40
		public bool inIsPremium; // 0x48

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ItemPopup window); // 0x00000001803E17A0-0x00000001803E1800
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14112
	{
		// Fields
		public string inHeader; // 0x10
		public string inBtnAText; // 0x18
		public BaseDef inCraftableItem; // 0x20
		public int inQuantity; // 0x28
		public Action inButtonACallback; // 0x30
		public string inBtnBText; // 0x38
		public Action inButtonBCallback; // 0x40
		public bool inIsPremium; // 0x48

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x00000001803E1CA0-0x00000001803E1DC0
	}

	// Constructors
	public UI_Window_ItemPopup(); // 0x00000001803EBE50-0x00000001803EBEA0

	// Methods
	public static void OpenWindow(string inHeader = "" /* Metadata: 0x007BA62D */, string inBtnAText = "" /* Metadata: 0x007BA631 */, BaseDef inCraftableItem = null, int inQuantity = 1 /* Metadata: 0x007BA635 */, Action inButtonACallback = null, string inBtnBText = "" /* Metadata: 0x007BA639 */, Action inButtonBCallback = null, bool inIsPremium = false /* Metadata: 0x007BA63D */); // 0x00000001803EB690-0x00000001803EB7A0
	public static void QueueWindow(string inHeader = "" /* Metadata: 0x007BA63E */, string inBtnAText = "" /* Metadata: 0x007BA642 */, BaseDef inCraftableItem = null, int inQuantity = 1 /* Metadata: 0x007BA646 */, Action inButtonACallback = null, string inBtnBText = "" /* Metadata: 0x007BA64A */, Action inButtonBCallback = null, bool inIsPremium = false /* Metadata: 0x007BA64E */); // 0x00000001803EB7A0-0x00000001803EB8B0
	public static void CloseWindow(); // 0x00000001803EB4D0-0x00000001803EB520
	public void Setup(string inHeader = "" /* Metadata: 0x007BA64F */, string inBtnAText = "" /* Metadata: 0x007BA653 */, BaseDef inCraftableItem = null, int inQuantity = 1 /* Metadata: 0x007BA657 */, Action inButtonACallback = null, string inBtnBText = "" /* Metadata: 0x007BA65B */, Action inButtonBCallback = null, bool inIsPremium = false /* Metadata: 0x007BA65F */); // 0x00000001803EB920-0x00000001803EBE50
	public void SetupBotRightBtn(Action inCallback, string inText); // 0x00000001803EB8B0-0x00000001803EB920
	public void BtnClicked_A(); // 0x00000001803EB440-0x00000001803EB470
	public void BtnClicked_B(); // 0x00000001803EB470-0x00000001803EB4A0
	public void BtnClicked_BotRight(); // 0x00000001803EB4A0-0x00000001803EB4D0
	protected override void OnOpen(); // 0x00000001803EB610-0x00000001803EB690
	protected override void OnClose(bool inAnimate); // 0x00000001803EB520-0x00000001803EB610
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

