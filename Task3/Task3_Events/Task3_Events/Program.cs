// ----------------------------------------------------------------------
// <copyright file="{Program.cs}" company="{companyName}">
// {copyrightText}
// </copyright>
// <author>{Zhenis Duissekov}</author>
//-----------------------------------------------------------------------

namespace Task3_Events
{
    public class Program
    {
        /// <summary>
        /// Main
        /// Publisher and Subscribers
        /// Timer
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var alarm = new Alarm() { Name = "Server crash" };
            var countdown = new Countdown();
            var mailServices = new MailServices();
            var emailServices = new EmailServices();
            var msgServices = new MsgServices();
            countdown.EventIsUp += mailServices.OnEventIsUp;
            countdown.EventIsUp += emailServices.OnEventIsUp;
            countdown.EventIsUp += msgServices.OnEventIsUp;
            countdown.TimeCounter(alarm);
        }
    }
}