using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
using System;

public class Mail : MonoBehaviour
{
    public static int restart1;
    public static int restart2;

    public void MailTo1()
    {
        MailAddress fromAdres = new MailAddress("interactive_skeleton_app@mail.ru", "Скелет Григорий");//от куда
        MailAddress toAdres = new MailAddress("vdmitriev04@inbox.ru", "");//куда
        
        MailMessage messege = new MailMessage(fromAdres, toAdres);
        messege.Subject = $"{Menu.fio} прошёл задания на следуюющие оценки";//Тема

        messege.Body = $"Студент: {Menu.fio}" +
            $"\nГруппа: {Menu.group}" +
            $"\n\n\t-----Задание №1-----" +

            $"\nДанный студент справился с заданием на оценку {QutionsOneCO.mark1}!" +

            $"\nКоличество набраных баллов: {QutionsOneCO.ball} из 6" +
            $"\nПопытка №{restart1}";

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

    public void MailTo2()
    {
        MailAddress fromAdres = new MailAddress("interactive_skeleton_app@mail.ru", "Скелет Григорий");//от куда
        MailAddress toAdres = new MailAddress("vdmitriev04@inbox.ru", "");//куда

        MailMessage messege = new MailMessage(fromAdres, toAdres);
        messege.Subject = $"{Menu.fio} прошёл задания на следуюющие оценки";//Тема

        messege.Body = $"Студент: {Menu.fio}" +
            $"\nГруппа: {Menu.group}" +
            $"\n\n\t-----Задание №2-----" +
            $"\nДанный студент справился с заданием на оценку {QutionsTwoCO.mark2}!" +

            $"\nКоличество набраных баллов: {QutionsTwoCO.ball} из 16!" +

            $"\nПопытка №{restart2}";//Сообщение

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
