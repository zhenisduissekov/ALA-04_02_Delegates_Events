// ----------------------------------------------------------------------
// <copyright file="{Countdown.cs}" company="{companyName}">
// {copyrightText}
// </copyright>
// <author>{Zhenis Duissekov}</author>
//-----------------------------------------------------------------------

namespace Task3_Events
{
    using System;
    using System.Threading;

    /// <summary>
    /// Countdown class with event
    /// </summary>
    public class Countdown
    {
        public EventHandler<AlarmEventArgs> EventIsUp;

        public void TimeCounter(Alarm alarm)
        {
            Console.WriteLine("Event is up to 3 seconds...");
            Thread.Sleep(3000);
            OnEventIsUp(alarm);
        }

        protected void OnEventIsUp(Alarm alarm)
        {
            this.EventIsUp?.Invoke(this, new AlarmEventArgs() { Alarm = alarm });
        }
    }
}