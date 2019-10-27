// ----------------------------------------------------------------------
// <copyright file="{MsgServices.cs}" company="{companyName}">
// {copyrightText}
// </copyright>
// <author>{Zhenis Duissekov}</author>
//-----------------------------------------------------------------------

namespace Task3_Events
{
    using System;

    /// <summary>
    /// Message Services class
    /// </summary>
    public class MsgServices
    {
        public void OnEventIsUp(object source, AlarmEventArgs a)
        {
            Console.WriteLine($"MsgServices: {a.Alarm.Name} Note was sent by message..");
        }
    }
}