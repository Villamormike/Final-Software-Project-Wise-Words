using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Software_Project_Wise_Words
{
    public class Flashcards
    {

        public string Question { get; }
        public string Answer { get; }
        public string[] Choices { get; } // split MCA
        public string Type { get; }
        //public byte[] ImageData { get; set; }
        public byte[] Image { get; } // Image data as byte array
        public Flashcards(string question, string mca, string answer, string type, byte[] image = null)
        {
            Question = question;
            Answer = answer;
            Type = type;
            Image = image;
            //ImageData = imageData;

            if (!string.IsNullOrEmpty(mca))
            {
                Choices = mca.Split(',');
            }
            else
            {
                Choices = new string[0];
            }
        }
    }
}
