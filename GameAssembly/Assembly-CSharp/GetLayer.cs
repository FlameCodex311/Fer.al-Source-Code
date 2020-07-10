/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class GetLayer // TypeDefIndex: 12685
{
	// Fields
	private static int _actor; // 0x00
	private static LayerMask _actorMask; // 0x04
	private static int _decal; // 0x08
	private static LayerMask _decalMask; // 0x0C
	private static int _playerAndCameraCollision; // 0x10
	private static LayerMask _playerAndCameraCollisionMask; // 0x14
	private static int _playerCollision; // 0x18
	private static LayerMask _playerCollisionMask; // 0x1C
	private static int _water; // 0x20
	private static LayerMask _waterMask; // 0x24

	// Constructors
	static GetLayer(); // 0x00000001810557D0-0x00000001810558F0

	// Methods
	public static int CombinedLayerMask(params /* 0x00000001800B36B0-0x00000001800B36C0 */ int[] inLayerIDs); // 0x0000000181054EF0-0x0000000181054F50
	public static int Actor(bool inReturnMask = false /* Metadata: 0x00783001 */); // 0x0000000181054CD0-0x0000000181054EF0
	public static int Decal(bool inReturnMask = false /* Metadata: 0x00783002 */); // 0x0000000181054F50-0x0000000181055170
	public static int PlayerAndCameraCollision(bool inReturnMask = false /* Metadata: 0x00783003 */); // 0x0000000181055170-0x0000000181055390
	public static int PlayerCollision(bool inReturnMask = false /* Metadata: 0x00783004 */); // 0x0000000181055390-0x00000001810555B0
	public static int Water(bool inReturnMask = false /* Metadata: 0x00783005 */); // 0x00000001810555B0-0x00000001810557D0
}

