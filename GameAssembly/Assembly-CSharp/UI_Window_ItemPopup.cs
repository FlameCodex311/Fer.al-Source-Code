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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_ItemPopup : UI_Window // TypeDefIndex: 12511
{
	// Fields
	[Header] // 0x00000001800CD6A0-0x00000001800CD6F0
	[SerializeField] // 0x00000001800CD6A0-0x00000001800CD6F0
	private Rectangle _bodyRectangle; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _bodyColorNormal; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _bodyColorPremium; // 0x120
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UIShiny _shinyEffect; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _headerText; // 0x138
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageTitleText; // 0x140
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _messageText; // 0x148
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _btnB; // 0x150
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _btnAText; // 0x158
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _btnBText; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconImage; // 0x168
	private Action _buttonACallback; // 0x170
	private Action _buttonBCallback; // 0x178

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12512
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
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ItemPopup window); // 0x0000000180ECE1B0-0x0000000180ECE210
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12513
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
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180ECE800-0x0000000180ECE920
	}

	// Constructors
	public UI_Window_ItemPopup(); // 0x0000000180ED8B30-0x0000000180ED8B80

	// Methods
	public static void OpenWindow(string inHeader = "" /* Metadata: 0x00782F15 */, string inBtnAText = "" /* Metadata: 0x00782F19 */, BaseDef inCraftableItem = null, int inQuantity = 1 /* Metadata: 0x00782F1D */, Action inButtonACallback = null, string inBtnBText = "" /* Metadata: 0x00782F21 */, Action inButtonBCallback = null, bool inIsPremium = false /* Metadata: 0x00782F25 */); // 0x0000000180ED83F0-0x0000000180ED8500
	public static void QueueWindow(string inHeader = "" /* Metadata: 0x00782F26 */, string inBtnAText = "" /* Metadata: 0x00782F2A */, BaseDef inCraftableItem = null, int inQuantity = 1 /* Metadata: 0x00782F2E */, Action inButtonACallback = null, string inBtnBText = "" /* Metadata: 0x00782F32 */, Action inButtonBCallback = null, bool inIsPremium = false /* Metadata: 0x00782F36 */); // 0x0000000180ED8500-0x0000000180ED8620
	public static void CloseWindow(); // 0x0000000180ED8290-0x0000000180ED82E0
	public void Setup(string inHeader = "" /* Metadata: 0x00782F37 */, string inBtnAText = "" /* Metadata: 0x00782F3B */, BaseDef inCraftableItem = null, int inQuantity = 1 /* Metadata: 0x00782F3F */, Action inButtonACallback = null, string inBtnBText = "" /* Metadata: 0x00782F43 */, Action inButtonBCallback = null, bool inIsPremium = false /* Metadata: 0x00782F47 */); // 0x0000000180ED8620-0x0000000180ED8B30
	public void BtnClicked_A(); // 0x0000000180ED8230-0x0000000180ED8260
	public void BtnClicked_B(); // 0x0000000180ED8260-0x0000000180ED8290
	protected override void OnOpen(); // 0x0000000180ED8370-0x0000000180ED83F0
	protected override void OnClose(bool inAnimate); // 0x0000000180ED82E0-0x0000000180ED8370
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
}

