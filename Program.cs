using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace _7_4_Lab_Dating_Game_Ver2
{
    class Program
    {
         static void Main(string[] args)
        {
            DatingProfile dater1 = new DatingProfile("Joy", "Strictclub", 35, "F", "I'm writing my bio!");
            DatingProfile dater2 = new DatingProfile("Paul", "Bunyon", 42, "M", "I like trees and oxen!");

            //allowing a dater to change his/her bio w/ tests to verify
            dater1.WriteBio();
            dater1.ShowDetails();

            dater2.WriteBio();
            dater2.ShowDetails();

            /*FIRST MESSAGE from dater 1*/
            //Create a new Message (sender, title, body, read status)
            Message aNewMess = new Message(dater1, "Hello to dater2", "Do you like trees?");//, false);
            dater1.SendMessage(aNewMess.MessageTitle_isProtected, aNewMess.MessageData_isProtected, dater2);

            /*First MESSAGE from dater 2*/
            //(sender, title, body, read status)
            Message dater2Mess = new Message(dater2, "Hello to dater1", "I like redwoods!");//, false);
            dater2.SendMessage(dater2Mess.MessageTitle_isProtected, dater2Mess.MessageData_isProtected, dater1);

            /*READING Message*/
            dater1.ReadMessage(dater1);
            dater2.ReadMessage(dater2);
            Console.WriteLine("starting 2nd read");
            dater1.ReadMessage(dater1);
            dater2.ReadMessage(dater2);

            //the following are class notes Lesson 6 video (working stuff out) 
            //and are Not part of Lab 7-4.

        }
    }
}
