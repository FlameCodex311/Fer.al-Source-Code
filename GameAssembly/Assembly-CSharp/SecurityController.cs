/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SecurityController // TypeDefIndex: 10965
{
	// Fields
	private static string _salt; // 0x00

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <requestAuthTokenAndJWT>d__1 : IAsyncStateMachine // TypeDefIndex: 10966
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<string> <>t__builder; // 0x08
		private TaskAwaiter<WWWResponse<APIRequestTokenResponse>> <>u__1; // 0x20
		private TaskAwaiter<WWWResponse<APIClientAuthenticateResponse>> <>u__2; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F0F20-0x00000001801F0F30
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0F30-0x00000001801F0F80
	}

	// Constructors
	public SecurityController(); // 0x000000018036B6C0-0x000000018036B6D0
	static SecurityController(); // 0x0000000180EBF220-0x0000000180EBF260

	// Methods
	[AsyncStateMachine] // 0x00000001800FA6D0-0x00000001800FA720
	public static Task<string> requestAuthTokenAndJWT(); // 0x0000000180EBFC10-0x0000000180EBFCE0
	public static string encryptChallenge(string challenge, string IV); // 0x0000000180EBF260-0x0000000180EBFA40
	private static string generateSharedSecret(); // 0x0000000180EBFA40-0x0000000180EBFC10
}

