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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class NetworkedObjectExporter // TypeDefIndex: 11683
{
	// Fields
	private static NetworkedScene _networkedScene; // 0x00
	private static bool _exportErrors; // 0x08
	private static QuestExportObject exportObject; // 0x10
	private static List<CompileNetworkObjectInfo> actorsList; // 0x18

	// Nested types
	[Serializable]
	public class QuestExportObject // TypeDefIndex: 11684
	{
		// Fields
		public CompileNetworkObjectInfo[] actors; // 0x10
		public string[] stringTable; // 0x18
		public NetworkedScene.QuestTrackableItemDetails[] questTrackableItemDetails; // 0x20
		public string version; // 0x28

		// Constructors
		public QuestExportObject(); // 0x00000001807D7220-0x00000001807D7260
	}

	[Serializable]
	public class NetworkObjectState // TypeDefIndex: 11685
	{
		// Fields
		public NetworkObjectCmd[] cmds; // 0x10
		public string name; // 0x18

		// Constructors
		public NetworkObjectState(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class CompileNetworkObjectInfo // TypeDefIndex: 11686
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
		public CompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo); // 0x00000001807C5590-0x00000001807C5900

		// Methods
		protected void VerifyVolumes(Collider inCollider, NetworkedObjectInfo inNetworkerdObjectInfo); // 0x00000001807C51C0-0x00000001807C5590
	}

	[Serializable]
	public class NetworkObjectCmd // TypeDefIndex: 11687
	{
		// Fields
		public string actor; // 0x10
		public string cmd; // 0x18
		public string[] cmdParams; // 0x20

		// Constructors
		public NetworkObjectCmd(); // 0x0000000180373240-0x0000000180373250
	}

	private class NetworkObjectCommand : NetworkObjectCmd // TypeDefIndex: 11688
	{
		// Constructors
		public NetworkObjectCommand(Task inTask, string inName = null); // 0x00000001807CEB80-0x00000001807D1B60
	}

	private class NetworkObjectBranch : NetworkObjectCmd // TypeDefIndex: 11689
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public NetworkObjectState[] branches; // 0x28

		// Constructors
		internal NetworkObjectBranch(Task inTask, Node inNode = null); // 0x00000001807CD370-0x00000001807CEB80

		// Methods
		private bool ChqBranchesForAsk(NetworkObjectState[] inBranches); // 0x00000001807CD0A0-0x00000001807CD370
	}

	private class SphereTriggerCompileNetworkObjectInfo : CompileNetworkObjectInfo // TypeDefIndex: 11690
	{
		// Fields
		public string radius; // 0x68

		// Constructors
		public SphereTriggerCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo); // 0x00000001807D7260-0x00000001807D7590
	}

	private class VolumeTriggerCompileNetworkObjectInfo : CompileNetworkObjectInfo // TypeDefIndex: 11691
	{
		// Fields
		public string halfWidthX; // 0x68
		public string halfWidthY; // 0x70
		public string halfWidthZ; // 0x78

		// Constructors
		public VolumeTriggerCompileNetworkObjectInfo(NetworkedObjectInfo inNetworkObjectInfo); // 0x00000001807DB2D0-0x00000001807DBA50
	}

	public class NetworkObjectsToolsHelper // TypeDefIndex: 11692
	{
		// Constructors
		public NetworkObjectsToolsHelper(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public static void CheckNetworkedObjectInfoInteraction(NetworkedObjectInfo inNoi); // 0x00000001807D1B60-0x00000001807D1BF0
		public static void NewUUID(NetworkedObjectInfo inNoi); // 0x00000001807D1BF0-0x00000001807D1C70
	}

	// Constructors
	public NetworkedObjectExporter(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public static string GetData(string inChartID); // 0x00000001807D2EE0-0x00000001807D3780
	private static string GetJson(List<NetworkedScene.QuestTrackableItem> inQuestTrackableItems); // 0x00000001807D3FB0-0x00000001807D4350
	private static bool CompileData(); // 0x00000001807D2730-0x00000001807D2EE0
	private static void AddQuestItemCommand(NetworkedObjectInfo noi, CompileNetworkObjectInfo compileActor); // 0x00000001807D1C70-0x00000001807D2070
	private static List<NetworkObjectCmd> MakeCommands(Node inTargetNode, string inCallingActorName); // 0x00000001807D4C40-0x00000001807D5710
	private static void CommandHelper(Task inTask, ref List<NetworkObjectCmd> inCmdsList); // 0x00000001807D2130-0x00000001807D2730
	private static void NetworkActionTaskChq(Task inTask, string inCallingActorName); // 0x00000001807D5710-0x00000001807D5960
	private static List<NetworkObjectState> GetStatesOrBranches(Node inNode, string inCallingActorName); // 0x00000001807D46E0-0x00000001807D4C40
	private static void NonServerActionChq(Node inTargetNode, string inCallingActorName); // 0x00000001807D5960-0x00000001807D5E60
	private static List<NetworkObjectState> GetDialogStatesOrBranches(List<Node> inOptions, string inCallingActorName); // 0x00000001807D3780-0x00000001807D3FB0
	private static List<NetworkObjectState> GetMakeStatesOrBranches(ProbabilitySelector inProbabilitySelector, string inCallingActorName); // 0x00000001807D4350-0x00000001807D46E0
	private static string ParamsChq(string inCmd, out string[] outCmdParams, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] inParams); // 0x00000001807D5E60-0x00000001807D5FF0
	private static void SyncCommands(ref NetworkObjectCmd[] refQuestActorCommands); // 0x00000001807D5FF0-0x00000001807D61A0
	private static void SyncNames(); // 0x00000001807D61A0-0x00000001807D6480
	private static NetworkObjectState[] CleanEmptyStates(List<NetworkObjectState> iNnetworkObjectState); // 0x00000001807D2070-0x00000001807D2130
}

