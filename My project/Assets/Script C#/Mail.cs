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
>>>>>>> parent of f3506e61 (Внесены правки)
    {
        MailAddress fromAdres = new MailAddress("interactive_skeleton_app@mail.ru", "������ ��������");//�� ����
        MailAddress toAdres = new MailAddress("vdmitriev04@inbox.ru", "");//����
        
        MailMessage messege = new MailMessage(fromAdres, toAdres);
        messege.Subject = $"������� {Name.text} ";//����

        messege.Body = $"�������: {Name.text}" +
            $"\n������: {group.text}" +
            $"\n\n\t-----������� �1-----" +
<<<<<<< HEAD

            $"\n������ ������� ��������� � �������� �� ������ {QutionsOneCO.mark1}!" +

=======
            $"\n������ ������� ��������� � �������� �1 �� ������ {QutionsOneCO.mark2}!" +
>>>>>>> parent of f3506e61 (Внесены правки)
            $"\n���������� �������� ������: {QutionsOneCO.ball} �� 6" +
            $"\n���������� �������� ������� �1: {restart1}" +
            $"\n\n\t-----������� �2-----" +
<<<<<<< HEAD
            $"\n������ ������� ��������� � �������� �� ������ {QutionsTwoCO.mark2}!" +

            $"\n���������� �������� ������: {QutionsTwoCO.ball} �� 16!" +

            $"\n������� �{restart2}";//���������
=======
            $"\n������ ������� ��������� � �������� �2 �� ������ {QutionsTwoCO.mark2}!" +
            $"\n���������� �������� ������: {QutionsTwoCO.ball} �� 15!" +
            $"\n���������� �������� ������� �2: {restart2}";//���������
>>>>>>> parent of f3506e61 (Внесены правки)

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
