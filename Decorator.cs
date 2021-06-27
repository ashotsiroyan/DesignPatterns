using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    public interface INotifier
    {
        void Send(string message);
    }

    public class MailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Mail Notification: " + message);
        }
    }

    public class SMSNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS Notification: " + message);
        }
    }

    public class FBNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("FB Notification: " + message);
        }
    }

    public abstract class Decorator : INotifier
    {
        protected INotifier notifier;

        public Decorator(INotifier notifier)
        {
            this.notifier = notifier;
        }

        public abstract void Send(string message);
    }

    public class WarningDecorator : Decorator
    {
        public WarningDecorator(INotifier notifier): base(notifier)
        {

        }

        public override void Send(string message)
        {
            notifier.Send("Warning: " + message);
        }
    }

    public class ErrorDecorator : Decorator
    {
        public ErrorDecorator(INotifier notifier) : base(notifier)
        {

        }

        public override void Send(string message)
        {
            notifier.Send("Error: " + message);
        }
    }
}
