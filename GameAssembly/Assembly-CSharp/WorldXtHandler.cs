/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
public static class WorldXtHandler // TypeDefIndex: 11277
{
	// Nested types
	[MessageRouteHandler] // 0x00000001800B36B0-0x00000001800B36C0
	private static class DefaultHandlers // TypeDefIndex: 11278
	{
	}

	// Methods
	[MessageSender] // 0x00000001801461C0-0x00000001801461E0
	public static void RequestReady(); // 0x00000001810042F0-0x00000001810045C0
	[MessageSender] // 0x00000001801462E0-0x0000000180146300
	public static void RequestWorldObjectInfo(int objectId); // 0x0000000181004B70-0x0000000181004C20
	[MessageSender] // 0x00000001801464B0-0x00000001801464D0
	public static void RequestWorldObjectAction(string objectName); // 0x0000000181004A10-0x0000000181004AC0
	[MessageSender] // 0x0000000180146640-0x0000000180146660
	public static void RequestWorldObjectAskResponse(string objectName, string askResponse); // 0x0000000181004AC0-0x0000000181004B70
	[MessageSender] // 0x0000000180146790-0x00000001801467B0
	public static void RequestWorldObjectInteractionStart(string objectName); // 0x0000000181004D50-0x0000000181004DD0
	[MessageSender] // 0x00000001801467E0-0x0000000180146800
	public static void RequestWorldObjectInteractionCancel(string objectName); // 0x0000000181004C20-0x0000000181004CA0
	[MessageSender] // 0x00000001801469D0-0x00000001801469F0
	public static void RequestWorldObjectInteractionFinish(string objectName); // 0x0000000181004CA0-0x0000000181004D50
	[MessageSender] // 0x0000000180146AC0-0x0000000180146AE0
	public static void RequestUpdate(WorldObjectMoverNodeType nodeType, Vector3 position, Vector3 direction, Quaternion rotation, float speed, ActorActionType actionType); // 0x00000001810045C0-0x0000000181004A10
	[MessageRoute] // 0x0000000180146D70-0x0000000180146D90
	private static void HandleMove(WorldObjectMoveMessage message); // 0x0000000181004290-0x00000001810042F0
	[MessageRoute] // 0x0000000180146E70-0x0000000180146E90
	private static void HandleAction(WorldObjectActionMessage message); // 0x0000000181004230-0x0000000181004290
	[MessageRoute] // 0x0000000180147020-0x0000000180147040
	private static void HandleActionStart(WorldObjectActionStartMessage message); // 0x00000001810041D0-0x0000000181004230
	[MessageRoute] // 0x00000001801471E0-0x0000000180147200
	private static void HandleActionCancel(WorldObjectActionCancelMessage message); // 0x0000000181004110-0x0000000181004170
	[MessageRoute] // 0x0000000180147410-0x0000000180147430
	private static void HandleActionFinish(WorldObjectActionFinishMessage message); // 0x0000000181004170-0x00000001810041D0
}

