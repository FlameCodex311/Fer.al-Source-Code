/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_GlobalWindow_Loading : UI_GlobalWindow<UI_GlobalWindow_Loading> // TypeDefIndex: 11318
{
	// Fields
	public GameObject panelProgressBar; // 0x108
	public Image imageProgressBar; // 0x110
	public UnityEngine.UI.Text labelProgressBarPercentage; // 0x118
	private float _desiredProgress; // 0x120
	private float _currentProgress; // 0x124

	// Properties
	private float MaxDelta { get; } // 0x0000000180378680-0x0000000180378690 

	// Constructors
	public UI_GlobalWindow_Loading(); // 0x0000000180378620-0x0000000180378680

	// Methods
	public override void MAwake(); // 0x0000000180378330-0x0000000180378390
	public void SetProgress(float inProgress); // 0x0000000180378600-0x0000000180378620
	public override void MUpdate(); // 0x0000000180378390-0x00000001803785A0
	protected override void OnCloseComplete(); // 0x00000001803785A0-0x0000000180378600
}

