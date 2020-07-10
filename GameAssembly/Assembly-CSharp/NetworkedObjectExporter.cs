/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class NetworkedObjectExporter // TypeDefIndex: 10192
{
	// Fields
	private static NetworkedScene _networkedScene; // 0x00
	private static bool _exportErrors; // 0x08
	private static QuestExportObject exportObject; // 0x10
	private static List<CompileNetworkObjectInfo> actorsList; // 0x18

	// Nested types
	[Serializable]
	public class QuestExportObject // TypeDefIndex: 10193
	{
		// Fields
		public CompileNetworkObjectInfo[] actors; // 0x10
		public string[] stringTable; // 0x18
		public NetworkedScene.QuestTrackableItemDetails[] questTrackableItemDetails; // 0x20
		public string version; // 0x28

		// Constructors
		public QuestExportObject(); // 0x0000000181571470-0x00000001815714B0
	}

	[Serializable]
	public class NetworkObjectState // TypeDefIndex: 10194
	{
		// Fields
		public NetworkObjectCmd[] cmds; // 0x10
		public string name; // 0x18

		// Constructors
		public NetworkObjectState(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class CompileNetworkObjectInfo // TypeDefIndex: 10195
	{
		// Fields
		public string name; // 0x10
		public string defId; // 0x18
		public string type; // 0x20
		public string subDefId; // 0x28
		public string local; // 0x30
		public string uuid; // 0x38
		public Vector3 position; // 0x40
		public Quaternion rotation; // 0x4C
		public NetworkObjectState[] states; // 0x60

		// Constructors
		public CompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo); // 0x00000001812D6FF0-0x00000001812D7370

		// Methods
		protected void VerifyVolumes(Collider inCollider, NetworkedObjectInfo inNetworkerdObjectInfo); // 0x00000001812D6CE0-0x00000001812D6FF0
	}

	[Serializable]
	public class NetworkObjectCmd // TypeDefIndex: 10196
	{
		// Fields
		public string actor; // 0x10
		public string cmd; // 0x18
		public string[] cmdParams; // 0x20

		// Constructors
		public NetworkObjectCmd(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	private class NetworkObjectCommand : NetworkObjectCmd // TypeDefIndex: 10197
	{
		// Constructors
		public NetworkObjectCommand(Task inTask, string inName = null); // 0x000000018156C320-0x000000018156EE30
	}

	private class NetworkObjectBranch : NetworkObjectCmd // TypeDefIndex: 10198
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		public NetworkObjectState[] branches; // 0x28

		// Constructors
		internal NetworkObjectBranch(Task inTask, Node inNode = null); // 0x000000018156AA20-0x000000018156C320

		// Methods
		private bool ChqBranchesForAsk(NetworkObjectState[] inBranches); // 0x000000018156A730-0x000000018156AA20
	}

	private class SphereTriggerCompileNetworkObjectInfo : CompileNetworkObjectInfo // TypeDefIndex: 10199
	{
		// Fields
		public string radius; // 0x68

		// Constructors
		public SphereTriggerCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo); // 0x00000001815721D0-0x00000001815724F0
	}

	private class VolumeTriggerCompileNetworkObjectInfo : CompileNetworkObjectInfo // TypeDefIndex: 10200
	{
		// Fields
		public string halfWidthX; // 0x68
		public string halfWidthY; // 0x70
		public string halfWidthZ; // 0x78

		// Constructors
		public VolumeTriggerCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo); // 0x0000000181576620-0x0000000181576960
	}

	public class NetworkObjectsToolsHelper // TypeDefIndex: 10201
	{
		// Constructors
		public NetworkObjectsToolsHelper(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public static void CheckNetworkedObjectInfoInteraction(NetworkedObjectInfo inNoi); // 0x000000018156EE30-0x000000018156EEC0
		public static void NewUUID(NetworkedObjectInfo inNoi); // 0x000000018156EEC0-0x000000018156EF50
	}

	// Constructors
	public NetworkedObjectExporter(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public static string GetData(string inChartID); // 0x00000001812E8840-0x00000001812E9110
	private static string GetJson(List<NetworkedScene.QuestTrackableItem> inQuestTrackableItems); // 0x00000001812E9370-0x00000001812E9710
	private static bool CompileData(); // 0x00000001812E80E0-0x00000001812E8840
	private static void AddQuestItemCommand(NetworkedObjectInfo noi, CompileNetworkObjectInfo compileActor); // 0x00000001812E7630-0x00000001812E7A00
	private static List<NetworkObjectCmd> MakeCommands(Node inTargetNode, string inCallingActorName); // 0x00000001812EA040-0x00000001812EABA0
	private static void CommandHelper(Task inTask, ref List<NetworkObjectCmd> inCmdsList); // 0x00000001812E7AC0-0x00000001812E80E0
	private static void NetworkActionTaskChq(Task inTask, string inCallingActorName); // 0x00000001812EABA0-0x00000001812EAE10
	private static List<NetworkObjectState> GetStatesOrBranches(Node inNode, string inCallingActorName); // 0x00000001812E9AA0-0x00000001812EA040
	private static void NonServerActionChq(Node inTargetNode, string inCallingActorName); // 0x00000001812EAE10-0x00000001812EB350
	private static List<NetworkObjectState> GetDialogStatesOrBranches(List<Node> inOptions, string inCallingActorName); // 0x00000001812E9110-0x00000001812E9370
	private static List<NetworkObjectState> GetMakeStatesOrBranches(ProbabilitySelector inProbabilitySelector, string inCallingActorName); // 0x00000001812E9710-0x00000001812E9AA0
	private static string ParamsChq(string inCmd, out string[] outCmdParams, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] inParams); // 0x00000001812EB350-0x00000001812EB4F0
	private static void SyncCommands(ref NetworkObjectCmd[] refQuestActorCommands); // 0x00000001812EB4F0-0x00000001812EB6B0
	private static void SyncNames(); // 0x00000001812EB6B0-0x00000001812EB9A0
	private static NetworkObjectState[] CleanEmptyStates(List<NetworkObjectState> iNnetworkObjectState); // 0x00000001812E7A00-0x00000001812E7AC0
}

