using System;


namespace Modul_3
{
    class Program
    {
        static void Main(string[] args)
        {

            SleepTime();
            WakeUpTime();
            DoYouNeedToSleep();


        }

        private static byte SleepTime()
        {

            Console.Write("When did you go to bed yesterday? ");
            byte sleep = Convert.ToByte(Console.ReadLine());

            return sleep;
            
            
        }

        private static byte WakeUpTime()
        {


            Console.Write("When did you wake up? ");
            byte wakeUp = Convert.ToByte(Console.ReadLine());

            return wakeUp;


        }

        private static string DoYouNeedToSleep(wakeUp)

        {


            if (sleep > wakeUp)
            {
                int sleepDur = Math.Abs(wakeUp + 24 - sleep);
                if (sleepDur > 14)
                {
                    string answer = $"You've slept well ({sleepDur})";
                    return answer;
                }
                else if (sleepDur > 3)

                {
                    string answer = $"You've slept {sleepDur} hours. That's a lot.";
                    return answer; 
                }

                else
                {
                    string answer = $"You have only slept {sleepDur} hours. Go back to bed!";

                    return answer;
                }
            }
            else
            {

                int sleepDur = Math.Abs(sleep - wakeUp);


                if (sleepDur > 14)
                {
                    string answer = $"You've slept well ({sleepDur})";
                    return answer;
                }
                else if (sleepDur > 3)

                {
                    string answer = $"You've slept {sleepDur} hours. That's a lot.";
                    return answer;
                }

                else
                {
                    string answer = $"You have only slept {sleepDur} hours. Go back to bed!";

                    return answer;


                }

            }
        }
    }
}