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

public class BuildersFollyUI_GoalListItem : MonoBehaviour // TypeDefIndex: 10508
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
	public BuildersFollyUI_GoalListItem(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	internal void Init(BuildersFollyLevel_Scriptable.BuildersFollyGoal inBuildersFollyGoal); // 0x0000000180492B60-0x0000000180492CF0
	public void BtnClicked_GoalSelected(); // 0x0000000180491F80-0x0000000180492010
	internal void InitStars(int inPoints); // 0x00000001804920C0-0x0000000180492B60
	internal void SetStars(int inPoints, bool inOn); // 0x0000000180492CF0-0x00000001804932C0
	private void DoStar(UI_ColorizedIcon inStar, Color inColor, bool inPulse = false /* Metadata: 0x0077BD60 */); // 0x0000000180492010-0x00000001804920C0
}

