/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Iss.Handlers;
using Iss.Http;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Iss
{
	public class IssClient : WWTcpClient // TypeDefIndex: 14370
	{
		// Fields
		private const int EOM = 0; // Metadata: 0x007BA7AD
		private static readonly char MSG_XML; // 0x00
		private static readonly char MSG_JSON; // 0x02
		private static readonly char MSG_STR; // 0x04
		private static readonly string MSG_TYPE_XT; // 0x08
		private static readonly char OPT_NO_RESET; // 0x10
		private static readonly char OPT_DELIMITER; // 0x12
		private static readonly string TYPE_XT_NO_RESET; // 0x18
		private const int MIN_POLL_SPEED = 0; // Metadata: 0x007BA7B1
		private const int DEFAULT_POLL_SPEED = 750; // Metadata: 0x007BA7B5
		private const int MAX_POLL_SPEED = 10000; // Metadata: 0x007BA7B9
		private const string HTTP_POLL_REQUEST = "poll"; // Metadata: 0x007BA7BD
		public const string CONNECTION_MODE_DISCONNECTED = "disconnected"; // Metadata: 0x007BA7C5
		public const string CONNECTION_MODE_SOCKET = "socket"; // Metadata: 0x007BA7D5
		public const string CONNECTION_MODE_HTTP = "http"; // Metadata: 0x007BA7DF
		private bool isHttpMode; // 0xC8
		private int _httpPollSpeed; // 0xCC
		private HttpConnection httpConnection; // 0xD0
		private SysHandler sysHandler; // 0xD8
		private ExtHandler extHandler; // 0xE0
		public IssEvent.OnAdminMessageDelegate onAdminMessage; // 0xE8
		public IssEvent.OnExtensionResponseDelegate onExtensionResponse; // 0xF0
		public IssEvent.OnJoinRoomDelegate onJoinRoom; // 0xF8
		public IssEvent.OnJoinRoomErrorDelegate onJoinRoomError; // 0x100
		public IssEvent.OnLoginDelegate onLogin; // 0x108
		public IssEvent.OnLogoutDelegate onLogout; // 0x110
		public IssEvent.OnRandomKeyDelegate onRandomKey; // 0x118
		public IssEvent.OnRoomListUpdateDelegate onRoomListUpdate; // 0x120
		public string defaultZone; // 0x128
		public string blueBoxIpAddress; // 0x130
		public int blueBoxPort; // 0x138
		public bool smartConnect; // 0x13C
		public bool checkVersion; // 0x13D
		public int myUserId; // 0x140
		public string myUsername; // 0x148
		public int playerId; // 0x150
		public int activeRoomId; // 0x154
		public bool changingRoom; // 0x158
		public int httpPort; // 0x15C
		private readonly string _xtInitalCommand; // 0x160
		private readonly string _xtInitialCommandNoReset; // 0x168
		private StringBuilder _xtBuffer; // 0x170
	
		// Properties
		public bool IsConnected { get; } // 0x00000001804D5820-0x00000001804D5830 
		public int HttpPollSpeed { get; } // 0x00000001806479E0-0x00000001806479F0 
		public string ConnectionMode { get; } // 0x0000000180874120-0x0000000180874180 
	
		// Nested types
		public enum XtMsgType // TypeDefIndex: 14371
		{
			Xml = 0,
			Csv = 1,
			Json = 2
		}
	
		// Constructors
		public IssClient(); // 0x0000000180874110-0x0000000180874120
		public IssClient(bool debug, bool useSecure); // 0x0000000180873C00-0x0000000180874110
		static IssClient(); // 0x0000000180873AE0-0x0000000180873C00
	
		// Methods
		public void SetIsConnected(bool b); // 0x0000000180873240-0x0000000180873250
		public void SetHttpPollSpeed(int sp); // 0x0000000180873230-0x0000000180873240
		~IssClient(); // 0x00000001803FED90-0x00000001803FEE30
		public override void Disconnect(); // 0x0000000180870280-0x00000001808704E0
		public void Login(string zone, string name, string pass); // 0x0000000180871660-0x00000001808719A0
		public void Logout(); // 0x00000001808719A0-0x0000000180871A50
		public void SendPublicMessage(string message); // 0x0000000180871F30-0x0000000180872030
		public void SendPublicMessage(string message, int roomId); // 0x0000000180872030-0x0000000180872140
		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, bool noReset); // 0x00000001808721D0-0x0000000180872210
		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, XtMsgType type, bool noReset); // 0x0000000180872DD0-0x0000000180872E10
		public void SendXtMessageCompressed(string xtName, string cmd, ICollection paramObj, bool noReset); // 0x0000000180872190-0x00000001808721D0
		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, XtMsgType type, int roomId, bool compress, bool noReset); // 0x0000000180872210-0x0000000180872DD0
		public void GetRandomKey(); // 0x00000001808704E0-0x0000000180870590
		protected override void Initialize(bool isLogOut); // 0x00000001808714B0-0x0000000180871530
		private void SetupMessageHandlers(); // 0x0000000180873250-0x0000000180873300
		private void AddMessageHandler(string key, IMessageHandler handler); // 0x0000000180870180-0x0000000180870250
		protected override void HandleMessage(string msg); // 0x0000000180870CF0-0x0000000180870F50
		private void XmlReceived(string msg); // 0x0000000180873600-0x0000000180873780
		private void JsonReceived(string msg); // 0x0000000180871530-0x0000000180871660
		private void StrReceived(string msg); // 0x00000001808733E0-0x00000001808735F0
		private void Send(Hashtable header, string action, int fromRoom, string message); // 0x0000000180872E10-0x0000000180873230
		private string MakeXmlHeader(Hashtable headerObj); // 0x0000000180871A50-0x0000000180871E80
		private string CloseXmlHeader(); // 0x0000000180870250-0x0000000180870280
		protected override void SendString(string strMessage, bool log); // 0x0000000180872140-0x0000000180872190
		internal void SendJson(string jsMessage); // 0x0000000180871E80-0x0000000180871F30
		protected override void HandleSocketConnection(object sender, EventArgs e); // 0x0000000180870F50-0x0000000180871240
		protected override void HandleSocketDisconnection(); // 0x0000000180871240-0x00000001808712E0
		protected override void HandleIOError(string originalError); // 0x0000000180870BB0-0x0000000180870CF0
		private void TryBlueBoxConnection(string originalError); // 0x0000000180870BB0-0x0000000180870CF0
		private void StartHttpPollThread(); // 0x0000000180873300-0x00000001808733E0
		private void HttpPoll(); // 0x00000001808712E0-0x00000001808714B0
		private void HandleHttpData(HttpEvent evt); // 0x0000000180870790-0x0000000180870960
		private void HandleHttpConnect(HttpEvent evt); // 0x0000000180870650-0x0000000180870790
		private void HandleHttpClose(HttpEvent evt); // 0x0000000180870590-0x0000000180870650
		private void HandleHttpError(HttpEvent evt); // 0x0000000180870960-0x0000000180870BB0
		protected override void _DispatchEvent(WWTcpEvent evt); // 0x0000000180873780-0x0000000180873AE0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <StartHttpPollThread>b__80_0(); // 0x00000001808735F0-0x0000000180873600
	}
}
