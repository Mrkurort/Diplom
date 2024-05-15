using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Mail : MonoBehaviour
{
    public Text Name;
    public Text group;
    public Text eMail;

    public void MailTo()
    {
        MailAddress fromAdres = new MailAddress("interactive_skeleton_app@mail.ru", "Скелет Григорий");//от куда
        MailAddress toAdres = new MailAddress(eMail.text, Name.text);//куда
        
        MailMessage messege = new MailMessage(fromAdres, toAdres);
        messege.Body = $"Студент {Name.text} ";//Сообщение
        messege.Subject = $"Студент{Name.text} из группы {group.text} получил следующий результат";//Тема

        SmtpClient smtpClient = new SmtpClient();
        smtpClient.Host = "smtp.mail.ru";
        smtpClient.Port = 465;
        smtpClient.EnableSsl = true;
        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtpClient.UseDefaultCredentials = false;
        smtpClient.Credentials = new NetworkCredential(fromAdres.Address, "usaYALLpu32$");

        smtpClient.Send(messege);
    }
}
