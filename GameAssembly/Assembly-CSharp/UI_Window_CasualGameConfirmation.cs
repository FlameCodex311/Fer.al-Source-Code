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

public class UI_Window_CasualGameConfirmation : UI_Window // TypeDefIndex: 14007
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _titleText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _bannerImage; // 0x118
	private BaseDef _casualGameDef; // 0x120

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14008
	{
		// Fields
		public BaseDef inCasualGameDef; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_CasualGameConfirmation window); // 0x000000018047E8F0-0x000000018047E920
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14009
	{
		// Fields
		public BaseDef inCasualGameDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x000000018047EFA0-0x000000018047F070
	}

	// Constructors
	public UI_Window_CasualGameConfirmation(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(BaseDef inCasualGameDef); // 0x000000018047FD70-0x000000018047FE30
	public static void QueueWindow(BaseDef inCasualGameDef); // 0x000000018047FE30-0x000000018047FEF0
	public static void CloseWindow(); // 0x000000018047FC10-0x000000018047FC60
	private void Setup(BaseDef inCasualGameDef); // 0x000000018047FEF0-0x00000001804800B0
	protected override void OnOpen(); // 0x000000018047FCF0-0x000000018047FD70
	protected override void OnClose(bool inAnimate); // 0x000000018047FC60-0x000000018047FCF0
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	public void BtnClicked_Play(); // 0x000000018047FB70-0x000000018047FC10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__7_0(Sprite inResult); // 0x00000001804800B0-0x00000001804800E0
}

