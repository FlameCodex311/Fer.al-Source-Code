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

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Plugins
{
	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions> // TypeDefIndex: 5791
	{
		// Fields
		private static readonly StringBuilder _Buffer; // 0x00
		private static readonly List<char> _OpenedTags; // 0x08
	
		// Constructors
		public StringPlugin(); // 0x00000001818CAA30-0x00000001818CAA70
		static StringPlugin(); // 0x00000001818CA9A0-0x00000001818CAA30
	
		// Methods
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative); // 0x00000001818CA880-0x00000001818CA920
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, string fromValue, bool setImmediately); // 0x00000001818CA920-0x00000001818CA9A0
		public override void Reset(TweenerCore<string, string, StringOptions> t); // 0x00000001818BE120-0x00000001818BE150
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value); // 0x0000000180766BD0-0x0000000180766BE0
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t); // 0x00000001818CA7A0-0x00000001818CA880
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue); // 0x00000001818CA600-0x00000001818CA660
		public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818C9F10-0x00000001818CA600
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled); // 0x00000001818C9710-0x00000001818C9F10
		private char[] ScrambledCharsToUse(StringOptions options); // 0x00000001818CA660-0x00000001818CA7A0
	}
}
