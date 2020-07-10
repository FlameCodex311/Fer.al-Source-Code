/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x0000000180106CD0-0x0000000180106D00
public class SanctuaryGridOverlay : ManagedBehaviour // TypeDefIndex: 11789
{
	// Fields
	private Material _lineMaterial; // 0x50
	private Transform _trackingObject; // 0x58
	private Vector3 _trackingObjectEdgeL; // 0x60
	private Vector3 _trackingObjectEdgeR; // 0x6C
	private Vector3 _trackingObjectEdgeF; // 0x78
	private Vector3 _trackingObjectEdgeB; // 0x84

	// Constructors
	public SanctuaryGridOverlay(); // 0x000000018128B3F0-0x000000018128B4F0

	// Methods
	private void CreateLineMaterial(); // 0x000000018128B0A0-0x000000018128B180
	public void UpdateEdges(Vector3 inL, Vector3 inR, Vector3 inF, Vector3 inB); // 0x000000018128B3A0-0x000000018128B3F0
	private void RenderObjectOverlay(); // 0x000000018128B180-0x000000018128B3A0
}

