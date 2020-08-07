/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_AvatarPositioner : UI_StageSubjectPositioner // TypeDefIndex: 13826
{
	// Fields
	private UI_Stage_Avatar _avatarStage; // 0x70

	// Properties
	public UI_Stage_Avatar AvatarStage { get; } // 0x0000000180418980-0x0000000180418990 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass9_0 // TypeDefIndex: 13827
	{
		// Fields
		public UI_AvatarPositioner <>4__this; // 0x10
		public bool inFreeze; // 0x18

		// Constructors
		public <>c__DisplayClass9_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <FreezeAvatar>b__0(); // 0x0000000180517770-0x0000000180517810
		internal void <FreezeAvatar>b__1(); // 0x0000000180517810-0x0000000180517870
	}

	// Constructors
	public UI_AvatarPositioner(); // 0x000000018051E5C0-0x000000018051E5D0

	// Methods
	public void Setup(Camera inUICamera, UI_Stage_Avatar inStage); // 0x000000018051DFF0-0x000000018051E000
	public void ViewHead(); // 0x000000018051E580-0x000000018051E5A0
	public void ViewTail(); // 0x000000018051E5A0-0x000000018051E5C0
	public void ViewGeneral(); // 0x000000018051E560-0x000000018051E580
	public void ViewDetached(); // 0x000000018051E540-0x000000018051E560
	public void ViewBodyPart(ActorInfoBodyPart inBodyPart); // 0x000000018051E430-0x000000018051E540
	public void FreezeAvatar(bool inFreeze); // 0x000000018051DF20-0x000000018051DFF0
	private new void Update(); // 0x000000018051E420-0x000000018051E430
	private new void UpdateVirtualCamera(); // 0x000000018051E000-0x000000018051E420
}

