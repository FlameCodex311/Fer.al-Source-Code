/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_GlobalWindow_Loading : UI_GlobalWindow<UI_GlobalWindow_Loading> // TypeDefIndex: 13651
{
	// Fields
	public GameObject panelProgressBar; // 0x108
	public Image imageProgressBar; // 0x110
	public UnityEngine.UI.Text labelProgressBarPercentage; // 0x118
	private float _desiredProgress; // 0x120
	private float _currentProgress; // 0x124

	// Properties
	private float MaxDelta { get; } // 0x0000000180E40E80-0x0000000180E40E90 

	// Constructors
	public UI_GlobalWindow_Loading(); // 0x0000000180E40E20-0x0000000180E40E80

	// Methods
	public override void MAwake(); // 0x0000000180E40B20-0x0000000180E40B80
	public void SetProgress(float inProgress); // 0x0000000180E40E00-0x0000000180E40E20
	public override void MUpdate(); // 0x0000000180E40B80-0x0000000180E40DA0
	protected override void OnCloseComplete(); // 0x0000000180E40DA0-0x0000000180E40E00
}

