/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using ParadoxNotion.Design;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018011DEF0-0x000000018011DF50
	[Description] // 0x000000018011DEF0-0x000000018011DF50
	public class DailyQuestNotification : NetworkActionTask // TypeDefIndex: 14422
	{
		// Fields
		public ENotificationType notificationType; // 0x68
		public Statement questPrefix; // 0x70
		public Statement questStarted; // 0x78
		public Statement questCompleted; // 0x80
		public Statement questName; // 0x88
		public Statement progress; // 0x90
		public Statement basicNotification; // 0x98
	
		// Properties
		protected override string info { get; } // 0x000000018174D840-0x000000018174DA20 
	
		// Nested types
		public enum ENotificationType // TypeDefIndex: 14423
		{
			Start = 0,
			Complete = 1,
			Progress = 2,
			BasicNotification = 3
		}
	
		// Constructors
		public DailyQuestNotification(); // 0x000000018174D710-0x000000018174D840
	
		// Methods
		protected override void OnExecute(); // 0x000000018174D470-0x000000018174D710
	}
}
