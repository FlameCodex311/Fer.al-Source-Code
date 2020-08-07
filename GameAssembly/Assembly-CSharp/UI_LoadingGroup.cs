/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[DeComponentDescription] // 0x0000000180286920-0x0000000180286950
public class UI_LoadingGroup : MonoBehaviour // TypeDefIndex: 11314
{
	// Fields
	[DeComment] // 0x0000000180286A80-0x0000000180286AD0
	[SerializeField] // 0x0000000180286A80-0x0000000180286AD0
	private List<GameObject> _loadingObjectsOn; // 0x20
	[DeComment] // 0x0000000180286CB0-0x0000000180286D00
	[SerializeField] // 0x0000000180286CB0-0x0000000180286D00
	private List<GameObject> _loadingObjectsOff; // 0x28
	private bool _isLoading; // 0x30

	// Constructors
	public UI_LoadingGroup(); // 0x00000001803CA060-0x00000001803CA0E0

	// Methods
	private void OnEnable(); // 0x00000001803C9E30-0x00000001803C9E40
	public void SetIsLoading(bool inIsLoading); // 0x00000001803C9E40-0x00000001803C9E50
	private void UpdateObjects(); // 0x00000001803C9E50-0x00000001803CA060
}

