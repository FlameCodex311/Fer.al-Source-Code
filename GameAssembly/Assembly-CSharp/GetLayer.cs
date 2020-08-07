/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class GetLayer // TypeDefIndex: 14254
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
	static GetLayer(); // 0x00000001806806B0-0x00000001806807D0

	// Methods
	public static int CombinedLayerMask(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ int[] inLayerIDs); // 0x000000018067FDE0-0x000000018067FE30
	public static int Actor(bool inReturnMask = false /* Metadata: 0x007BA718 */); // 0x000000018067FBC0-0x000000018067FDE0
	public static int Decal(bool inReturnMask = false /* Metadata: 0x007BA719 */); // 0x000000018067FE30-0x0000000180680050
	public static int PlayerAndCameraCollision(bool inReturnMask = false /* Metadata: 0x007BA71A */); // 0x0000000180680050-0x0000000180680270
	public static int PlayerCollision(bool inReturnMask = false /* Metadata: 0x007BA71B */); // 0x0000000180680270-0x0000000180680490
	public static int Water(bool inReturnMask = false /* Metadata: 0x007BA71C */); // 0x0000000180680490-0x00000001806806B0
}

