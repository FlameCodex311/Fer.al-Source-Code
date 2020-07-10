/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class WebUtils // TypeDefIndex: 11132
{
	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass4_0<T> // TypeDefIndex: 11133
		where T : new()
	{
		// Fields
		public Action<WWWResponse<T>> inCallback;

		// Constructors
		public <>c__DisplayClass4_0();

		// Methods
		internal void <Get>b__0(WWWResponse r);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetAsync>d__5<T> : IAsyncStateMachine // TypeDefIndex: 11134
		where T : new()
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;
		public string inURL;
		private TaskAwaiter<WWWResponse> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetAsync>d__6<T> : IAsyncStateMachine // TypeDefIndex: 11135
		where T : new()
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;
		public bool inSendAuthorization;
		public string inURL;
		private TaskAwaiter<WWWResponse> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_Request>d__8 : IEnumerator<object> // TypeDefIndex: 11136
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<WWWResponse> inCallback; // 0x20
		public UnityWebRequest inRequest; // 0x28
		private Stopwatch <stopwatch>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_Request>d__8(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180FF6EA0-0x0000000180FF7170
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FF7170-0x0000000180FF71C0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <_RequestWithProxy>d__9 : IEnumerator<object> // TypeDefIndex: 11137
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<WWWResponse> inCallback; // 0x20
		public HttpWebRequest httpWebRequest; // 0x28
		private Stopwatch <stopwatch>5__2; // 0x30
		private Task<WebResponse> <responseTask>5__3; // 0x38
		private HttpWebResponse <response>5__4; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <_RequestWithProxy>d__9(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000180FF76D0-0x0000000180FF7780
		private bool MoveNext(); // 0x0000000180FF71C0-0x0000000180FF7680
		private void <>m__Finally1(); // 0x0000000180FF7780-0x0000000180FF77D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180FF7680-0x0000000180FF76D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetAsync>d__10 : IAsyncStateMachine // TypeDefIndex: 11138
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public bool inSendAuthorization; // 0x20
		public string inURL; // 0x28
		private TaskAwaiter<WWWResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F6BF0-0x00000001801F6C00
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6C00-0x00000001801F6C50
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <GetAsync>d__11 : IAsyncStateMachine // TypeDefIndex: 11139
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public Dictionary<string, string> inHeaders; // 0x28
		private TaskAwaiter<WWWResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F6C50-0x00000001801F6C60
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6C60-0x00000001801F6CB0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <PutAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 11140
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public string inBodyData; // 0x28
		private TaskAwaiter<WWWResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F6DD0-0x00000001801F6DE0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6DE0-0x00000001801F6E30
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <PostAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 11141
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public WWWForm inFormData; // 0x28
		private TaskAwaiter<WWWResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F6CB0-0x00000001801F6CC0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6CC0-0x00000001801F6D10
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <PostJsonAsync>d__14<T> : IAsyncStateMachine // TypeDefIndex: 11142
		where T : new()
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;
		public object objectToSerialize;
		public bool sendAuthorization;
		public string customAuthBearer;
		public string inURL;
		private TaskAwaiter<WWWResponse<T>> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <PostJsonAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 11143
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public object objectToSerialize; // 0x20
		public bool sendAuthorization; // 0x28
		public string customAuthBearer; // 0x30
		public string inURL; // 0x38
		private TaskAwaiter<WWWResponse> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x00000001801F6D70-0x00000001801F6D80
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6D80-0x00000001801F6DD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <PostAsync>d__16<T> : IAsyncStateMachine // TypeDefIndex: 11144
		where T : new()
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;
		public bool inSendAuthorization;
		public string customAuthBearer;
		public string inURL;
		public byte[] inBodyData;
		private TaskAwaiter<WWWResponse<T>> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <PostAsync>d__17<T> : IAsyncStateMachine // TypeDefIndex: 11145
		where T : new()
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;
		public string inURL;
		public byte[] inBodyData;
		public Dictionary<string, string> inHeaders;
		private TaskAwaiter<WWWResponse> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <PostAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 11146
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public byte[] inBodyData; // 0x28
		public Dictionary<string, string> inHeaders; // 0x30
		private TaskAwaiter<WWWResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F6D10-0x00000001801F6D20
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6D20-0x00000001801F6D70
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DeleteAsync>d__19<T> : IAsyncStateMachine // TypeDefIndex: 11147
		where T : new()
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;
		public bool inSendAuthorization;
		public string inURL;
		public byte[] inBodyData;
		private TaskAwaiter<WWWResponse<T>> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DeleteAsync>d__20<T> : IAsyncStateMachine // TypeDefIndex: 11148
		where T : new()
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;
		public string inURL;
		public byte[] inBodyData;
		public Dictionary<string, string> inHeaders;
		private TaskAwaiter<WWWResponse> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <DeleteAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 11149
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public byte[] inBodyData; // 0x28
		public Dictionary<string, string> inHeaders; // 0x30
		private TaskAwaiter<WWWResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001801F6B90-0x00000001801F6BA0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6BA0-0x00000001801F6BF0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 11150
	{
		// Fields
		public bool done; // 0x10
		public WWWResponse response; // 0x18

		// Constructors
		public <>c__DisplayClass22_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <_RequestAsync>b__0(WWWResponse res); // 0x0000000180FF5DC0-0x0000000180FF5DD0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <_RequestAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 11151
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public UnityWebRequest inRequest; // 0x20
		private <>c__DisplayClass22_0 <>8__1; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001801F6E40-0x00000001801F6E50
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F6E50-0x00000001801F6EA0
	}

	// Methods
	public static Coroutine Post(string inURL, WWWForm inFormData, Action<WWWResponse> inCallback = null); // 0x0000000180FFE370-0x0000000180FFE420
	public static Coroutine Post(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null, Action<WWWResponse> inCallback = null); // 0x0000000180FFE100-0x0000000180FFE370
	public static Coroutine Put(string inURL, string inBodyData, Action<WWWResponse> inCallback = null); // 0x0000000180FFE510-0x0000000180FFE5C0
	public static Coroutine Get(string inURL, Action<WWWResponse> inCallback = null); // 0x0000000180FFDD30-0x0000000180FFDDE0
	public static Coroutine Get<T>(string inURL, Action<WWWResponse<T>> inCallback = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801105E0-0x0000000180110630
	public static Task<WWWResponse<T>> GetAsync<T>(string inURL, Action<WWWResponse<T>> inCallback = null)
		where T : new();
	[AsyncStateMachine] // 0x0000000180110860-0x00000001801108B0
	public static Task<WWWResponse<T>> GetAsync<T>(string inURL, bool inSendAuthorization)
		where T : new();
	public static Coroutine Delete(string inURL, Action<WWWResponse> inCallback = null); // 0x0000000180FFDAA0-0x0000000180FFDB50
	[IteratorStateMachine] // 0x0000000180110C60-0x0000000180110CB0
	private static IEnumerator _Request(UnityWebRequest inRequest, Action<WWWResponse> inCallback = null); // 0x0000000180FFE710-0x0000000180FFE780
	[IteratorStateMachine] // 0x0000000180110EF0-0x0000000180110F40
	private static IEnumerator _RequestWithProxy(HttpWebRequest httpWebRequest, Action<WWWResponse> inCallback = null); // 0x0000000180FFE6A0-0x0000000180FFE710
	[AsyncStateMachine] // 0x00000001801111E0-0x0000000180111230
	public static Task<WWWResponse> GetAsync(string inURL, bool inSendAuthorization); // 0x0000000180FFDC40-0x0000000180FFDD30
	[AsyncStateMachine] // 0x0000000180111460-0x00000001801114B0
	public static Task<WWWResponse> GetAsync(string inURL, Dictionary<string, string> inHeaders = null); // 0x0000000180FFDB50-0x0000000180FFDC40
	[AsyncStateMachine] // 0x0000000180111590-0x00000001801115E0
	public static Task<WWWResponse> PutAsync(string inURL, string inBodyData); // 0x0000000180FFE420-0x0000000180FFE510
	[AsyncStateMachine] // 0x0000000180111760-0x00000001801117B0
	public static Task<WWWResponse> PostAsync(string inURL, WWWForm inFormData); // 0x0000000180FFDDE0-0x0000000180FFDED0
	[AsyncStateMachine] // 0x00000001801119D0-0x0000000180111A20
	public static Task<WWWResponse<T>> PostJsonAsync<T>(string inURL, object objectToSerialize, bool sendAuthorization = true /* Metadata: 0x007827A4 */, string customAuthBearer = null)
		where T : new();
	[AsyncStateMachine] // 0x0000000180111BA0-0x0000000180111BF0
	public static Task<WWWResponse> PostJsonAsync(string inURL, object objectToSerialize, bool sendAuthorization = true /* Metadata: 0x007827A5 */, string customAuthBearer = null); // 0x0000000180FFDFE0-0x0000000180FFE100
	[AsyncStateMachine] // 0x0000000180111E40-0x0000000180111E90
	public static Task<WWWResponse<T>> PostAsync<T>(string inURL, byte[] inBodyData, bool inSendAuthorization, string customAuthBearer = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801120E0-0x0000000180112130
	public static Task<WWWResponse<T>> PostAsync<T>(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null)
		where T : new();
	[AsyncStateMachine] // 0x0000000180112250-0x00000001801122A0
	public static Task<WWWResponse> PostAsync(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null); // 0x0000000180FFDED0-0x0000000180FFDFE0
	[AsyncStateMachine] // 0x00000001801124C0-0x0000000180112510
	public static Task<WWWResponse<T>> DeleteAsync<T>(string inURL, byte[] inBodyData, bool inSendAuthorization)
		where T : new();
	[AsyncStateMachine] // 0x0000000180112740-0x0000000180112790
	public static Task<WWWResponse<T>> DeleteAsync<T>(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801129C0-0x0000000180112A10
	public static Task<WWWResponse> DeleteAsync(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null); // 0x0000000180FFD990-0x0000000180FFDAA0
	[AsyncStateMachine] // 0x0000000180112B20-0x0000000180112B70
	private static Task<WWWResponse> _RequestAsync(UnityWebRequest inRequest); // 0x0000000180FFE5C0-0x0000000180FFE6A0
}

