// See https://aka.ms/new-console-template for more information


Account acc1 = new Account { AccountNo = 111, Balance = 50000 };
//acc1.Subscribe(Notification.SendEmail);
acc1.alert += Notification.SendEmail;
Notification n = new Notification();
//acc1.Subscribe(n.SendSms);
acc1.alert += n.SendSms;
acc1.alert += n.WhatsApp;

//acc1.alert("");


acc1.Deposite(1000);
//acc1.Withradw(1000);
Console.WriteLine($"Current Balance is: {acc1.Balance}");


  delegate void Alert(string msg);

class Account
{
    public event Alert alert = null;
    public int AccountNo { get; set; }
    public int Balance { get; set; }

    //public void Subscribe(Alert alert)
    //{
    //    this.alert += alert; 
    //}
    //public void UnSubscribe(Alert alert)
    //{
    //    this.alert -= alert;
    //}

    public void Deposite(int amt)
    {
        Balance += amt;
        //Notification.SendEmail($"Deposited {amt} into account {AccountNo}");

        if(alert != null)
            alert($"Deposited {amt} into account {AccountNo}");
    }

    public void Withradw(int amt)
    {

        Balance -= amt;
        //Notification.SendEmail($"Withrawn {amt} from account {AccountNo}");\
        if(alert !=null)
            alert($"Withrawn {amt} from account {AccountNo}");
    }

}

class Notification
{
    public static void SendEmail(string msg)
    {
        Console.WriteLine($"Mail: {msg}");

        //System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient();
        //smtpClient.Host = "smtp.gmail.com";
        //smtpClient.Port = 587;
        //smtpClient.Credentials = null;
        //System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage("from-email", "to-email");
        //message.Subject = "Subject";
        //message.Body = "Message Body";
        //message.Attachments.Add(null);

        //smtpClient.Send(message);
    }
    public  void SendSms(string msg)
    {
        Console.WriteLine($"SMS: {msg}");
    }
    public void WhatsApp(string msg)
    {
        Console.WriteLine($"WhatsApp: {msg}");
    }
}