/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class SecurityController // TypeDefIndex: 12488
{
	// Fields
	private static string _salt; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <requestAuthTokenAndJWT>d__1 : IAsyncStateMachine // TypeDefIndex: 12489
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse<APIRequestTokenResponse>> <>u__1; // 0x20
		private TaskAwaiter<WWWResponse<APIClientAuthenticateResponse>> <>u__2; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180002F40-0x0000000180002F50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002F50-0x0000000180003250
	}

	// Constructors
	public SecurityController(); // 0x0000000180373240-0x0000000180373250
	static SecurityController(); // 0x00000001803FDB60-0x00000001803FDBA0

	// Methods
	[AsyncStateMachine] // 0x00000001801D53C0-0x00000001801D5410
	public static Task<string> requestAuthTokenAndJWT(); // 0x00000001803FE510-0x00000001803FE5E0
	public static string encryptChallenge(string challenge, string IV); // 0x00000001803FDBA0-0x00000001803FE350
	private static string generateSharedSecret(); // 0x00000001803FE350-0x00000001803FE510
}

