/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_ApplyCreatureChanges : UI_Window // TypeDefIndex: 13980
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _avatarIcon; // 0x108
	private CreatureCustomizationTarget _currentCustomizationTarget; // 0x110
	private ActorInfo _oldActorInfo; // 0x118
	private Action<bool> _onProceedResult; // 0x120

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 13981
	{
		// Fields
		public CreatureCustomizationTarget inCurrentCustomizationTarget; // 0x10
		public ActorInfo inOldActorInfo; // 0x18
		public Action<bool> inOnProceedResult; // 0x20

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_ApplyCreatureChanges window); // 0x0000000180634CA0-0x0000000180634CE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 13982
	{
		// Fields
		public CreatureCustomizationTarget inCurrentCustomizationTarget; // 0x10
		public ActorInfo inOldActorInfo; // 0x18
		public Action<bool> inOnProceedResult; // 0x20

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180634DE0-0x0000000180634EB0
	}

	// Constructors
	public UI_Window_ApplyCreatureChanges(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult); // 0x00000001806400B0-0x0000000180640190
	public static void QueueWindow(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult); // 0x0000000180640190-0x0000000180640270
	public static void CloseWindow(); // 0x0000000180640060-0x00000001806400B0
	public void Setup(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult); // 0x0000000180640270-0x0000000180640370
	public void BtnClicked_Apply(); // 0x000000018063FE40-0x000000018063FF00
	public void BtnClicked_Discard(); // 0x000000018063FF80-0x0000000180640060
	public void BtnClicked_Cancel(); // 0x000000018063FF00-0x000000018063FF80
	protected override void OnOpen(); // 0x00000001803B4570-0x00000001803B4580
	protected override void OnClose(bool inAnimate); // 0x00000001803B4560-0x00000001803B4570
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
}

