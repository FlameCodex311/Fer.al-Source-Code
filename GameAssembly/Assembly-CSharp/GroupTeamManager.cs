/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using WW.Debug;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class GroupTeamManager // TypeDefIndex: 12203
{
	// Fields
	public static string questDefId; // 0x00
	public static List<UserInfo> currentGroupMembers; // 0x08
	public static UserInfo creator; // 0x10
	public static bool iAmHost; // 0x18
	private static GroupTeamManager _instance; // 0x20

	// Properties
	public static GroupTeamManager Instance { get; } // 0x0000000180685FB0-0x0000000180686010 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_CreateGroupTeam>d__11 : IEnumerator<object> // TypeDefIndex: 12204
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_CreateGroupTeam>d__11(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068EC30-0x000000018068ECF0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068ECF0-0x000000018068ED40
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerCreateGroupTeam>d__12 : IAsyncStateMachine // TypeDefIndex: 12205
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x000000018000B3D0-0x000000018000B3E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_InviteToGroupTeam>d__14 : IEnumerator<object> // TypeDefIndex: 12206
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inUserUUIDToAdd; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_InviteToGroupTeam>d__14(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068F0F0-0x000000018068F1E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068F1E0-0x000000018068F230
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerInviteToGroupTeam>d__15 : IAsyncStateMachine // TypeDefIndex: 12207
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserUUIDToAdd; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018000B400-0x000000018000B410
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_AcceptGroupTeamInvitation>d__17 : IEnumerator<object> // TypeDefIndex: 12208
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inGroupCreatorUUID; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_AcceptGroupTeamInvitation>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068EAF0-0x000000018068EBE0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068EBE0-0x000000018068EC30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestAcceptGroupTeamInvitation>d__18 : IAsyncStateMachine // TypeDefIndex: 12209
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inGroupCreatorUUID; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018000B350-0x000000018000B360
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_RejectGroupTeamInvitation>d__20 : IEnumerator<object> // TypeDefIndex: 12210
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inGroupCreatorUUID; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_RejectGroupTeamInvitation>d__20(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068F230-0x000000018068F320
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068F320-0x000000018068F370
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestRejectGroupTeamInvitation>d__21 : IAsyncStateMachine // TypeDefIndex: 12211
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inGroupCreatorUUID; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018000B3B0-0x000000018000B3C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_GroupTeamJoin>d__23 : IEnumerator<object> // TypeDefIndex: 12212
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inHostUUID; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_GroupTeamJoin>d__23(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068EFA0-0x000000018068F0A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068F0A0-0x000000018068F0F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerGroupTeamJoin>d__24 : IAsyncStateMachine // TypeDefIndex: 12213
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inHostUUID; // 0x28
		public GroupTeamManager <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B3F0-0x000000018000B400
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_GroupAnnounce>d__27 : IEnumerator<object> // TypeDefIndex: 12214
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public LobbyManager.ELobbyType inType; // 0x28
		public string inAssocDefID; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_GroupAnnounce>d__27(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068ED40-0x000000018068EE40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068EE40-0x000000018068EE90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RequestServerGroupAnnounce>d__28 : IAsyncStateMachine // TypeDefIndex: 12215
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x28
		public string inAssocDefID; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x000000018000B3E0-0x000000018000B3F0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_GroupQuest>d__31 : IEnumerator<object> // TypeDefIndex: 12216
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inQuestDefID; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_GroupQuest>d__31(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x000000018068EE90-0x000000018068EF50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x000000018068EF50-0x000000018068EFA0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <HandleGroupTeamJoinResponse>d__36 : IAsyncStateMachine // TypeDefIndex: 12217
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public XtReader data; // 0x28
		private int <partyMemberCount>5__2; // 0x30
		private UserInfo[] <partyMembers>5__3; // 0x38
		private UniTask<UserInfo> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x000000018000B2F0-0x000000018000B300
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <HandleGroupTeamUserJoinedResponse>d__38 : IAsyncStateMachine // TypeDefIndex: 12218
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public XtReader data; // 0x28
		private UniTask<UserInfo> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x000000018000B300-0x000000018000B310
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 12219
	{
		// Fields
		public string userUUID; // 0x10

		// Constructors
		public <>c__DisplayClass39_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <HandleGroupTeamUserLeftResponse>b__0(UserInfo userInfo); // 0x00000001803E2140-0x00000001803E2170
	}

	// Constructors
	static GroupTeamManager(); // 0x0000000180685F00-0x0000000180685FB0
	private GroupTeamManager(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public static void CreateGroup(string inQuestDefId); // 0x00000001806848A0-0x00000001806849D0
	[DebugButton] // 0x000000018024D8B0-0x000000018024D910
	public static void CreateGroup(); // 0x00000001806849D0-0x0000000180684AB0
	[IteratorStateMachine] // 0x000000018024DB10-0x000000018024DB60
	private IEnumerator _CreateGroupTeam(); // 0x0000000180685C60-0x0000000180685CC0
	[AsyncStateMachine] // 0x000000018024E130-0x000000018024E180
	private void RequestServerCreateGroupTeam(); // 0x00000001806858B0-0x0000000180685940
	[DebugButton] // 0x000000018024E3B0-0x000000018024E410
	public static void AddPlayerToGroup(string inUserUUIDToAdd); // 0x00000001806847B0-0x00000001806848A0
	[IteratorStateMachine] // 0x000000018024E490-0x000000018024E4E0
	private IEnumerator _InviteToGroupTeam(string inUserUUIDToAdd); // 0x0000000180685E20-0x0000000180685E90
	[AsyncStateMachine] // 0x000000018024E770-0x000000018024E7C0
	private void RequestServerInviteToGroupTeam(string inUserUUIDToAdd); // 0x0000000180685B40-0x0000000180685BF0
	[DebugButton] // 0x000000018024E930-0x000000018024E990
	public static void AcceptGroupTeamInvitation(string inGroupCreatorUUID); // 0x00000001806846C0-0x00000001806847B0
	[IteratorStateMachine] // 0x000000018024EAC0-0x000000018024EB10
	private IEnumerator _AcceptGroupTeamInvitation(string inGroupCreatorUUID); // 0x0000000180685BF0-0x0000000180685C60
	[AsyncStateMachine] // 0x000000018024ED80-0x000000018024EDD0
	private void RequestAcceptGroupTeamInvitation(string inGroupCreatorUUID); // 0x0000000180685750-0x0000000180685800
	[DebugButton] // 0x000000018024F0D0-0x000000018024F130
	public static void RejectGroupInvite(string inGroupCreatorUUID); // 0x0000000180685660-0x0000000180685750
	[IteratorStateMachine] // 0x000000018024F350-0x000000018024F3A0
	private IEnumerator _RejectGroupTeamInvitation(string inGroupCreatorUUID); // 0x0000000180685E90-0x0000000180685F00
	[AsyncStateMachine] // 0x000000018024F6E0-0x000000018024F730
	private void RequestRejectGroupTeamInvitation(string inGroupCreatorUUID); // 0x0000000180685800-0x00000001806858B0
	[DebugButton] // 0x000000018024F9B0-0x000000018024FA10
	public static Coroutine GroupTeamJoin(string inHostUUID); // 0x0000000180684DE0-0x0000000180684ED0
	[IteratorStateMachine] // 0x000000018024FC10-0x000000018024FC60
	private IEnumerator _GroupTeamJoin(string inHostUUID); // 0x0000000180685DB0-0x0000000180685E20
	[AsyncStateMachine] // 0x0000000180251260-0x00000001802512B0
	private void RequestServerGroupTeamJoin(string inHostUUID); // 0x0000000180685A80-0x0000000180685B40
	[DebugButton] // 0x00000001802515E0-0x0000000180251640
	public static void GroupTeamLeave(); // 0x0000000180684ED0-0x0000000180684F70
	[DebugButton] // 0x0000000180251790-0x00000001802517F0
	public static Coroutine GroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID); // 0x0000000180684AB0-0x0000000180684BB0
	[IteratorStateMachine] // 0x0000000180251A80-0x0000000180251AD0
	private IEnumerator _GroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID); // 0x0000000180685CC0-0x0000000180685D40
	[AsyncStateMachine] // 0x0000000180251DC0-0x0000000180251E10
	private void RequestServerGroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID); // 0x0000000180685940-0x0000000180685A00
	[DebugButton] // 0x0000000180251F90-0x0000000180251FF0
	public static Coroutine GroupQuest(string inQuestDefID); // 0x0000000180684CF0-0x0000000180684DE0
	public Coroutine GroupQuest(); // 0x0000000180684BB0-0x0000000180684CF0
	[IteratorStateMachine] // 0x0000000180252230-0x0000000180252280
	private IEnumerator _GroupQuest(string inQuestDefID); // 0x0000000180685D40-0x0000000180685DB0
	private void RequestServerGroupQuest(string inQuestDefID); // 0x0000000180685A00-0x0000000180685A80
	private void OnGroupTeamJoinSuccessResponse(RequestGroupTeamJoinSuccessMessage inMessage); // 0x0000000180685610-0x0000000180685660
	private void OnGroupTeamJoinFailureResponse(RequestGroupTeamJoinFailedMessage inMessage); // 0x00000001806855C0-0x0000000180685610
	internal static void HandleGroupTeamCreateResponse(XtReader data); // 0x0000000180684F70-0x00000001806850F0
	[AsyncStateMachine] // 0x0000000180252750-0x00000001802527A0
	internal static void HandleGroupTeamJoinResponse(XtReader data); // 0x00000001806850F0-0x00000001806851A0
	internal static void HandleGroupTeamLeaveResponse(XtReader data); // 0x00000001806851A0-0x00000001806852C0
	[AsyncStateMachine] // 0x0000000180252990-0x00000001802529E0
	internal static void HandleGroupTeamUserJoinedResponse(XtReader data); // 0x00000001806852C0-0x0000000180685370
	internal static void HandleGroupTeamUserLeftResponse(XtReader data); // 0x0000000180685370-0x00000001806855C0
}

