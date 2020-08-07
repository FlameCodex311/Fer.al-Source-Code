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

[Serializable]
public class ScoreStar // TypeDefIndex: 10567
{
	// Fields
	public WWImage star; // 0x10
	public float fillThreshold; // 0x18
	public WWTextMeshProUGUI scoreThresholdText; // 0x20

	// Constructors
	public ScoreStar(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public void SetStarColor(Color inColor); // 0x00000001803FA8D0-0x00000001803FA970
	public void SetStarScoreThreshold(int inScore); // 0x00000001803FA970-0x00000001803FAA00
	public void PunchStar(); // 0x00000001803FA7B0-0x00000001803FA8D0
}

