﻿using System;
using log4net;

namespace CS.Diagnostics
{
    /// <summary>
    /// 自定义的Logger
    /// <remarks>
    /// 通过实现ITracer来适配不同的Loger
    /// </remarks>
    /// </summary>
    public class Logger : ITracer
    {
        protected ILog Log { get; set; }

        public bool IsDebugEnabled => Log.IsDebugEnabled;
        public bool IsInfoEnabled => Log.IsInfoEnabled;
        public bool IsWarnEnabled => Log.IsWarnEnabled;
        public bool IsErrorEnabled => Log.IsErrorEnabled;
        public bool IsFatalEnabled => Log.IsFatalEnabled;

        /// <summary>
        /// 初始化为应用日志
        /// </summary>
        public Logger()
        {
            Log = LogManager.GetLogger("App");
        }

        /// <summary>
        /// 初始化为开发日志
        /// </summary>
        /// <param name="type"></param>
        public Logger(Type type)
        {
            Log = LogManager.GetLogger(type);
        }

        /// <summary>
        /// 直接回返开发日志
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ITracer GetSysLog(Type type)
        {
            var log = new Logger(type);
            return log;
        }

        /// <summary>
        /// 直接返回应用日志
        /// </summary>
        /// <returns></returns>
        public static ITracer GetAppLog()
        {
            var log = new Logger();
            return log;
        }

        public void Debug(object message)
        {
            if (IsDebugEnabled)
                Log.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            if (IsDebugEnabled)
                Log.Debug(message, exception);
        }

        public void DebugFormat(string format, params object[] args)
        {
            if (IsDebugEnabled)
                Log.DebugFormat(format, args);
        }

        public void DebugFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsDebugEnabled)
                Log.DebugFormat(provider, format, args);
        }

        public void Info(object message)
        {
            if (IsInfoEnabled)
                Log.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            if (IsInfoEnabled)
                Log.Info(message, exception);
        }

        public void InfoFormat(string format, params object[] args)
        {
            if (IsInfoEnabled)
                Log.InfoFormat(format, args);
        }

        public void InfoFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsInfoEnabled)
                Log.InfoFormat(provider, format, args);
        }

        public void Warn(object message)
        {
            if (IsWarnEnabled)
                Log.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            if (IsWarnEnabled)
                Log.Warn(message, exception);
        }

        public void WarnFormat(string format, params object[] args)
        {
            if (IsWarnEnabled)
                Log.WarnFormat(format, args);
        }

        public void WarnFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsWarnEnabled)
                Log.WarnFormat(provider, format, args);
        }

        public void Error(object message)
        {
            if (IsErrorEnabled)
                Log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            if (IsErrorEnabled)
                Log.Error(message, exception);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            if (IsErrorEnabled)
                Log.ErrorFormat(format, args);
        }

        public void ErrorFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsErrorEnabled)
                Log.ErrorFormat(provider, format, args);
        }

        public void Fatal(object message)
        {
            if (IsFatalEnabled)
                Log.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            if (IsFatalEnabled)
                Log.Fatal(message, exception);
        }

        public void FatalFormat(string format, params object[] args)
        {
            if (IsFatalEnabled)
                Log.FatalFormat(format, args);
        }

        public void FatalFormat(IFormatProvider provider, string format, params object[] args)
        {
            if (IsFatalEnabled)
                Log.FatalFormat(provider, format, args);
        }
    }
}