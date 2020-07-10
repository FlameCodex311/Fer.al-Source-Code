/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[RequireComponent] // 0x0000000180163A50-0x0000000180163AA0
public class TriggerCullingGroup : ManagedBehaviour // TypeDefIndex: 10655
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _visibleOnEnter; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _visibleOnExit; // 0x51
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _onlyDisableRenderers; // 0x52
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _gameObjectToCull; // 0x58

	// Properties
	private bool Visible { get; set; } // 0x0000000180FA91F0-0x0000000180FA9530 0x0000000180FA9530-0x0000000180FA98A0

	// Constructors
	public TriggerCullingGroup(); // 0x0000000180FA9190-0x0000000180FA91F0

	// Methods
	public override void MStart(); // 0x0000000180FA8EF0-0x0000000180FA8F90
	private void OnTriggerEnter(Collider other); // 0x0000000180FA8F90-0x0000000180FA9070
	private void OnTriggerExit(Collider other); // 0x0000000180FA9070-0x0000000180FA9150
	private void SetVisible(bool inVisible); // 0x0000000180FA9150-0x0000000180FA9190
}

