/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_AvatarPositioner : UI_StageSubjectPositioner // TypeDefIndex: 12637
{
	// Fields
	private UI_Stage_Avatar _avatarStage; // 0x70

	// Properties
	public UI_Stage_Avatar AvatarStage { get; } // 0x0000000180369B50-0x0000000180369B60 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 12638
	{
		// Fields
		public UI_AvatarPositioner <>4__this; // 0x10
		public bool inFreeze; // 0x18

		// Constructors
		public <>c__DisplayClass9_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <FreezeAvatar>b__0(); // 0x0000000180FB27B0-0x0000000180FB2850
		internal void <FreezeAvatar>b__1(); // 0x0000000180FB2850-0x0000000180FB28B0
	}

	// Constructors
	public UI_AvatarPositioner(); // 0x0000000180FB9740-0x0000000180FB9750

	// Methods
	public void Setup(Camera inUICamera, UI_Stage_Avatar inStage); // 0x0000000180FB9150-0x0000000180FB9160
	public void ViewHead(); // 0x0000000180FB9700-0x0000000180FB9720
	public void ViewTail(); // 0x0000000180FB9720-0x0000000180FB9740
	public void ViewGeneral(); // 0x0000000180FB96E0-0x0000000180FB9700
	public void ViewDetached(); // 0x0000000180FB96C0-0x0000000180FB96E0
	public void ViewBodyPart(ActorInfoBodyPart inBodyPart); // 0x0000000180FB95B0-0x0000000180FB96C0
	public void FreezeAvatar(bool inFreeze); // 0x0000000180FB9080-0x0000000180FB9150
	private new void Update(); // 0x0000000180FB95A0-0x0000000180FB95B0
	private new void UpdateVirtualCamera(); // 0x0000000180FB9160-0x0000000180FB95A0
}

