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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Iss
{
	public class IssClient : WWTcpClient // TypeDefIndex: 15983
	{
		// Fields
		private const int EOM = 0; // Metadata: 0x00785083
		private static readonly char MSG_XML; // 0x00
		private static readonly char MSG_JSON; // 0x02
		private static readonly char MSG_STR; // 0x04
		private static readonly string MSG_TYPE_XT; // 0x08
		private static readonly char OPT_NO_RESET; // 0x10
		private static readonly char OPT_DELIMITER; // 0x12
		private static readonly string TYPE_XT_NO_RESET; // 0x18
		private const int MIN_POLL_SPEED = 0; // Metadata: 0x00785087
		private const int DEFAULT_POLL_SPEED = 750; // Metadata: 0x0078508B
		private const int MAX_POLL_SPEED = 10000; // Metadata: 0x0078508F
		private const string HTTP_POLL_REQUEST = "poll"; // Metadata: 0x00785093
		public const string CONNECTION_MODE_DISCONNECTED = "disconnected"; // Metadata: 0x0078509B
		public const string CONNECTION_MODE_SOCKET = "socket"; // Metadata: 0x007850AB
		public const string CONNECTION_MODE_HTTP = "http"; // Metadata: 0x007850B5
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
		public bool IsConnected { get; } // 0x0000000180F6A9C0-0x0000000180F6A9D0 
		public int HttpPollSpeed { get; } // 0x0000000180424130-0x0000000180424140 
		public string ConnectionMode { get; } // 0x0000000180F6A960-0x0000000180F6A9C0 
	
		// Nested types
		public enum XtMsgType // TypeDefIndex: 15984
		{
			Xml = 0,
			Csv = 1,
			Json = 2
		}
	
		// Constructors
		public IssClient(); // 0x0000000180F6A950-0x0000000180F6A960
		public IssClient(bool debug, bool useSecure); // 0x0000000180F6A420-0x0000000180F6A950
		static IssClient(); // 0x0000000180F6A300-0x0000000180F6A420
	
		// Methods
		public void SetIsConnected(bool b); // 0x0000000180F69A30-0x0000000180F69A40
		public void SetHttpPollSpeed(int sp); // 0x0000000180F69A20-0x0000000180F69A30
		~IssClient(); // 0x0000000180EC0080-0x0000000180EC0120
		public override void Disconnect(); // 0x0000000180F669D0-0x0000000180F66C30
		public void Login(string zone, string name, string pass); // 0x0000000180F67E10-0x0000000180F68180
		public void Logout(); // 0x0000000180F68180-0x0000000180F68230
		public void SendPublicMessage(string message); // 0x0000000180F68730-0x0000000180F68830
		public void SendPublicMessage(string message, int roomId); // 0x0000000180F68830-0x0000000180F68940
		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, bool noReset); // 0x0000000180F689D0-0x0000000180F68A10
		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, XtMsgType type, bool noReset); // 0x0000000180F69590-0x0000000180F695D0
		public void SendXtMessageCompressed(string xtName, string cmd, ICollection paramObj, bool noReset); // 0x0000000180F68990-0x0000000180F689D0
		public void SendXtMessage(string xtName, string cmd, ICollection paramObj, XtMsgType type, int roomId, bool compress, bool noReset); // 0x0000000180F68A10-0x0000000180F69590
		public void GetRandomKey(); // 0x0000000180F66C30-0x0000000180F66CE0
		protected override void Initialize(bool isLogOut); // 0x0000000180F67C60-0x0000000180F67CE0
		private void SetupMessageHandlers(); // 0x0000000180F69A40-0x0000000180F69AF0
		private void AddMessageHandler(string key, IMessageHandler handler); // 0x0000000180F668D0-0x0000000180F669A0
		protected override void HandleMessage(string msg); // 0x0000000180F67470-0x0000000180F676D0
		private void XmlReceived(string msg); // 0x0000000180F69E10-0x0000000180F69FA0
		private void JsonReceived(string msg); // 0x0000000180F67CE0-0x0000000180F67E10
		private void StrReceived(string msg); // 0x0000000180F69BE0-0x0000000180F69E00
		private void Send(Hashtable header, string action, int fromRoom, string message); // 0x0000000180F695D0-0x0000000180F69A20
		private string MakeXmlHeader(Hashtable headerObj); // 0x0000000180F68230-0x0000000180F68680
		private string CloseXmlHeader(); // 0x0000000180F669A0-0x0000000180F669D0
		protected override void SendString(string strMessage, bool log); // 0x0000000180F68940-0x0000000180F68990
		internal void SendJson(string jsMessage); // 0x0000000180F68680-0x0000000180F68730
		protected override void HandleSocketConnection(object sender, EventArgs e); // 0x0000000180F676D0-0x0000000180F679F0
		protected override void HandleSocketDisconnection(); // 0x0000000180F679F0-0x0000000180F67A90
		protected override void HandleIOError(string originalError); // 0x0000000180F67330-0x0000000180F67470
		private void TryBlueBoxConnection(string originalError); // 0x0000000180F67330-0x0000000180F67470
		private void StartHttpPollThread(); // 0x0000000180F69AF0-0x0000000180F69BE0
		private void HttpPoll(); // 0x0000000180F67A90-0x0000000180F67C60
		private void HandleHttpData(HttpEvent evt); // 0x0000000180F66EE0-0x0000000180F670D0
		private void HandleHttpConnect(HttpEvent evt); // 0x0000000180F66DA0-0x0000000180F66EE0
		private void HandleHttpClose(HttpEvent evt); // 0x0000000180F66CE0-0x0000000180F66DA0
		private void HandleHttpError(HttpEvent evt); // 0x0000000180F670D0-0x0000000180F67330
		protected override void _DispatchEvent(WWTcpEvent evt); // 0x0000000180F69FA0-0x0000000180F6A300
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <StartHttpPollThread>b__80_0(); // 0x0000000180F69E00-0x0000000180F69E10
	}
}
