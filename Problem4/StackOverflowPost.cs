using System;
using System.Threading.Tasks;

namespace Problem4
{

    public class StackOverflowPost
    {
        private string _title;
        private string _description;
        private DateTime _created;
        private int _votes;

        public StackOverflowPost(string title, string description)
        {
            _title = title;
            _description = description;
            _created = DateTime.Now;
            _votes = 0;
        }

        public void UpVote()
        {
            _votes++;
        }

        public void DownVote()
        {
            _votes--;
        }

        public int GetVotes()
        {
            return _votes;
        }
    }
}
