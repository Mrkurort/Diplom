using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class Mail : MonoBehaviour
{
    [SerializeField] private TMP_Text Name, group, eMail;
    public static int restart1;
    public static int restart2;
    
    public void MailTo()
    {
        MailAddress fromAdres = new MailAddress("interactive_skeleton_app@mail.ru", "Скелет Григорий");//от куда
        MailAddress toAdres = new MailAddress("vdmitriev04@inbox.ru");//куда
        
        MailMessage messege = new MailMessage(fromAdres, toAdres);
        messege.Subject = $"Студент {Name.text} ";//Тема

        messege.Body = $"Студент: {Name.text}" +
            $"\nГруппа: {group.text}" +
            $"\n-----Задание №1-----" +
            $"\nДанный студент справился с заданием №1 на оценку {QutionsOneCO.mark2}!" +
            $"\nКол-во запусков задания №1: {restart1}" +
            $"\n-----Задание №2-----" +
            $"\nДанный студент справился с заданием №2 на оценку {QutionsTwoCO.mark2}!" +
            $"\nКол-во запусков задания №2: {restart2}";//Сообщение

        messege.IsBodyHtml = false;

        using SmtpClient smtpClient = new SmtpClient("smtp.mail.ru", 25);
        {
            smtpClient.EnableSsl = true;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(fromAdres.Address, "0PQQ6pZw32UYLnw6skKd");

            smtpClient.Send(messege);
        }
    }

    public Animator anim;
    public Animator anim2;

    public void ToMailForm()
    {
        anim.SetTrigger("isTrigger");
    }

    public void ToMailForm2()
    {
        anim.SetTrigger("isTrigger");
    }
}
