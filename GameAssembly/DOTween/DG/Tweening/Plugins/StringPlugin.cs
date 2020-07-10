/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Plugins
{
	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 5632
	{
		// Fields
		private static readonly StringBuilder _Buffer; // 0x00
		private static readonly List<char> _OpenedTags; // 0x08
	
		// Constructors
		public StringPlugin(); // 0x0000000180C487A0-0x0000000180C487E0
		static StringPlugin(); // 0x0000000180C48710-0x0000000180C487A0
	
		// Methods
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative); // 0x0000000180C485F0-0x0000000180C48690
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, string fromValue, bool setImmediately); // 0x0000000180C48690-0x0000000180C48710
		public override void Reset(TweenerCore<string, string, StringOptions> t); // 0x0000000180C3BCD0-0x0000000180C3BD00
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value); // 0x0000000180BCE250-0x0000000180BCE260
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t); // 0x0000000180C48510-0x0000000180C485F0
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue); // 0x0000000180C48370-0x0000000180C483D0
		public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C47C70-0x0000000180C48370
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled); // 0x0000000180C47450-0x0000000180C47C70
		private char[] ScrambledCharsToUse(StringOptions options); // 0x0000000180C483D0-0x0000000180C48510
	}
}
