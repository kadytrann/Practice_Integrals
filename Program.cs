/* 
 Kady Tran
4/12/2024
 */

namespace Practice_Integrals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Part1();
            // This is to add space in between
            Console.WriteLine("");
            Part2();

        } // End of main

        public static void Part1()
        {
            // Asking user to enter number 1
            Console.Write("Enter Number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            // Asking user to enter number 2
            Console.Write("Enter Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            // Asking user to enter number 3
            Console.Write("Enter Number 3: ");
            int num3 = int.Parse(Console.ReadLine());

            // Setting up Number 5
            int num5 = 5;

            // Storing results for the first 5 questions
            int q1 = num1 + num2;
            int q2 = num3 - num1 + num2;
            int q3 = num3 * num2 - num3;
            int q4 = num1 / num3 - num1;
            int q5 = num3 + num3 - num2 * num5;

            // Displaying results of first 5 questions

            Console.WriteLine("Question 1: " + num1 + "+" + num2 + "=" + q1);
            Console.WriteLine("Question 2: " + num3 + "-" + num1 + "+" + num2 + "=" + q2);
            Console.WriteLine("Question 3: " + num3 + "*" + num2 + "-" + num3 + "=" + q3);
            Console.WriteLine("Question 4: " + num1 + "/" + num3 + "-" + num1 + "=" + q4);
            Console.WriteLine("Question 5: " + num3 + "+" + num3 + "-" + num5 + "=" + q5);

            // Storing results for Questions 6-10 using results from the first 5 numbers
            int q6 = q1 * q3;
            int q7 = q2 / q4;
            int q8 = q5 + q1 + num2;
            int q9 = q3 - q6 + num1 * q4;
            int q10 = q3 * q2 + q4 + num2 - q6 / q8;

            // Displaying results of questions 6-10

            Console.WriteLine("Question 6: " + q1 + "*" + q3 + "=" + q6);
            Console.WriteLine("Question 7: " + q2 + "/" + q4 + "=" + q7);
            // Console.WriteLine("Question 8: " + q5 + "+" + q1 + "+" + num2 + "=" + q8);
            Console.WriteLine("Question 9: " + q3 + "-" + q6 + "+" + num1 + "*" + q4 + "=" + q9);
            // Console.WriteLine("Question 10: " + q3 + "*" + q2 + "+" + q4 + "+" + num2 + "-" + q6 + "/" q8 "=" + q10);

        } // Part 1 code

        public static void Part2()
        {
            // Display word problem
            Console.WriteLine("Samantha runs a small bakery. In one day, she bakes 5 batches of cookies, with each batch containing 24 cookies. She sells each cookie for $2. At the end of the day, she gives away 10 cookies to her neighbors and had to throw away 8 cookies that were accidentally burnt. How much money did Samantha make from selling the cookies after giving away and throwing away some of them?");

            // Cost of a single cookie
            int cost = 2;
            Console.WriteLine("Cost of a single cookie: $" + cost);

            // Number of cookies in a batch
            int numberOfCookiesInBatch = 24;
            Console.WriteLine("Number of cookies in a batch: " + numberOfCookiesInBatch);

            // Cost for a batch of cookies
            int costForOneBatch = cost * numberOfCookiesInBatch;
            Console.WriteLine("Cost for a batch of cookies: $" + costForOneBatch);

            // Total cookies in 5 batches
            int totalBatchOfCookies = 5;
            int cookiesInFiveBatches = numberOfCookiesInBatch * totalBatchOfCookies;
            Console.WriteLine("Total cookies in 5 batches: " + cookiesInFiveBatches);

            // Total Cost for 5 batches of cookies
            int totalCostForFiveBatches = cost * cookiesInFiveBatches;
            Console.WriteLine("Total cost for 5 batches of cookies: $" + totalCostForFiveBatches);

            // Number of cookies that were given away
            int cookiesGivenAway = 10;
            Console.WriteLine("Amount of cookies given away: " + cookiesGivenAway);

            // Cost of cookies given away
            int costOfCookiesGivenAway = cookiesGivenAway * cost;
            Console.WriteLine("Cost of cookies given away: $" + costOfCookiesGivenAway);

            // Number of cookies that were thrown away
            int cookiesThrownAway = 8;
            Console.WriteLine("Amount of cookies thrown away: " + cookiesThrownAway);

            // Cost of cookies thrown away
            int costOfCookiesThrownAway = cookiesThrownAway * cost;
            Console.WriteLine("Cost of cookies thrown away: $" + costOfCookiesThrownAway);

            // Samantha's profit from selling cookies after throwing and giving away
            int profit = totalCostForFiveBatches - costOfCookiesGivenAway - costOfCookiesThrownAway;
            Console.WriteLine("Samantha's profit: $" + profit);

        } // Part 2 code

    }
}
