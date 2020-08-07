/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UVScroll : ManagedBehaviour // TypeDefIndex: 14266
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int materialIndex; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 uvAnimationRate; // 0x54
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private string textureName; // 0x60
	private Vector2 uvOffset; // 0x68
	private Renderer _renderer; // 0x70

	// Constructors
	public UVScroll(); // 0x00000001804551D0-0x0000000180455300

	// Methods
	public override void MStart(); // 0x0000000180454EF0-0x0000000180455000
	public override void MUpdate(); // 0x0000000180455000-0x00000001804551D0
	public void reset(); // 0x0000000180455300-0x00000001804554A0
}

