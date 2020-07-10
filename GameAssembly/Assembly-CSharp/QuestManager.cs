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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class QuestManager : SingletonManagerBase<QuestManager> // TypeDefIndex: 10333
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
	public Quest PrimaryQuest { get; } // 0x0000000180369B40-0x0000000180369B50 
	public List<Quest> SecondaryQuests { get; } // 0x0000000180369B50-0x0000000180369B60 

	// Nested types
	public enum EQuestCMD // TypeDefIndex: 10334
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

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 10335
	{
		// Fields
		public QuestShowResults _inQuestShowResultsAction; // 0x10

		// Constructors
		public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ShowResults>b__0(bool leave); // 0x000000018101B7B0-0x000000018101B7F0
		internal void <ShowResults>b__1(bool leave); // 0x000000018101B7B0-0x000000018101B7F0
		internal void <ShowResults>b__2(bool leave); // 0x000000018101B7B0-0x000000018101B7F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_QuestOpen>d__22 : IEnumerator<object> // TypeDefIndex: 10336
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public string inQuestDefID; // 0x20
		public QuestManager <>4__this; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_QuestOpen>d__22(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018101CE10-0x000000018101CFB0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018101CFB0-0x000000018101D000
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerQuestOpen>d__23 : IAsyncStateMachine // TypeDefIndex: 10337
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public QuestDefComponent inQuestDef; // 0x28
		public Action<RequestQuestOpenSuccessMessage> onSuccess; // 0x30
		public Action<RequestQuestGenericFailedMessage> onFailed; // 0x38
		private TaskAwaiter <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F74D0-0x00000001801F74E0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public QuestManager(); // 0x000000018100AB70-0x000000018100AC00
	static QuestManager(); // 0x000000018100AB10-0x000000018100AB70

	// Methods
	public override void Init(); // 0x0000000181009B40-0x0000000181009C10
	public override void Deinit(); // 0x0000000181008E40-0x0000000181008FB0
	public bool IsOnSocialExpanseQuest(); // 0x0000000181009C10-0x0000000181009CF0
	private void OnGiftPushMessage(GiftPushMessage inMessage); // 0x0000000181009D30-0x0000000181009F50
	public bool GetQuestCompleted(string inQuestDefId); // 0x00000001810090D0-0x00000001810093E0
	private void OnRoomJoinSuccessMessage(RoomJoinSuccessMessage inMessage); // 0x0000000181009F50-0x000000018100A130
	internal void SetupNetworkedScene(NetworkedScene inNetworkedScene); // 0x000000018100A5A0-0x000000018100A620
	private static void UpdateSceneNetworkedObjectInfos(); // 0x000000018100A7E0-0x000000018100AAA0
	internal void ShowResults(QuestShowResults _inQuestShowResultsAction); // 0x000000018100A650-0x000000018100A7E0
	public Coroutine QuestOpen(string inQuestDefID); // 0x000000018100A3C0-0x000000018100A460
	[IteratorStateMachine] // 0x00000001800E3D10-0x00000001800E3D60
	private IEnumerator _QuestOpen(string inQuestDefID); // 0x000000018100AAA0-0x000000018100AB10
	[AsyncStateMachine] // 0x00000001800E3EF0-0x00000001800E3F40
	public void RequestServerQuestOpen(QuestDefComponent inQuestDef, Action<RequestQuestOpenSuccessMessage> onSuccess = null, Action<RequestQuestGenericFailedMessage> onFailed = null); // 0x000000018100A460-0x000000018100A530
	public void NetworkObjectAskResponse(string inActorID, string inResponse); // 0x0000000181009CF0-0x0000000181009D30
	internal WorldObject GetWorldObject(string inUUID); // 0x00000001810093E0-0x00000001810094B0
	internal void PrimaryQuestAdd(QuestDefComponent inPrimaryQuestDef); // 0x000000018100A130-0x000000018100A280
	internal void PrimarySocialExpanseQuestAdd(SocialExpanseDefComponent inSocialExpanseDef); // 0x000000018100A280-0x000000018100A3C0
	internal static void OnStartQuestInit(); // 0x00000001803581E0-0x00000001803581F0
	private static NetworkedObject GetNetworkedObjectFromDictionary(string inKey); // 0x0000000181008FB0-0x00000001810090D0
	internal static void AddActorDictionary(Dictionary<string, NetworkedObject> inDict); // 0x0000000181007E10-0x0000000181008050
	internal static void SetActorDictionary(Dictionary<string, NetworkedObject> inDict); // 0x000000018100A530-0x000000018100A5A0
	internal static void InitInitialActorStatus(NetworkedObject inActorData, string inSpawningActorName); // 0x00000001803581E0-0x00000001803581F0
	internal static void HandleQuestStartResponse(XtReader data); // 0x0000000181009930-0x0000000181009B40
	internal static void HandleQuestOpenResponse(XtReader data); // 0x0000000181009820-0x0000000181009930
	internal static void HandleCommand(XtReader inData, bool inNoReply); // 0x00000001810094B0-0x0000000181009820
	private static void ShowInData(XtReader inData); // 0x000000018100A620-0x000000018100A650
	private static void CommandGiveObjective(XtReader inData); // 0x0000000181008180-0x00000001810087B0
	private static void CommandTaskProgress(XtReader inData); // 0x0000000181008C20-0x0000000181008E40
	private static void CommandSummaryTally(XtReader inData); // 0x00000001810089A0-0x0000000181008C20
	private static void CommandNotify(XtReader inData); // 0x00000001810087B0-0x00000001810087D0
	private static void CommandSetState(XtReader inData, bool inNoReply); // 0x00000001810087D0-0x00000001810089A0
	private static void CommandAsk(XtReader inData); // 0x0000000181008050-0x0000000181008180
}

