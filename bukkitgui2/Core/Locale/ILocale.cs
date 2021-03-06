﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bukkitgui2.Core.Locale
{
	interface ILocale
	{
		/// <summary>
		/// Private isInitialized variable to store the value that will be returned on the public get request
		/// </summary>
		private bool _isInitialized;

		/// <summary>
		/// True if this component is initialized and can be used
		/// </summary>
		public readonly bool isInitialized;

		/// <summary>
		/// Returns the current language of the translator
		/// </summary>
		public readonly string currentLanguage;

		/// <summary>
		/// Create or open needed files, create streams if needed, do everything what's needed before a Log() call can be made
		/// </summary>
		public void Initialize();

		/// <summary>
		/// Stop the logger, dispose used sources
		/// </summary>
		public void Dispose();

		/// <summary>
		/// Translate a string
		/// </summary>
		/// <param name="original">The original text</param>
		/// <returns></returns>
		public string Tr(string original);

		/// <summary>
		/// Translate a string
		/// </summary>
		/// <param name="original">The original text</param>
		/// <param name="p1">replacement value of parameter %1</param>
		/// <param name="p2">replacement value of parameter %2</param>
		/// <param name="p3">replacement value of parameter %3</param>
		/// <param name="p4">replacement value of parameter %4</param>
		/// <returns></returns>
		public string Tr(string original,string p1, string p2="", string p3="", string p4="");

	}
}
