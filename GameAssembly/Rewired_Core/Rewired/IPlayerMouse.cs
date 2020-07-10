﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800B82D0-0x00000001800B8320
	[CustomObfuscation] // 0x00000001800B82D0-0x00000001800B8320
	internal interface IPlayerMouse : IPlayerController // TypeDefIndex: 5881
	{
		// Properties
		bool defaultToCenter { get; }
		ScreenRect movementArea { get; set; }
		PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; }
		Vector2 screenPosition { get; }
		Vector2 screenPositionPrev { get; }
		Vector2 screenPositionDelta { get; }
		PlayerController.MouseAxis xAxis { get; }
		PlayerController.MouseAxis yAxis { get; }
		PlayerController.MouseWheel wheel { get; }
		PlayerController.Button leftButton { get; }
		PlayerController.Button rightButton { get; }
		PlayerController.Button middleButton { get; }
		float pointerSpeed { get; }
		bool useHardwarePointerPosition { get; }
	
		// Events
		event Action<Vector2> ScreenPositionChangedEvent {
			add; // 0x00000000-0x00000000
			remove; // 0x00000000-0x00000000
		}
	}
}
