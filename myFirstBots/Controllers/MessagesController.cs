using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using Microsoft.Bot.Connector;
using Microsoft.Bot.Connector.Utilities;
using Newtonsoft.Json;

namespace myFirstBots
{
   // [BotAuthentication]
    public class MessagesController : ApiController
    {
        /// <summary>
        /// POST: api/Messages
        /// Receive a message from a user and reply to it
        /// </summary>
        string []names = { "Nosipho", "Ntobeko", "welcome", "Nqobani"};
        int[] age = { 22, 22,22,22};
        int count = 0;

        public async Task<Message> Post([FromBody]Message message)
        {
            if (message.Type == "Message")
            {
                

               if( message.Text.ToLower().Contains("hellow")|| message.Text.ToLower().Contains("hellow"))
                {
                    count = 0;
                    return message.CreateReplyMessage($"Hi,welcome to emmedia Intern Bots,you can ask me anything about Nosipho,Welcome,Nqobani and Ntobeko!!!e.g email, phone number,qoutes,advice,nickname");

                }
               else if(message.Text.ToLower().Contains("nosipho") && (message.Text.ToLower().Contains("nickname")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"her nickname is:Gundie");
                }
                else if (message.Text.ToLower().Contains("nosipho") && (message.Text.ToLower().Contains("surname") || message.Text.ToLower().Contains("last name")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"her surname is Nsibande");
                }
                else if (message.Text.ToLower().Contains("nosipho") && (message.Text.ToLower().Contains("like") || message.Text.ToLower().Contains("likes")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"reading,playing lady soccer,boxing,and watch soccer,crickectand rugby");
                }

                else if (message.Text.ToLower().Contains("nosipho") &&( message.Text.ToLower().Contains("age")|| message.Text.ToLower().Contains("old")))
                {
                    return message.CreateReplyMessage($"she is 22 years old");
                }
                else if (message.Text.ToLower().Contains("nosipho") && (message.Text.ToLower().Contains("email")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"nosiphonsibande54@gmail.com");
                }
                else if (message.Text.ToLower().Contains("nosipho") && (message.Text.ToLower().Contains("phone number")|| message.Text.ToLower().Contains("number")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"her number is:0844802863");
                }
                else if (message.Text.ToLower().Contains("nosipho") && (message.Text.ToLower().Contains("job") || message.Text.ToLower().Contains("work")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"she is doing her internship at emmedia");
                }
                else if (message.Text.ToLower().Contains("nosipho") && (message.Text.ToLower().Contains("qoutes") || message.Text.ToLower().Contains("qoutes")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"The problem with programmers is that you will never know what the programmer is doid until it too late!!!! ");
                }
                else if (message.Text.ToLower().Contains("nosipho") &&(( message.Text.ToLower().Contains("advice"))))
                {
                    count = 1;
                    return message.CreateReplyMessage($"OOPS!! work hard");
                }
                else if (message.Text.ToLower().Contains("nosipho") && (message.Text.ToLower().Contains("address") || message.Text.ToLower().Contains("home address")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"Bergville and pmb but current in durban");
                }
                else if (message.Text.ToLower().Contains("nosipho") && ((message.Text.ToLower().Contains("school"))))
                {
                    count = 1;
                    return message.CreateReplyMessage($"Primary school:Glenrust primary School,High school:Tabhane Secondary and University:Mangosuthu");
                }
                else if (message.Text.ToLower().Contains("nosipho"))
                {
                    //return message.CreateReplyMessage($"Primary school:Glenrust primary School,High school:Tabhane Secondary and University:Mangosuthu");
                    count=1;
                    return message.CreateReplyMessage("what you want to know about nosipho?");
                }

               //ntobeko
               else if (message.Text.ToLower().Contains("ntobeko") && ( message.Text.ToLower().Contains("nickname")))
                {
                    count =2;
                    return message.CreateReplyMessage($"his nickname is:Ntobe");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && (message.Text.ToLower().Contains("age") || message.Text.ToLower().Contains("old")))
                {
                    count = 2;
                    return message.CreateReplyMessage($"He is 23 years old");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && (message.Text.ToLower().Contains("email")))
                {
                    return message.CreateReplyMessage($"His address is:ntobeko54@gmail.com");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && (message.Text.ToLower().Contains("phone number") || message.Text.ToLower().Contains("number")))
                {
                    return message.CreateReplyMessage($"His number is:0744782588");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && (message.Text.ToLower().Contains("school")))
                {
                    return message.CreateReplyMessage($"Mangosuthu university of technology");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && (message.Text.ToLower().Contains("qoutes") || message.Text.ToLower().Contains("qoute")))
                {
                    return message.CreateReplyMessage($"I have always wished for my computer to be as easy to use as my telephone; my wish has come true because I can no longer figure out how to use my telephone");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && ((message.Text.ToLower().Contains("food"))))
                {
                    return message.CreateReplyMessage($"He like Pizza");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && ((message.Text.ToLower().Contains("movies") || message.Text.ToLower().Contains("movie"))))
                {
                    return message.CreateReplyMessage($"OOPS!! He like all movies,but to name them he watch action movie like star wars");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && (message.Text.ToLower().Contains("surname") || message.Text.ToLower().Contains("last name")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"her surname is Nkabinde");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && (message.Text.ToLower().Contains("like") || message.Text.ToLower().Contains("likes")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"eating,he like food");
                }
                else if (message.Text.ToLower().Contains("ntobeko"))
                {
                    return message.CreateReplyMessage($"what do you want know about ntobeko??");
                }

                //welcome
                else if (message.Text.ToLower().Contains("welcome") && (message.Text.ToLower().Contains("nickname")))
                {
                    count = 2;
                    return message.CreateReplyMessage($"his nickname is: Ramboh");
                }
                else if (message.Text.ToLower().Contains("welcome") && (message.Text.ToLower().Contains("surname") || message.Text.ToLower().Contains("last name")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"her surname is Malamlela");
                }
                else if (message.Text.ToLower().Contains("welcome") && (message.Text.ToLower().Contains("like") || message.Text.ToLower().Contains("likes")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"he like energy drinks and abuke opopayi");
                }
                else if (message.Text.ToLower().Contains("welcome") && (message.Text.ToLower().Contains("age") || message.Text.ToLower().Contains("old")))
                {
                    count = 2;
                    return message.CreateReplyMessage($"He is 25 years old");
                }
                else if (message.Text.ToLower().Contains("welcome") && (message.Text.ToLower().Contains("email")))
                {
                    return message.CreateReplyMessage($"His address is:welcome4@gmail.com");
                }
                else if (message.Text.ToLower().Contains("welcome") && (message.Text.ToLower().Contains("phone number") || message.Text.ToLower().Contains("number")))
                {
                    return message.CreateReplyMessage($"His number is: 0842266993");
                }
                else if (message.Text.ToLower().Contains("welcome") && (message.Text.ToLower().Contains("school")))
                {
                    return message.CreateReplyMessage($"Mangosuthu university of technology");
                }
                else if (message.Text.ToLower().Contains("welcome") && (message.Text.ToLower().Contains("qoutes") || message.Text.ToLower().Contains("qoute")))
                {
                    return message.CreateReplyMessage($"Good design adds value faster than it adds cost");
                }
                else if (message.Text.ToLower().Contains("welcome") && ((message.Text.ToLower().Contains("food"))))
                {
                    return message.CreateReplyMessage($"i dont's know,i think ......yes fish ");
                }
                else if (message.Text.ToLower().Contains("welcome") && ((message.Text.ToLower().Contains("movies") || message.Text.ToLower().Contains("movie"))))
                {
                    return message.CreateReplyMessage($"OOPS!! The Godfather,The Godfather: Part Ii,The Dark Knight,12 Angry Men,Schindler's List,he watch  even funny movies!");
                }
                else if (message.Text.ToLower().Contains("welcome"))
                {
                    return message.CreateReplyMessage($"what do you want know about welcome (Ramboh) malamlela??");
                }
               //nqobani
                else if (message.Text.ToLower().Contains("nqobani") && (message.Text.ToLower().Contains("nickname")))
                {
                    count = 2;
                    return message.CreateReplyMessage($"his nickname is: blocko");
                }
                else if (message.Text.ToLower().Contains("nqobani") && (message.Text.ToLower().Contains("age") || message.Text.ToLower().Contains("old")))
                {
                    count = 2;
                    return message.CreateReplyMessage($"He is 22 years old");
                }
                else if (message.Text.ToLower().Contains("nqobani") && (message.Text.ToLower().Contains("email")))
                {
                    return message.CreateReplyMessage($"His address is:nqobani4@gmail.com");
                }
                else if (message.Text.ToLower().Contains("nqobani") && (message.Text.ToLower().Contains("phone number") || message.Text.ToLower().Contains("number")))
                {
                    return message.CreateReplyMessage($"His number is: 0842266993");
                }
                else if (message.Text.ToLower().Contains("ntobeko") && (message.Text.ToLower().Contains("school")))
                {
                    return message.CreateReplyMessage($"Mangosuthu university of technology");
                }
                else if (message.Text.ToLower().Contains("nqobani") && (message.Text.ToLower().Contains("qoutes") || message.Text.ToLower().Contains("qoute")))
                {
                    return message.CreateReplyMessage($"For a long time it puzzled me how something so expensive, so leading edge, could be so useless. And then it occurred to me that a computer is a stupid machine with the ability to do incredibly smart things, while computer programmers are smart people with the ability to do incredibly stupid things. They are, in short, a perfect match");
                }
                else if (message.Text.ToLower().Contains("nqobani") && ((message.Text.ToLower().Contains("food"))))
                {
                    return message.CreateReplyMessage($"He like everything but especlal,burger");
                }
                else if (message.Text.ToLower().Contains("nqobani") && ((message.Text.ToLower().Contains("movies") || message.Text.ToLower().Contains("movie"))))
                {
                    return message.CreateReplyMessage($"OOPS!! he like action movies");
                }
                else if (message.Text.ToLower().Contains("nqobani"))
                {
                    return message.CreateReplyMessage($"what do you want know about nqobani??");
                }
                else if (message.Text.ToLower().Contains("nqobani") && (message.Text.ToLower().Contains("surname") || message.Text.ToLower().Contains("last name")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"her surname is Zulu");
                }
                else if (message.Text.ToLower().Contains("nqobani") && (message.Text.ToLower().Contains("like") || message.Text.ToLower().Contains("likes")))
                {
                    count = 1;
                    return message.CreateReplyMessage($"he likes jokes and swimming");
                }
                return message.CreateReplyMessage($"ooh!,my developer told me that if you ask a question ,make sure you include the name of the person,e.g How old is nosipho? not how old is she?");

               

            }
            else
            {
                return HandleSystemMessage(message);
            }
        }

        private Message HandleSystemMessage(Message message)
        {
            if (message.Type == "Ping")
            {
                Message reply = message.CreateReplyMessage();
                reply.Type = "Ping";
                return reply;
            }
            else if (message.Type == "DeleteUserData")
            {
                // Implement user deletion here
                // If we handle user deletion, return a real message
            }
            else if (message.Type == "BotAddedToConversation")
            {
                return message.CreateReplyMessage($"Hi,welcome to my first bots!!!!");

            }
            else if (message.Type == "BotRemovedFromConversation")
            {
            }
            else if (message.Type == "UserAddedToConversation")
            {
            }
            else if (message.Type == "UserRemovedFromConversation")
            {
            }
            else if (message.Type == "EndOfConversation")
            {
            }

            return null;
        }
    }
}