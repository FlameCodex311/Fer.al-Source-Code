/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Iss;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss.Http
{
	public class HttpConnection // TypeDefIndex: 16003
	{
		// Fields
		public const string HANDSHAKE_TOKEN = "#"; // Metadata: 0x00785141
		private const string HANDSHAKE = "connect"; // Metadata: 0x00785146
		private const string DISCONNECT = "disconnect"; // Metadata: 0x00785151
		private const string CONN_LOST = "ERR#01"; // Metadata: 0x0078515F
		private const string servletUrl = "BlueBox/HttpBox.do"; // Metadata: 0x00785169
		private const string paramName = "sfsHttp"; // Metadata: 0x0078517F
		private string sessionId; // 0x10
		private bool connected; // 0x18
		private string ipAddr; // 0x20
		private int port; // 0x28
		private string webUrl; // 0x30
		private IHttpProtocolCodec codec; // 0x38
		private IssClient sfs; // 0x40
		private HttpCallbackHandler OnHttpConnectCallback; // 0x48
		private HttpCallbackHandler OnHttpCloseCallback; // 0x50
		private HttpCallbackHandler OnHttpErrorCallback; // 0x58
		private HttpCallbackHandler OnHttpDataCallback; // 0x60
	
		// Nested types
		public delegate void HttpCallbackHandler(HttpEvent evt); // TypeDefIndex: 16004; 0x000000018082AC80-0x000000018082B070
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 16005
		{
			// Fields
			public HttpConnection <>4__this; // 0x10
			public string message; // 0x18
	
			// Constructors
			public <>c__DisplayClass25_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <Send>b__0(); // 0x0000000180F701B0-0x0000000180F701E0
		}
	
		// Constructors
		public HttpConnection(IssClient sfs); // 0x0000000180F568B0-0x0000000180F56920
	
		// Methods
		public string GetSessionId(); // 0x000000018036AC80-0x000000018036AC90
		public bool IsConnected(); // 0x000000018041BAC0-0x000000018041BAD0
		public void Connect(string ipAddr); // 0x0000000180F55930-0x0000000180F55940
		public void Connect(string ipAddr, int port); // 0x0000000180F55940-0x0000000180F55BB0
		public string GetWebUrl(); // 0x0000000180397720-0x0000000180397730
		public void Close(); // 0x0000000180F558F0-0x0000000180F55930
		public void Send(string message); // 0x0000000180F56730-0x0000000180F568B0
		private void HttpSendViaSockets(string message); // 0x0000000180F55BB0-0x0000000180F56730
		public void AddEventListener(string evt, HttpCallbackHandler method); // 0x0000000180F55810-0x0000000180F558F0
	}
}
