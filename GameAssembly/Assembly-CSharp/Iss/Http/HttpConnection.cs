/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Iss;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss.Http
{
	public class HttpConnection // TypeDefIndex: 14390
	{
		// Fields
		public const string HANDSHAKE_TOKEN = "#"; // Metadata: 0x007BA86B
		private const string HANDSHAKE = "connect"; // Metadata: 0x007BA870
		private const string DISCONNECT = "disconnect"; // Metadata: 0x007BA87B
		private const string CONN_LOST = "ERR#01"; // Metadata: 0x007BA889
		private const string servletUrl = "BlueBox/HttpBox.do"; // Metadata: 0x007BA893
		private const string paramName = "sfsHttp"; // Metadata: 0x007BA8A9
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
		public delegate void HttpCallbackHandler(HttpEvent evt); // TypeDefIndex: 14391; 0x00000001803F4920-0x00000001803F4CE0
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass25_0 // TypeDefIndex: 14392
		{
			// Fields
			public HttpConnection <>4__this; // 0x10
			public string message; // 0x18
	
			// Constructors
			public <>c__DisplayClass25_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <Send>b__0(); // 0x0000000180884A30-0x0000000180884A60
		}
	
		// Constructors
		public HttpConnection(IssClient sfs); // 0x000000018086EBE0-0x000000018086EC50
	
		// Methods
		public string GetSessionId(); // 0x0000000180372440-0x0000000180372450
		public bool IsConnected(); // 0x00000001803F6D30-0x00000001803F6D40
		public void Connect(string ipAddr); // 0x000000018086DCC0-0x000000018086DCD0
		public void Connect(string ipAddr, int port); // 0x000000018086DCD0-0x000000018086DF20
		public string GetWebUrl(); // 0x00000001803745C0-0x00000001803745D0
		public void Close(); // 0x000000018086DC80-0x000000018086DCC0
		public void Send(string message); // 0x000000018086EA60-0x000000018086EBE0
		private void HttpSendViaSockets(string message); // 0x000000018086DF20-0x000000018086EA60
		public void AddEventListener(string evt, HttpCallbackHandler method); // 0x000000018086DBA0-0x000000018086DC80
	}
}
