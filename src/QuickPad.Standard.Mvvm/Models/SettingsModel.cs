﻿using System.Reflection;
using Microsoft.Extensions.Logging;
using QuickPad.Mvvm.ViewModels;

namespace QuickPad.Mvvm.Models
{
    public abstract class SettingsModel<TStorage, TStream> : ViewModel<TStorage, TStream>
        where TStream : class
    {
        // Not Ignored
        public string CustomThemeId
        {
            get => Get((string)null, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool PasteTextOnly
        {
            get => Get(true, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public string DefaultFont
        {
            get => Get("Consolas", MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public string DefaultRtfFont
        {
            get => Get("Calibri", MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool SpellCheck
        {
            get => Get(false, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool WordWrap
        {
            get => Get(false, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool RtfSpellCheck
        {
            get => Get(true, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool RtfWordWrap
        {
            get => Get(true, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool UseAcrylic
        {
            get => Get(false, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public double DefaultFontRtfSize
        {
            get => Get(12.0, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public double DefaultFontSize
        {
            get => Get(14.0, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool AutoSave
        {
            get => Get(true, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public int AutoSaveFrequency
        {
            get => Get(10, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public string DefaultFileType
        {
            get => Get(".txt", MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public string DefaultEncoding
        {
            get => Get("Utf8", MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public string DefaultMode
        {
            get => Get(DisplayModes.LaunchClassicMode.ToString(), MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool AcknowledgeFontSelectionChange
        {
            get => Get(false, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public bool EnableGoogleSearch
        {
            get => Get(false, MethodBase.GetCurrentMethod().Name);
            set => Set(value, MethodBase.GetCurrentMethod().Name);
        }

        public abstract bool Set<TValue>(TValue value, string propertyName = null);
        public abstract TValue Get<TValue>(TValue defaultValue, string propertyName = null);

        protected SettingsModel(ILogger logger, IApplication<TStorage, TStream> app) : base(logger, app)
        {
        }
    }
}