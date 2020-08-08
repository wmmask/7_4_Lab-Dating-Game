using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace _7_4_Lab_Dating_Game_Ver2
{
    class Message
    {

        public DatingProfile sender_isProtected;
        public string MessageTitle_isProtected;
        public string MessageData_isProtected;
        private bool isRead_isProtected = false;


        //My updated constructor:
        public Message(DatingProfile profile, string title, string data)
        { //public version of my class
            sender_isProtected = profile;
            MessageTitle_isProtected = title;
            MessageData_isProtected = data;
        }

        public void ShowDetails()
        {//Method to review data of a new message
            Console.WriteLine(sender_isProtected + "in mess class");
            Console.WriteLine(MessageTitle_isProtected + "in mess class");
            Console.WriteLine(MessageData_isProtected + "in mess class");
            Console.WriteLine(isRead_isProtected + "in mess class");
        }

    }
}
