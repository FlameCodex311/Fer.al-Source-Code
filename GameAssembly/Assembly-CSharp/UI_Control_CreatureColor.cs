/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Control_CreatureColor : UI_CustomizationControl // TypeDefIndex: 11972
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CreatureColorCategory _creatureColorCategory; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_Control_HSVSliders _hsvSliders; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _tabGroup; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Graphic[] _colorPreviewGraphics; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<GameObject> _tabRelatedObjects; // 0x48
	private ColorTarget[] _colorTargets; // 0x50

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180F2C080-0x0000000180F2C0D0 

	// Nested types
	private enum CreatureColorCategory // TypeDefIndex: 11973
	{
		Body = 1,
		EyeShape = 5,
		EyePupil = 6,
		Eye = 7,
		Horns = 10,
		Clothing = 15,
		Spark = 20,
		Wings = 25
	}

	private class ColorTarget // TypeDefIndex: 11974
	{
		// Fields
		private Graphic _colorPreviewGraphic; // 0x10
		private Action<HSVColor> _setColorAction; // 0x18
		private HSVColor _color; // 0x20

		// Properties
		private HSVColor Color { get; set; } // 0x0000000180F1AF40-0x0000000180F1AF70 0x0000000180F1AF70-0x0000000180F1B090

		// Constructors
		public ColorTarget(HSVColor color, Action<HSVColor> setColorAction, Graphic colorPreviewGraphic = null); // 0x0000000180F1AE40-0x0000000180F1AF40

		// Methods
		public void SetAsSelected(UI_Control_HSVSliders inHSVSliders); // 0x0000000180F1AD10-0x0000000180F1AE00
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <SetAsSelected>b__7_0(HSVColor colorFromSlider); // 0x0000000180F1AE00-0x0000000180F1AE40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 11975
	{
		// Fields
		public ActorInfoClothingItem item; // 0x10
		public UI_Control_CreatureColor <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__13(HSVColor color); // 0x0000000180F1F640-0x0000000180F1F700
		internal void <Setup>b__14(HSVColor color); // 0x0000000180F1F700-0x0000000180F1F7C0
		internal void <Setup>b__15(HSVColor color); // 0x0000000180F1F7C0-0x0000000180F1F880
		internal void <Setup>b__16(HSVColor color); // 0x0000000180F1F880-0x0000000180F1F940
	}

	// Constructors
	public UI_Control_CreatureColor(); // 0x0000000180F2C010-0x0000000180F2C080

	// Methods
	private void OnEnable(); // 0x0000000180F293C0-0x0000000180F29620
	private void OnDesignerEditClothingTargetChanged(ActorInfoClothingItem inItem); // 0x0000000180F29020-0x0000000180F29030
	private void OnBodyPartSet(ActorInfoBodyPart inBodyPart); // 0x0000000180F29020-0x0000000180F29030
	private void OnDisable(); // 0x0000000180F29170-0x0000000180F293C0
	private void Setup(); // 0x0000000180F29620-0x0000000180F2B7A0
	private void OnColorTabSelected(int inTabIndex); // 0x0000000180F29030-0x0000000180F29170
	public override bool CheckIsValid(); // 0x0000000180F28F20-0x0000000180F29020
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_0(HSVColor color); // 0x0000000180F2B7A0-0x0000000180F2B830
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_1(HSVColor color); // 0x0000000180F2BB90-0x0000000180F2BC20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_2(HSVColor color); // 0x0000000180F2BCB0-0x0000000180F2BD40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_3(HSVColor color); // 0x0000000180F2BD40-0x0000000180F2BDD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_4(HSVColor color); // 0x0000000180F2BDD0-0x0000000180F2BE60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_5(HSVColor color); // 0x0000000180F2BE60-0x0000000180F2BEF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_6(HSVColor color); // 0x0000000180F2BDD0-0x0000000180F2BE60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_7(HSVColor color); // 0x0000000180F2BE60-0x0000000180F2BEF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_9(HSVColor color); // 0x0000000180F2BF80-0x0000000180F2C010
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_10(HSVColor color); // 0x0000000180F2B830-0x0000000180F2B8C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_11(HSVColor color); // 0x0000000180F2B8C0-0x0000000180F2B950
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_12(HSVColor color); // 0x0000000180F2B950-0x0000000180F2B9E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_8(HSVColor color); // 0x0000000180F2BEF0-0x0000000180F2BF80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_17(HSVColor color); // 0x0000000180F2B9E0-0x0000000180F2BA70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_18(HSVColor color); // 0x0000000180F2BA70-0x0000000180F2BB00
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_19(HSVColor color); // 0x0000000180F2BB00-0x0000000180F2BB90
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Setup>b__13_20(HSVColor color); // 0x0000000180F2BC20-0x0000000180F2BCB0
}

