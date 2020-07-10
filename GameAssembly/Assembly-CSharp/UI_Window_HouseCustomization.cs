/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_HouseCustomization : UI_Window // TypeDefIndex: 12481
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_StageSubjectPositioner _stageSubjectPositioner; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_LazyItemList_House _itemList; // 0x110
	private UI_Stage_House _stage; // 0x118

	// Properties
	public UI_StageSubjectPositioner StageSubjectPositioner { get; } // 0x00000001803BD3C0-0x00000001803BD3D0 

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12482
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Action<UI_Window_HouseCustomization> <>9__0_0; // 0x08
		public static Action<UI_Window> <>9__1_0; // 0x10

		// Constructors
		static <>c(); // 0x0000000180ECF630-0x0000000180ECF690
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0_0(UI_Window_HouseCustomization window); // 0x0000000180E9D080-0x0000000180E9D0A0
		internal void <QueueWindow>b__1_0(UI_Window inWindow); // 0x0000000180ECDC50-0x0000000180ECDCD0
	}

	// Constructors
	public UI_Window_HouseCustomization(); // 0x0000000180E9F830-0x0000000180E9F840

	// Methods
	public static void OpenWindow(); // 0x0000000180ED46C0-0x0000000180ED47C0
	public static void QueueWindow(); // 0x0000000180ED47C0-0x0000000180ED48C0
	public static void CloseWindow(); // 0x0000000180ED4020-0x0000000180ED4070
	private void Setup(); // 0x00000001803581E0-0x00000001803581F0
	protected override void OnOpen(); // 0x0000000180ED4560-0x0000000180ED46C0
	protected override void DoDelayedOpenAnimation(); // 0x0000000180ED4070-0x0000000180ED4110
	protected override void OnClose(bool inAnimate); // 0x0000000180ED4110-0x0000000180ED4360
	private void OnHouseStageLoaded(UIHouseStageLoadedMessage inMessage); // 0x0000000180ED4470-0x0000000180ED4560
	private void OnHouseStageInitialized(UIHouseStageInitializedMessage inMessage); // 0x0000000180ED4390-0x0000000180ED4470
	private void OnCurrentHouseChanged(SanctuaryLookItemComponent inLookItem); // 0x0000000180ED4360-0x0000000180ED4390
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__10_0(); // 0x0000000180ED48C0-0x0000000180ED4920
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__10_1(); // 0x00000001809E8060-0x00000001809E8080
}

