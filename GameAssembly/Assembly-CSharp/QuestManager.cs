/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Tasks.Actions;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class QuestManager : SingletonManagerBase<QuestManager> // TypeDefIndex: 11823
{
	// Fields
	private Quest _primaryQuest; // 0x60
	private Dictionary<int, Quest> _secondaryQuestIndexMap; // 0x68
	private List<Quest> _secondaryQuests; // 0x70
	public static QuestSummary questSummary; // 0x00
	private static Dictionary<string, NetworkedObject> _networkedObjectDictionary; // 0x08
	private static Dictionary<string, WorldObject> _networkedWorldObjects; // 0x10
	public static string allCompletePrizeDefId; // 0x18

	// Properties
	public Quest PrimaryQuest { get; } // 0x0000000180418970-0x0000000180418980 
	public List<Quest> SecondaryQuests { get; } // 0x0000000180418980-0x0000000180418990 

	// Nested types
	public enum EQuestCMD // TypeDefIndex: 11824
	{
		SET_STATE = 1,
		SAY = 2,
		ASK = 3,
		GAME = 4,
		TAKE_ITEM = 7,
		TELEPORT = 14,
		FOCUS = 15,
		ON_EXIT = 19,
		TASK_PROGRESS = 20,
		NOTIFY = 38,
		GIVE_OBJECTIVE = 81,
		SUMMARY_TALLY = 82,
		DEBUGSAY = 1001
	}

	public enum EGiveObjectiveResetMode // TypeDefIndex: 11825
	{
		None = 0,
		Forward = 1,
		All = 2,
		OnlyThisOne = 3
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 11826
	{
		// Fields
		public QuestShowResults _inQuestShowResultsAction; // 0x10

		// Constructors
		public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ShowResults>b__0(bool leave); // 0x000000018065F2D0-0x000000018065F310
		internal void <ShowResults>b__1(bool leave); // 0x000000018065F2D0-0x000000018065F310
		internal void <ShowResults>b__2(bool leave); // 0x000000018065F2D0-0x000000018065F310
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_QuestOpen>d__23 : IEnumerator<object> // TypeDefIndex: 11827
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inQuestDefID; // 0x20
		public QuestManager <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_QuestOpen>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018065F6A0-0x000000018065F830
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018065F830-0x000000018065F880
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerQuestOpen>d__24 : IAsyncStateMachine // TypeDefIndex: 11828
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public QuestDefComponent inQuestDef; // 0x28
		public Action<RequestQuestOpenSuccessMessage> onSuccess; // 0x30
		public Action<RequestQuestGenericFailedMessage> onFailed; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018000A2C0-0x000000018000A2D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public QuestManager(); // 0x000000018064E750-0x000000018064E7E0
	static QuestManager(); // 0x000000018064E6F0-0x000000018064E750

	// Methods
	public override void Init(); // 0x000000018064D670-0x000000018064D740
	public override void Deinit(); // 0x000000018064C990-0x000000018064CB00
	public bool IsOnSocialExpanseQuest(); // 0x000000018064D740-0x000000018064D810
	private void OnGiftPushMessage(GiftPushMessage inMessage); // 0x000000018064D850-0x000000018064DB30
	public bool GetQuestCompleted(string inQuestDefId); // 0x000000018064CC20-0x000000018064CF20
	private void OnRoomJoinSuccessMessage(RoomJoinSuccessMessage inMessage); // 0x000000018064DB30-0x000000018064DD00
	internal void SetupNetworkedScene(NetworkedScene inNetworkedScene); // 0x000000018064E170-0x000000018064E1F0
	private static void UpdateSceneNetworkedObjectInfos(); // 0x000000018064E3A0-0x000000018064E680
	internal void ShowResults(QuestShowResults _inQuestShowResultsAction); // 0x000000018064E220-0x000000018064E3A0
	public Coroutine QuestOpen(string inQuestDefID); // 0x000000018064DF90-0x000000018064E030
	[IteratorStateMachine] // 0x00000001802797A0-0x00000001802797F0
	private IEnumerator _QuestOpen(string inQuestDefID); // 0x000000018064E680-0x000000018064E6F0
	[AsyncStateMachine] // 0x0000000180279A70-0x0000000180279AC0
	public void RequestServerQuestOpen(QuestDefComponent inQuestDef, Action<RequestQuestOpenSuccessMessage> onSuccess = null, Action<RequestQuestGenericFailedMessage> onFailed = null); // 0x000000018064E030-0x000000018064E100
	public void NetworkObjectAskResponse(string inActorID, string inResponse); // 0x000000018064D810-0x000000018064D850
	internal WorldObject GetWorldObject(string inUUID); // 0x000000018064CF20-0x000000018064CFF0
	internal void PrimaryQuestAdd(QuestDefComponent inPrimaryQuestDef); // 0x000000018064DD00-0x000000018064DE50
	internal void PrimarySocialExpanseQuestAdd(SocialExpanseDefComponent inSocialExpanseDef); // 0x000000018064DE50-0x000000018064DF90
	internal static void OnStartQuestInit(); // 0x00000001803774A0-0x00000001803774B0
	private static NetworkedObject GetNetworkedObjectFromDictionary(string inKey); // 0x000000018064CB00-0x000000018064CC20
	internal static void AddActorDictionary(Dictionary<string, NetworkedObject> inDict); // 0x000000018064B940-0x000000018064BB80
	internal static void SetActorDictionary(Dictionary<string, NetworkedObject> inDict); // 0x000000018064E100-0x000000018064E170
	internal static void InitInitialActorStatus(NetworkedObject inActorData, string inSpawningActorName); // 0x00000001803774A0-0x00000001803774B0
	internal static void HandleQuestStartResponse(XtReader data); // 0x000000018064D460-0x000000018064D670
	internal static void HandleQuestOpenResponse(XtReader data); // 0x000000018064D350-0x000000018064D460
	internal static void HandleCommand(XtReader inData, bool inNoReply); // 0x000000018064CFF0-0x000000018064D350
	private static void ShowInData(XtReader inData); // 0x000000018064E1F0-0x000000018064E220
	private static void CommandGiveObjective(XtReader inData); // 0x000000018064BCA0-0x000000018064C320
	private static void CommandTaskProgress(XtReader inData); // 0x000000018064C780-0x000000018064C990
	private static void CommandSummaryTally(XtReader inData); // 0x000000018064C510-0x000000018064C780
	private static void CommandNotify(XtReader inData); // 0x000000018064C320-0x000000018064C340
	private static void CommandSetState(XtReader inData, bool inNoReply); // 0x000000018064C340-0x000000018064C510
	private static void CommandAsk(XtReader inData); // 0x000000018064BB80-0x000000018064BCA0
}

