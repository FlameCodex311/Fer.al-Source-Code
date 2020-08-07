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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Services.Chat
{
	public class ChatEntry // TypeDefIndex: 14362
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
		public ChatDisplayData DisplayData { get; } // 0x00000001807642A0-0x00000001807642C0 
		public bool IsMe { get; } // 0x00000001807642D0-0x0000000180764310 
		public bool IsFiltered { get; } // 0x00000001807642C0-0x00000001807642D0 
	
		// Nested types
		public struct ChatDisplayData // TypeDefIndex: 14363
		{
			// Fields
			public readonly string DisplayName; // 0x00
			public readonly string DisplayMessage; // 0x08
			public readonly string DisplayMessageWithBlockIgnored; // 0x10
	
			// Constructors
			public ChatDisplayData(string displayName, string displayMessage, string displayMessageWithBlockIgnored); // 0x00000001800064E0-0x00000001800064F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RefreshDisplayData>d__24 : IAsyncStateMachine // TypeDefIndex: 14364
		{
			// Fields
			public int <>1__state; // 0x00
			public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
			public ChatEntry <>4__this; // 0x18
			private UniTask.Awaiter <>u__1; // 0x20
	
			// Methods
			private void MoveNext(); // 0x000000018001B080-0x000000018001B090
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private struct <RefreshDisplayData>d__25 : IAsyncStateMachine // TypeDefIndex: 14365
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
			private void MoveNext(); // 0x000000018001B090-0x000000018001B0A0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
		}
	
		// Constructors
		public ChatEntry(string message); // 0x0000000180764270-0x00000001807642A0
		public ChatEntry(JsonData jsonData, string inConversationId = null); // 0x0000000180763D90-0x0000000180764270
	
		// Methods
		private string FilteredMessage(string message, List<string> maskArray); // 0x00000001807637C0-0x0000000180763A20
		public bool IsSingleEmojiMessage(List<ChatEmojiDefComponent> inEmojiDefs); // 0x0000000180763B60-0x0000000180763C10
		public string GetTimeStampUIString(); // 0x0000000180763A20-0x0000000180763B60
		[AsyncStateMachine] // 0x0000000180221D00-0x0000000180221D50
		public UniTask RefreshDisplayData(); // 0x0000000180763C10-0x0000000180763CA0
		[AsyncStateMachine] // 0x0000000180222030-0x0000000180222080
		private UniTask RefreshDisplayData(CancellationToken inCancellationToken); // 0x0000000180763CA0-0x0000000180763D50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <IsSingleEmojiMessage>b__22_0(ChatEmojiDefComponent emoji); // 0x0000000180763D50-0x0000000180763D90
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <RefreshDisplayData>b__25_0(RelationshipManager.Block b); // 0x00000001803E2140-0x00000001803E2170
	}
}
