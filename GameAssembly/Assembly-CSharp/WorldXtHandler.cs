/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Server;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
public static class WorldXtHandler // TypeDefIndex: 12805
{
	// Nested types
	[MessageRouteHandler] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static class DefaultHandlers // TypeDefIndex: 12806
	{
	}

	// Methods
	[MessageSender] // 0x000000018022EC10-0x000000018022EC30
	public static void RequestReady(string uniqueMapId, Vector3? sanctuaryPosition = default, string jumpToUserId = null); // 0x00000001805EBAF0-0x00000001805EBD20
	[MessageSender] // 0x000000018022EEA0-0x000000018022EEC0
	public static void RequestWorldObjectInfo(int objectId); // 0x00000001805EC3D0-0x00000001805EC480
	[MessageSender] // 0x000000018022EFF0-0x000000018022F010
	public static void RequestWorldObjectAction(string objectName); // 0x00000001805EC270-0x00000001805EC320
	[MessageSender] // 0x000000018022F420-0x000000018022F440
	public static void RequestWorldObjectAskResponse(string objectName, string askResponse); // 0x00000001805EC320-0x00000001805EC3D0
	[MessageSender] // 0x000000018022F500-0x000000018022F520
	public static void RequestWorldObjectInteractionStart(string objectName); // 0x00000001805EC5B0-0x00000001805EC630
	[MessageSender] // 0x000000018022F690-0x000000018022F6B0
	public static void RequestWorldObjectInteractionCancel(string objectName); // 0x00000001805EC480-0x00000001805EC500
	[MessageSender] // 0x000000018022F8A0-0x000000018022F8C0
	public static void RequestWorldObjectInteractionFinish(string objectName); // 0x00000001805EC500-0x00000001805EC5B0
	[MessageSender] // 0x000000018022FA20-0x000000018022FA40
	public static void RequestUpdate(WorldObjectMoverNodeType nodeType, Vector3 position, Vector3 direction, Quaternion rotation, float speed, ActorActionType actionType); // 0x00000001805EBD20-0x00000001805EC0F0
	[MessageSender] // 0x000000018022FA20-0x000000018022FA40
	public static void RequestUpdate(WorldObjectMoverNodeType nodeType, ActorActionType actionType, string uniqueMapId, string userToGoTo); // 0x00000001805EC0F0-0x00000001805EC270
	[MessageRoute] // 0x000000018022FC80-0x000000018022FCA0
	private static void HandleMove(WorldObjectMoveMessage message); // 0x00000001805EB9B0-0x00000001805EBAF0
	[MessageRoute] // 0x000000018022FE20-0x000000018022FE40
	private static void HandleAction(WorldObjectActionMessage message); // 0x00000001805EB950-0x00000001805EB9B0
	[MessageRoute] // 0x0000000180230080-0x00000001802300A0
	private static void HandleActionStart(WorldObjectActionStartMessage message); // 0x00000001805EB8F0-0x00000001805EB950
	[MessageRoute] // 0x00000001802301E0-0x0000000180230200
	private static void HandleActionCancel(WorldObjectActionCancelMessage message); // 0x00000001805EB830-0x00000001805EB890
	[MessageRoute] // 0x0000000180230670-0x0000000180230690
	private static void HandleActionFinish(WorldObjectActionFinishMessage message); // 0x00000001805EB890-0x00000001805EB8F0
}

