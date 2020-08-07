/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Control_CreatureColor : UI_CustomizationControl // TypeDefIndex: 13518
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CreatureColorCategory _creatureColorCategory; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_Control_HSVSliders _hsvSliders; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Graphic[] _colorPreviewGraphics; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<GameObject> _tabRelatedObjects; // 0x48
	private ColorTarget[] _colorTargets; // 0x50

	// Properties
	private ActorInfo ActorInfo { get; } // 0x0000000180549920-0x0000000180549970 

	// Nested types
	private enum CreatureColorCategory // TypeDefIndex: 13519
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

	private class ColorTarget // TypeDefIndex: 13520
	{
		// Fields
		private Graphic _colorPreviewGraphic; // 0x10
		private Action<HSVColor> _setColorAction; // 0x18
		private HSVColor _color; // 0x20

		// Properties
		private HSVColor Color { get; set; } // 0x0000000180538FE0-0x0000000180539010 0x0000000180539010-0x0000000180539130

		// Constructors
		public ColorTarget(HSVColor color, Action<HSVColor> setColorAction, Graphic colorPreviewGraphic = null); // 0x0000000180538EE0-0x0000000180538FE0

		// Methods
		public void SetAsSelected(UI_Control_HSVSliders inHSVSliders); // 0x0000000180538DB0-0x0000000180538EA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <SetAsSelected>b__7_0(HSVColor colorFromSlider); // 0x0000000180538EA0-0x0000000180538EE0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 13521
	{
		// Fields
		public ActorInfoClothingItem item; // 0x10
		public UI_Control_CreatureColor <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Setup>b__13(HSVColor color); // 0x000000018053D580-0x000000018053D640
		internal void <Setup>b__14(HSVColor color); // 0x000000018053D640-0x000000018053D700
		internal void <Setup>b__15(HSVColor color); // 0x000000018053D700-0x000000018053D7C0
		internal void <Setup>b__16(HSVColor color); // 0x000000018053D7C0-0x000000018053D880
	}

	// Constructors
	public UI_Control_CreatureColor(); // 0x00000001805498B0-0x0000000180549920

	// Methods
	private void OnEnable(); // 0x0000000180546DC0-0x0000000180547010
	private void OnDesignerEditClothingTargetChanged(ActorInfoClothingItem inItem); // 0x0000000180546A20-0x0000000180546A30
	private void OnBodyPartSet(ActorInfoBodyPart inBodyPart); // 0x0000000180546A20-0x0000000180546A30
	private void OnDisable(); // 0x0000000180546B70-0x0000000180546DC0
	private void Setup(); // 0x0000000180547010-0x0000000180549040
	private void OnColorTabSelected(int inTabIndex); // 0x0000000180546A30-0x0000000180546B70
	public override bool CheckIsValid(); // 0x0000000180546920-0x0000000180546A20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_0(HSVColor color); // 0x0000000180549040-0x00000001805490D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_1(HSVColor color); // 0x0000000180549430-0x00000001805494C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_2(HSVColor color); // 0x0000000180549550-0x00000001805495E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_3(HSVColor color); // 0x00000001805495E0-0x0000000180549670
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_4(HSVColor color); // 0x0000000180549670-0x0000000180549700
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_5(HSVColor color); // 0x0000000180549700-0x0000000180549790
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_6(HSVColor color); // 0x0000000180549670-0x0000000180549700
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_7(HSVColor color); // 0x0000000180549700-0x0000000180549790
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_9(HSVColor color); // 0x0000000180549820-0x00000001805498B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_10(HSVColor color); // 0x00000001805490D0-0x0000000180549160
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_11(HSVColor color); // 0x0000000180549160-0x00000001805491F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_12(HSVColor color); // 0x00000001805491F0-0x0000000180549280
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_8(HSVColor color); // 0x0000000180549790-0x0000000180549820
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_17(HSVColor color); // 0x0000000180549280-0x0000000180549310
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_18(HSVColor color); // 0x0000000180549310-0x00000001805493A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_19(HSVColor color); // 0x00000001805493A0-0x0000000180549430
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Setup>b__13_20(HSVColor color); // 0x00000001805494C0-0x0000000180549550
}

