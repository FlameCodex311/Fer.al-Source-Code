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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class GroupTeamManager // TypeDefIndex: 10695
{
	// Fields
	public static string questDefId; // 0x00
	public static List<UserInfo> currentGroupMembers; // 0x08
	public static UserInfo creator; // 0x10
	public static bool iAmHost; // 0x18
	private static GroupTeamManager _instance; // 0x20

	// Properties
	public static GroupTeamManager Instance { get; } // 0x000000018105A960-0x000000018105A9C0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_CreateGroupTeam>d__11 : IEnumerator<object> // TypeDefIndex: 10696
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_CreateGroupTeam>d__11(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181066490-0x0000000181066550
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181066550-0x00000001810665A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerCreateGroupTeam>d__12 : IAsyncStateMachine // TypeDefIndex: 10697
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F9050-0x00000001801F9060
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_InviteToGroupTeam>d__14 : IEnumerator<object> // TypeDefIndex: 10698
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inUserUUIDToAdd; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_InviteToGroupTeam>d__14(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181066950-0x0000000181066A40
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181066A40-0x0000000181066A90
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerInviteToGroupTeam>d__15 : IAsyncStateMachine // TypeDefIndex: 10699
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inUserUUIDToAdd; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F9080-0x00000001801F9090
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_AcceptGroupTeamInvitation>d__17 : IEnumerator<object> // TypeDefIndex: 10700
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inGroupCreatorUUID; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_AcceptGroupTeamInvitation>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181066350-0x0000000181066440
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181066440-0x0000000181066490
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestAcceptGroupTeamInvitation>d__18 : IAsyncStateMachine // TypeDefIndex: 10701
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inGroupCreatorUUID; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F8FD0-0x00000001801F8FE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_RejectGroupTeamInvitation>d__20 : IEnumerator<object> // TypeDefIndex: 10702
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inGroupCreatorUUID; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_RejectGroupTeamInvitation>d__20(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181066A90-0x0000000181066B80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181066B80-0x000000018107F5B0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestRejectGroupTeamInvitation>d__21 : IAsyncStateMachine // TypeDefIndex: 10703
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inGroupCreatorUUID; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F9030-0x00000001801F9040
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_GroupTeamJoin>d__23 : IEnumerator<object> // TypeDefIndex: 10704
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inHostUUID; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_GroupTeamJoin>d__23(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181066800-0x0000000181066900
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181066900-0x0000000181066950
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerGroupTeamJoin>d__24 : IAsyncStateMachine // TypeDefIndex: 10705
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public string inHostUUID; // 0x28
		public GroupTeamManager <>4__this; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F9070-0x00000001801F9080
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_GroupAnnounce>d__27 : IEnumerator<object> // TypeDefIndex: 10706
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public LobbyManager.ELobbyType inType; // 0x28
		public string inAssocDefID; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_GroupAnnounce>d__27(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810665A0-0x00000001810666A0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810666A0-0x00000001810666F0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RequestServerGroupAnnounce>d__28 : IAsyncStateMachine // TypeDefIndex: 10707
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public LobbyManager.ELobbyType inType; // 0x28
		public string inAssocDefID; // 0x30
		private TaskAwaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F9060-0x00000001801F9070
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_GroupQuest>d__31 : IEnumerator<object> // TypeDefIndex: 10708
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public GroupTeamManager <>4__this; // 0x20
		public string inQuestDefID; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_GroupQuest>d__31(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001810666F0-0x00000001810667B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x00000001810667B0-0x0000000181066800
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <HandleGroupTeamJoinResponse>d__36 : IAsyncStateMachine // TypeDefIndex: 10709
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public XtReader data; // 0x28
		private int <partyMemberCount>5__2; // 0x30
		private UserInfo[] <partyMembers>5__3; // 0x38
		private UniTask<UserInfo> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F8F70-0x00000001801F8F80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <HandleGroupTeamUserJoinedResponse>d__38 : IAsyncStateMachine // TypeDefIndex: 10710
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public XtReader data; // 0x28
		private UniTask<UserInfo> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F8F80-0x00000001801F8F90
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 10711
	{
		// Fields
		public string userUUID; // 0x10

		// Constructors
		public <>c__DisplayClass39_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <HandleGroupTeamUserLeftResponse>b__0(UserInfo userInfo); // 0x0000000180EB3C90-0x0000000180EB3CC0
	}

	// Constructors
	static GroupTeamManager(); // 0x000000018105A8B0-0x000000018105A960
	private GroupTeamManager(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public static void CreateGroup(string inQuestDefId); // 0x0000000181059250-0x0000000181059380
	[DebugButton] // 0x0000000180170070-0x00000001801700D0
	public static void CreateGroup(); // 0x0000000181059380-0x0000000181059460
	[IteratorStateMachine] // 0x0000000180170210-0x0000000180170260
	private IEnumerator _CreateGroupTeam(); // 0x000000018105A610-0x000000018105A670
	[AsyncStateMachine] // 0x0000000180170540-0x0000000180170590
	private void RequestServerCreateGroupTeam(); // 0x000000018105A260-0x000000018105A2F0
	[DebugButton] // 0x00000001801708D0-0x0000000180170930
	public static void AddPlayerToGroup(string inUserUUIDToAdd); // 0x0000000181059160-0x0000000181059250
	[IteratorStateMachine] // 0x0000000180170E00-0x0000000180170E50
	private IEnumerator _InviteToGroupTeam(string inUserUUIDToAdd); // 0x000000018105A7D0-0x000000018105A840
	[AsyncStateMachine] // 0x0000000180171060-0x00000001801710B0
	private void RequestServerInviteToGroupTeam(string inUserUUIDToAdd); // 0x000000018105A4F0-0x000000018105A5A0
	[DebugButton] // 0x00000001801712A0-0x0000000180171300
	public static void AcceptGroupTeamInvitation(string inGroupCreatorUUID); // 0x0000000181059070-0x0000000181059160
	[IteratorStateMachine] // 0x0000000180171500-0x0000000180171550
	private IEnumerator _AcceptGroupTeamInvitation(string inGroupCreatorUUID); // 0x000000018105A5A0-0x000000018105A610
	[AsyncStateMachine] // 0x0000000180171710-0x0000000180171760
	private void RequestAcceptGroupTeamInvitation(string inGroupCreatorUUID); // 0x000000018105A100-0x000000018105A1B0
	[DebugButton] // 0x00000001801719C0-0x0000000180171A20
	public static void RejectGroupInvite(string inGroupCreatorUUID); // 0x000000018105A010-0x000000018105A100
	[IteratorStateMachine] // 0x0000000180171CC0-0x0000000180171D10
	private IEnumerator _RejectGroupTeamInvitation(string inGroupCreatorUUID); // 0x000000018105A840-0x000000018105A8B0
	[AsyncStateMachine] // 0x0000000180171F90-0x0000000180171FE0
	private void RequestRejectGroupTeamInvitation(string inGroupCreatorUUID); // 0x000000018105A1B0-0x000000018105A260
	[DebugButton] // 0x0000000180173580-0x00000001801735E0
	public static Coroutine GroupTeamJoin(string inHostUUID); // 0x0000000181059790-0x0000000181059880
	[IteratorStateMachine] // 0x00000001801736D0-0x0000000180173720
	private IEnumerator _GroupTeamJoin(string inHostUUID); // 0x000000018105A760-0x000000018105A7D0
	[AsyncStateMachine] // 0x00000001801739C0-0x0000000180173A10
	private void RequestServerGroupTeamJoin(string inHostUUID); // 0x000000018105A430-0x000000018105A4F0
	[DebugButton] // 0x0000000180173AF0-0x0000000180173B50
	public static void GroupTeamLeave(); // 0x0000000181059880-0x0000000181059920
	[DebugButton] // 0x0000000180173C90-0x0000000180173CF0
	public static Coroutine GroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID); // 0x0000000181059460-0x0000000181059560
	[IteratorStateMachine] // 0x0000000180173FE0-0x0000000180174030
	private IEnumerator _GroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID); // 0x000000018105A670-0x000000018105A6F0
	[AsyncStateMachine] // 0x0000000180174400-0x0000000180174450
	private void RequestServerGroupAnnounce(LobbyManager.ELobbyType inType, string inAssocDefID); // 0x000000018105A2F0-0x000000018105A3B0
	[DebugButton] // 0x00000001801747B0-0x0000000180174810
	public static Coroutine GroupQuest(string inQuestDefID); // 0x00000001810596A0-0x0000000181059790
	public Coroutine GroupQuest(); // 0x0000000181059560-0x00000001810596A0
	[IteratorStateMachine] // 0x0000000180174A00-0x0000000180174A50
	private IEnumerator _GroupQuest(string inQuestDefID); // 0x000000018105A6F0-0x000000018105A760
	private void RequestServerGroupQuest(string inQuestDefID); // 0x000000018105A3B0-0x000000018105A430
	private void OnGroupTeamJoinSuccessResponse(RequestGroupTeamJoinSuccessMessage inMessage); // 0x0000000181059FC0-0x000000018105A010
	private void OnGroupTeamJoinFailureResponse(RequestGroupTeamJoinFailedMessage inMessage); // 0x0000000181059F70-0x0000000181059FC0
	internal static void HandleGroupTeamCreateResponse(XtReader data); // 0x0000000181059920-0x0000000181059AA0
	[AsyncStateMachine] // 0x0000000180174C40-0x0000000180174C90
	internal static void HandleGroupTeamJoinResponse(XtReader data); // 0x0000000181059AA0-0x0000000181059B50
	internal static void HandleGroupTeamLeaveResponse(XtReader data); // 0x0000000181059B50-0x0000000181059C70
	[AsyncStateMachine] // 0x0000000180175020-0x0000000180175070
	internal static void HandleGroupTeamUserJoinedResponse(XtReader data); // 0x0000000181059C70-0x0000000181059D20
	internal static void HandleGroupTeamUserLeftResponse(XtReader data); // 0x0000000181059D20-0x0000000181059F70
}

