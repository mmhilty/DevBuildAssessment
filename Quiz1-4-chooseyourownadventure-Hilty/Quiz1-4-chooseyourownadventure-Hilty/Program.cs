using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1_4_chooseyourownadventure_Hilty
{
    class Program
    {
        static void Main(string[] args)
        {
            /* prompt, 
             * smartyangel choice, 
             * idiotbad choice, //gated here
             * smartyangel result, 
             * idiotbad result*/
            //          int  Choice = returnMoralityChoice("", "", "", "", "");
            bool killswitch = true;
            while (killswitch)
            {
                bool userAlive = true;
                while (userAlive)
                {

                    Console.WriteLine(@"
You emerge, blinking, into a clearing in the woods. Straight ahead there chicken legs.

...What? 

Massive, meaty, chicken legs standing still RIGHT THERE in the middle of a clearing! Unbidden,
your gaze is drawn upward. Sitting right on top of them is a hut, of all things! Cackling drifts 
from the windows along with the smell of what you think could be pork stew. 
");

                    int approachChoice = returnMoralityChoice(
                        @"After taking a moment to get over the sight of a hut on chicken legs, your gaze drifts down.
There hut is standing on a bare patch of ground surrounded by a fence made of... are those
human bones? Coincidentally, the gate is directly in front of you.",
                        "Go towards it",
                        "Run away",
                        "You, who has apparently never heard a folk tale in their life, start forward. Maybe you can get some stew!",
                        "As you disappear into the underbrush, the world seems to sigh in relief. A folk tale was averted this day.");

                    if (approachChoice == 0) //you ran away
                    {
                        break;
                    }

                    int gateChoice = returnMoralityChoice(@"
When you touch the gate, it creaks 'screeeeeee-oil! oil! Please, I am parched!' 
You see an oil can a few feet away, but it does look filthy.You're sure to get dirty fingers.",
        "Get the oil can and oil the gate",
        "Gross!No way you're touching that thing.",
        @"You pick up the oil can. It is just as sticky as it looks. But you take it over and give the gate a good oiling.
You push the now silent gate open and walk inside.",
        "Ignoring the pained squeaking, you force the gate open and walk inside.");

                    int dogChoice = returnMoralityChoice(@"
There's a huge brown dog knawing on a bone. He looks at you, but doesn't seem likely to get up",
                        "You give the dog some meat and bread from your pocket as you walk by. He takes it in a dignified manner.",
                        "You look distrustfully at the dog and pass on by.");

                    int catChoice = returnMoralityChoice(@"
Closer in to the house, you see a skinny black cat staring at a hole in the ground.
'What are you doing?', you say to it.
'I'm waiting for a mouse,' it mews mournfully, 'I haven't eaten in three days.'",
    "'Oh no, poor cat! Here, have some of my lunch!'",
    "Not your problem.",
    "You give him the cheese from your pocket, which he devours instantly, purring.",
    "'Good hunting,' you mumble as you pass by.");

                    //if (catChoice == 1)
                    //{
                    //    Console.WriteLine();
                    //    bool towelHave = true;
                    //}

                    Console.WriteLine(@"Now you're close to the hut, but the front door is 10 feet in the air. 

Suddenly, the legs twitch and hop up! When they come down, they come down in a crouch so the door is right close in front of you. You
notice that the door looks a little bit like a mouth for some reason.
");
                    int doorChoice = returnMoralityChoice("",
                        "How convenient! You knock",
                        "Ok that's just one step... hop too far. You're outta here.",
                        "A step. A scratch. A muffled cackle. Someone is coming to the door.",
                        "As you disappear into the underbrush, the universe seems to sigh in relief. A folk tale was averted this day");

                    if (doorChoice == 0) //you ran away
                    {
                        break;
                    }

                    //CHASE SCENE

                    Console.WriteLine(@"The door flies open! Standing there is Baba Yaga, the bony-legged one, the witch. Her eyes were
small and beady and her nose so long it appeared through the door before she. In one gnarled hand she holds a meat cleaver dripping 
with fresh blood. 

This may have been a mistake.");

                    int Choice = returnMoralityChoice("", "You curtsey.",
                        "You stand there silently shaking.",
                        "She looks at you and smiles, showing every one of her iron teeth.'Such a polite young thing! I will enjoy having you for dinner.'",
                        "She looks at you and smiles, showing every one of her iron teeth.");

                    Console.WriteLine(@"
This was DEFINITELY a mistake. As you turn to run away, she takes a swing at you with her cleaver.

You dodge and start back towards the forest.
");

                    userAlive = returnAvertedDeath(@"'DOG,' she shouts in a voice like a thousand angry hornets, 'TEAR HER APART SO I MAY FEAST TONIGHT!'",
                        @"But the dog didn't get up from his bone. 
'DOG, WHAT ARE YOU DOING?'
He growls 'In all the years that I've served you, you never threw me anything but an old bones, but she gave me real meat and bread.'",
                        "The dog leaps up, snarling. You haven't a chance.", dogChoice); //dogchoice

                    Console.WriteLine("You run on.");

                    userAlive = returnAvertedDeath("The witch howls in rage; 'CAT, TEAR OUT HER EYES SO I WILL HAVE MEAT FOR MY STEWPOT.'", @"But the cat didn't get up from its spot in the sun.
'CAT, WHAT ARE YOU DOING?'
He purrs 'In all the years that I have served you, you have given me only water and made me hunt for my dinner. The girl gave me real cheese.'",
    "The cat leaps up towards your face. You try to dodge, but he's too fast. Everything goes red and then black. You're done for.",
    catChoice); //catchoice

                    Console.WriteLine("You run on.");

                    userAlive = returnAvertedDeath("The witch's voice goes high, like the howling of the wind in a blizzard. 'GATE, STICK FAST SO I MAY CRACK HER BONES FOR MY BREAD.' ",
                        @"But the gate opens smoothly, letting you through. 
'GATE, WHY DO YOU NOT STICK?'
'In all the years that we've served you, you never so much as sprinkled a drop of oil on us, and we could hardly stand the sound of our own creaking. But the girl oiled us and we can now swing back and forth without a sound.'
", @"You try to force it open, but the gate holds tight. 
As you rattle it, it even seems to grow taller. It's no use. You turn and in a flash Baba Yaga is on you. You're done. ", gateChoice); //gatechoice



                    Console.WriteLine(@"In a flash, you're out! The gate shuts behind you, stopping the witch just long enough for you to disappear into the underbrush. The world seems to sigh in relief. A folk tale was averted this day.");

                    break;

                }

                killswitch = ContinueLoop("\nDo you want to go again?");

            }

        }

        static int returnMoralityChoice(string prompt, string choice1, string choice2, string result1, string result2)
        {
            Console.WriteLine(prompt);
            Console.WriteLine("What do you choose?");
            Console.WriteLine($"1) {choice1}"); //smartyangel choice
            Console.WriteLine($"2) {choice2}"); //idiotbad choice
            int userAnswer = 0;

            userAnswer = Convert.ToInt32(Console.ReadLine());
                
            if (userAnswer == 1)
            {
                Console.WriteLine(result1);
                Console.WriteLine();

                return 1;
            }

            else
            {
                Console.WriteLine(result2);
                Console.WriteLine();

                return 0;
            }

            

        }

        static int returnMoralityChoice(string prompt, string choice1, string choice2) //did that methody stuff with argument gating
        {
            Console.WriteLine(prompt);
            Console.WriteLine("What do you choose?");
            Console.WriteLine($"1) {choice1}"); //smartyangel choice
            Console.WriteLine($"2) {choice2}"); //idiotbad choice
            int userAnswer = 0;

            userAnswer = Convert.ToInt32(Console.ReadLine());

            if (userAnswer == 1)
            {
                
                return 1;
            }

            else
            {
                
                return 0;
            }



        }

        static bool returnAvertedDeath(string prompt, string goodresult, string badresult, int userchoice) //true if alive, false if dead
        {
            Console.WriteLine(prompt);

            if (userchoice == 1)
            {

                Console.WriteLine(goodresult);
                return true;
            }

            else
            {

                Console.WriteLine(badresult);
                return false;


            }



        }

        static bool ContinueLoop(string prompt)
        {
            while (true)
            {
                bool userContinue;
                Console.WriteLine(prompt);
                Console.WriteLine("Y/N?");
                string userContinueInput = Console.ReadLine();

                if (userContinueInput.ToLower() == "y")
                {
                    userContinue = true;
                }

                else if (userContinueInput.ToLower() == "n")
                {
                    userContinue = false;
                }

                else
                {
                    Console.WriteLine("I'm not sure what you mean.");
                    continue;
                }


                return userContinue;

            }
        }
            // intro module
            /*
            static void introArea()
            {

            }

            // area 1 module

            static void caveArea()        
            {

            }

            // area 2 module

            static void woodArea()
            {
                Console.WriteLine(@"
    You emerge, blinking into a clearing in the woods. Straight ahead there are... chicken legs? 
    Your gaze is drawn upward. There's a hut on them. Cackling drifts from the windows along with
    the meaty smell of stew. ");

                Console.WriteLine(@"What do you do?
    1) Go towards the hut
    2) Back away slowly
    ");



                Console.WriteLine(@"You, who has apparently never read a folk tale in their life, start forward. Maybe you can get some stew!");

                //gate choice
                Console.WriteLine(@"When you touch the gate, it creaks 'screeeeeee-oil! oil! Please, I am parched!'
    You see an oil can a few feet away, but it does look filthy. You're sure to get dirty fingers.
    1) Get the oil can and oil the gate
    2) Gross! No way you're touching that thing.");

                int gateChoice = Convert.ToInt32(Console.ReadLine);

                if (gateChoice == 1)
                {
                    Console.WriteLine(@"You pick up the oil can. It is just as sticky as it looks. But you take it over and give the gate a good oiling.
    You push the now silent gate open and walk inside.");
                }

                else if (gateChoice == 2)
                {
                    Console.WriteLine("Ignoring the pained sqeaking, you force the gate open and walk inside");
                }
                //eat the stew

                // 


            }

            static void endingArea()
            {



            }
            */
        }
}
