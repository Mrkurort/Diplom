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
    [SerializeField] private TMP_Text Name, group, eMail;
    public static int restart1;
    public static int restart2;
<<<<<<< HEAD

    public void MailTo1()
=======
    
    public void MailTo()
>>>>>>> parent of f3506e61 (Р’РЅРµСЃРµРЅС‹ РїСЂР°РІРєРё)
    {
        MailAddress fromAdres = new MailAddress("interactive_skeleton_app@mail.ru", "Скелет Григорий");//от куда
        MailAddress toAdres = new MailAddress("vdmitriev04@inbox.ru", "");//куда
        
        MailMessage messege = new MailMessage(fromAdres, toAdres);
        messege.Subject = $"Студент {Name.text} ";//Тема

        messege.Body = $"Студент: {Name.text}" +
            $"\nГруппа: {group.text}" +
            $"\n\n\t-----Задание №1-----" +
<<<<<<< HEAD

            $"\nДанный студент справился с заданием на оценку {QutionsOneCO.mark1}!" +

=======
            $"\nДанный студент справился с заданием №1 на оценку {QutionsOneCO.mark2}!" +
>>>>>>> parent of f3506e61 (Р’РЅРµСЃРµРЅС‹ РїСЂР°РІРєРё)
            $"\nКоличество набраных баллов: {QutionsOneCO.ball} из 6" +
            $"\nКоличество запусков задания №1: {restart1}" +
            $"\n\n\t-----Задание №2-----" +
<<<<<<< HEAD
            $"\nДанный студент справился с заданием на оценку {QutionsTwoCO.mark2}!" +

            $"\nКоличество набраных баллов: {QutionsTwoCO.ball} из 16!" +

            $"\nПопытка №{restart2}";//Сообщение
=======
            $"\nДанный студент справился с заданием №2 на оценку {QutionsTwoCO.mark2}!" +
            $"\nКоличество набраных баллов: {QutionsTwoCO.ball} из 15!" +
            $"\nКоличество запусков задания №2: {restart2}";//Сообщение
>>>>>>> parent of f3506e61 (Р’РЅРµСЃРµРЅС‹ РїСЂР°РІРєРё)

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
