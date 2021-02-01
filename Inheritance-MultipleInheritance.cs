using System;
using System.Collections.Generic;

namespace CSharpIntermediate 
{
  public class TextBox : UiControl, IDraggable, IDroppable
  {
    public void Drag()
    {
      throw new NotImplementedException();
    }

    public void Drop()
    {
      throw new NotImplementedException();
    }
  }

  public class UiControl
  {
    public string Id { get; set; }
    public Size Size { get; set; }
    public Position TopLeft { get; set; }

    public virtual void Draw()
    {
    }

    public void Focus()
    {
      System.Console.WriteLine("Received focus.");
    }

  }

  public class Size
  {

  }

  public class Video{

  }

  public class Mail{

  }

  public class Message{

  }

  // An interface is like a contract. Any class that implements an interface 
  // should define its methods.

  public interface IDraggable
  {
    void Drag();
  }

    public interface IDroppable
  {
    void Drop();
  }

  public class VideoEncoder
  {
    private readonly IList<INotificationChannel> _notificationChannels; 

    public VideoEncoder()
    {
      _notificationChannels = new List<INotificationChannel>();
    }

    public static void createEncoder()
    {
      var encoder = new VideoEncoder();
      encoder.RegisterNotificationChannel(new MailNotificationChannel());
      encoder.RegisterNotificationChannel(new SmsNotificationChannel());      
      encoder.Encode(new Video());
    }

    public void Encode(Video video)
    {
      foreach(var channel in _notificationChannels)
        channel.Send(new Message()); 
    }

    public void RegisterNotificationChannel(INotificationChannel channel)
    {
      _notificationChannels.Add(channel);
    }
  }

  public class MailService
  {
    public void Send(Mail mail)
    {
      System.Console.WriteLine("sending email...");
    }
  }

  public class MailNotificationChannel : INotificationChannel
  {
    public void Send(Message message)
    {
      System.Console.WriteLine("sending mail");
    }
  }

  public class SmsNotificationChannel : INotificationChannel
  {
    public void Send(Message message)
    {
      System.Console.WriteLine("sending SMS");
    }
  }

  public interface INotificationChannel
  {
    void Send(Message message);

  }
}