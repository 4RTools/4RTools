using System;
using System.Collections.Generic;

namespace _4RTools.Utils
{
    public interface IObserver
    {
        void Update(ISubject subject);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(Message message);
    }

    public enum MessageCode { 
        PROCESS_CHANGED,
        PROFILE_CHANGED,
        PROFILE_INPUT_CHANGE,
        TURN_ON,
        TURN_OFF,
        SHUTDOWN_APPLICATION,
        CLICK_ICON_TRAY,
        SERVER_LIST_CHANGED
    }

    public class Message
    {
        public MessageCode code { get; }
        public object data { get; set; }
        public Message() { }

        public Message(MessageCode code, object data)
        {
            this.code = code;
            this.data = data;
        }
    }

    public class Subject : ISubject
    {
        public Message Message { get; set; } = new Message();
        private List<IObserver> _observers = new List<IObserver>();
        public void Attach(IObserver observer)
        {
            Console.WriteLine("Subject: Attached an observer.");
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached an observer.");
        }

        public void Notify(Message message)
        {
            Console.WriteLine("Subject: Notifying observers...");
            this.Message = message;
            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }
    }
}
