/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BuildersFollyUI_GoalListItem : MonoBehaviour // TypeDefIndex: 12847
{
	// Fields
	public TextMeshProUGUI goalNameAndPoints; // 0x20
	public WWImage goalImage; // 0x28
	public WWImage stationIcon; // 0x30
	public UI_ColorizedIcon halfStar; // 0x38
	public UI_ColorizedIcon oneStar; // 0x40
	public UI_ColorizedIcon oneHalfStar; // 0x48
	public UI_ColorizedIcon twoStar; // 0x50
	public UI_ColorizedIcon twoHalfStar; // 0x58
	public UI_ColorizedIcon threeStar; // 0x60
	internal Vector3 starStartScale; // 0x68
	internal BuildersFollyLevel_Scriptable.BuildersFollyGoal buildersFollyGoal; // 0x78
	private int _maxPoints; // 0x80
	private BuildersFollyUIManager _uiManager; // 0x88

	// Constructors
	public BuildersFollyUI_GoalListItem(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	internal void Init(BuildersFollyLevel_Scriptable.BuildersFollyGoal inBuildersFollyGoal); // 0x00000001813DA790-0x00000001813DAA30
	public void BtnClicked_GoalSelected(); // 0x00000001813DA140-0x00000001813DA260
	internal void InitStars(int inPoints); // 0x00000001813DA360-0x00000001813DA790
	internal void SetStars(int inPoints, bool inOn); // 0x00000001813DAA30-0x00000001813DAC30
	private void DoStar(UI_ColorizedIcon inStar, Color inColor, bool inPulse = false /* Metadata: 0x007832AF */); // 0x00000001813DA260-0x00000001813DA360
}

