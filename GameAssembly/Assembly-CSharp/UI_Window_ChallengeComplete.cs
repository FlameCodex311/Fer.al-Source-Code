/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ChallengeComplete : UI_Window // TypeDefIndex: 14010
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _affiliationIcon; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _aradiaColor; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _delilahColor; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _questIcon; // 0x138
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _questTitleText; // 0x140
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _questLocationText; // 0x148
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _challengeBannerRectangle; // 0x150
	private Action<bool> _resultCallback; // 0x158

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14011
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ChallengeComplete window); // 0x000000018047E750-0x000000018047E770
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14012
	{
		// Fields
		public Action<bool> inResultCallback; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047EE10-0x000000018047EED0
	}

	// Constructors
	public UI_Window_ChallengeComplete(); // 0x00000001804808F0-0x0000000180480940

	// Methods
	public static void OpenWindow(Action<bool> inResultCallback = null); // 0x0000000180480710-0x00000001804807D0
	public static void QueueWindow(Action<bool> inResultCallback = null); // 0x00000001804807D0-0x0000000180480890
	public static void CloseWindow(); // 0x00000001804801A0-0x00000001804801F0
	private void Setup(Action<bool> inResultCallback = null); // 0x00000001803EF2A0-0x00000001803EF2B0
	protected override void OnOpen(); // 0x00000001804801F0-0x0000000180480710
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Leave(); // 0x0000000180480140-0x00000001804801A0
	public void BtnClicked_Cancel(); // 0x00000001804800E0-0x0000000180480140
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnOpen>b__13_0(Sprite inSprite); // 0x00000001803B4D80-0x00000001803B4DB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnOpen>b__13_1(Sprite sprite); // 0x0000000180480890-0x00000001804808C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnOpen>b__13_2(Sprite inSprite); // 0x00000001804808C0-0x00000001804808F0
}

