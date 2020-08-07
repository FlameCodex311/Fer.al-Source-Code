/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x00000001801E3560-0x00000001801E3590
public class SanctuaryGridOverlay : ManagedBehaviour // TypeDefIndex: 13323
{
	// Fields
	private Material _lineMaterial; // 0x50
	private Transform _trackingObject; // 0x58
	private Vector3 _trackingObjectEdgeL; // 0x60
	private Vector3 _trackingObjectEdgeR; // 0x6C
	private Vector3 _trackingObjectEdgeF; // 0x78
	private Vector3 _trackingObjectEdgeB; // 0x84

	// Constructors
	public SanctuaryGridOverlay(); // 0x00000001807B5100-0x00000001807B5200

	// Methods
	private void CreateLineMaterial(); // 0x00000001807B4DC0-0x00000001807B4EA0
	public void UpdateEdges(Vector3 inL, Vector3 inR, Vector3 inF, Vector3 inB); // 0x00000001807B50B0-0x00000001807B5100
	private void RenderObjectOverlay(); // 0x00000001807B4EA0-0x00000001807B50B0
}

