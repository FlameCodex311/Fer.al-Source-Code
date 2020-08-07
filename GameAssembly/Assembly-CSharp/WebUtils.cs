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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class WebUtils // TypeDefIndex: 12664
{
	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass4_0<T> // TypeDefIndex: 12665
		where T : new()
	{
		// Fields
		public Action<WWWResponse<T>> inCallback;

		// Constructors
		public <>c__DisplayClass4_0();

		// Methods
		internal void <Get>b__0(WWWResponse r);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetAsync>d__5<T> : IAsyncStateMachine // TypeDefIndex: 12666
		where T : new()
	{
		// Fields
		public int <>1__state;
		public AsyncTaskMethodBuilder<WWWResponse<T>> <>t__builder;
		public string inURL;
		private TaskAwaiter<WWWResponse> <>u__1;

		// Methods
		private void MoveNext();
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetAsync>d__6<T> : IAsyncStateMachine // TypeDefIndex: 12667
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
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_Request>d__8 : IEnumerator<object> // TypeDefIndex: 12668
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Action<WWWResponse> inCallback; // 0x20
		public UnityWebRequest inRequest; // 0x28
		private Stopwatch <stopwatch>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_Request>d__8(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805DE2C0-0x00000001805DE580
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805DE580-0x00000001805DE5D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <_RequestWithProxy>d__9 : IEnumerator<object> // TypeDefIndex: 12669
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <_RequestWithProxy>d__9(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001805DEAC0-0x00000001805DEB70
		private bool MoveNext(); // 0x00000001805DE5D0-0x00000001805DEA70
		private void <>m__Finally1(); // 0x00000001805DEB70-0x00000001805DEBC0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805DEA70-0x00000001805DEAC0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetAsync>d__10 : IAsyncStateMachine // TypeDefIndex: 12670
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public bool inSendAuthorization; // 0x20
		public string inURL; // 0x28
		private TaskAwaiter<WWWResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180009850-0x0000000180009860
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009860-0x00000001800098B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <GetAsync>d__11 : IAsyncStateMachine // TypeDefIndex: 12671
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public Dictionary<string, string> inHeaders; // 0x28
		private TaskAwaiter<WWWResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x00000001800098B0-0x00000001800098C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800098C0-0x0000000180009910
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PutAsync>d__12 : IAsyncStateMachine // TypeDefIndex: 12672
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public string inBodyData; // 0x28
		private TaskAwaiter<WWWResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180009A30-0x0000000180009A40
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009A40-0x0000000180009A90
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PostAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 12673
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public WWWForm inFormData; // 0x28
		private TaskAwaiter<WWWResponse> <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180009910-0x0000000180009920
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009920-0x0000000180009970
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PostJsonAsync>d__14<T> : IAsyncStateMachine // TypeDefIndex: 12674
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
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PostJsonAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 12675
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
		private void MoveNext(); // 0x00000001800099D0-0x00000001800099E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800099E0-0x0000000180009A30
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PostAsync>d__16<T> : IAsyncStateMachine // TypeDefIndex: 12676
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
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PostAsync>d__17<T> : IAsyncStateMachine // TypeDefIndex: 12677
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
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <PostAsync>d__18 : IAsyncStateMachine // TypeDefIndex: 12678
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public byte[] inBodyData; // 0x28
		public Dictionary<string, string> inHeaders; // 0x30
		private TaskAwaiter<WWWResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180009970-0x0000000180009980
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009980-0x00000001800099D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DeleteAsync>d__19<T> : IAsyncStateMachine // TypeDefIndex: 12679
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
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DeleteAsync>d__20<T> : IAsyncStateMachine // TypeDefIndex: 12680
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
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine);
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <DeleteAsync>d__21 : IAsyncStateMachine // TypeDefIndex: 12681
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public string inURL; // 0x20
		public byte[] inBodyData; // 0x28
		public Dictionary<string, string> inHeaders; // 0x30
		private TaskAwaiter<WWWResponse> <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x00000001800097F0-0x0000000180009800
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009800-0x0000000180009850
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass22_0 // TypeDefIndex: 12682
	{
		// Fields
		public bool done; // 0x10
		public WWWResponse response; // 0x18

		// Constructors
		public <>c__DisplayClass22_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <_RequestAsync>b__0(WWWResponse res); // 0x00000001804A0220-0x00000001804A0230
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <_RequestAsync>d__22 : IAsyncStateMachine // TypeDefIndex: 12683
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<WWWResponse> <>t__builder; // 0x08
		public UnityWebRequest inRequest; // 0x20
		private <>c__DisplayClass22_0 <>8__1; // 0x28
		private TaskAwaiter <>u__1; // 0x30

		// Methods
		private void MoveNext(); // 0x0000000180009AA0-0x0000000180009AB0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180009AB0-0x0000000180009B00
	}

	// Methods
	public static Coroutine Post(string inURL, WWWForm inFormData, Action<WWWResponse> inCallback = null); // 0x00000001805E5650-0x00000001805E5700
	public static Coroutine Post(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null, Action<WWWResponse> inCallback = null); // 0x00000001805E53F0-0x00000001805E5650
	public static Coroutine Put(string inURL, string inBodyData, Action<WWWResponse> inCallback = null); // 0x00000001805E57F0-0x00000001805E58A0
	public static Coroutine Get(string inURL, Action<WWWResponse> inCallback = null); // 0x00000001805E5020-0x00000001805E50D0
	public static Coroutine Get<T>(string inURL, Action<WWWResponse<T>> inCallback = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801F0170-0x00000001801F01C0
	public static Task<WWWResponse<T>> GetAsync<T>(string inURL, Action<WWWResponse<T>> inCallback = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801F0570-0x00000001801F05C0
	public static Task<WWWResponse<T>> GetAsync<T>(string inURL, bool inSendAuthorization)
		where T : new();
	public static Coroutine Delete(string inURL, Action<WWWResponse> inCallback = null); // 0x00000001805E4D90-0x00000001805E4E40
	[IteratorStateMachine] // 0x00000001801F07C0-0x00000001801F0810
	private static IEnumerator _Request(UnityWebRequest inRequest, Action<WWWResponse> inCallback = null); // 0x00000001805E59F0-0x00000001805E5A60
	[IteratorStateMachine] // 0x00000001801F0AE0-0x00000001801F0B30
	private static IEnumerator _RequestWithProxy(HttpWebRequest httpWebRequest, Action<WWWResponse> inCallback = null); // 0x00000001805E5980-0x00000001805E59F0
	[AsyncStateMachine] // 0x00000001801F0D00-0x00000001801F0D50
	public static Task<WWWResponse> GetAsync(string inURL, bool inSendAuthorization); // 0x00000001805E4F30-0x00000001805E5020
	[AsyncStateMachine] // 0x00000001801F0F90-0x00000001801F0FE0
	public static Task<WWWResponse> GetAsync(string inURL, Dictionary<string, string> inHeaders = null); // 0x00000001805E4E40-0x00000001805E4F30
	[AsyncStateMachine] // 0x00000001801F1360-0x00000001801F13B0
	public static Task<WWWResponse> PutAsync(string inURL, string inBodyData); // 0x00000001805E5700-0x00000001805E57F0
	[AsyncStateMachine] // 0x00000001801F1680-0x00000001801F16D0
	public static Task<WWWResponse> PostAsync(string inURL, WWWForm inFormData); // 0x00000001805E50D0-0x00000001805E51C0
	[AsyncStateMachine] // 0x00000001801F18A0-0x00000001801F18F0
	public static Task<WWWResponse<T>> PostJsonAsync<T>(string inURL, object objectToSerialize, bool sendAuthorization = true /* Metadata: 0x007B9F71 */, string customAuthBearer = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801F2E50-0x00000001801F2EA0
	public static Task<WWWResponse> PostJsonAsync(string inURL, object objectToSerialize, bool sendAuthorization = true /* Metadata: 0x007B9F72 */, string customAuthBearer = null); // 0x00000001805E52D0-0x00000001805E53F0
	[AsyncStateMachine] // 0x00000001801F3180-0x00000001801F31D0
	public static Task<WWWResponse<T>> PostAsync<T>(string inURL, byte[] inBodyData, bool inSendAuthorization, string customAuthBearer = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801F3330-0x00000001801F3380
	public static Task<WWWResponse<T>> PostAsync<T>(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801F3590-0x00000001801F35E0
	public static Task<WWWResponse> PostAsync(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null); // 0x00000001805E51C0-0x00000001805E52D0
	[AsyncStateMachine] // 0x00000001801F38F0-0x00000001801F3940
	public static Task<WWWResponse<T>> DeleteAsync<T>(string inURL, byte[] inBodyData, bool inSendAuthorization)
		where T : new();
	[AsyncStateMachine] // 0x00000001801F3DB0-0x00000001801F3E00
	public static Task<WWWResponse<T>> DeleteAsync<T>(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null)
		where T : new();
	[AsyncStateMachine] // 0x00000001801F4130-0x00000001801F4180
	public static Task<WWWResponse> DeleteAsync(string inURL, byte[] inBodyData, Dictionary<string, string> inHeaders = null); // 0x00000001805E4C80-0x00000001805E4D90
	[AsyncStateMachine] // 0x00000001801F4410-0x00000001801F4460
	private static Task<WWWResponse> _RequestAsync(UnityWebRequest inRequest); // 0x00000001805E58A0-0x00000001805E5980
}

