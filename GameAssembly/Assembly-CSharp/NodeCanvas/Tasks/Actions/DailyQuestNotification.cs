/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x000000018028AFD0-0x000000018028B030
	[Description] // 0x000000018028AFD0-0x000000018028B030
	public class DailyQuestNotification : NetworkActionTask<Blackboard> // TypeDefIndex: 15528
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
		protected override string info { get; } // 0x0000000180CC1B50-0x0000000180CC1D20 
	
		// Nested types
		public enum ENotificationType // TypeDefIndex: 15529
		{
			Start = 0,
			Complete = 1,
			Progress = 2,
			BasicNotification = 3
		}
	
		// Constructors
		public DailyQuestNotification(); // 0x0000000180CC1A20-0x0000000180CC1B50
	
		// Methods
		protected override void OnExecute(); // 0x0000000180CC1780-0x0000000180CC1A20
	}
}
