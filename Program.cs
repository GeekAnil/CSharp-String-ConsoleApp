namespace StringApps
{
    using System;

    class Program
    {
       
         static void Main(string[] args)
        {
            string[] amendments = new string[10];

            Console.WriteLine();
            Console.WriteLine("                                     String Console Application!!!!");
            Console.WriteLine("                                     --------------------------");
            Console.WriteLine("                                     --------------------------");
            Console.WriteLine("                                     --------------------------");

            Console.WriteLine();
            Console.WriteLine();
            int choice;
            string tryMore = "Y";
            Console.WriteLine();
            while (tryMore.ToUpper() == "Y")
            {

                Console.WriteLine("                  1.Convert the 10 amendments into a string array");
                Console.WriteLine("                  2.Loop through the array and print each amendment");
                Console.WriteLine("                  3.Find the amendment that contains the word 'controversy");
                Console.WriteLine("                  4.Longest amendment in the list");
                Console.WriteLine("                  5.Exit");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("     Enter your choice:(1:5): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        string amendment1 = "Congress shall make no law respecting an establishment of religion or prohibiting the free exercise thereof, or abridging the freedom of speech or of the press, or the right of the people peaceably to assemble and to petition the government for a redress of grievances.";
                        string amendment2 = "A well - regulated militia being necessary to the security of a free state, the right of the people to keep and bear arms shall not be infringed.";
                        string amendment3 = "No soldier shall, in time of peace, be quartered in any house without the consent of the owner, nor in time of war but in a manner to be prescribed by law.";
                        string amendment4 = "The right of the people to be secure in their persons, houses, papers, and effects against unreasonable searches and seizures shall not be violated, and no warrants shall issue but upon probable cause, supported by oath or affirmation, and particularly describing the place to be searched and the persons or things to be seized.";
                        string amendment5 = "No person shall be held to answer for a capital or otherwise infamous crime unless on a presentment or indictment of a grand jury, except in cases arising in the land or naval forces, or in the militia, when in actual service in time of war or public danger; nor shall any person be subject for the same offense to be twice put in jeopardy of life or limb; nor shall be compelled in any criminal case to be a witness against himself, nor be deprived of life, liberty, or property without due process of law; nor shall private property be taken for public use without just compensation.";
                        string amendment6 = "In all criminal prosecutions, the accused shall enjoy the right to a speedy and public trial by an impartial jury of the state and district wherein the crime shall have been committed, which district shall have been previously ascertained by law, and to be informed of the nature and cause of the accusation; to be confronted with the witnesses against him; to have compulsory process for obtaining witnesses in his favor; and to have the assistance of counsel for his defense.";
                        string amendment7 = "In suits at common law, where the value in controversy shall exceed twenty dollars, the right of trial by jury shall be preserved, and no fact tried by a jury shall be otherwise reexamined in any court of the United States than according to the rules of the common law.";
                        string amendment8 = "Excessive bail shall not be required, nor excessive fines imposed, nor cruel and unusual punishments inflicted.";
                        string amendment9 = "The enumeration in the Constitution of certain rights shall not be construed to deny or disparage others retained by the people.";
                        string amendment10 = "The powers not delegated to the United States by the Constitution, nor prohibited by it to the states, are reserved to the states respectively, or to the people.";
                        //  Console.Write("amendment" + i);
                        amendments[0] = amendment1;
                        amendments[1] = amendment2;
                        amendments[2] = amendment3;
                        amendments[3] = amendment4;
                        amendments[4] = amendment5;
                        amendments[5] = amendment6;
                        amendments[6] = amendment7;
                        amendments[7] = amendment8;
                        amendments[8] = amendment9;
                        amendments[9] = amendment10;
                        Console.WriteLine();
                        Console.WriteLine("All amendments have been added to string array");
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("List of all amendments in amendment array ");
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine();
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("Amendment" + (i + 1) + "  ==>>");
                            Console.WriteLine(amendments[i]);
                            Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Amendment with the word controversy: ");
                        for (int i = 0; i < 10; i++)
                        {

                            if (amendments[i].ToLower().Contains("controversy"))
                            {
                                Console.WriteLine("Found in amendment" + (i + 1));

                                Console.WriteLine(amendments[i]);

                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine();
                        int longest = 1;
                        string longestAmendment = "";
                        //string longestString = "";
                        int j;
                        for (j = 0; j < 10; j++)
                        {
                            if (amendments[j].Length > longest)
                            {
                                longest = amendments[j].Length;
                                longestAmendment = amendments[j];
                            }
                        }
                        // Console.Write("Longest amendmen is: "+"amendment"+j);
                        Console.WriteLine();
                        Console.Write("Lenght of Longest amendmend is: " + longest);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine(longestAmendment);
                        //Console.ReadLine();
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("           PROGRAM TERMINATING,,,HIT [ENTER] TO END THE PROGRAM!!!!!!!!!");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("Invalid Choice,,Try Again!!!!");
                        break;
                }
                Console.WriteLine();
                Console.Write("Do you want to Continue(Y/N): ");
                // Console.WriteLine();
                tryMore = Console.ReadLine();
            }
        }
    }
}
