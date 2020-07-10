/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SanctuaryObjectUpdateMessage : Message // TypeDefIndex: 11801
{
	// Fields
	public readonly SanctuaryObjectBase sanctuaryObject; // 0x18
	public readonly SanctuarySurface surface; // 0x20
	public readonly Vector3? hitPoint; // 0x28
	public readonly Vector3? hitNormal; // 0x38
	public readonly bool move; // 0x48
	public readonly bool rotate; // 0x49
	public readonly float? rotation; // 0x4C
	public readonly bool activeObject; // 0x54
	public readonly bool updateToLastGood; // 0x55

	// Constructors
	public SanctuaryObjectUpdateMessage(SanctuaryObjectBase inSanctuaryObject, float? inRotation, RaycastHit? inHit, SanctuarySurface inSurface, bool inMove, bool inRotate, bool inActive, bool inUpdateToLastGood); // 0x000000018136DBA0-0x000000018136DED0
}

