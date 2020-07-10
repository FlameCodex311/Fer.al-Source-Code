/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[DeComponentDescription] // 0x00000001800E9890-0x00000001800E98C0
public class UI_LoadingGroup : MonoBehaviour // TypeDefIndex: 13647
{
	// Fields
	[DeComment] // 0x00000001800E9B70-0x00000001800E9BC0
	[SerializeField] // 0x00000001800E9B70-0x00000001800E9BC0
	private List<GameObject> _loadingObjectsOn; // 0x20
	[DeComment] // 0x00000001800E9C20-0x00000001800E9C70
	[SerializeField] // 0x00000001800E9C20-0x00000001800E9C70
	private List<GameObject> _loadingObjectsOff; // 0x28
	private bool _isLoading; // 0x30

	// Constructors
	public UI_LoadingGroup(); // 0x0000000180E806E0-0x0000000180E80760

	// Methods
	private void OnEnable(); // 0x0000000180897DB0-0x0000000180897DC0
	public void SetIsLoading(bool inIsLoading); // 0x0000000180E804C0-0x0000000180E804D0
	private void UpdateObjects(); // 0x0000000180E804D0-0x0000000180E806E0
}

