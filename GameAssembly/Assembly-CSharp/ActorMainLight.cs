/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ActorMainLight : MonoBehaviour // TypeDefIndex: 11514
{
	// Fields
	private static List<ActorMainLight> _lights; // 0x00
	private bool _checkedForLight; // 0x20
	private Light _light; // 0x28

	// Properties
	private Light Light { get; } // 0x00000001821E03D0-0x00000001821E0420 

	// Constructors
	public ActorMainLight(); // 0x00000001803743C0-0x00000001803743D0
	static ActorMainLight(); // 0x00000001821E0370-0x00000001821E03D0

	// Methods
	public void Awake(); // 0x00000001821DFF80-0x00000001821DFF90
	public void OnEnable(); // 0x00000001821E0010-0x00000001821E0080
	public void OnDisable(); // 0x00000001821DFF90-0x00000001821E0010
	public void Update(); // 0x00000001821DFF80-0x00000001821DFF90
	private void OnDrawGizmos(); // 0x00000001821DFF80-0x00000001821DFF90
	private void SetGlobals(); // 0x00000001821E0080-0x00000001821E0370
}

