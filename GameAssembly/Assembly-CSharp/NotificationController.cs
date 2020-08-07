/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class NotificationController : MonoBehaviour // TypeDefIndex: 12964
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnFollowOnlineStatusUpdate>d__2 : IAsyncStateMachine // TypeDefIndex: 12965
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RelationshipFollowOnlineStatusUpdateResponse inMessage; // 0x28
		private UniTask<UserInfo> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018001BB70-0x000000018001BB80
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <OnChat>d__5 : IAsyncStateMachine // TypeDefIndex: 12966
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatConversationMessage inMessage; // 0x28
		private UniTask<bool> <>u__1; // 0x30
		private UniTask<UserInfo> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018001BB60-0x000000018001BB70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 12967
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<AchievementAction> <>9__8_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001808085F0-0x00000001808088D0
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <OnSeasonPassChallengeUpdated>b__8_0(AchievementAction action); // 0x00000001808084E0-0x0000000180808590
	}

	// Constructors
	public NotificationController(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x0000000180803800-0x0000000180803A80
	private void OnDestroy(); // 0x0000000180802670-0x00000001808028F0
	[AsyncStateMachine] // 0x00000001802576E0-0x0000000180257730
	private void OnFollowOnlineStatusUpdate(RelationshipFollowOnlineStatusUpdateResponse inMessage); // 0x00000001808028F0-0x00000001808029A0
	private void OnPrimaryQuestAdded(PrimaryQuestAddedMessage inMessage); // 0x0000000180802E70-0x0000000180802FC0
	private void OnPrimaryQuestUpdated(PrimaryQuestUpdatedMessage inMessage); // 0x0000000180802FC0-0x0000000180803100
	[AsyncStateMachine] // 0x0000000180257820-0x0000000180257870
	private void OnChat(ChatConversationMessage inMessage); // 0x00000001808025C0-0x0000000180802670
	private void OnGiftPush(GiftPushMessage inMessage); // 0x00000001808029A0-0x0000000180802CB0
	private void OnNetworkAvatarSpawned(NetworkedAvatarSpawnedMessage inMessage); // 0x0000000180802CB0-0x0000000180802E70
	private void OnSeasonPassChallengeUpdated(SeasonPassChallengeUpdateResponse inMessage); // 0x00000001808032E0-0x0000000180803570
	private void OnSeasonPassChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage); // 0x0000000180803100-0x00000001808032E0
	private void OnSeasonPassTierCompleted(SeasonPassTierCompletedMessage inMessage); // 0x0000000180803570-0x0000000180803800
}

