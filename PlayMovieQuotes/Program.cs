using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PlayMovieQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            string varURL = "";
            SoundPlayer quote = new SoundPlayer();
            Random randNum = new Random();
            int selectedQuote = (randNum.Next(1, 3));
            switch (selectedQuote)
            {
                case 1:
                    varURL = "http://www.wavsource.com/snds_2015-09-20_4380281261564803/tv/simpsons/apu/bastard.wav";
                    break;
                case 2:
                    varURL = "http://www.wavsource.com/snds_2015-09-20_4380281261564803/tv/simpsons/apu/do_not_listen.wav";
                    break;
                case 3:
                    varURL = "http://www.wavsource.com/snds_2015-09-20_4380281261564803/tv/simpsons/apu/hell.wav";
                    break;
                default:
                    break;
            }
            quote.SoundLocation = varURL;
           
            try
            {
                quote.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine(@"i'm sorry, you are not connected to the internet. please reconnect and try again.");
            }

            Console.ReadLine();

            
          


    

        }
        
    }
}
