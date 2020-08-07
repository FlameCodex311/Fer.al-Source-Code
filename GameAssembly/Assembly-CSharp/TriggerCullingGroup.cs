/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x0000000180242C40-0x0000000180242C90
public class TriggerCullingGroup : ManagedBehaviour // TypeDefIndex: 12158
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _visibleOnEnter; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _visibleOnExit; // 0x51
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _onlyDisableRenderers; // 0x52
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _gameObjectToCull; // 0x58

	// Properties
	private bool Visible { get; set; } // 0x000000018050E6D0-0x000000018050EA00 0x000000018050EA00-0x000000018050ED60

	// Constructors
	public TriggerCullingGroup(); // 0x000000018050E670-0x000000018050E6D0

	// Methods
	public override void MStart(); // 0x000000018050E3E0-0x000000018050E470
	private void OnTriggerEnter(Collider other); // 0x000000018050E470-0x000000018050E550
	private void OnTriggerExit(Collider other); // 0x000000018050E550-0x000000018050E630
	private void SetVisible(bool inVisible); // 0x000000018050E630-0x000000018050E670
}

