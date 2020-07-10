/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public static class BipedNaming // TypeDefIndex: 9308
	{
		// Fields
		public static string[] typeLeft; // 0x00
		public static string[] typeRight; // 0x08
		public static string[] typeSpine; // 0x10
		public static string[] typeHead; // 0x18
		public static string[] typeArm; // 0x20
		public static string[] typeLeg; // 0x28
		public static string[] typeTail; // 0x30
		public static string[] typeEye; // 0x38
		public static string[] typeExclude; // 0x40
		public static string[] typeExcludeSpine; // 0x48
		public static string[] typeExcludeHead; // 0x50
		public static string[] typeExcludeArm; // 0x58
		public static string[] typeExcludeLeg; // 0x60
		public static string[] typeExcludeTail; // 0x68
		public static string[] typeExcludeEye; // 0x70
		public static string[] pelvis; // 0x78
		public static string[] hand; // 0x80
		public static string[] foot; // 0x88
	
		// Nested types
		[Serializable]
		public enum BoneType // TypeDefIndex: 9309
		{
			Unassigned = 0,
			Spine = 1,
			Head = 2,
			Arm = 3,
			Leg = 4,
			Tail = 5,
			Eye = 6
		}
	
		[Serializable]
		public enum BoneSide // TypeDefIndex: 9310
		{
			Center = 0,
			Left = 1,
			Right = 2
		}
	
		// Constructors
		static BipedNaming(); // 0x000000018163CC80-0x000000018163FDF0
	
		// Methods
		public static Transform[] GetBonesOfType(BoneType boneType, Transform[] bones); // 0x000000018163C750-0x000000018163C910
		public static Transform[] GetBonesOfSide(BoneSide boneSide, Transform[] bones); // 0x000000018163C510-0x000000018163C6D0
		public static Transform[] GetBonesOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x000000018163C6D0-0x000000018163C750
		public static Transform GetFirstBoneOfTypeAndSide(BoneType boneType, BoneSide boneSide, Transform[] bones); // 0x000000018163C910-0x000000018163C9D0
		public static Transform GetNamingMatch(Transform[] transforms, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[][] namings); // 0x000000018163C9D0-0x000000018163CC40
		public static BoneType GetBoneType(string boneName); // 0x000000018163C300-0x000000018163C480
		public static BoneSide GetBoneSide(string boneName); // 0x000000018163C270-0x000000018163C300
		public static Transform GetBone(Transform[] transforms, BoneType boneType, BoneSide boneSide = BoneSide.Center /* Metadata: 0x00744FFC */, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[][] namings); // 0x000000018163C480-0x000000018163C510
		private static bool isLeft(string boneName); // 0x00000001816405B0-0x0000000181640840
		private static bool isRight(string boneName); // 0x0000000181640A80-0x0000000181640D10
		private static bool isSpine(string boneName); // 0x0000000181640D10-0x0000000181640F50
		private static bool isHead(string boneName); // 0x0000000181640370-0x00000001816405B0
		private static bool isArm(string boneName); // 0x000000018163FEF0-0x0000000181640130
		private static bool isLeg(string boneName); // 0x0000000181640840-0x0000000181640A80
		private static bool isTail(string boneName); // 0x0000000181640F50-0x0000000181641190
		private static bool isEye(string boneName); // 0x0000000181640130-0x0000000181640370
		private static bool isTypeExclude(string boneName); // 0x0000000181641190-0x0000000181641320
		private static bool matchesNaming(string boneName, string[] namingConvention); // 0x0000000181641470-0x00000001816415C0
		private static bool excludesNaming(string boneName, string[] namingConvention); // 0x000000018163FDF0-0x000000018163FE90
		private static bool matchesLastLetter(string boneName, string[] namingConvention); // 0x0000000181641380-0x0000000181641470
		private static bool LastLetterIs(string boneName, string letter); // 0x000000018163CC40-0x000000018163CC80
		private static string firstLetter(string boneName); // 0x000000018163FE90-0x000000018163FEF0
		private static string lastLetter(string boneName); // 0x0000000181641320-0x0000000181641380
	}
}
