/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using LitJson;
using UniRx.Async;
using UniRx.Async.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Services.Chat
{
	public class ChatEntry // TypeDefIndex: 15975
	{
		// Fields
		public string sourceUUID; // 0x10
		private UserInfo _sourceUserInfo; // 0x18
		private string _message; // 0x20
		private string _filteredMessage; // 0x28
		public List<string> mask; // 0x30
		public readonly DateTime timeStamp; // 0x38
		public readonly DateTime localTimeStamp; // 0x40
		public string conversationId; // 0x48
		public bool allowed; // 0x50
		public readonly string ConversationType; // 0x58
		private CancellationTokenSource _cancellationTokenSource; // 0x60
		private ChatDisplayData _displayData; // 0x68
		public Action<ChatDisplayData> OnDisplayDataChanged; // 0x80
	
		// Properties
		public ChatDisplayData DisplayData { get; } // 0x0000000180EB41E0-0x0000000180EB4200 
		public bool IsMe { get; } // 0x0000000180EB4210-0x0000000180EB4250 
		public bool IsFiltered { get; } // 0x0000000180EB4200-0x0000000180EB4210 
	
		// Nested types
		public struct ChatDisplayData // TypeDefIndex: 15976
		{
			// Fields
			public readonly string DisplayName; // 0x00
			public readonly string DisplayMessage; // 0x08
			public readonly string DisplayMessageWithBlockIgnored; // 0x10
	
			// Constructors
			public ChatDisplayData(string displayName, string displayMessage, string displayMessageWithBlockIgnored); // 0x0000000180005C50-0x0000000180005C60
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RefreshDisplayData>d__24 : IAsyncStateMachine // TypeDefIndex: 15977
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public ChatEntry <>4__this; // 0x18
			private UniTask.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x00000001801F0A10-0x00000001801F0A20
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private struct <RefreshDisplayData>d__25 : IAsyncStateMachine // TypeDefIndex: 15978
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public ChatEntry <>4__this; // 0x18
			public CancellationToken inCancellationToken; // 0x20
			private string <displayName>5__2; // 0x28
			private UniTask<UserInfo> <>u__1; // 0x30
			private UniTask<bool> <>u__2; // 0x40
	
			// Methods
			private void MoveNext(); // 0x00000001801F0A20-0x00000001801F0A30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
		}
	
		// Constructors
		public ChatEntry(string message); // 0x0000000180EB41B0-0x0000000180EB41E0
		public ChatEntry(JsonData jsonData, string inConversationId = null); // 0x0000000180EB3CC0-0x0000000180EB41B0
	
		// Methods
		private string FilteredMessage(string message, List<string> maskArray); // 0x0000000180EB3680-0x0000000180EB3900
		public bool IsSingleEmojiMessage(List<ChatEmojiDefComponent> inEmojiDefs); // 0x0000000180EB3A50-0x0000000180EB3B10
		public string GetTimeStampUIString(); // 0x0000000180EB3900-0x0000000180EB3A50
		[AsyncStateMachine] // 0x00000001800E0950-0x00000001800E09A0
		public UniTask RefreshDisplayData(); // 0x0000000180EB3B10-0x0000000180EB3BA0
		[AsyncStateMachine] // 0x00000001800E0AD0-0x00000001800E0B20
		private UniTask RefreshDisplayData(CancellationToken inCancellationToken); // 0x0000000180EB3BA0-0x0000000180EB3C50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <IsSingleEmojiMessage>b__22_0(ChatEmojiDefComponent emoji); // 0x0000000180EB3C50-0x0000000180EB3C90
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <RefreshDisplayData>b__25_0(RelationshipManager.Block b); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}
}
