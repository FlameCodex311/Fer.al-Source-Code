/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

public static class FEasing // TypeDefIndex: 9278
{
	// Nested types
	public enum EFease // TypeDefIndex: 9279
	{
		EaseInCubic = 0,
		EaseOutCubic = 1,
		EaseInOutCubic = 2,
		EaseInOutElastic = 3,
		EaseInElastic = 4,
		EaseOutElastic = 5,
		EaseInExpo = 6,
		EaseOutExpo = 7,
		EaseInOutExpo = 8,
		Linear = 9
	}

	public delegate float Function(float s, float e, float v, float extraParameter = 1f /* Metadata: 0x00744F41 */); // TypeDefIndex: 9280; 0x0000000180BCA530-0x0000000180BCA850

	// Methods
	public static float EaseInCubic(float start, float end, float value, float ignore = 1f /* Metadata: 0x00744EF1 */); // 0x00000001815DB920-0x00000001815DB940
	public static float EaseOutCubic(float start, float end, float value, float ignore = 1f /* Metadata: 0x00744EF5 */); // 0x00000001815DBE60-0x00000001815DBE90
	public static float EaseInOutCubic(float start, float end, float value, float ignore = 1f /* Metadata: 0x00744EF9 */); // 0x00000001815DBB20-0x00000001815DBB80
	public static float EaseOutElastic(float start, float end, float value, float rangeMul = 1f /* Metadata: 0x00744EFD */); // 0x00000001815DBE90-0x00000001815DBFD0
	public static float EaseInElastic(float start, float end, float value, float rangeMul = 1f /* Metadata: 0x00744F01 */); // 0x00000001815DB940-0x00000001815DBA80
	public static float EaseInOutElastic(float start, float end, float value, float rangeMul = 1f /* Metadata: 0x00744F05 */); // 0x00000001815DBB80-0x00000001815DBD50
	public static float EaseInExpo(float start, float end, float value, float ignore = 1f /* Metadata: 0x00744F09 */); // 0x00000001815DBA80-0x00000001815DBB20
	public static float EaseOutExpo(float start, float end, float value, float ignore = 1f /* Metadata: 0x00744F0D */); // 0x00000001815DBFD0-0x00000001815DC080
	public static float EaseInOutExpo(float start, float end, float value, float ignore = 1f /* Metadata: 0x00744F11 */); // 0x00000001815DBD50-0x00000001815DBE60
	public static float Linear(float start, float end, float value, float ignore = 1f /* Metadata: 0x00744F15 */); // 0x00000001815DC1F0-0x00000001815DC270
	public static Function GetEasingFunction(EFease easingFunction); // 0x00000001815DC080-0x00000001815DC1F0
}

