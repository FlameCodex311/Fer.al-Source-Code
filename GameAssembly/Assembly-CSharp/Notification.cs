/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class Notification // TypeDefIndex: 11427
{
	// Fields
	public NotificationGroup notificationGroup; // 0x10
	public NotificationType notificationType; // 0x14
	public bool isLogged; // 0x18
	public BaseDef baseDef; // 0x20
	public DateTime timeStamp; // 0x28
	public string messageText; // 0x30
	public UserInfo userInfo; // 0x38
	public string imageDefId; // 0x40
	public int? quantity; // 0x48
	private bool _isUnread; // 0x50
	public bool? _hasImage; // 0x51
	public bool? _hasRawImage; // 0x53

	// Properties
	public string Text { get; } // 0x0000000180E96590-0x0000000180E96660 
	public bool IsUnread { get; } // 0x0000000180619B50-0x0000000180619B60 
	public bool HasImage { get; } // 0x0000000180E96320-0x0000000180E964A0 
	public bool HasRawImage { get; } // 0x0000000180E964A0-0x0000000180E96590 

	// Constructors
	public Notification(BaseDef inBaseDef); // 0x0000000180E962A0-0x0000000180E96320
	public Notification(string inMessageText = null, string inImageDefId = null); // 0x0000000180E96210-0x0000000180E962A0

	// Methods
	public void MarkAsRead(); // 0x0000000180E96200-0x0000000180E96210
	public string GetTimeStampUIString(); // 0x0000000180E960B0-0x0000000180E96200
}

