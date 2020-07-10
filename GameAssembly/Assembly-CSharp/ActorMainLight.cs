/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ActorMainLight : MonoBehaviour // TypeDefIndex: 10023
{
	// Fields
	private static List<ActorMainLight> _lights; // 0x00
	private bool _checkedForLight; // 0x20
	private Light _light; // 0x28

	// Properties
	private Light Light { get; } // 0x000000018140E870-0x000000018140E8C0 

	// Constructors
	public ActorMainLight(); // 0x0000000180E095D0-0x0000000180E095E0
	static ActorMainLight(); // 0x000000018140E810-0x000000018140E870

	// Methods
	public void Awake(); // 0x000000018140E420-0x000000018140E430
	public void OnEnable(); // 0x000000018140E4B0-0x000000018140E520
	public void OnDisable(); // 0x000000018140E430-0x000000018140E4B0
	public void Update(); // 0x000000018140E420-0x000000018140E430
	private void OnDrawGizmos(); // 0x000000018140E420-0x000000018140E430
	private void SetGlobals(); // 0x000000018140E520-0x000000018140E810
}

