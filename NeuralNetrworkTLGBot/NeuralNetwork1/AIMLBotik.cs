using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIMLbot;

namespace AForge.WindowsForms
{
    class AIMLBotik
    {
        Bot myBot;
        User myUser;  ///   map[TLGUserID] -> AIML User ID
        Dictionary<int, User> map = new Dictionary<int, User>();

        public AIMLBotik()
        {
            myBot = new Bot();
            myBot.loadSettings();
            myBot.isAcceptingUserInput = false;
            myBot.loadAIMLFromFiles();
            myBot.isAcceptingUserInput = true;
        }

        public void Init(int TLGUserID)
        {
            map.Add(TLGUserID, new User($"{TLGUserID}", myBot));
        }

        public string Talk(string phrase, int TLGUserID)
        {
            Request r;
            if (map.ContainsKey(TLGUserID))
                r = new Request(phrase, map[TLGUserID], myBot);
            else
            {
                Init(TLGUserID);
                r = new Request(phrase, map[TLGUserID], myBot);
            }
            Result res = myBot.Chat(r);
            return res.Output;
        }
    }
}
