/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class NotificationController : MonoBehaviour // TypeDefIndex: 11431
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnFollowOnlineStatusUpdate>d__2 : IAsyncStateMachine // TypeDefIndex: 11432
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public RelationshipFollowOnlineStatusUpdateResponse inMessage; // 0x28
		private UniTask<UserInfo> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F0730-0x00000001801F0740
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <OnChat>d__5 : IAsyncStateMachine // TypeDefIndex: 11433
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public ChatConversationMessage inMessage; // 0x28
		private UniTask<bool> <>u__1; // 0x30
		private UniTask<UserInfo> <>u__2; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F0720-0x00000001801F0730
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11434
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Predicate<AchievementAction> <>9__8_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E9A9F0-0x0000000180E9CDC0
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <OnSeasonPassChallengeUpdated>b__8_0(AchievementAction action); // 0x0000000180E9A800-0x0000000180E9A8C0
	}

	// Constructors
	public NotificationController(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180E95780-0x0000000180E95A00
	private void OnDestroy(); // 0x0000000180E94580-0x0000000180E94800
	[AsyncStateMachine] // 0x00000001800B5560-0x00000001800B55B0
	private void OnFollowOnlineStatusUpdate(RelationshipFollowOnlineStatusUpdateResponse inMessage); // 0x0000000180E94800-0x0000000180E948B0
	private void OnPrimaryQuestAdded(PrimaryQuestAddedMessage inMessage); // 0x0000000180E94DB0-0x0000000180E94F00
	private void OnPrimaryQuestUpdated(PrimaryQuestUpdatedMessage inMessage); // 0x0000000180E94F00-0x0000000180E95050
	[AsyncStateMachine] // 0x00000001800B56C0-0x00000001800B5710
	private void OnChat(ChatConversationMessage inMessage); // 0x0000000180E944D0-0x0000000180E94580
	private void OnGiftPush(GiftPushMessage inMessage); // 0x0000000180E948B0-0x0000000180E94BE0
	private void OnNetworkAvatarSpawned(NetworkedAvatarSpawnedMessage inMessage); // 0x0000000180E94BE0-0x0000000180E94DB0
	private void OnSeasonPassChallengeUpdated(SeasonPassChallengeUpdateResponse inMessage); // 0x0000000180E95240-0x0000000180E954E0
	private void OnSeasonPassChallengeCompleted(SeasonPassChallengeCompleteResponse inMessage); // 0x0000000180E95050-0x0000000180E95240
	private void OnSeasonPassTierCompleted(SeasonPassTierCompletedMessage inMessage); // 0x0000000180E954E0-0x0000000180E95780
}

