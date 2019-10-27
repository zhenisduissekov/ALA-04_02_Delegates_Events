// ----------------------------------------------------------------------
// <copyright file="{EmailServices.cs}" company="{companyName}">
// {copyrightText}
// </copyright>
// <author>{Zhenis Duissekov}</author>
//-----------------------------------------------------------------------

namespace Task3_Events
{
    using System;

    /// <summary>
    /// Email services class
    /// </summary>
    public class EmailServices
    {
        public void OnEventIsUp(object source, AlarmEventArgs a)
        {
            Console.WriteLine($"EmailServices: {a.Alarm.Name} Note was sent by email..");
        }
    }
}