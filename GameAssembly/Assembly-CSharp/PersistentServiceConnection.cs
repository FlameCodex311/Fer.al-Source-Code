/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class PersistentServiceConnection // TypeDefIndex: 11119
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsConnected>k__BackingField; // 0x10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsAuthorized>k__BackingField; // 0x11
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private string <Name>k__BackingField; // 0x18
	private PersistentServiceClient _client; // 0x20
	private string _host; // 0x28
	private int _port; // 0x30
	private Coroutine _reconnectCoroutine; // 0x38
	private int retrySeconds; // 0x40

	// Properties
	public bool IsConnected { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180375540-0x0000000180375550 0x00000001803930B0-0x00000001803930C0
	public bool IsAuthorized { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180375550-0x0000000180375560 0x0000000180393640-0x0000000180393650
	public string Name { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RetryConnect>d__32 : IEnumerator<object> // TypeDefIndex: 11120
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public PersistentServiceConnection <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RetryConnect>d__32(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811669A0-0x0000000181166A80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181166A80-0x0000000181166AD0
	}

	// Constructors
	protected PersistentServiceConnection(); // 0x0000000180EC1450-0x0000000180EC1460

	// Methods
	protected void Init(string name, string host, int port, bool isDebug, bool isSecured); // 0x00000001811744B0-0x0000000181174780
	~PersistentServiceConnection(); // 0x0000000181174410-0x00000001811744B0
	public void Connect(); // 0x0000000181173F40-0x0000000181174190
	public void Login(string token, string uuid); // 0x0000000181174810-0x0000000181174930
	public void Disconnect(); // 0x0000000181174190-0x0000000181174410
	public void ProcessEventQueue(); // 0x0000000180EC12A0-0x0000000180EC12C0
	public void Send(PersistentServiceRequest req); // 0x0000000180EC1320-0x0000000180EC1380
	protected abstract void SendConnectMessage(bool succes, string error);
	protected abstract void SendConnectionLostMessage();
	protected abstract void ListenForAuthorizationMessage();
	protected void OnAuthMessage(PersistentServiceAuthResponse message); // 0x0000000181174930-0x0000000181174990
	protected virtual void OnAuthorized(); // 0x00000001803581E0-0x00000001803581F0
	protected virtual void OnConnection(bool success, string error); // 0x00000001811749E0-0x0000000181174A90
	private void OnConnectionLost(); // 0x0000000181174990-0x00000001811749E0
	private void StartReconnectCoroutine(); // 0x0000000181174C30-0x0000000181174D10
	[IteratorStateMachine] // 0x000000018010DD40-0x000000018010DD90
	private IEnumerator RetryConnect(); // 0x0000000181174BC0-0x0000000181174C30
	private void OnMessageReceived(string message); // 0x0000000180EC1290-0x0000000180EC12A0
	private void OnDebugMessage(string message); // 0x0000000181174A90-0x0000000181174BC0
	protected void Log(string message); // 0x00000001803581E0-0x00000001803581F0
	protected void LogError(string message); // 0x0000000181174780-0x0000000181174810
}

