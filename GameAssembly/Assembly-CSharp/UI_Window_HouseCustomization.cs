/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_HouseCustomization : UI_Window // TypeDefIndex: 14085
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_StageSubjectPositioner _stageSubjectPositioner; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_LazyItemList_House _itemList; // 0x110
	private UI_Stage_House _stage; // 0x118

	// Properties
	public UI_StageSubjectPositioner StageSubjectPositioner { get; } // 0x0000000180380B50-0x0000000180380B60 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 14086
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_HouseCustomization> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x00000001803E2970-0x00000001803E29D0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_HouseCustomization window); // 0x00000001803B24A0-0x00000001803B24C0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x00000001803E1250-0x00000001803E12D0
	}

	// Constructors
	public UI_Window_HouseCustomization(); // 0x00000001803B50E0-0x00000001803B50F0

	// Methods
	public static void OpenWindow(); // 0x00000001803E7920-0x00000001803E7A20
	public static void QueueWindow(); // 0x00000001803E7A20-0x00000001803E7B20
	public static void CloseWindow(); // 0x00000001803E72C0-0x00000001803E7310
	private void Setup(); // 0x00000001803774A0-0x00000001803774B0
	protected override void OnOpen(); // 0x00000001803E77C0-0x00000001803E7920
	protected override void DoDelayedOpenAnimation(); // 0x00000001803E7310-0x00000001803E73B0
	protected override void OnClose(bool inAnimate); // 0x00000001803E73B0-0x00000001803E75C0
	private void OnHouseStageLoaded(UIHouseStageLoadedMessage inMessage); // 0x00000001803E76D0-0x00000001803E77C0
	private void OnHouseStageInitialized(UIHouseStageInitializedMessage inMessage); // 0x00000001803E75F0-0x00000001803E76D0
	private void OnCurrentHouseChanged(SanctuaryLookItemComponent inLookItem); // 0x00000001803E75C0-0x00000001803E75F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__10_0(); // 0x00000001803E7B20-0x00000001803E7B80
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__10_1(); // 0x00000001803B6890-0x00000001803B68B0
}

