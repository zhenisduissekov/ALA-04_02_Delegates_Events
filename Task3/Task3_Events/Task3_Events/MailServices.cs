// ----------------------------------------------------------------------
// <copyright file="{MailServices.cs}" company="{companyName}">
// {copyrightText}
// </copyright>
// <author>{Zhenis Duissekov}</author>
//-----------------------------------------------------------------------

namespace Task3_Events
{
    /// <summary>
    /// Mail services class
    /// </summary>
    public class MailServices
    {
        public void OnEventIsUp(object source, AlarmEventArgs a)
        {
            System.Console.WriteLine($"MailServices: {a.Alarm.Name} Note was sent by mail..");
        }
    }
}