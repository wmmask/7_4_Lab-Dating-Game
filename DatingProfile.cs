using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Security.Cryptography.X509Certificates;

namespace _7_4_Lab_Dating_Game_Ver2
{
    class DatingProfile
    {
        private string firstName_isProtected;
        private string lastName_isProtected;
        private int age_isProtected;
        private string gender_isProtected;
        private string bio_isProtected;
        public ArrayList myMessages_isProtected = new ArrayList();
        private int myIndex = 0;

        public DatingProfile(string firstName_notProtected, string lastName_notProtected,
          int age_notProtected, string gender_notProtected, string bio_notProtected)
        {  //public version of the dating profile class
            firstName_isProtected = firstName_notProtected; 
            lastName_isProtected = lastName_notProtected;
            age_isProtected = age_notProtected;
            gender_isProtected = gender_notProtected;
            bio_isProtected = bio_notProtected;
            myMessages_isProtected = myMessages_isProtected;
        }

        public string firstName_notProtected
        {
            get { return firstName_isProtected; }
            set { firstName_isProtected = value; }
        }
        public string lastName_notProtected
        {
            get { return lastName_isProtected; }
            set { lastName_isProtected = value; }
        }
        public int age_notProtected
        {
            get { return age_isProtected; }
            set { age_isProtected = value; }
        }
        public string gender_notProtected
        {
            get { return gender_isProtected; }
            set { gender_isProtected = value; }
        }
        public string bio_notProtected
        {
            get { return bio_isProtected; }
            set { bio_isProtected = value; }
        }

        public void ShowDetails()
        {//Method to review data for any given user's profile
            Console.WriteLine(firstName_notProtected);
            Console.WriteLine(lastName_notProtected);
            Console.WriteLine(age_notProtected);
            Console.WriteLine(gender_notProtected);
            Console.WriteLine(bio_notProtected);
        }

        //methods
        public void SendMessage(string newTitle, string newData, DatingProfile toProfile)
        {
            toProfile.myIndex += 3;
            toProfile.myMessages_isProtected.Add(false);
            toProfile.myMessages_isProtected.Add(newTitle);
            toProfile.myMessages_isProtected.Add(newData);
        }

        public void WriteBio()
        {//● WriteBio(string text) – allow users to write their bio text to their profile.
            string myBio;
            Console.WriteLine("Enter a short biography for your dating profile");
            myBio = Console.ReadLine();
            bio_isProtected = myBio;
        }

        public void ReadMessage(DatingProfile fromProfile)
        {
            int toReadLength = fromProfile.myIndex;
            int i;
            for (i = 0; i < (toReadLength - 1); i = i + 3)
            {
                if (fromProfile.myMessages_isProtected[i] is false)
                {
                    Console.WriteLine(fromProfile.myMessages_isProtected[i + 1]);
                    Console.WriteLine(fromProfile.myMessages_isProtected[i + 2]);
                    fromProfile.myMessages_isProtected[i] = true;
                 }

            }

        }
    }
}
