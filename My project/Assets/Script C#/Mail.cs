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
        MailAddress fromAdres = new MailAddress("interactive_skeleton_app@mail.ru", "������ ��������");//�� ����
        MailAddress toAdres = new MailAddress("vdmitriev04@inbox.ru", "");//����
        
        MailMessage messege = new MailMessage(fromAdres, toAdres);
        messege.Subject = $"{Menu.fio} ������ ������� �� ���������� ������";//����

        messege.Body = $"�������: {Menu.fio}" +
            $"\n������: {Menu.group}" +
            $"\n\n\t-----������� �1-----" +

            $"\n������ ������� ��������� � �������� �� ������ {QutionsOneCO.mark1}!" +

            $"\n���������� �������� ������: {QutionsOneCO.ball} �� 6" +
            $"\n������� �{restart1}";

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
        MailAddress fromAdres = new MailAddress("interactive_skeleton_app@mail.ru", "������ ��������");//�� ����
        MailAddress toAdres = new MailAddress("vdmitriev04@inbox.ru", "");//����

        MailMessage messege = new MailMessage(fromAdres, toAdres);
        messege.Subject = $"{Menu.fio} ������ ������� �� ���������� ������";//����

        messege.Body = $"�������: {Menu.fio}" +
            $"\n������: {Menu.group}" +
            $"\n\n\t-----������� �2-----" +
            $"\n������ ������� ��������� � �������� �� ������ {QutionsTwoCO.mark2}!" +

            $"\n���������� �������� ������: {QutionsTwoCO.ball} �� 16!" +

            $"\n������� �{restart2}";//���������

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
