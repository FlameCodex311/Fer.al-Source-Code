/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x000000018026FA70-0x000000018026FAA0
public class MinimapBlipArea : MinimapBlip // TypeDefIndex: 12360
{
	// Fields
	public EColorType colorType; // 0x80
	public GameObject mainBlip; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _color; // 0x90
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _radius; // 0xA0

	// Nested types
	public enum EColorType // TypeDefIndex: 12361
	{
		Primary = 0,
		Daily = 1,
		UserControlled = 2
	}

	// Constructors
	public MinimapBlipArea(); // 0x0000000180BFF4F0-0x0000000180BFF570

	// Methods
	private void OnTriggerEnter(Collider other); // 0x0000000180BFF350-0x0000000180BFF3E0
	private void OnTriggerExit(Collider other); // 0x0000000180BFF3E0-0x0000000180BFF470
	public override void MStart(); // 0x0000000180BFF100-0x0000000180BFF1D0
	public override void MUpdate(); // 0x0000000180BFF1D0-0x0000000180BFF2B0
	private void OnDrawGizmosSelected(); // 0x0000000180BFF2B0-0x0000000180BFF350
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <MStart>b__7_0(); // 0x0000000180BFF470-0x0000000180BFF4F0
}

